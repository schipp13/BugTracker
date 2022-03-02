
namespace BugTracker.Views
{
    partial class BusinessReports
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.reportsPanel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.programmerDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bugDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bugDataGridView1 = new System.Windows.Forms.DataGridView();
            this.bugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugtrackingdatabaseDataSet = new BugTracker.bugtrackingdatabaseDataSet();
            this.bugTableAdapter = new BugTracker.bugtrackingdatabaseDataSetTableAdapters.bugTableAdapter();
            this.tableAdapterManager = new BugTracker.bugtrackingdatabaseDataSetTableAdapters.TableAdapterManager();
            this.programmerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programmerTableAdapter = new BugTracker.bugtrackingdatabaseDataSetTableAdapters.programmerTableAdapter();
            this.reportsPanel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programmerDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bugDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bugDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugtrackingdatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(771, 12);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(97, 31);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // reportsPanel
            // 
            this.reportsPanel.Controls.Add(this.tabPage1);
            this.reportsPanel.Controls.Add(this.tabPage2);
            this.reportsPanel.Controls.Add(this.tabPage3);
            this.reportsPanel.Location = new System.Drawing.Point(12, 49);
            this.reportsPanel.Name = "reportsPanel";
            this.reportsPanel.SelectedIndex = 0;
            this.reportsPanel.Size = new System.Drawing.Size(856, 487);
            this.reportsPanel.TabIndex = 1;
            this.reportsPanel.SelectedIndexChanged += new System.EventHandler(this.reportsPanel_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.programmerDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(848, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Number of Tickets";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // programmerDataGridView
            // 
            this.programmerDataGridView.AllowUserToAddRows = false;
            this.programmerDataGridView.AllowUserToDeleteRows = false;
            this.programmerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.programmerDataGridView.Location = new System.Drawing.Point(-4, 0);
            this.programmerDataGridView.Name = "programmerDataGridView";
            this.programmerDataGridView.ReadOnly = true;
            this.programmerDataGridView.Size = new System.Drawing.Size(852, 455);
            this.programmerDataGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bugDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(848, 461);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Time to Resolution";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bugDataGridView
            // 
            this.bugDataGridView.AllowUserToAddRows = false;
            this.bugDataGridView.AllowUserToDeleteRows = false;
            this.bugDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bugDataGridView.Location = new System.Drawing.Point(-4, 0);
            this.bugDataGridView.Name = "bugDataGridView";
            this.bugDataGridView.ReadOnly = true;
            this.bugDataGridView.Size = new System.Drawing.Size(852, 455);
            this.bugDataGridView.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bugDataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(848, 461);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Issues Per Software";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bugDataGridView1
            // 
            this.bugDataGridView1.AllowUserToAddRows = false;
            this.bugDataGridView1.AllowUserToDeleteRows = false;
            this.bugDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bugDataGridView1.Location = new System.Drawing.Point(-4, 0);
            this.bugDataGridView1.Name = "bugDataGridView1";
            this.bugDataGridView1.ReadOnly = true;
            this.bugDataGridView1.Size = new System.Drawing.Size(852, 455);
            this.bugDataGridView1.TabIndex = 0;
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
            // programmerBindingSource
            // 
            this.programmerBindingSource.DataMember = "programmer";
            this.programmerBindingSource.DataSource = this.bugtrackingdatabaseDataSet;
            // 
            // programmerTableAdapter
            // 
            this.programmerTableAdapter.ClearBeforeFill = true;
            // 
            // BusinessReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 563);
            this.Controls.Add(this.reportsPanel);
            this.Controls.Add(this.CancelButton);
            this.Name = "BusinessReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BusinessReports";
            this.Load += new System.EventHandler(this.BusinessReports_Load);
            this.reportsPanel.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.programmerDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bugDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bugDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugtrackingdatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TabControl reportsPanel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private bugtrackingdatabaseDataSet bugtrackingdatabaseDataSet;
        private System.Windows.Forms.BindingSource bugBindingSource;
        private bugtrackingdatabaseDataSetTableAdapters.bugTableAdapter bugTableAdapter;
        private bugtrackingdatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource programmerBindingSource;
        private bugtrackingdatabaseDataSetTableAdapters.programmerTableAdapter programmerTableAdapter;
        private System.Windows.Forms.DataGridView programmerDataGridView;
        private System.Windows.Forms.DataGridView bugDataGridView;
        private System.Windows.Forms.DataGridView bugDataGridView1;
    }
}