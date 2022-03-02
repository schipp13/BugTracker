
namespace BugTracker.Views
{
    partial class ReportIssueForm_Dev_Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label currentStatusLabel;
            System.Windows.Forms.Label severityLabel1;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label replicatBugStepsLabel;
            System.Windows.Forms.Label softwareVersionLabel;
            System.Windows.Forms.Label softwareNameLabel;
            System.Windows.Forms.Label bugIssueLabel;
            this.bugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugtrackingdatabaseDataSet = new BugTracker.bugtrackingdatabaseDataSet();
            this.tableAdapterManager = new BugTracker.bugtrackingdatabaseDataSetTableAdapters.TableAdapterManager();
            this.bugTableAdapter = new BugTracker.bugtrackingdatabaseDataSetTableAdapters.bugTableAdapter();
            this.currentStatusComboBox = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.severityComboBox = new System.Windows.Forms.ComboBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.replicateBugStepsTextBox = new System.Windows.Forms.TextBox();
            this.softwareVersionTextBox = new System.Windows.Forms.TextBox();
            this.softwareNameTextBox = new System.Windows.Forms.TextBox();
            this.bugIssueTextBox = new System.Windows.Forms.TextBox();
            this.AssignToLabel = new System.Windows.Forms.Label();
            this.AssignToComboBox = new System.Windows.Forms.ComboBox();
            currentStatusLabel = new System.Windows.Forms.Label();
            severityLabel1 = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            replicatBugStepsLabel = new System.Windows.Forms.Label();
            softwareVersionLabel = new System.Windows.Forms.Label();
            softwareNameLabel = new System.Windows.Forms.Label();
            bugIssueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bugBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugtrackingdatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // currentStatusLabel
            // 
            currentStatusLabel.AutoSize = true;
            currentStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            currentStatusLabel.Location = new System.Drawing.Point(409, 78);
            currentStatusLabel.Name = "currentStatusLabel";
            currentStatusLabel.Size = new System.Drawing.Size(117, 20);
            currentStatusLabel.TabIndex = 6;
            currentStatusLabel.Text = "Current Status:";
            // 
            // severityLabel1
            // 
            severityLabel1.AutoSize = true;
            severityLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            severityLabel1.Location = new System.Drawing.Point(457, 33);
            severityLabel1.Name = "severityLabel1";
            severityLabel1.Size = new System.Drawing.Size(69, 20);
            severityLabel1.TabIndex = 4;
            severityLabel1.Text = "Severity:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notesLabel.Location = new System.Drawing.Point(43, 431);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(55, 20);
            notesLabel.TabIndex = 14;
            notesLabel.Text = "Notes:";
            // 
            // replicatBugStepsLabel
            // 
            replicatBugStepsLabel.AutoSize = true;
            replicatBugStepsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            replicatBugStepsLabel.Location = new System.Drawing.Point(43, 304);
            replicatBugStepsLabel.Name = "replicatBugStepsLabel";
            replicatBugStepsLabel.Size = new System.Drawing.Size(159, 20);
            replicatBugStepsLabel.TabIndex = 12;
            replicatBugStepsLabel.Text = "Replicate Bug Steps:";
            // 
            // softwareVersionLabel
            // 
            softwareVersionLabel.AutoSize = true;
            softwareVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            softwareVersionLabel.Location = new System.Drawing.Point(30, 75);
            softwareVersionLabel.Name = "softwareVersionLabel";
            softwareVersionLabel.Size = new System.Drawing.Size(135, 20);
            softwareVersionLabel.TabIndex = 2;
            softwareVersionLabel.Text = "Software Version:";
            // 
            // softwareNameLabel
            // 
            softwareNameLabel.AutoSize = true;
            softwareNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            softwareNameLabel.Location = new System.Drawing.Point(42, 30);
            softwareNameLabel.Name = "softwareNameLabel";
            softwareNameLabel.Size = new System.Drawing.Size(123, 20);
            softwareNameLabel.TabIndex = 0;
            softwareNameLabel.Text = "Software Name:";
            // 
            // bugIssueLabel
            // 
            bugIssueLabel.AutoSize = true;
            bugIssueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bugIssueLabel.Location = new System.Drawing.Point(43, 155);
            bugIssueLabel.Name = "bugIssueLabel";
            bugIssueLabel.Size = new System.Drawing.Size(85, 20);
            bugIssueLabel.TabIndex = 10;
            bugIssueLabel.Text = "Bug Issue:";
            // 
            // bugBindingSource
            // 
            this.bugBindingSource.DataMember = "bug";
            this.bugBindingSource.DataSource = this.bugtrackingdatabaseDataSet;
            // 
            // bugtrackingdatabaseDataSet
            // 
            this.bugtrackingdatabaseDataSet.DataSetName = "bugtrackingdatabaseDataSet";
            this.bugtrackingdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bugTableAdapter = this.bugTableAdapter;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.programmerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BugTracker.bugtrackingdatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bugTableAdapter
            // 
            this.bugTableAdapter.ClearBeforeFill = true;
            // 
            // currentStatusComboBox
            // 
            this.currentStatusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentStatusComboBox.FormattingEnabled = true;
            this.currentStatusComboBox.Items.AddRange(new object[] {
            "Pending",
            "In-Progress",
            "Completed"});
            this.currentStatusComboBox.Location = new System.Drawing.Point(532, 74);
            this.currentStatusComboBox.Name = "currentStatusComboBox";
            this.currentStatusComboBox.Size = new System.Drawing.Size(192, 28);
            this.currentStatusComboBox.TabIndex = 7;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(681, 626);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(72, 28);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(603, 626);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(72, 28);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // severityComboBox
            // 
            this.severityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.severityComboBox.FormattingEnabled = true;
            this.severityComboBox.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.severityComboBox.Location = new System.Drawing.Point(532, 30);
            this.severityComboBox.Name = "severityComboBox";
            this.severityComboBox.Size = new System.Drawing.Size(191, 28);
            this.severityComboBox.TabIndex = 5;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTextBox.Location = new System.Drawing.Point(46, 454);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notesTextBox.Size = new System.Drawing.Size(677, 124);
            this.notesTextBox.TabIndex = 15;
            // 
            // replicateBugStepsTextBox
            // 
            this.replicateBugStepsTextBox.Enabled = false;
            this.replicateBugStepsTextBox.Location = new System.Drawing.Point(46, 327);
            this.replicateBugStepsTextBox.Multiline = true;
            this.replicateBugStepsTextBox.Name = "replicateBugStepsTextBox";
            this.replicateBugStepsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.replicateBugStepsTextBox.Size = new System.Drawing.Size(676, 101);
            this.replicateBugStepsTextBox.TabIndex = 13;
            // 
            // softwareVersionTextBox
            // 
            this.softwareVersionTextBox.Enabled = false;
            this.softwareVersionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.softwareVersionTextBox.Location = new System.Drawing.Point(171, 74);
            this.softwareVersionTextBox.Name = "softwareVersionTextBox";
            this.softwareVersionTextBox.Size = new System.Drawing.Size(208, 26);
            this.softwareVersionTextBox.TabIndex = 3;
            // 
            // softwareNameTextBox
            // 
            this.softwareNameTextBox.Enabled = false;
            this.softwareNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.softwareNameTextBox.Location = new System.Drawing.Point(171, 27);
            this.softwareNameTextBox.Name = "softwareNameTextBox";
            this.softwareNameTextBox.Size = new System.Drawing.Size(253, 26);
            this.softwareNameTextBox.TabIndex = 1;
            // 
            // bugIssueTextBox
            // 
            this.bugIssueTextBox.Enabled = false;
            this.bugIssueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bugIssueTextBox.Location = new System.Drawing.Point(46, 178);
            this.bugIssueTextBox.Multiline = true;
            this.bugIssueTextBox.Name = "bugIssueTextBox";
            this.bugIssueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bugIssueTextBox.Size = new System.Drawing.Size(677, 123);
            this.bugIssueTextBox.TabIndex = 11;
            // 
            // AssignToLabel
            // 
            this.AssignToLabel.AutoSize = true;
            this.AssignToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignToLabel.Location = new System.Drawing.Point(34, 122);
            this.AssignToLabel.Name = "AssignToLabel";
            this.AssignToLabel.Size = new System.Drawing.Size(87, 20);
            this.AssignToLabel.TabIndex = 8;
            this.AssignToLabel.Text = "Assign To: ";
            // 
            // AssignToComboBox
            // 
            this.AssignToComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignToComboBox.FormattingEnabled = true;
            this.AssignToComboBox.Location = new System.Drawing.Point(127, 114);
            this.AssignToComboBox.Name = "AssignToComboBox";
            this.AssignToComboBox.Size = new System.Drawing.Size(252, 28);
            this.AssignToComboBox.TabIndex = 9;
            // 
            // ReportIssueForm_Dev_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 681);
            this.Controls.Add(this.AssignToComboBox);
            this.Controls.Add(this.AssignToLabel);
            this.Controls.Add(severityLabel1);
            this.Controls.Add(this.severityComboBox);
            this.Controls.Add(bugIssueLabel);
            this.Controls.Add(replicatBugStepsLabel);
            this.Controls.Add(notesLabel);
            this.Controls.Add(currentStatusLabel);
            this.Controls.Add(softwareVersionLabel);
            this.Controls.Add(this.replicateBugStepsTextBox);
            this.Controls.Add(this.bugIssueTextBox);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.currentStatusComboBox);
            this.Controls.Add(this.softwareVersionTextBox);
            this.Controls.Add(softwareNameLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.softwareNameTextBox);
            this.Name = "ReportIssueForm_Dev_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportIssueForm_Dev_Admin";
            this.Load += new System.EventHandler(this.ReportIssueForm_Dev_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bugBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugtrackingdatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bugBindingSource;
        private bugtrackingdatabaseDataSet bugtrackingdatabaseDataSet;
        private bugtrackingdatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private bugtrackingdatabaseDataSetTableAdapters.bugTableAdapter bugTableAdapter;
        private System.Windows.Forms.ComboBox currentStatusComboBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox severityComboBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.TextBox replicateBugStepsTextBox;
        private System.Windows.Forms.TextBox softwareVersionTextBox;
        private System.Windows.Forms.TextBox softwareNameTextBox;
        private System.Windows.Forms.TextBox bugIssueTextBox;
        private System.Windows.Forms.Label AssignToLabel;
        private System.Windows.Forms.ComboBox AssignToComboBox;
    }
}