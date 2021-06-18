using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inf_Saug_Uzd4_Password_Manager
{
    public class UserList
    {
        private static List<User> userList;
        private SQLiteConnection cn;

        public UserList()
        {
            cn = new SQLiteConnection(@"URI=file:C:\sqlite\Inf_Saug_Uzd4.db");
        }

        public List<User> GetUsers()
        {
            List<User> userList = new List<User>();
            try
            {
                string sql = "SELECT username, password FROM User";
                SQLiteCommand cmd = new SQLiteCommand(sql, cn);

                cn.Open();
                SQLiteDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    string username = rd["username"].ToString();
                    string password = rd["password"].ToString();
                    userList.Add(new User(username, password));
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return userList;
        }

        public void Register(User user)
        {
            userList.Add(user);
        }

        public User Login(string username, string pass)
        {
            foreach (User user in userList)
                if (user.GetUsername().Equals(username) && user.GetPassword().Equals(pass))
                    return user;
            throw new Exception("Blogai ivesti duomenys");
        }

        public void ChangePassword(string name, string newpass)
        {
            try
            {
                string sql = "UPDATE User SET password=@newpass WHERE username=@username";
                SQLiteCommand cmd = new SQLiteCommand(sql, cn);
                cmd.Parameters.AddWithValue("@newpass", newpass);
                cmd.Parameters.AddWithValue("@username", name);
                cn.Open();
                SQLiteDataReader rd = cmd.ExecuteReader();
                cmd.Connection = cn;
                rd = cmd.ExecuteReader();
                cn.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }


        public void AddUser(string username, string password)
        {
            try
            {
                string sql = "INSERT INTO User (username, password) VALUES (@username, @password)";
                SQLiteCommand cmd = new SQLiteCommand(sql, cn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public void RemoveUser(string Username)
        {
            try
            {
                if (Username != Startform.currentUser)
                {
                    MessageBox.Show("Naudotojas pasalintas.");
                    string sql = "DELETE FROM User WHERE username=@username";
                    SQLiteCommand cmd = new SQLiteCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@username", Username);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
