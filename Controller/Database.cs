using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker.Models
{
    internal class Database
    {
        private MySqlConnection connString = new MySqlConnection("server = 127.0.0.1; user id = root; password=Password1; persistsecurityinfo=True;database=bugtrackingdatabase");
        Programmer[] ListOfTickets = null;
      
        // Populate the Issue list

        // Login 
        public bool ExistingAccount(string query)
        {
            connString.Open();

            using(MySqlCommand cmd = new MySqlCommand(query, connString))
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    connString.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    reader.Dispose();
                }
            }
            connString.Close();

            return false;
        }

        // Check if account has admin privileges
        public bool HasAdminPrivileges(string query)
        {
            connString.Open();

            using (MySqlCommand cmd = new MySqlCommand(query, connString))
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    connString.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    reader.Dispose();
                }
            }
            connString.Close();

            return false;
        }


        public void InsertQuery(string query)
        {
            using(MySqlCommand cmd = new MySqlCommand(query, connString))
            {
                connString.Open();
                cmd.ExecuteNonQuery();
            }
            connString.Close();
        }

        public void DeleteQuery(string query)
        {
            using (MySqlCommand cmd = new MySqlCommand(query, connString))
            {
                connString.Open();
                cmd.ExecuteNonQuery();
            }
            connString.Close();
        }

        public void UpdateQuery(string query)
        {
            using(MySqlCommand cmd = new MySqlCommand(query, connString))
            {
                connString.Open();
                cmd.ExecuteNonQuery();
            }
            connString.Close();
        }

        public void SearchQuery(string query)
        {
            using (MySqlCommand cmd = new MySqlCommand(query, connString))
            {
                connString.Open();
                cmd.ExecuteNonQuery();
            }
            connString.Close();
        }
        public Programmer[] populateFullNameList(string query)
        {
            connString.Open();
            var FullNameList = new List<Programmer>();

            using (MySqlCommand cmd = new MySqlCommand(query, connString))
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    try
                    {
                        FullNameList.Add(new Programmer { FirstName = reader.GetString(0), LastName = reader.GetString(1) });

                        ListOfTickets = FullNameList.ToArray();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
            connString.Close();
            return ListOfTickets;
                
        }

        string programmerId;
        public string getId(string query)
        {
            using (MySqlCommand cmd = new MySqlCommand(query, connString))
            {
                connString.Open();
                try
                {
                    programmerId = cmd.ExecuteScalar().ToString();
                    cmd.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            connString.Close();

            return programmerId;
        }
    } 
}
