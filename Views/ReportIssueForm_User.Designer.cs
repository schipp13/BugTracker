namespace BugTracker.Views
{
    partial class ReportIssueForm_User
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
            System.Windows.Forms.Label bugIssueLabel;
            System.Windows.Forms.Label replicateBugStepsLabel;
            this.usernameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.replicateBugStepsTextBox = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.bugIssueTextBox = new System.Windows.Forms.TextBox();
            this.softwareVersionTextBox = new System.Windows.Forms.TextBox();
            this.softwareNameTextBox = new System.Windows.Forms.TextBox();
            this.bugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugtrackingdatabaseDataSet = new BugTracker.bugtrackingdatabaseDataSet();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.bugTableAdapter = new BugTracker.bugtrackingdatabaseDataSetTableAdapters.bugTableAdapter();
            this.tableAdapterManager = new BugTracker.bugtrackingdatabaseDataSetTableAdapters.TableAdapterManager();
            softwareNameLabel = new System.Windows.Forms.Label();
            softwareVersionLabel = new System.Windows.Forms.Label();
            bugIssueLabel = new System.Windows.Forms.Label();
            replicateBugStepsLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bugBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugtrackingdatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // softwareNameLabel
            // 
            softwareNameLabel.AutoSize = true;
            softwareNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            softwareNameLabel.Location = new System.Drawing.Point(43, 31);
            softwareNameLabel.Name = "softwareNameLabel";
            softwareNameLabel.Size = new System.Drawing.Size(123, 20);
            softwareNameLabel.TabIndex = 0;
            softwareNameLabel.Text = "Software Name:";
            // 
            // softwareVersionLabel
            // 
            softwareVersionLabel.AutoSize = true;
            softwareVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            softwareVersionLabel.Location = new System.Drawing.Point(31, 67);
            softwareVersionLabel.Name = "softwareVersionLabel";
            softwareVersionLabel.Size = new System.Drawing.Size(135, 20);
            softwareVersionLabel.TabIndex = 2;
            softwareVersionLabel.Text = "Software Version:";
            // 
            // bugIssueLabel
            // 
            bugIssueLabel.AutoSize = true;
            bugIssueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bugIssueLabel.Location = new System.Drawing.Point(31, 108);
            bugIssueLabel.Name = "bugIssueLabel";
            bugIssueLabel.Size = new System.Drawing.Size(85, 20);
            bugIssueLabel.TabIndex = 4;
            bugIssueLabel.Text = "Bug Issue:";
            // 
            // replicateBugStepsLabel
            // 
            replicateBugStepsLabel.AutoSize = true;
            replicateBugStepsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            replicateBugStepsLabel.Location = new System.Drawing.Point(31, 271);
            replicateBugStepsLabel.Name = "replicateBugStepsLabel";
            replicateBugStepsLabel.Size = new System.Drawing.Size(159, 20);
            replicateBugStepsLabel.TabIndex = 6;
            replicateBugStepsLabel.Text = "Replicate Bug Steps:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(31, 21);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(165, 25);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Hello Username";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(replicateBugStepsLabel);
            this.panel1.Controls.Add(this.replicateBugStepsTextBox);
            this.panel1.Controls.Add(this.EnterButton);
            this.panel1.Controls.Add(bugIssueLabel);
            this.panel1.Controls.Add(this.bugIssueTextBox);
            this.panel1.Controls.Add(softwareVersionLabel);
            this.panel1.Controls.Add(this.softwareVersionTextBox);
            this.panel1.Controls.Add(softwareNameLabel);
            this.panel1.Controls.Add(this.softwareNameTextBox);
            this.panel1.Location = new System.Drawing.Point(36, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 476);
            this.panel1.TabIndex = 1;
            // 
            // replicateBugStepsTextBox
            // 
            this.replicateBugStepsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replicateBugStepsTextBox.Location = new System.Drawing.Point(35, 294);
            this.replicateBugStepsTextBox.Multiline = true;
            this.replicateBugStepsTextBox.Name = "replicateBugStepsTextBox";
            this.replicateBugStepsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.replicateBugStepsTextBox.Size = new System.Drawing.Size(570, 116);
            this.replicateBugStepsTextBox.TabIndex = 7;
            // 
            // EnterButton
            // 
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterButton.Location = new System.Drawing.Point(560, 428);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(85, 28);
            this.EnterButton.TabIndex = 8;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // bugIssueTextBox
            // 
            this.bugIssueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bugIssueTextBox.Location = new System.Drawing.Point(35, 131);
            this.bugIssueTextBox.Multiline = true;
            this.bugIssueTextBox.Name = "bugIssueTextBox";
            this.bugIssueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bugIssueTextBox.Size = new System.Drawing.Size(570, 113);
            this.bugIssueTextBox.TabIndex = 5;
            // 
            // softwareVersionTextBox
            // 
            this.softwareVersionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.softwareVersionTextBox.Location = new System.Drawing.Point(172, 64);
            this.softwareVersionTextBox.Name = "softwareVersionTextBox";
            this.softwareVersionTextBox.Size = new System.Drawing.Size(227, 26);
            this.softwareVersionTextBox.TabIndex = 3;
            // 
            // softwareNameTextBox
            // 
            this.softwareNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.softwareNameTextBox.Location = new System.Drawing.Point(172, 28);
            this.softwareNameTextBox.Name = "softwareNameTextBox";
            this.softwareNameTextBox.Size = new System.Drawing.Size(293, 26);
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
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(635, 12);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 0;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
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
            // ReportIssueForm_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 531);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.usernameLabel);
            this.Name = "ReportIssueForm_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportIssueForm_User";
            this.Load += new System.EventHandler(this.ReportIssueForm_User_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bugBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugtrackingdatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button EnterButton;
        private bugtrackingdatabaseDataSet bugtrackingdatabaseDataSet;
        private System.Windows.Forms.BindingSource bugBindingSource;
        private bugtrackingdatabaseDataSetTableAdapters.bugTableAdapter bugTableAdapter;
        private bugtrackingdatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox bugIssueTextBox;
        private System.Windows.Forms.TextBox softwareVersionTextBox;
        private System.Windows.Forms.TextBox softwareNameTextBox;
        private System.Windows.Forms.TextBox replicateBugStepsTextBox;
    }
}