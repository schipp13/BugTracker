using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BugTracker.Views;
using BugTracker.Models;

namespace BugTracker
{
    public partial class LoginForm : Form
    {
        int id;
        string FirstName;
        Database database = new Database();
        public LoginForm()
        {
            InitializeComponent();
            populateDB_UserAccount();

        }

        public void populateDB_UserAccount()
        {
            // Create a test user account 

            User newUser = new User();
            newUser.FirstName = "Bob";
            newUser.LastName = "Rudoplh";
            newUser.Phone = "111-111-1111";
            newUser.Email = "Brudoplh@gmail.com";
            newUser.Username = "Bob";
            newUser.Password = "Password1";

            database.InsertQuery($"INSERT INTO client (FirstName, LastName, Email, Phone, UserName, Password) VALUES" +
                $"('{newUser.FirstName}','{newUser.LastName}','{newUser.Email}','{newUser.Phone}','{newUser.Username}','{newUser.Password}')");
        }

        private void SignUpLabel_Click(object sender, EventArgs e)
        {
            // Loads the NewUserForm
            this.Hide();
            NewUserForm newUser = new NewUserForm();
            newUser.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            bool isExistingAccount = false;
            isExistingAccount = database.ExistingAccount($"SELECT * FROM client WHERE UserName = '{userNameTextBox.Text}' AND Password = '{passwordTextBox.Text}'");   
            
            if(isExistingAccount)
            {
                this.Hide();
                
                var userId = from client in bugtrackingdatabaseDataSet.client
                             where client.UserName == userNameTextBox.Text
                             select new 
                             { 
                                 id = client.ClientId,         
                                 firstName = client.FirstName
                             };

                foreach(var item in userId)
                {
                    id = item.id;
                    FirstName = item.firstName;
                }

                
                ReportIssueForm_User reportForm = new ReportIssueForm_User(FirstName, id);
                reportForm.Show();
            }
            else
            {
                MessageBox.Show("The username or password is incorrect. Please try again");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bugtrackingdatabaseDataSet);

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bugtrackingdatabaseDataSet.client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.bugtrackingdatabaseDataSet.client);

        }

        private void DevLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            DevLoginForm loginForm = new DevLoginForm();
            loginForm.Show();
        }
    }
}
