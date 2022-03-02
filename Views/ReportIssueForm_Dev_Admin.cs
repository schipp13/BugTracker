
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
    public partial class ReportIssueForm_Dev_Admin : Form
    {
        int bugId;
        DateTime reportedTime;
        Database database = new Database();
        public ReportIssueForm_Dev_Admin(int id)
        {
            InitializeComponent();
            bugId = id;           
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ReportForm_Programmer_Admin reportForm_Programmer_Admin = new ReportForm_Programmer_Admin();
            reportForm_Programmer_Admin.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string status = currentStatusComboBox.SelectedItem.ToString();

            string timeToCompletion = DateTime.UtcNow.Subtract(reportedTime).ToString();

            if (status == "Completed")
            {
                database.UpdateQuery($"UPDATE bug SET ResolvedTime = '{DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss")}', TimeToResolution = '{timeToCompletion}'," +
                    $" Severity = '{severityComboBox.SelectedItem.ToString()}', CurrentStatus = '{status}', Notes = '{notesTextBox.Text}' WHERE BugId = {bugId}");

                MessageBox.Show("The ticket has been updated.");
            }
            else
            {
                string FullName = AssignToComboBox.SelectedItem.ToString();
                string[] seperateName = FullName.Split(' ');

                int programmerId = Convert.ToInt32(database.getId($"SELECT programmerId FROM programmer WHERE FirstName = '{seperateName[0]}' AND LastName = '{seperateName[1]}'"));


                database.UpdateQuery($"UPDATE bug SET CurrentStatus = '{status}', Severity = '{severityComboBox.SelectedItem.ToString()}'," +
                    $"Notes = '{notesTextBox.Text}', ProgrammerId = '{programmerId}' WHERE BugId = {bugId}");               

                MessageBox.Show("The ticket has been updated.");
               
            }

            this.Close();
            ReportForm_Programmer_Admin reportForm_Programmer_Admin = new ReportForm_Programmer_Admin();
            reportForm_Programmer_Admin.Show();
        }

        int devId;
        string devName;
        private void ReportIssueForm_Dev_Admin_Load(object sender, EventArgs e)
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
                                  programmerId = bug.ProgrammerId,
                                  notes = bug.Notes,
                                  reportedDate = bug.ReportedTime,
                              };

            foreach (var issue in SelectedBug)
            {
                if (string.IsNullOrEmpty(issue.notes))
                {
                    notesTextBox.Text = "";
                }
                else
                {
                    notesTextBox.Text = issue.notes;
                }
                softwareNameTextBox.Text = issue.softwareName;
                softwareVersionTextBox.Text = issue.softwareVersion;
                severityComboBox.SelectedItem = issue.severity;
                currentStatusComboBox.SelectedItem = issue.status;
                bugIssueTextBox.Text = issue.bugissue;
                replicateBugStepsTextBox.Text = issue.replicatedStep;
                devId = issue.programmerId;
                reportedTime = issue.reportedDate;
            }

            

            var FullNameList = database.populateFullNameList($"SELECT FirstName, LastName FROM programmer");

            foreach (var item in FullNameList)
            {
                devName = $"{item.FirstName} {item.LastName}";

                AssignToComboBox.Items.Add(devName);
            }

            /*var AssignedDeveloper = from devloper in bugtrackingdatabaseDataSet.programmer
                                    where devloper.ProgrammerId == devId
                                    select new
                                    {
                                        FirstName = devloper.FirstName,
                                        LastName = devloper.LastName
                                    };
            */

            var AssignedDeveloper = database.populateFullNameList($"SELECT FirstName, LastName FROM programmer WHERE programmerId = {devId}");

            foreach (var item in AssignedDeveloper)
            {
                devName = $"{item.FirstName} {item.LastName}";
                AssignToComboBox.SelectedItem = devName;
            }

        }
    }
}
