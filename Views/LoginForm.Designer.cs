namespace BugTracker
{
    partial class LoginForm
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.bugtrackingdatabaseDataSet = new BugTracker.bugtrackingdatabaseDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new BugTracker.bugtrackingdatabaseDataSetTableAdapters.clientTableAdapter();
            this.tableAdapterManager = new BugTracker.bugtrackingdatabaseDataSetTableAdapters.TableAdapterManager();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.DevLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bugtrackingdatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userNameLabel.Location = new System.Drawing.Point(64, 48);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(93, 20);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "User Name:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.Location = new System.Drawing.Point(75, 104);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(82, 20);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password:";
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(134, 161);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(86, 33);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(319, 161);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(78, 31);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.Location = new System.Drawing.Point(482, 9);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(45, 13);
            this.SignUpLabel.TabIndex = 7;
            this.SignUpLabel.Text = "Sign-Up";
            this.SignUpLabel.Click += new System.EventHandler(this.SignUpLabel_Click);
            // 
            // bugtrackingdatabaseDataSet
            // 
            this.bugtrackingdatabaseDataSet.DataSetName = "bugtrackingdatabaseDataSet";
            this.bugtrackingdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.bugtrackingdatabaseDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bugTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.programmerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BugTracker.bugtrackingdatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(163, 45);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(234, 26);
            this.userNameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(163, 101);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(234, 26);
            this.passwordTextBox.TabIndex = 3;
            // 
            // DevLabel
            // 
            this.DevLabel.AutoSize = true;
            this.DevLabel.Location = new System.Drawing.Point(12, 9);
            this.DevLabel.Name = "DevLabel";
            this.DevLabel.Size = new System.Drawing.Size(55, 13);
            this.DevLabel.TabIndex = 6;
            this.DevLabel.Text = "Dev_login";
            this.DevLabel.Click += new System.EventHandler(this.DevLabel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 236);
            this.Controls.Add(this.DevLabel);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.SignUpLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.LoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bugtrackingdatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label SignUpLabel;
        private bugtrackingdatabaseDataSet bugtrackingdatabaseDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private bugtrackingdatabaseDataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private bugtrackingdatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label DevLabel;
    }
}

