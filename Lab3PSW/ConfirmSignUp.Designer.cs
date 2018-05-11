namespace Lab3PSW
{
    partial class ConfirmSignUp
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.eventCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.usersComboBox = new System.Windows.Forms.ComboBox();
            this.uSERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet = new Lab3PSW.UsersDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userEventName = new System.Windows.Forms.Label();
            this.uSERSTableAdapter = new Lab3PSW.UsersDataSetTableAdapters.USERSTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.80175F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.19825F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 304);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 233);
            this.splitContainer1.MinimumSize = new System.Drawing.Size(444, 55);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.OkButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CancelButton);
            this.splitContainer1.Size = new System.Drawing.Size(524, 68);
            this.splitContainer1.SplitterDistance = 262;
            this.splitContainer1.TabIndex = 8;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(66, 17);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(98, 32);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(104, 17);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(98, 32);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "CANCEL";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 224);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 422F));
            this.tableLayoutPanel2.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.69643F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.30357F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(524, 224);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.eventCheckedListBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(105, 74);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(416, 147);
            this.panel5.TabIndex = 3;
            // 
            // eventCheckedListBox
            // 
            this.eventCheckedListBox.FormattingEnabled = true;
            this.eventCheckedListBox.Location = new System.Drawing.Point(10, 35);
            this.eventCheckedListBox.Name = "eventCheckedListBox";
            this.eventCheckedListBox.Size = new System.Drawing.Size(397, 79);
            this.eventCheckedListBox.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(96, 147);
            this.panel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 60);
            this.label1.TabIndex = 5;
            this.label1.Text = "\r\nEvents to \r\nconfirm:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.usersComboBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(105, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 65);
            this.panel3.TabIndex = 1;
            // 
            // usersComboBox
            // 
            this.usersComboBox.DataSource = this.uSERSBindingSource;
            this.usersComboBox.DisplayMember = "login";
            this.usersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usersComboBox.FormattingEnabled = true;
            this.usersComboBox.Location = new System.Drawing.Point(10, 22);
            this.usersComboBox.Name = "usersComboBox";
            this.usersComboBox.Size = new System.Drawing.Size(397, 21);
            this.usersComboBox.TabIndex = 1;
            this.usersComboBox.ValueMember = "Id";
            this.usersComboBox.DisplayMemberChanged += new System.EventHandler(this.usersComboBox_DisplayMemberChanged);
            this.usersComboBox.SelectedValueChanged += new System.EventHandler(this.usersComboBox_SelectedValueChanged);
            // 
            // uSERSBindingSource
            // 
            this.uSERSBindingSource.DataMember = "USERS";
            this.uSERSBindingSource.DataSource = this.usersDataSet;
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "UsersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userEventName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 65);
            this.panel1.TabIndex = 0;
            // 
            // userEventName
            // 
            this.userEventName.AutoSize = true;
            this.userEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.userEventName.Location = new System.Drawing.Point(43, 22);
            this.userEventName.Name = "userEventName";
            this.userEventName.Size = new System.Drawing.Size(50, 20);
            this.userEventName.TabIndex = 4;
            this.userEventName.Text = "User:";
            // 
            // uSERSTableAdapter
            // 
            this.uSERSTableAdapter.ClearBeforeFill = true;
            // 
            // ConfirmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 304);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ConfirmSignUp";
            this.Text = "Confirm Sign Up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfirmSignUp_FormClosing);
            this.Load += new System.EventHandler(this.ConfirmSignUp_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox usersComboBox;
        private System.Windows.Forms.CheckedListBox eventCheckedListBox;
        private System.Windows.Forms.Label userEventName;
        private System.Windows.Forms.Label label1;
        private UsersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource uSERSBindingSource;
        private UsersDataSetTableAdapters.USERSTableAdapter uSERSTableAdapter;
        private UsersDataSetTableAdapters.EVENTTableAdapter eVENTTableAdapter =
           new UsersDataSetTableAdapters.EVENTTableAdapter();
        private UsersDataSetTableAdapters.EVENTPARTICIPATORSTableAdapter eVENTPARTICIPATORSTableAdapter =
            new UsersDataSetTableAdapters.EVENTPARTICIPATORSTableAdapter();
    }
}