namespace BugTracker.Views
{
    partial class ReportIssueForm_Dev
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
            System.Windows.Forms.Label softwareNameLabel;
            System.Windows.Forms.Label softwareVersionLabel;
            System.Windows.Forms.Label severityLabel;
            System.Windows.Forms.Label currentStatusLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label replicatBugStepsLabel;
            System.Windows.Forms.Label bugIssueLabel;
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.softwareNameTextBox = new System.Windows.Forms.TextBox();
            this.bugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugtrackingdatabaseDataSet = new BugTracker.bugtrackingdatabaseDataSet();
            this.softwareVersionTextBox = new System.Windows.Forms.TextBox();
            this.currentStatusComboBox = new System.Windows.Forms.ComboBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.bugIssueTextBox = new System.Windows.Forms.TextBox();
            this.bugTableAdapter = new BugTracker.bugtrackingdatabaseDataSetTableAdapters.bugTableAdapter();
            this.tableAdapterManager = new BugTracker.bugtrackingdatabaseDataSetTableAdapters.TableAdapterManager();
            this.replicateBugStepsTextBox = new System.Windows.Forms.TextBox();
            this.severityTextBox = new System.Windows.Forms.TextBox();
            softwareNameLabel = new System.Windows.Forms.Label();
            softwareVersionLabel = new System.Windows.Forms.Label();
            severityLabel = new System.Windows.Forms.Label();
            currentStatusLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            replicatBugStepsLabel = new System.Windows.Forms.Label();
            bugIssueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bugBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugtrackingdatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // softwareNameLabel
            // 
            softwareNameLabel.AutoSize = true;
            softwareNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            softwareNameLabel.Location = new System.Drawing.Point(52, 37);
            softwareNameLabel.Name = "softwareNameLabel";
            softwareNameLabel.Size = new System.Drawing.Size(123, 20);
            softwareNameLabel.TabIndex = 0;
            softwareNameLabel.Text = "Software Name:";
            // 
            // softwareVersionLabel
            // 
            softwareVersionLabel.AutoSize = true;
            softwareVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            softwareVersionLabel.Location = new System.Drawing.Point(40, 82);
            softwareVersionLabel.Name = "softwareVersionLabel";
            softwareVersionLabel.Size = new System.Drawing.Size(135, 20);
            softwareVersionLabel.TabIndex = 2;
            softwareVersionLabel.Text = "Software Version:";
            // 
            // severityLabel
            // 
            severityLabel.AutoSize = true;
            severityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            severityLabel.Location = new System.Drawing.Point(467, 37);
            severityLabel.Name = "severityLabel";
            severityLabel.Size = new System.Drawing.Size(69, 20);
            severityLabel.TabIndex = 4;
            severityLabel.Text = "Severity:";
            // 
            // currentStatusLabel
            // 
            currentStatusLabel.AutoSize = true;
            currentStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            currentStatusLabel.Location = new System.Drawing.Point(419, 85);
            currentStatusLabel.Name = "currentStatusLabel";
            currentStatusLabel.Size = new System.Drawing.Size(117, 20);
            currentStatusLabel.TabIndex = 6;
            currentStatusLabel.Text = "Current Status:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notesLabel.Location = new System.Drawing.Point(53, 459);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(55, 20);
            notesLabel.TabIndex = 13;
            notesLabel.Text = "Notes:";
            // 
            // replicatBugStepsLabel
            // 
            replicatBugStepsLabel.AutoSize = true;
            replicatBugStepsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            replicatBugStepsLabel.Location = new System.Drawing.Point(53, 296);
            replicatBugStepsLabel.Name = "replicatBugStepsLabel";
            replicatBugStepsLabel.Size = new System.Drawing.Size(159, 20);
            replicatBugStepsLabel.TabIndex = 15;
            replicatBugStepsLabel.Text = "Replicate Bug Steps:";
            // 
            // bugIssueLabel
            // 
            bugIssueLabel.AutoSize = true;
            bugIssueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bugIssueLabel.Location = new System.Drawing.Point(53, 135);
            bugIssueLabel.Name = "bugIssueLabel";
            bugIssueLabel.Size = new System.Drawing.Size(85, 20);
            bugIssueLabel.TabIndex = 17;
            bugIssueLabel.Text = "Bug Issue:";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(613, 633);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(72, 28);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(691, 633);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(72, 28);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // softwareNameTextBox
            // 
            this.softwareNameTextBox.Enabled = false;
            this.softwareNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.softwareNameTextBox.Location = new System.Drawing.Point(181, 34);
            this.softwareNameTextBox.Name = "softwareNameTextBox";
            this.softwareNameTextBox.Size = new System.Drawing.Size(253, 26);
            this.softwareNameTextBox.TabIndex = 1;
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
            // softwareVersionTextBox
            // 
            this.softwareVersionTextBox.Enabled = false;
            this.softwareVersionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.softwareVersionTextBox.Location = new System.Drawing.Point(181, 81);
            this.softwareVersionTextBox.Name = "softwareVersionTextBox";
            this.softwareVersionTextBox.Size = new System.Drawing.Size(208, 26);
            this.softwareVersionTextBox.TabIndex = 3;
            // 
            // currentStatusComboBox
            // 
            this.currentStatusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentStatusComboBox.FormattingEnabled = true;
            this.currentStatusComboBox.Items.AddRange(new object[] {
            "Pending",
            "In-Progress",
            "Completed"});
            this.currentStatusComboBox.Location = new System.Drawing.Point(542, 81);
            this.currentStatusComboBox.Name = "currentStatusComboBox";
            this.currentStatusComboBox.Size = new System.Drawing.Size(192, 28);
            this.currentStatusComboBox.TabIndex = 7;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTextBox.Location = new System.Drawing.Point(56, 482);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notesTextBox.Size = new System.Drawing.Size(677, 126);
            this.notesTextBox.TabIndex = 10;
            // 
            // bugIssueTextBox
            // 
            this.bugIssueTextBox.Enabled = false;
            this.bugIssueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bugIssueTextBox.Location = new System.Drawing.Point(56, 158);
            this.bugIssueTextBox.Multiline = true;
            this.bugIssueTextBox.Name = "bugIssueTextBox";
            this.bugIssueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bugIssueTextBox.Size = new System.Drawing.Size(677, 123);
            this.bugIssueTextBox.TabIndex = 8;
            // 
            // bugTableAdapter
            // 
            this.bugTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bugTableAdapter = this.bugTableAdapter;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.programmerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BugTracker.bugtrackingdatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // replicateBugStepsTextBox
            // 
            this.replicateBugStepsTextBox.Enabled = false;
            this.replicateBugStepsTextBox.Location = new System.Drawing.Point(57, 319);
            this.replicateBugStepsTextBox.Multiline = true;
            this.replicateBugStepsTextBox.Name = "replicateBugStepsTextBox";
            this.replicateBugStepsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.replicateBugStepsTextBox.Size = new System.Drawing.Size(676, 127);
            this.replicateBugStepsTextBox.TabIndex = 9;
            // 
            // severityTextBox
            // 
            this.severityTextBox.Enabled = false;
            this.severityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.severityTextBox.Location = new System.Drawing.Point(542, 37);
            this.severityTextBox.Name = "severityTextBox";
            this.severityTextBox.Size = new System.Drawing.Size(143, 26);
            this.severityTextBox.TabIndex = 5;
            // 
            // ReportIssueForm_Dev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 681);
            this.Controls.Add(this.severityTextBox);
            this.Controls.Add(this.replicateBugStepsTextBox);
            this.Controls.Add(bugIssueLabel);
            this.Controls.Add(this.bugIssueTextBox);
            this.Controls.Add(replicatBugStepsLabel);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(currentStatusLabel);
            this.Controls.Add(this.currentStatusComboBox);
            this.Controls.Add(severityLabel);
            this.Controls.Add(softwareVersionLabel);
            this.Controls.Add(this.softwareVersionTextBox);
            this.Controls.Add(softwareNameLabel);
            this.Controls.Add(this.softwareNameTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Name = "ReportIssueForm_Dev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportIssueForm_Dev";
            this.Load += new System.EventHandler(this.ReportIssueForm_Dev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bugBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugtrackingdatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private bugtrackingdatabaseDataSet bugtrackingdatabaseDataSet;
        private System.Windows.Forms.BindingSource bugBindingSource;
        private bugtrackingdatabaseDataSetTableAdapters.bugTableAdapter bugTableAdapter;
        private bugtrackingdatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox softwareNameTextBox;
        private System.Windows.Forms.TextBox softwareVersionTextBox;
        private System.Windows.Forms.ComboBox currentStatusComboBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.TextBox bugIssueTextBox;
        private System.Windows.Forms.TextBox replicateBugStepsTextBox;
        private System.Windows.Forms.TextBox severityTextBox;
    }
}