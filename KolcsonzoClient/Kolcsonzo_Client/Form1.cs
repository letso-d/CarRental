using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grpc.Core;
using Grpc.Net.Client;
using Kolcsonzo;
using Kolcsonzo_Client;
using System.Threading;

namespace Kolcsonzo_Client
{

    public partial class Form1 : Form
    {
        public static bool IsAdmin = false;
        public static bool LoggedIn = false;
        public static string Uid = "";
        string sorttext = "";
        SortBy SortBy = SortBy.BRAND;
        bool asc = false;
        GrpcChannel channel = GrpcChannel.ForAddress("https://localhost:5001");
        Kolcsonzo.Kolcsonzo.KolcsonzoClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new Kolcsonzo.Kolcsonzo.KolcsonzoClient(channel);
                client.Connect(new Empty { });
            }
            catch
            {
                MessageBox.Show("A szerver nem elérhető.");
                this.Close();
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!LoggedIn)
            {
                LoginForm l = new LoginForm(this.client);
                var dialogresult = l.ShowDialog();
                if (LoggedIn == true)
                {
                    if (IsAdmin==true)
                    {
                        addButton.Visible = true;
                        deleteLabel.Visible = true;
                    }
                    LoginButton.Text = "Log Out";
                }
            }
            else
            {
                var result = client.Logout(new Session_Id2 { Id = Uid });
                if (result.Success != "You are not logged in.")
                {
                    SetLogoutValues();
                    MessageBox.Show(result.Success);
                }
                else
                {
                    MessageBox.Show(result.Success);
                }
            }
        }

        private void rentButton_Click(object sender, EventArgs e)
        {
            if (CarsList.Items.Count<1)
            {
                MessageBox.Show("Nincs mit kölcsönözni!");
            }
            else
            {
                Car kivalasztott = (Car)CarsList.SelectedItem;
                var result = client.Rent(new Car2 { LicPlNum = kivalasztott.LicPlNum, Uid = Uid });
                if (result.Success == "You have to log in to perform this action!")
                {
                    SetLogoutValues();
                }
                MessageBox.Show(result.Success);
                Refresh();
            }
        }

        private async Task GetCars(bool sorted)
        {
            List<Car> cars = new List<Car>();

            if (sorted)
            {
                using (var call = client.ListType(new Kolcsonzo.Type { Type_=sorttext}))
                {
                    while (await call.ResponseStream.MoveNext())
                    {
                        Car c = call.ResponseStream.Current;
                        cars.Add(new Car(c));
                    }
                }
            }
            else
            {
                using (var call = client.List(new Empty { }))
                {
                    while (await call.ResponseStream.MoveNext())
                    {
                        Car c = call.ResponseStream.Current;
                        cars.Add(new Car(c));
                    }
                }
            }
            CarsList.DataSource = null;
            if (cars.Count>0)
            {
                CarsList.DataSource = cars;
                CarsList.DisplayMember = "Formatted";
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (CarsList.Items.Count < 1)
            {
                MessageBox.Show("Nincs mit visszavinni!");
            }
            else
            {
                int km=0;
                using (KmForm k = new KmForm())
                {
                    var res = k.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        km = k.Km;
                    }
                }
                Car kivalasztott = (Car)CarsList.SelectedItem;
                var result = client.Back(new Car3 { LicPlNum = kivalasztott.LicPlNum, Uid = Uid, Km = km });
                if (result.Success == "You have to log in to perform this action!")
                {
                    SetLogoutValues();
                }
                MessageBox.Show(result.Success);
                Refresh();
            }
        }

        private void deleteLabel_Click(object sender, EventArgs e)
        {
            if (CarsList.Items.Count < 1)
            {
                MessageBox.Show("Nincs mit törölni!");
            }
            else
            {
                Car kivalasztott = (Car)CarsList.SelectedItem;
                var result = client.Delete(new Car2 { LicPlNum = kivalasztott.LicPlNum, Uid = Uid });
                if (result.Success == "You have to log in to perform this action!")
                {
                    SetLogoutValues();
                }
                MessageBox.Show(result.Success);
                Refresh();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (AddForm a = new AddForm(this.client))
            {
                var res = a.ShowDialog();
                if (LoggedIn == false)
                {
                    SetLogoutValues();
                }
                else if (res == DialogResult.OK)
                {
                    Refresh();
                }
            }
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            sorttext = "";
            StringBuilder sb = new StringBuilder();
            if (SedanBox.Checked)
            {
                sb.Append("Sedan ");
            }
            if (KombiBox.Checked)
            {
                sb.Append("Kombi ");
            }
            if (FerdehBox.Checked)
            {
                sb.Append("Ferdehátú ");
            }
            if (CabrioBox.Checked)
            {
                sb.Append("Cabrio ");
            }
            if (CoupeBox.Checked)
            {
                sb.Append("Coupe ");
            }
            if (EgyteruBox.Checked)
            {
                sb.Append("Egyterű ");
            }
            if (SportBox.Checked)
            {
                sb.Append("Sport ");
            }
            if (CrossoverBox.Checked)
            {
                sb.Append("Crossover ");
            }
            if (sb.Length>1)
            {
                sorttext = sb.ToString().Trim();
            }
            
            GetCars(sorttext.Length > 0 ? true : false);
        }

        private void SetLogoutValues()
        {
            this.LoginButton.Text = "Log In";
            addButton.Visible = false;
            deleteLabel.Visible = false;
            LoggedIn = false;
            IsAdmin = false;
        }

        private async Task Sort(SortBy s)
        {
            if (s == SortBy && asc == true)
            {
                SortBy = s;
                SortDesc();
            }
            else
            {
                SortBy = s;
                SortAsc();
            }
        }

        private void SortAsc()
        {
            List<Car> SortedList = new List<Car>();
            switch (SortBy)
            {
                case SortBy.BRAND:
                    SortedList = CarsList.Items.Cast<Car>().ToList().OrderBy(o => o.Brand).ToList();
                    break;
                case SortBy.TYPE:
                    SortedList = CarsList.Items.Cast<Car>().ToList().OrderBy(o => o.Type).ToList();
                    break;
                case SortBy.YEAR:
                    SortedList = CarsList.Items.Cast<Car>().ToList().OrderBy(o => o.Year).ToList();
                    break;
                case SortBy.KM:
                    SortedList = CarsList.Items.Cast<Car>().ToList().OrderBy(o => o.Km).ToList();
                    break;
                case SortBy.PRICEPERKM:
                    SortedList = CarsList.Items.Cast<Car>().ToList().OrderBy(o => o.Priceperkm).ToList();
                    break;
                case SortBy.LICPLNUM:
                    SortedList = CarsList.Items.Cast<Car>().ToList().OrderBy(o => o.LicPlNum).ToList();
                    break;
                case SortBy.RENTED:
                    SortedList = CarsList.Items.Cast<Car>().ToList().OrderBy(o => o.IsRented).ToList();
                    break;
                case SortBy.RENTER:
                    SortedList = CarsList.Items.Cast<Car>().ToList().OrderBy(o => o.Renter).ToList();
                    break;
            }
            CarsList.DataSource = null;
            CarsList.DataSource = SortedList;
            CarsList.DisplayMember = "Formatted";
        }

        private void SortDesc()
        {
            List<Car> SortedList = new List<Car>();
            switch (SortBy)
            {
                case SortBy.BRAND:
                    SortedList = CarsList.Items.Cast<Car>().ToList().OrderByDescending(o => o.Brand).ToList();
                    break;
                case SortBy.TYPE:
                    SortedList = CarsList.Items.Cast<Car>().ToList().OrderByDescending(o => o.Type).ToList();
                    break;
                case SortBy.YEAR:
                    SortedList = CarsList.Items.Cast<Car>().ToList().OrderByDescending(o => o.Year).ToList();
                    break;
                case SortBy.KM:
                    SortedList = CarsList.Items.Cast<Car>().ToList().OrderByDescending(o => o.Km).ToList();
                    break;
                case SortBy.PRICEPERKM:
                    SortedList = CarsList.Items.Cast<Car>().ToList().OrderByDescending(o => o.Priceperkm).ToList();
                    break;
                case SortBy.LICPLNUM:
                    SortedList = CarsList.Items.Cast<Car>().ToList().OrderByDescending(o => o.LicPlNum).ToList();
                    break;
                case SortBy.RENTED:
                    SortedList = CarsList.Items.Cast<Car>().ToList().OrderByDescending(o => o.IsRented).ToList();
                    break;
                case SortBy.RENTER:
                    SortedList = CarsList.Items.Cast<Car>().ToList().OrderByDescending(o => o.Renter).ToList();
                    break;
            }
            CarsList.DataSource = null;
            CarsList.DataSource = SortedList;
            CarsList.DisplayMember = "Formatted";
        }

        private void BrandLabel_Click(object sender, EventArgs e)
        {
            if (asc == true)
            {
                asc = false;
            }
            else
            {
                asc = true;
            }
            Sort(SortBy.BRAND);
        }

        private void TypeLabel_Click(object sender, EventArgs e)
        {
            if (asc == true)
            {
                asc = false;
            }
            else
            {
                asc = true;
            }
            Sort(SortBy.TYPE);
        }

        private void YearLabel_Click(object sender, EventArgs e)
        {
            if (asc == true)
            {
                asc = false;
            }
            else
            {
                asc = true;
            }
            Sort(SortBy.YEAR);
        }

        private void KmLabel_Click(object sender, EventArgs e)
        {
            if (asc == true)
            {
                asc = false;
            }
            else
            {
                asc = true;
            }
            Sort(SortBy.KM);
        }

        private void PricePerKmLabel_Click(object sender, EventArgs e)
        {
            if (asc == true)
            {
                asc = false;
            }
            else
            {
                asc = true;
            }
            Sort(SortBy.PRICEPERKM);
        }

        private void LicPlNumLabel_Click(object sender, EventArgs e)
        {
            if (asc == true)
            {
                asc = false;
            }
            else
            {
                asc = true;
            }
            Sort(SortBy.LICPLNUM);
        }

        private void IsRentedLabel_Click(object sender, EventArgs e)
        {
            if (asc == true)
            {
                asc = false;
            }
            else
            {
                asc = true;
            }
            Sort(SortBy.RENTED);
        }

        private void RenterLabel_Click(object sender, EventArgs e)
        {
            if (asc == true)
            {
                asc = false;
            }
            else
            {
                asc = true;
            }
            Sort(SortBy.RENTER);
        }

        private async void Refresh()
        {
            await GetCars(sorttext.Length > 0);
            Sort(SortBy);
        }
    }
}
