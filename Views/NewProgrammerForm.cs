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
    public partial class NewProgrammerForm : Form
    {
        int id;
        Database database = new Database();
        bool editProgrammer;
        public NewProgrammerForm(string titleName, bool editMode)
        {
            InitializeComponent();
            titleLabel.Text = titleName;
            SearchButton.Visible = false;
            searchTextBox.Visible = false;
            editProgrammer = editMode;
            if (editMode)
            {
                SearchButton.Visible = true;
                searchTextBox.Visible = true;
            }
        }

       
        private void programmerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.programmerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bugtrackingdatabaseDataSet);

        }

        private void NewProgrammerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bugtrackingdatabaseDataSet.programmer' table. You can move, or remove it, as needed.
            this.programmerTableAdapter.Fill(this.bugtrackingdatabaseDataSet.programmer);

        }

        public bool isValid()
        {
            bool valid = true;

            if (string.IsNullOrEmpty(firstNameTextBox.Text) || string.IsNullOrEmpty(lastNameTextBox.Text) ||
               string.IsNullOrEmpty(phoneTextBox.Text) || string.IsNullOrEmpty(emailTextBox.Text) ||
               string.IsNullOrEmpty(userNameTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text) ||
               string.IsNullOrEmpty(permissionLevelComboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("Please make sure all fields have the correct data before continuing.");
                valid = false;
            }

            return valid;
        }
        private bool accountExists()
        {
            bool found = false;

            found = database.ExistingAccount($"SELECT * FROM programmer WHERE FirstName = '{firstNameTextBox.Text}' AND LastName = '{lastNameTextBox.Text}'");

            return found;
        }
        private void CreateProgrammerButton_Click(object sender, EventArgs e)
        {
            if (accountExists() && editProgrammer == false)
            {
                MessageBox.Show("The account has already been created.");
            }
            else
            {
                if (isValid() && editProgrammer == false)
                {
                    Programmer newProgrammer = new Programmer();
                    newProgrammer.BugId = 0;
                    newProgrammer.FirstName = firstNameTextBox.Text;
                    newProgrammer.LastName = lastNameTextBox.Text;
                    newProgrammer.Phone = phoneTextBox.Text;
                    newProgrammer.Email = emailTextBox.Text;
                    newProgrammer.Username = userNameTextBox.Text;
                    newProgrammer.Password = passwordTextBox.Text;
                    newProgrammer.PermissionLevel = permissionLevelComboBox.SelectedItem.ToString();

                    database.InsertQuery($"INSERT INTO programmer (FirstName, LastName, Email, Phone, UserName, Password, PermissionLevel, BugId) " +
                        $"VALUES ('{newProgrammer.FirstName}','{newProgrammer.LastName}','{newProgrammer.Email}','{newProgrammer.Phone}','{newProgrammer.Username}'," +
                        $"'{newProgrammer.Password}','{newProgrammer.PermissionLevel}', '{newProgrammer.BugId}')");

                    MessageBox.Show("A new programmer account has been created successfuly");

                    this.Hide();
                    ReportForm_Programmer_Admin adminReportForm = new ReportForm_Programmer_Admin();
                    adminReportForm.Show();
                }
                else
                {
                    var programmerId = from programmer in bugtrackingdatabaseDataSet.programmer
                                       where programmer.FirstName == firstNameTextBox.Text
                                       select new
                                       {
                                           id = programmer.ProgrammerId ,
                                       };

                    foreach(var item in programmerId)
                    {
                        id = item.id;
                    }

                    database.UpdateQuery($"UPDATE programmer SET FirstName = '{firstNameTextBox.Text}', LastName = '{lastNameTextBox.Text}', Phone = '{phoneTextBox.Text}', Email = '{emailTextBox.Text}'," +
                  $"UserName = '{userNameTextBox.Text}', Password = '{passwordTextBox.Text}', PermissionLevel = '{permissionLevelComboBox.SelectedItem.ToString()}' WHERE ProgrammerId = {id}");

                    MessageBox.Show("The account has been updated successfuly");

                    this.Hide();
                    ReportForm_Programmer_Admin adminReportForm = new ReportForm_Programmer_Admin();
                    adminReportForm.Show();
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportForm_Programmer_Admin adminReportForm = new ReportForm_Programmer_Admin();
            adminReportForm.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var programmerToEdit = from programmer in bugtrackingdatabaseDataSet.programmer
                                   where programmer.FirstName == searchTextBox.Text
                                   select new
                                   {
                                       FirstName = programmer.FirstName,
                                       LastName = programmer.LastName,
                                       Phone = programmer.Phone,
                                       Email = programmer.Email,
                                       UserName = programmer.UserName,
                                       password = programmer.Password,
                                       permissionLevel = programmer.PermissionLevel,
                                   };
                
            foreach(var items in programmerToEdit)
            {
                firstNameTextBox.Text = items.FirstName;
                lastNameTextBox.Text = items.LastName;
                phoneTextBox.Text = items.Phone;
                emailTextBox.Text = items.Email;
                userNameTextBox.Text = items.UserName;
                passwordTextBox.Text = items.password;
                permissionLevelComboBox.SelectedItem = items.permissionLevel;
            }

        }
    }
}
