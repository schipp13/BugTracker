namespace BugTracker.Views
{
    partial class NewProgrammerForm
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
            System.Windows.Forms.Label permissionLevelLabel;
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CreateProgrammerButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.permissionLevelComboBox = new System.Windows.Forms.ComboBox();
            this.programmerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugtrackingdatabaseDataSet = new BugTracker.bugtrackingdatabaseDataSet();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.programmerTableAdapter = new BugTracker.bugtrackingdatabaseDataSetTableAdapters.programmerTableAdapter();
            this.tableAdapterManager = new BugTracker.bugtrackingdatabaseDataSetTableAdapters.TableAdapterManager();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            permissionLevelLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programmerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugtrackingdatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(35, 61);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(90, 20);
            firstNameLabel.TabIndex = 2;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(35, 112);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(90, 20);
            lastNameLabel.TabIndex = 4;
            lastNameLabel.Text = "Last Name:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(35, 214);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.Location = new System.Drawing.Point(35, 163);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(59, 20);
            phoneLabel.TabIndex = 6;
            phoneLabel.Text = "Phone:";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userNameLabel.Location = new System.Drawing.Point(35, 265);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(93, 20);
            userNameLabel.TabIndex = 10;
            userNameLabel.Text = "User Name:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.Location = new System.Drawing.Point(35, 316);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(82, 20);
            passwordLabel.TabIndex = 12;
            passwordLabel.Text = "Password:";
            // 
            // permissionLevelLabel
            // 
            permissionLevelLabel.AutoSize = true;
            permissionLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            permissionLevelLabel.Location = new System.Drawing.Point(35, 358);
            permissionLevelLabel.Name = "permissionLevelLabel";
            permissionLevelLabel.Size = new System.Drawing.Size(131, 20);
            permissionLevelLabel.TabIndex = 14;
            permissionLevelLabel.Text = "Permission Level:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(188, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Create an account";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.CreateProgrammerButton);
            this.panel1.Controls.Add(permissionLevelLabel);
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.permissionLevelComboBox);
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
            this.panel1.Size = new System.Drawing.Size(577, 433);
            this.panel1.TabIndex = 1;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(242, 6);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(250, 20);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.Text = "Enter a programmers first and last name";
            this.searchTextBox.Visible = false;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(498, 3);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Visible = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CreateProgrammerButton
            // 
            this.CreateProgrammerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateProgrammerButton.Location = new System.Drawing.Point(416, 396);
            this.CreateProgrammerButton.Name = "CreateProgrammerButton";
            this.CreateProgrammerButton.Size = new System.Drawing.Size(76, 28);
            this.CreateProgrammerButton.TabIndex = 16;
            this.CreateProgrammerButton.Text = "Create";
            this.CreateProgrammerButton.UseVisualStyleBackColor = true;
            this.CreateProgrammerButton.Click += new System.EventHandler(this.CreateProgrammerButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(498, 396);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(76, 28);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // permissionLevelComboBox
            // 
            this.permissionLevelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.programmerBindingSource, "PermissionLevel", true));
            this.permissionLevelComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permissionLevelComboBox.FormattingEnabled = true;
            this.permissionLevelComboBox.Items.AddRange(new object[] {
            "Admin",
            "Basic"});
            this.permissionLevelComboBox.Location = new System.Drawing.Point(39, 381);
            this.permissionLevelComboBox.Name = "permissionLevelComboBox";
            this.permissionLevelComboBox.Size = new System.Drawing.Size(260, 28);
            this.permissionLevelComboBox.TabIndex = 15;
            this.permissionLevelComboBox.Text = "Basic";
            // 
            // programmerBindingSource
            // 
            this.programmerBindingSource.DataMember = "programmer";
            this.programmerBindingSource.DataSource = this.bugtrackingdatabaseDataSet;
            // 
            // bugtrackingdatabaseDataSet
            // 
            this.bugtrackingdatabaseDataSet.DataSetName = "bugtrackingdatabaseDataSet";
            this.bugtrackingdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(130, 313);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(251, 26);
            this.passwordTextBox.TabIndex = 13;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(130, 259);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(251, 26);
            this.userNameTextBox.TabIndex = 11;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(130, 160);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(255, 26);
            this.phoneTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(130, 208);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(333, 26);
            this.emailTextBox.TabIndex = 9;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(130, 109);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(255, 26);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(130, 58);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(255, 26);
            this.firstNameTextBox.TabIndex = 3;
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
            // NewProgrammerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleLabel);
            this.Name = "NewProgrammerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewProgrammerForm";
            this.Load += new System.EventHandler(this.NewProgrammerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programmerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugtrackingdatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button CreateProgrammerButton;
        private bugtrackingdatabaseDataSet bugtrackingdatabaseDataSet;
        private System.Windows.Forms.BindingSource programmerBindingSource;
        private bugtrackingdatabaseDataSetTableAdapters.programmerTableAdapter programmerTableAdapter;
        private bugtrackingdatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox permissionLevelComboBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button SearchButton;
    }
}