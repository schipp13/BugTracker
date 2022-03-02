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
    public partial class ReportForm_Programmer_Admin : Form
    {
        Database database = new Database();
        public ReportForm_Programmer_Admin()
        {
            InitializeComponent();
        }

        private void bugBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bugBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bugtrackingdatabaseDataSet);
        }

        private void ReportForm_Programmer_Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bugtrackingdatabaseDataSet.bug' table. You can move, or remove it, as needed.
            this.bugTableAdapter.Fill(this.bugtrackingdatabaseDataSet.bug);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void NewProgrammerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            string titleName = "Create New Account";
            bool editMode = false;
            NewProgrammerForm newProgrammer = new NewProgrammerForm(titleName, editMode);
            newProgrammer.Show();
        }

        private void EditIssueButton_Click(object sender, EventArgs e)
        {
            if (bugDataGridView.SelectedRows.Count > 0)
            {
                int BugId = (int)bugDataGridView.SelectedRows[0].Cells[0].Value;
                this.Hide();
                ReportIssueForm_Dev_Admin reportForm_Dev_Admin = new ReportIssueForm_Dev_Admin(BugId);
                reportForm_Dev_Admin.Show();
            }
            else
            {
                MessageBox.Show("Please select a ticket to edit.");
            }

        }

        private void DeleteIssueButton_Click(object sender, EventArgs e)
        {
            if (bugDataGridView.SelectedRows.Count > 0)
            {
                if (bugDataGridView.SelectedRows[0].Cells[2].Value.ToString() == "Completed")
                {
                    int BugId = (int)bugDataGridView.SelectedRows[0].Cells[0].Value;
                    database.DeleteQuery($"DELETE FROM bug WHERE BugId = {BugId}");
                    this.bugTableAdapter.Fill(this.bugtrackingdatabaseDataSet.bug);
                }
                else
                {
                    MessageBox.Show("Please select a completed Issue to be deleted.");
                }
            }
            else
            {
                MessageBox.Show("Please select a ticket to delete.");
            }

        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusinessReports reports = new BusinessReports();
            reports.Show();
        }

        private void EditProgrammerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            string titleName = "Edit Account";
            bool editMode = true;
            NewProgrammerForm newProgrammer = new NewProgrammerForm(titleName, editMode);
            newProgrammer.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {         
            bugDataGridView.ClearSelection();
            foreach (DataGridViewRow row in bugDataGridView.Rows)
            {
                if (row.Cells[0].Value.ToString().Contains(searchTextBox.Text) || row.Cells[1].Value.ToString().Contains(searchTextBox.Text))
                {
                    bugDataGridView.Rows[row.Index].Selected = true;
                    break;
                }
            }
        }

        private void bugDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            bugDataGridView.ClearSelection();
        }
    }
}
