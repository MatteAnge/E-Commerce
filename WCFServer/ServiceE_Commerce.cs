using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;

namespace WCFServer
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "Service1" nel codice e nel file di configurazione contemporaneamente.
    public class ServiceE_Commerce : IServiceE_Commerce
    {
        public void Connection()
        {
            return;
        }
        
        public User LoginUser(string email, string password)
        {
            string query = "SELECT * FROM userr WHERE email ='" + email + "' and password = '" + password + "'";

            try
            {
                using (SqlDataReader reader = DBConnection.Read(query))
                {
                    if (reader.Read())
                    {
                        return new User((string)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (float)reader[4]);
                    }
                }
            }
            catch (Exception) { }
            return null;
        }
        
        public bool Sign_up(Address a,User u)
        {
            string query = "INSERT INTO Userr (name, surname, email, password, wallet) VALUES('" + u.name + "','" + u.surname + "','" + u.email + "','" + u.password + "', 0)";
            return DBConnection.Execute(query);
        }

        public bool AddAddress(Address a,User u)
        {
            string query = "INSERT INTO address (user_email, country, city, post_code, address) VALUES('" + u.email + "','" + a.country + "','" + a.city + "','" + a.postCode + "','" + a.address + "')";
            return DBConnection.Execute(query);
        }
        public bool DeleteAddress(Address a, User u)
        {
            string query = "DELETE address WHERE email ='" + u.email + "' and address ='" + a.address +"'";
            return DBConnection.Execute(query);
        }

        public Admin LoginAdmin(string email, string password)
        {
            string query = "SELECT * FROM admin WHERE email ='" + email + "' and password = '" + password + "'";

            try
            {
                using (SqlDataReader reader = DBConnection.Read(query))
                {
                    if (reader.Read())
                    {
                        return new Admin((string)reader[0], (string)reader[1], (string)reader[2], (string)reader[3]);
                    }
                }
            }
            catch (Exception) { }
            return null;
        }

        public List<User> GetListUsers()
        {
            List<User> listUsers = new List<User>();
            string query = "SELECT * FROM userr";

            try
            {
                using (SqlDataReader reader = DBConnection.Read(query))
                {
                    while (reader.Read())
                    {
                        listUsers.Add(new User((string)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (float)reader[4]));
                    }
                }
            }
            catch (Exception) { }
            return listUsers;
        }

        public bool AddProduct(Product p)
        {
            string query = "INSERT product (name,brand, description, img, price, quantity) VALUES('" + p.name + "','" + p.brand + "','" + p.description + "','" + p.img + "','" + p.price + "','" + p.quantity + "')";
            return DBConnection.Execute(query);
        }

        public bool DeleteProduct(Product p)
        {
            string query = "DELETE product WHERE name ='" + p.name + "'";
            return DBConnection.Execute(query);
        }

        public bool UpdateUserWallet(User u, float price, bool add)
        {
            string query;
            if(add)
            {   
                query = "UPDATE userr SET wallet ='" + (u.wallet + price) + "' WHERE email ='" + u.email + "'";
            }
            else
            {
                query = "UPDATE userr SET wallet ='" + (u.wallet - price) + "' WHERE email ='" + u.email + "'";
            }
            return DBConnection.Execute(query);
        }

        public bool UpdateProduct(Product p, int quantity)
        {
            int stock=p.quantity-quantity;
            string query = "UPDATE seat SET quantity ='" + stock +"' WHERE name ='" + p.name + "'"; 
            return DBConnection.Execute(query);
        }
        

        public bool BuyProduct(Product p, User u,int quantity,Address a)
        {
            float price=p.price * quantity;
            string query = "INSERT INTO order (user_email,product_name,quantity,price, country, city, post_code, address,order_date) VALUES('" + u.email +
                "','" + p.name + "','" + quantity + "','" + price + "','" + a.country + "','" + a.city + "','" + a.postCode + "','" + a.address + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "')";

            if (UpdateUserWallet(u, price, false))
            {
                if (UpdateProduct(p, quantity))
                {
                    return DBConnection.Execute(query);
                }
            }
            return false;
        }
        
    }
}
