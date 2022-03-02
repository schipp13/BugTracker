
namespace BugTracker.Views
{
    partial class DevLoginForm
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
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label passwordLabel;
            this.bugtrackingdatabaseDataSet = new BugTracker.bugtrackingdatabaseDataSet();
            this.programmerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programmerTableAdapter = new BugTracker.bugtrackingdatabaseDataSetTableAdapters.programmerTableAdapter();
            this.tableAdapterManager = new BugTracker.bugtrackingdatabaseDataSetTableAdapters.TableAdapterManager();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            userNameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bugtrackingdatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userNameLabel.Location = new System.Drawing.Point(70, 47);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(93, 20);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "User Name:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.Location = new System.Drawing.Point(77, 92);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(82, 20);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password:";
            // 
            // bugtrackingdatabaseDataSet
            // 
            this.bugtrackingdatabaseDataSet.DataSetName = "bugtrackingdatabaseDataSet";
            this.bugtrackingdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // programmerBindingSource
            // 
            this.programmerBindingSource.DataMember = "programmer";
            this.programmerBindingSource.DataSource = this.bugtrackingdatabaseDataSet;
            // 
            // programmerTableAdapter
            // 
            this.programmerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bugTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.programmerTableAdapter = this.programmerTableAdapter;
            this.tableAdapterManager.UpdateOrder = BugTracker.bugtrackingdatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(169, 41);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(222, 26);
            this.userNameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(169, 89);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(222, 26);
            this.passwordTextBox.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(313, 134);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(78, 31);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(128, 134);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(86, 33);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // DevLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 202);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Name = "DevLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DevLoginForm";
            this.Load += new System.EventHandler(this.DevLoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bugtrackingdatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bugtrackingdatabaseDataSet bugtrackingdatabaseDataSet;
        private System.Windows.Forms.BindingSource programmerBindingSource;
        private bugtrackingdatabaseDataSetTableAdapters.programmerTableAdapter programmerTableAdapter;
        private bugtrackingdatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button LoginButton;
    }
}