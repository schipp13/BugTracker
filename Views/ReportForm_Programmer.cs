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
    public partial class ReportForm_Programmer : Form
    {
        Database database = new Database();
        int programmerId;
        public ReportForm_Programmer(int id)
        {
            InitializeComponent();
            programmerId = id;
        }

        private void bugBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bugBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bugtrackingdatabaseDataSet);
        }

        private void ReportForm_Programmer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bugtrackingdatabaseDataSet.bug' table. You can move, or remove it, as needed.
            this.bugTableAdapter.Fill(this.bugtrackingdatabaseDataSet.bug);
           
            var AssignedTickets = bugtrackingdatabaseDataSet.bug.Where(bug => bug.ProgrammerId == programmerId).ToList();

            bugDataGridView.DataSource = AssignedTickets.ToArray();            
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void EditIssueButton_Click(object sender, EventArgs e)
        {
            if (bugDataGridView.SelectedRows.Count > 0)
            {
                int BugId = (int)bugDataGridView.SelectedRows[0].Cells[0].Value;
                this.Hide();
                ReportIssueForm_Dev reportForm_Dev = new ReportIssueForm_Dev(BugId, programmerId);
                reportForm_Dev.Show();
            }
            else
            {
                MessageBox.Show("Please select a ticket before editing.");
            }
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
