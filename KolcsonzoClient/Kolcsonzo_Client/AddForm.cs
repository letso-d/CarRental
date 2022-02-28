using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Grpc.Core;
using Kolcsonzo;

namespace Kolcsonzo_Client
{
    public partial class AddForm : Form
    {
        public AddForm(Kolcsonzo.Kolcsonzo.KolcsonzoClient client)
        {
            this.client = client;
            InitializeComponent();
            InitBrands();
            InitTypes();
            InitYearBox();
        }
        Kolcsonzo.Kolcsonzo.KolcsonzoClient client;
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (ValidateLicPlNum() && BrandBox.SelectedItem != null && TypeBox.SelectedItem != null && KmBox.Value > 0 && PricePerKmBox.Value > 0 && YearPicker.Value != null)
            {
                var result = client.Add(new Kolcsonzo.Car4
                {
                    Brand = BrandBox.Text,
                    Type = TypeBox.Text,
                    Km = Convert.ToInt32(KmBox.Value),
                    Priceperkm = Convert.ToInt32(PricePerKmBox.Value),
                    LicPlNum = LicPlNumText.Text,
                    Year = YearPicker.Value.Year,
                    Uid = Form1.Uid
                });
                if (result.Success == "You have to log in to perform this action!")
                {
                    Form1.LoggedIn = false;
                }
                MessageBox.Show(result.Success);
                this.Close();
            }
            else
            {
                MessageBox.Show("Az autó összes paraméterét meg kell adni!");
            }
        }


        private bool ValidateLicPlNum()
        {
            if (LicPlNumText.Text.Length != 6)
            {
                return false;
            }
            for (int i = 0; i < LicPlNumText.Text.Length; i++)
            {
                char c = LicPlNumText.Text[i];
                if (i<3)
                {
                    if (!Char.IsLetter(c) || c >= 128)
                    {
                        return false;
                    }
                }
                else
                {
                    if (!Char.IsDigit(c))
                    {
                        return false;
                    }
                }
            }
            LicPlNumText.Text = LicPlNumText.Text.ToUpper();
            return true;
        }

        private void InitYearBox()
        {
            YearPicker.MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            YearPicker.Format = DateTimePickerFormat.Custom;
            YearPicker.CustomFormat = "yyyy";
            YearPicker.ShowUpDown = true;
        }

        private async void InitBrands()
        {
            List<string> brands = new List<string>();
            using (var call = client.GetBrands(new Empty { }))
            {
                while (await call.ResponseStream.MoveNext())
                {
                    string s = call.ResponseStream.Current.S;
                    brands.Add(s);
                }
            }
            BrandBox.DataSource = brands;
        }
        private async void InitTypes()
        {
            List<string> types = new List<string>();
            using (var call = client.GetTypes(new Empty { }))
            {
                while (await call.ResponseStream.MoveNext())
                {
                    string s = call.ResponseStream.Current.S;
                    types.Add(s);
                }
            }
            TypeBox.DataSource = types;
        }
    }
}
