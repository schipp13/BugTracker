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
    public partial class ReportIssueForm_Dev : Form
    {
        int bugId;
        int programmerId;
        DateTime reportedTime;

        Database database = new Database();
        public ReportIssueForm_Dev(int id, int ProgrammerId)
        {
            InitializeComponent();
            bugId = id;
            programmerId = ProgrammerId;
           
        }

        private void bugBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bugBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bugtrackingdatabaseDataSet);
        }

        private void ReportIssueForm_Dev_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bugtrackingdatabaseDataSet.bug' table. You can move, or remove it, as needed.
            this.bugTableAdapter.Fill(this.bugtrackingdatabaseDataSet.bug);

            // load fields
            var SelectedBug = from bug in bugtrackingdatabaseDataSet.bug
                              where bug.BugId == bugId
                              select new
                              {
                                  softwareName = bug.SoftwareName,
                                  softwareVersion = bug.SoftwareVersion,
                                  severity = bug.Severity,
                                  status = bug.CurrentStatus,
                                  bugissue = bug.BugIssue,
                                  replicatedStep = bug.ReplicateBugSteps,
                                  notes = bug.Notes,
                                  reportedDate = bug.ReportedTime,
                              };

            foreach (var issue in SelectedBug)
            {
                if(string.IsNullOrEmpty(issue.notes))
                {
                    notesTextBox.Text = "";
                }
                else
                {
                    notesTextBox.Text = issue.notes;
                }
                softwareNameTextBox.Text = issue.softwareName;
                softwareVersionTextBox.Text = issue.softwareVersion;
                severityTextBox.Text = issue.severity;
                currentStatusComboBox.SelectedItem = issue.status;
                bugIssueTextBox.Text = issue.bugissue;
                replicateBugStepsTextBox.Text = issue.replicatedStep;
                reportedTime = issue.reportedDate;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ReportForm_Programmer reportForm_Programmer = new ReportForm_Programmer(programmerId);
            reportForm_Programmer.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string status = currentStatusComboBox.SelectedItem.ToString();
            string timeToCompletion = (DateTime.UtcNow.Subtract(reportedTime)).ToString();
            
            if (status == "Completed")
            {
                database.UpdateQuery($"UPDATE bug SET ResolvedTime = '{DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss")}', TimeToResolution = '{timeToCompletion}',CurrentStatus = '{status}', Notes = '{notesTextBox.Text}'" +
                    $"WHERE BugId = {bugId}");

                MessageBox.Show("The ticket has been updated.");
            }
            else
            {
                database.UpdateQuery($"UPDATE bug SET CurrentStatus = '{status}', Notes = '{notesTextBox.Text}'" +
                    $"WHERE BugId = {bugId}");

                MessageBox.Show("The ticket has been updated.");
            }

            this.Close();
            ReportForm_Programmer reportForm_Programmer = new ReportForm_Programmer(programmerId);
            reportForm_Programmer.Show();
        }
    }
}
