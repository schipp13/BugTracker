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
    public partial class ReportIssueForm_User : Form
    {
        Database database = new Database();
        int userId;
        public ReportIssueForm_User(string name, int id)
        {
            InitializeComponent();
            userId = id;
            usernameLabel.Text = $"Hello, {name}";
        }

        private void bugBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bugBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bugtrackingdatabaseDataSet);

        }

        private void ReportIssueForm_User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bugtrackingdatabaseDataSet.bug' table. You can move, or remove it, as needed.
            this.bugTableAdapter.Fill(this.bugtrackingdatabaseDataSet.bug);

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            Bug newBug = new Bug();
            newBug.UserId = userId;
            newBug.ProgrammerId = 0;
            newBug.SoftwareName = softwareNameTextBox.Text;
            newBug.SoftwareVersion = softwareVersionTextBox.Text;
            newBug.BugIssue = bugIssueTextBox.Text;
            newBug.ReplicateBugSteps = replicateBugStepsTextBox.Text;
            newBug.ReportedTime = DateTime.UtcNow;
            newBug.ResolvedTime = DateTime.UtcNow;
            newBug.TimeToResolution = " ";
            newBug.CurrentStatus = "Pending";
            newBug.Severity = "Low";
            newBug.Notes = "";


            database.InsertQuery($"INSERT INTO bug (CurrentStatus, Severity, ReportedTime, ResolvedTime, BugIssue, ReplicateBugSteps, SoftwareName, SoftwareVersion, UserId, ProgrammerId, Notes)" +
                $"VALUES ('{newBug.CurrentStatus}','{newBug.Severity}','{newBug.ReportedTime.ToString("yyyy-MM-dd HH:mm:ss")}','{newBug.ResolvedTime.ToString("yyyy-MM-dd HH:mm:ss")}','{newBug.BugIssue}', '{newBug.ReplicateBugSteps}', '{newBug.SoftwareName}'," +
                $"'{newBug.SoftwareVersion}', '{newBug.UserId}', '{newBug.ProgrammerId}', '{newBug.Notes}')");

            MessageBox.Show("Thank you for sending in a report. One of our developers will work on this shortly.");

            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
