namespace BugTracker.Views
{
    partial class ReportForm_Programmer_Admin
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.NewProgrammerButton = new System.Windows.Forms.Button();
            this.EditProgrammerButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.DeleteIssueButton = new System.Windows.Forms.Button();
            this.EditIssueButton = new System.Windows.Forms.Button();
            this.bugtrackingdatabaseDataSet = new BugTracker.bugtrackingdatabaseDataSet();
            this.bugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugTableAdapter = new BugTracker.bugtrackingdatabaseDataSetTableAdapters.bugTableAdapter();
            this.tableAdapterManager = new BugTracker.bugtrackingdatabaseDataSetTableAdapters.TableAdapterManager();
            this.bugDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bugtrackingdatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(12, 12);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(311, 26);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.Text = "Enter bug id";
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(329, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 26);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // NewProgrammerButton
            // 
            this.NewProgrammerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewProgrammerButton.Location = new System.Drawing.Point(494, 6);
            this.NewProgrammerButton.Name = "NewProgrammerButton";
            this.NewProgrammerButton.Size = new System.Drawing.Size(149, 34);
            this.NewProgrammerButton.TabIndex = 3;
            this.NewProgrammerButton.Text = "New Programmer";
            this.NewProgrammerButton.UseVisualStyleBackColor = true;
            this.NewProgrammerButton.Click += new System.EventHandler(this.NewProgrammerButton_Click);
            // 
            // EditProgrammerButton
            // 
            this.EditProgrammerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditProgrammerButton.Location = new System.Drawing.Point(649, 6);
            this.EditProgrammerButton.Name = "EditProgrammerButton";
            this.EditProgrammerButton.Size = new System.Drawing.Size(149, 34);
            this.EditProgrammerButton.TabIndex = 4;
            this.EditProgrammerButton.Text = "Edit Programmer";
            this.EditProgrammerButton.UseVisualStyleBackColor = true;
            this.EditProgrammerButton.Click += new System.EventHandler(this.EditProgrammerButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportButton.Location = new System.Drawing.Point(887, 12);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(75, 26);
            this.ReportButton.TabIndex = 7;
            this.ReportButton.Text = "Report";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.Location = new System.Drawing.Point(1050, 6);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(85, 32);
            this.LogoutButton.TabIndex = 8;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // DeleteIssueButton
            // 
            this.DeleteIssueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteIssueButton.Location = new System.Drawing.Point(1026, 492);
            this.DeleteIssueButton.Name = "DeleteIssueButton";
            this.DeleteIssueButton.Size = new System.Drawing.Size(109, 29);
            this.DeleteIssueButton.TabIndex = 6;
            this.DeleteIssueButton.Text = "Delete Issue";
            this.DeleteIssueButton.UseVisualStyleBackColor = true;
            this.DeleteIssueButton.Click += new System.EventHandler(this.DeleteIssueButton_Click);
            // 
            // EditIssueButton
            // 
            this.EditIssueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditIssueButton.Location = new System.Drawing.Point(911, 492);
            this.EditIssueButton.Name = "EditIssueButton";
            this.EditIssueButton.Size = new System.Drawing.Size(109, 29);
            this.EditIssueButton.TabIndex = 5;
            this.EditIssueButton.Text = "Edit Issue";
            this.EditIssueButton.UseVisualStyleBackColor = true;
            this.EditIssueButton.Click += new System.EventHandler(this.EditIssueButton_Click);
            // 
            // bugtrackingdatabaseDataSet
            // 
            this.bugtrackingdatabaseDataSet.DataSetName = "bugtrackingdatabaseDataSet";
            this.bugtrackingdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bugBindingSource
            // 
            this.bugBindingSource.DataMember = "bug";
            this.bugBindingSource.DataSource = this.bugtrackingdatabaseDataSet;
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
            // bugDataGridView
            // 
            this.bugDataGridView.AllowUserToAddRows = false;
            this.bugDataGridView.AllowUserToDeleteRows = false;
            this.bugDataGridView.AllowUserToResizeColumns = false;
            this.bugDataGridView.AutoGenerateColumns = false;
            this.bugDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bugDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.bugDataGridView.DataSource = this.bugBindingSource;
            this.bugDataGridView.Location = new System.Drawing.Point(12, 44);
            this.bugDataGridView.Name = "bugDataGridView";
            this.bugDataGridView.ReadOnly = true;
            this.bugDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bugDataGridView.Size = new System.Drawing.Size(1123, 442);
            this.bugDataGridView.TabIndex = 2;
            this.bugDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.bugDataGridView_DataBindingComplete);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BugId";
            this.dataGridViewTextBoxColumn1.HeaderText = "BugId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BugIssue";
            this.dataGridViewTextBoxColumn2.HeaderText = "BugIssue";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CurrentStatus";
            this.dataGridViewTextBoxColumn3.HeaderText = "CurrentStatus";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Severity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Severity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ReportedTime";
            this.dataGridViewTextBoxColumn5.HeaderText = "ReportedTime";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ResolvedTime";
            this.dataGridViewTextBoxColumn6.HeaderText = "ResolvedTime";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "UserId";
            this.dataGridViewTextBoxColumn8.HeaderText = "UserId";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ProgrammerId";
            this.dataGridViewTextBoxColumn9.HeaderText = "ProgrammerId";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn10.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "SoftwareName";
            this.dataGridViewTextBoxColumn11.HeaderText = "SoftwareName";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "SoftwareVersion";
            this.dataGridViewTextBoxColumn12.HeaderText = "SoftwareVersion";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ReplicateBugSteps";
            this.dataGridViewTextBoxColumn13.HeaderText = "ReplicateBugSteps";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "TimeToResolution";
            this.dataGridViewTextBoxColumn14.HeaderText = "TimeToResolution";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // ReportForm_Programmer_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 541);
            this.Controls.Add(this.bugDataGridView);
            this.Controls.Add(this.EditIssueButton);
            this.Controls.Add(this.DeleteIssueButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.EditProgrammerButton);
            this.Controls.Add(this.NewProgrammerButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.searchTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReportForm_Programmer_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm_Programmer_Admin";
            this.Load += new System.EventHandler(this.ReportForm_Programmer_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bugtrackingdatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button NewProgrammerButton;
        private System.Windows.Forms.Button EditProgrammerButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button DeleteIssueButton;
        private System.Windows.Forms.Button EditIssueButton;
        private bugtrackingdatabaseDataSet bugtrackingdatabaseDataSet;
        private System.Windows.Forms.BindingSource bugBindingSource;
        private bugtrackingdatabaseDataSetTableAdapters.bugTableAdapter bugTableAdapter;
        private bugtrackingdatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView bugDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}