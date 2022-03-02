namespace BugTracker.Views
{
    partial class NewUserForm
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label passwordLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CreateUserButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugtrackingdatabaseDataSet = new BugTracker.bugtrackingdatabaseDataSet();
            this.clientTableAdapter = new BugTracker.bugtrackingdatabaseDataSetTableAdapters.clientTableAdapter();
            this.tableAdapterManager = new BugTracker.bugtrackingdatabaseDataSetTableAdapters.TableAdapterManager();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugtrackingdatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(34, 26);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(90, 20);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(34, 68);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(90, 20);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(34, 152);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.Location = new System.Drawing.Point(34, 110);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(59, 20);
            phoneLabel.TabIndex = 4;
            phoneLabel.Text = "Phone:";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userNameLabel.Location = new System.Drawing.Point(34, 194);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(93, 20);
            userNameLabel.TabIndex = 8;
            userNameLabel.Text = "User Name:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.Location = new System.Drawing.Point(34, 236);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(82, 20);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create an account";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.CreateUserButton);
            this.panel1.Controls.Add(passwordLabel);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(userNameLabel);
            this.panel1.Controls.Add(this.userNameTextBox);
            this.panel1.Controls.Add(phoneLabel);
            this.panel1.Controls.Add(this.phoneTextBox);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(lastNameLabel);
            this.panel1.Controls.Add(this.lastNameTextBox);
            this.panel1.Controls.Add(firstNameLabel);
            this.panel1.Controls.Add(this.firstNameTextBox);
            this.panel1.Location = new System.Drawing.Point(17, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 325);
            this.panel1.TabIndex = 0;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(407, 288);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(82, 34);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CreateUserButton
            // 
            this.CreateUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateUserButton.Location = new System.Drawing.Point(315, 288);
            this.CreateUserButton.Name = "CreateUserButton";
            this.CreateUserButton.Size = new System.Drawing.Size(86, 34);
            this.CreateUserButton.TabIndex = 12;
            this.CreateUserButton.Text = "Create";
            this.CreateUserButton.UseVisualStyleBackColor = true;
            this.CreateUserButton.Click += new System.EventHandler(this.CreateUserButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(130, 230);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(260, 26);
            this.passwordTextBox.TabIndex = 11;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(130, 188);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(260, 26);
            this.userNameTextBox.TabIndex = 9;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(130, 104);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(260, 26);
            this.phoneTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(130, 146);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(303, 26);
            this.emailTextBox.TabIndex = 7;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(130, 62);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(260, 26);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(130, 20);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(260, 26);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.bugtrackingdatabaseDataSet;
            // 
            // bugtrackingdatabaseDataSet
            // 
            this.bugtrackingdatabaseDataSet.DataSetName = "bugtrackingdatabaseDataSet";
            this.bugtrackingdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 383);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewUserForm";
            this.Load += new System.EventHandler(this.NewUserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugtrackingdatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button CreateUserButton;
        private bugtrackingdatabaseDataSet bugtrackingdatabaseDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private bugtrackingdatabaseDataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private bugtrackingdatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
    }
}