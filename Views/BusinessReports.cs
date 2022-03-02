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
    public partial class BusinessReports : Form
    {

        Database database = new Database();
        public BusinessReports()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportForm_Programmer_Admin reportForm_Programmer_Admin = new ReportForm_Programmer_Admin();
            reportForm_Programmer_Admin.Show();
        }

        private void bugBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bugBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bugtrackingdatabaseDataSet);

        }

        private void BusinessReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bugtrackingdatabaseDataSet.programmer' table. You can move, or remove it, as needed.
            this.programmerTableAdapter.Fill(this.bugtrackingdatabaseDataSet.programmer);

            // TODO: This line of code loads data into the 'bugtrackingdatabaseDataSet.bug' table. You can move, or remove it, as needed.
            this.bugTableAdapter.Fill(this.bugtrackingdatabaseDataSet.bug);

        }

        private void reportsPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string reportName = reportsPanel.SelectedTab.Text;
            switch(reportName)
            {
               
                case "Number of Tickets":
                    var NumberOfTickets = bugtrackingdatabaseDataSet.bug
                                           .Join(bugtrackingdatabaseDataSet.programmer, b => b.ProgrammerId, p => p.ProgrammerId, (b,p) => new
                                           {
                                                p.FirstName,
                                                p.LastName,
                                                b.BugId
                                           })
                                           .GroupBy(p => new
                                           {
                                               p.FirstName,
                                               p.LastName
                                           })
                                           .Select(t => new
                                           {
                                               firstName = t.Key.FirstName,
                                               LastName = t.Key.LastName,
                                               bugCounter = t.Count()
                                           });
                  
                    programmerDataGridView.DataSource = NumberOfTickets.ToArray();
                    
                    break;

                case "Time to Resolution":                    
                    var TimeToResolution = from bug in bugtrackingdatabaseDataSet.bug
                                           orderby bug.SoftwareName
                                           select new
                                           {
                                               bugId = bug.BugId,
                                               softwareName = bug.SoftwareName,
                                               severity = bug.Severity,
                                               reportedTime = bug.ReportedTime,
                                               resolvedTime = bug.ResolvedTime,
                                               timetoresolution = bug.TimeToResolution,                                               
                                         };

                    bugDataGridView.DataSource = TimeToResolution.ToArray();
                   
                    break;

                case "Issues Per Software":             
                var NumberOfIssues = bugtrackingdatabaseDataSet.bug
                                     .GroupBy(p => new
                                    {
                                        SoftwareName = p.SoftwareName,
                                        SoftwareVersion = p.SoftwareVersion,

                                    })
                                    .Select( issue => new
                                    {
                                        issueCounter = issue.Count(),
                                        softwareName = issue.Key.SoftwareName,
                                        softwareVersion = issue.Key.SoftwareVersion,
                                        
                                    });

                    bugDataGridView1.DataSource = NumberOfIssues.ToArray();

                    break;
            }
        }
    }
}
