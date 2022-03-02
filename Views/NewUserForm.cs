using BugTracker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker.Views
{
    public partial class NewUserForm : Form
    {
        Database database = new Database();
        
        public NewUserForm()
        {
            InitializeComponent();
        }

        public bool isValid()
        {
            bool valid = true;

            if(string.IsNullOrEmpty(firstNameTextBox.Text) || string.IsNullOrEmpty(lastNameTextBox.Text) ||
               string.IsNullOrEmpty(phoneTextBox.Text) || string.IsNullOrEmpty(emailTextBox.Text) ||
               string.IsNullOrEmpty(userNameTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Please make sure all fields have the correct data before continuing.");
                valid = false;
            }

            return valid;
        }

        private bool accountExists()
        {
            bool found = false;

            found = database.ExistingAccount($"SELECT * FROM client WHERE FirstName = '{firstNameTextBox.Text}' AND LastName = '{lastNameTextBox.Text}'");

            return found;
        }
        private void CreateUserButton_Click(object sender, EventArgs e)
        {
           
            if (accountExists())
            {
                MessageBox.Show("The account has already been created.");
            }
            else
            {
                if (isValid())
                {                   
                    User newUser = new User();                    
                    newUser.FirstName = firstNameTextBox.Text;
                    newUser.LastName = lastNameTextBox.Text;
                    newUser.Phone = phoneTextBox.Text;
                    newUser.Email = emailTextBox.Text;
                    newUser.Username = userNameTextBox.Text;
                    newUser.Password = passwordTextBox.Text;

                    database.InsertQuery($"INSERT INTO client (FirstName, LastName, Email, Phone, UserName, Password) VALUES" +
                        $"('{newUser.FirstName}','{newUser.LastName}','{newUser.Email}','{newUser.Phone}','{newUser.Username}','{newUser.Password}')");

                    MessageBox.Show("The user was created.");

                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bugtrackingdatabaseDataSet);
        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bugtrackingdatabaseDataSet.client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.bugtrackingdatabaseDataSet.client);

        }
    }
}
