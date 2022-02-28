using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using MySql;
using MySql.Data.MySqlClient;

namespace Kolcsonzo
{
    public class KolcsonzoService : Kolcsonzo.KolcsonzoBase
    {
        MySqlConnection conn;
        static readonly List<User> users = new List<User>();
        static readonly List<Car> Cars = new List<Car>();
        public KolcsonzoService()
        {
            string connStr = "server=localhost;user=root;database=kolcsonzo;password=";
            this.conn = new MySqlConnection(connStr);
            this.conn.Open();
            Initialize();
        }

        private void Initialize()
        {
            lock (typeof(Kolcsonzo))
            {
                GetUsers();
                GetCars();
            }
        }

        public override Task<isConnected> Connect(Empty semmi, ServerCallContext context)
        {
            return Task.FromResult(new isConnected{IsConnected = true});
        }
        public override async Task List(Empty vmi, Grpc.Core.IServerStreamWriter<Car> responseStream, Grpc.Core.ServerCallContext context)
        {
            foreach (var Car in Cars)
            {
                FormatCar(Car);
                await responseStream.WriteAsync(Car);
            }
        }
        public override async Task GetBrands(Empty vmi, Grpc.Core.IServerStreamWriter<str> responseStream, Grpc.Core.ServerCallContext context)
        {
            string sql = "SELECT brand_name FROM brands ORDER BY brand_name;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                await responseStream.WriteAsync(new str { S = reader[0].ToString() });
            }
        }
        public override async Task GetTypes(Empty vmi, Grpc.Core.IServerStreamWriter<str> responseStream, Grpc.Core.ServerCallContext context)
        {
            string sql = "SELECT type_name FROM car_types ORDER BY type_name;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                await responseStream.WriteAsync(new str { S = reader[0].ToString() });
            }
        }

        public override async Task ListType(Type type, Grpc.Core.IServerStreamWriter<Car> responseStream, Grpc.Core.ServerCallContext context)
        {
            string[] types = type.Type_.Split(' ');
            foreach (var Car in Cars)
            {
                if (types.Contains(Car.Type))
                {
                    await responseStream.WriteAsync(Car);
                }
            }
        }

        public override Task<Session_Id> Login(LoginData data, ServerCallContext context)
        {
            User u = GetLogin(data.Username, data.Passwd);
            if (u != null)
            {
                u.Uid = Guid.NewGuid().ToString();
                return Task.FromResult(new Session_Id { Uid = u.Uid, Level = u.Level, Success = "You have successfully logged in." });
            }
            else
                return Task.FromResult(new Session_Id { Uid = "", Level = 0, Success = "Incorrect username or password." });
        }

        public override Task<Result> Logout(Session_Id2 id, ServerCallContext context)
        {
            User user = Find(id.Id);
            if (user == null)
            {
                return Task.FromResult(new Result { Success = "You have already logged out." });
            }

            if (user.Uid != id.Id)
            {
                return Task.FromResult(new Result { Success = "You are not logged in." });
            }
            else
            {
                lock (users)
                {
                    user.Uid = Guid.NewGuid().ToString();
                }

                return Task.FromResult(new Result { Success = "You have successfully logged out." });
            }

        }


        public override Task<Result> Add(Car4 Car, ServerCallContext context)
        {
            int level = GetLevel(Car.Uid);
            if (level == 0)
            {
                return Task.FromResult(new Result { Success = "You have to log in to perform this action!" });
            }
            else if (level == 1)
            {
                return Task.FromResult(new Result { Success = "You need admin permission to perform this action!" });
            }
            else
            {
                lock (Cars)
                {
                    int i = 0;
                    for (i = 0; i < Cars.Count; i++)
                    {
                        if (Cars[i].LicPlNum == Car.LicPlNum)
                        {
                            return Task.FromResult(new Result { Success = "This car is already exist in the database!" });
                        }
                    }
                    Car temp = new Car();
                    temp.Brand = Car.Brand;
                    temp.Type = Car.Type;
                    temp.Year = Car.Year;
                    temp.Km = Car.Km;
                    temp.Priceperkm = Car.Priceperkm;
                    temp.LicPlNum = Car.LicPlNum;
                    temp.IsRented = false;
                    Cars.Add(temp);
                    SaveCar(Car);
                    return Task.FromResult(new Result { Success = "Car " + temp.LicPlNum + " successfully added." });
                }
            }
        }

        public override Task<Result> Delete(Car2 Car, ServerCallContext context)
        {
            int level = GetLevel(Car.Uid);
            if (level == 0)
            {
                return Task.FromResult(new Result { Success = "You have to log in to perform this action!" });
            }
            else if (level == 1)
            {
                return Task.FromResult(new Result { Success = "You need admin permission to perform this action!" });
            }
            else
            {
                lock (Cars)
                {
                    int i = 0;
                    for (i = 0; i < Cars.Count; i++)
                    {
                        if (Cars[i].LicPlNum == Car.LicPlNum)
                        {
                            string licenseplate = Cars[i].LicPlNum;
                            Cars.RemoveAt(i);
                            DeleteCar(licenseplate);
                            return Task.FromResult(new Result { Success = licenseplate + " car successfully deleted." });
                        }
                    }
                    return Task.FromResult(new Result { Success = "No such car " + Car.LicPlNum + "." });
                }
            }
        }


        public override Task<Result> Rent(Car2 car, ServerCallContext context)
        {
            User u = Find(car.Uid);
            if (u == null)
            {
                return Task.FromResult(new Result { Success = "You have to log in to perform this action!" });
            }
            else
            {
                lock (Cars)
                {
                    for (int i = 0; i < Cars.Count; i++)
                    {
                        if (Cars[i].LicPlNum == car.LicPlNum)
                        {
                            if (Cars[i].IsRented == true)
                            {
                                return Task.FromResult(new Result { Success = "The " + Cars[i].LicPlNum + " is already rented." });
                            }
                            else
                            {
                                Cars[i].IsRented = true;
                                Cars[i].Renter = u.Username;
                                RentCar(Cars[i]);
                                return Task.FromResult(new Result { Success = Cars[i].LicPlNum + " car successfully rented." });
                            }
                        }
                    }
                    return Task.FromResult(new Result { Success = "No such car " + car.LicPlNum + "." });
                }
            }
        }

        public override Task<Result> Back(Car3 car, ServerCallContext context)
        {
            User u = Find(car.Uid);
            if (u == null)
            {
                return Task.FromResult(new Result { Success = "You have to log in to perform this action!" });
            }
            else
            {
                lock (Cars)
                {
                    for (int i = 0; i < Cars.Count; i++)
                    {
                        if (Cars[i].LicPlNum == car.LicPlNum)
                        {
                            if (Cars[i].IsRented == false)
                            {
                                return Task.FromResult(new Result { Success = "The " + Cars[i].LicPlNum + " is not rented." });
                            }
                            else if(Cars[i].Renter != u.Username)
                            {
                                return Task.FromResult(new Result { Success = "The car is not rented by you." });
                            }
                            else if (car.Km <= Cars[i].Km)
                            {
                                return Task.FromResult(new Result { Success = "The new km cannot be lower than the old km!" });
                            }
                            else
                            {
                                int payment = (car.Km - Cars[i].Km) * Cars[i].Priceperkm;
                                Cars[i].Km = car.Km;
                                Cars[i].IsRented = false;
                                Cars[i].Renter = "";
                                BackCar(Cars[i].LicPlNum);
                                return Task.FromResult(new Result { Success = Cars[i].LicPlNum + " car brought back successfully. " + payment +"Ft to be paid." });
                            }
                        }
                    }
                    return Task.FromResult(new Result { Success = "No such car " + car.LicPlNum + "." });
                }
            }
        }

        private User Find(string UId)
        {
            lock (users)
            {
                foreach (User user in users)
                {
                    if (user.Uid == UId)
                    {
                        return user;
                    }
                }
                return null;
            }
        }

        private int GetLevel(string UId)
        {
            lock (users)
            {
                foreach (User user in users)
                {
                    if (user.Uid == UId)
                    {
                        return user.Level;
                    }
                }
                return 0;
            }
        }

        private User GetLogin(string username, string password)
        {
            User temp = new User();
            lock (users)
            {
                foreach (User user in users)
                {
                    if (user.Username == username)
                    {
                        temp = user;
                        break;
                    }
                }
            }
            if (temp == null)
            {
                return null;
            }
            else if (!CheckPassword(username, password))
            {
                return null;
            }
            else
            {
                return temp;
            }
        }

        private bool CheckPassword(string username, string password)
        {
            string pw = "";
            string sql = String.Format("SELECT pass FROM users WHERE username = '{0}';", username);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                pw = reader[0].ToString();
            }
            reader.Close();
            if (pw != null && pw==password)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void GetUsers()
        {
            string sql;

            if (users.Count<1)
            {
                lock (users)
                {
                    sql = "SELECT username, user_type FROM users;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string uid = Guid.NewGuid().ToString();
                        users.Add(new User { Username = reader[0].ToString(), Level = Convert.ToInt32(reader[1]), Uid=uid });
                    }
                    reader.Close();
                }
            }
        }

        private void GetCars()
        {
            string sql;
            lock (Cars)
            {
                if (Cars.Count < 1)
                {
                    sql = "SELECT brands.brand_name, car_types.type_name, cars.lic_pl_num, cars.year, cars.km, cars.priceperkm, cars.is_rented, users.username FROM cars " +
                            "INNER JOIN brands ON brands.brand_id=cars.brand " +
                            "INNER JOIN car_types ON car_types.type_id=cars.car_type " +
                            "LEFT JOIN users ON users.user_id = cars.renter ORDER BY brands.brand_name;";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Cars.Add(new Car
                        {
                            Brand = reader[0].ToString(),
                            Type = reader[1].ToString(),
                            LicPlNum = reader[2].ToString(),
                            Year = Convert.ToInt32(reader[3]),
                            Km = Convert.ToInt32(reader[4]),
                            Priceperkm = Convert.ToInt32(reader[5]),
                            IsRented = Convert.ToInt32(reader[6]) == 1 ? true : false,
                            Renter = reader[7].ToString(),
                            Formatted = string.Format("{0,-14} {1,-10} {2,-4} {3,7} {4,8} {5,7}{6,7}    {7}",
                                reader[0].ToString(), reader[1].ToString(), Convert.ToInt32(reader[3]), Convert.ToInt32(reader[4]), 
                                Convert.ToInt32(reader[5]), reader[2].ToString(), Convert.ToInt32(reader[6]) == 0 ? "Igen" : "Nem", reader[7].ToString())
                    });
                    }
                    reader.Close();
                }

            }
        }

        private void SaveCar(Car4 car)
        {
            string sql = String.Format("INSERT INTO cars(brand, car_type, lic_pl_num, year, km, priceperkm) " +
                "VALUES((SELECT brand_id FROM brands WHERE brand_name = '{0}'), (SELECT type_id FROM car_types WHERE type_name = '{1}')," +
                " '{2}', {3}, {4}, {5})", car.Brand, car.Type, car.LicPlNum, car.Year, car.Km, car.Priceperkm);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        private void DeleteCar(string licplatenumber)
        {
            string sql = String.Format("DELETE FROM cars WHERE lic_pl_num='{0}'", licplatenumber);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        private void RentCar(Car car)
        {
            string sql = String.Format("UPDATE cars SET is_rented=1, renter=(SELECT user_id FROM users WHERE username ='{0}') WHERE lic_pl_num='{1}'", car.Renter, car.LicPlNum);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        private void BackCar(string licplatenumber)
        {
            string sql = String.Format("UPDATE cars SET is_rented=0, renter=null WHERE lic_pl_num='{0}'", licplatenumber);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        private void FormatCar(Car c)
        {
            c.Formatted = string.Format("{0,-14} {1,-10} {2,-4} {3,7} {4,8} {5,7}{6,7}    {7}",
                c.Brand, c.Type, c.Year, c.Km, c.Priceperkm, c.LicPlNum, c.IsRented == false ? "Igen" : "Nem", c.Renter);
        }
    }
}
