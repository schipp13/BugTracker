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
    public partial class DevLoginForm : Form
    {
        Database database = new Database();
        public DevLoginForm()
        {
            InitializeComponent();
            populateDB_DevAccount();
        }

        public void populateDB_DevAccount()
        {

            // Create a test admin account
            Programmer adminProgrammer = new Programmer();
            adminProgrammer.BugId = 0;
            adminProgrammer.FirstName = "John";
            adminProgrammer.LastName = "Doe";
            adminProgrammer.Phone = "555-555-5555";
            adminProgrammer.Email = "Jdoe@gmail.com";
            adminProgrammer.Username = "Jdoe";
            adminProgrammer.Password = "Password";
            adminProgrammer.PermissionLevel = "Admin";

            database.InsertQuery($"INSERT INTO programmer (FirstName, LastName, Email, Phone, UserName, Password, PermissionLevel, BugId) " +
                      $"VALUES ('{adminProgrammer.FirstName}','{adminProgrammer.LastName}','{adminProgrammer.Email}','{adminProgrammer.Phone}','{adminProgrammer.Username}'," +
                      $"'{adminProgrammer.Password}','{adminProgrammer.PermissionLevel}', '{ adminProgrammer.BugId}')");

            // Create a test dev account

            Programmer programmer = new Programmer();
            programmer.BugId = 0;
            programmer.FirstName = "Jane";
            programmer.LastName = "Doe";
            programmer.Phone = "555-555-5555";
            programmer.Email = "Jdoe@gmail.com";
            programmer.Username = "Computers";
            programmer.Password = "Password";
            programmer.PermissionLevel = "Basic";

            database.InsertQuery($"INSERT INTO programmer (FirstName, LastName, Email, Phone, UserName, Password, PermissionLevel, BugId) " +
                      $"VALUES ('{programmer.FirstName}','{programmer.LastName}','{programmer.Email}','{programmer.Phone}','{programmer.Username}'," +
                      $"'{programmer.Password}','{programmer.PermissionLevel}', '{ programmer.BugId}')");


        }

        private void programmerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.programmerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bugtrackingdatabaseDataSet);
        }

        private void DevLoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bugtrackingdatabaseDataSet.programmer' table. You can move, or remove it, as needed.
            this.programmerTableAdapter.Fill(this.bugtrackingdatabaseDataSet.programmer);

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool isExistingAccount = false, hasAdminPrivileges = false;

            isExistingAccount = database.ExistingAccount($"SELECT * FROM programmer WHERE UserName = '{userNameTextBox.Text}' AND Password = '{passwordTextBox.Text}'");

            if (isExistingAccount)
            {
                hasAdminPrivileges = database.HasAdminPrivileges($"SELECT * FROM programmer WHERE UserName = '{userNameTextBox.Text}' AND PermissionLevel = 'Admin'");
                if (hasAdminPrivileges)
                {
                    this.Hide();
                    ReportForm_Programmer_Admin reportForm = new ReportForm_Programmer_Admin();
                    reportForm.Show();
                }
                else
                {
                    int programmerId = Convert.ToInt32(database.getId($"SELECT programmerId FROM programmer WHERE UserName = '{userNameTextBox.Text}' AND Password = '{passwordTextBox.Text}'"));
                    this.Hide();
                    ReportForm_Programmer reportForm = new ReportForm_Programmer(programmerId);
                    reportForm.Show();
                }
            }
            else
            {
                MessageBox.Show("The username or password is incorrect. Please try again.");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
