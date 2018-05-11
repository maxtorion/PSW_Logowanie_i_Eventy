namespace Lab3PSW
{
    partial class ResetPassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.participationLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usersComboBox = new System.Windows.Forms.ComboBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.confirmTextBox = new System.Windows.Forms.TextBox();
            this.usersDataSet = new Lab3PSW.UsersDataSet();
            this.uSERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSERSTableAdapter = new Lab3PSW.UsersDataSetTableAdapters.USERSTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.44828F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.55173F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(580, 342);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.participationLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 79);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.usersComboBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(139, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 79);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 79);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.passwordTextBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(139, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(438, 79);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 173);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(130, 79);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.confirmTextBox);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(139, 173);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(438, 79);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 258);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(130, 81);
            this.panel7.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(139, 258);
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
            this.splitContainer1.Size = new System.Drawing.Size(444, 81);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.TabIndex = 8;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(57, 23);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(98, 32);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(74, 23);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(98, 32);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "CANCEL";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // participationLabel1
            // 
            this.participationLabel1.AutoSize = true;
            this.participationLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.participationLabel1.Location = new System.Drawing.Point(77, 28);
            this.participationLabel1.Name = "participationLabel1";
            this.participationLabel1.Size = new System.Drawing.Size(50, 20);
            this.participationLabel1.TabIndex = 5;
            this.participationLabel1.Text = "User:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "New \r\nPassword:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(39, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "Confirm \r\nPassword:";
            // 
            // usersComboBox
            // 
            this.usersComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSERSBindingSource, "login", true));
            this.usersComboBox.DataSource = this.uSERSBindingSource;
            this.usersComboBox.DisplayMember = "login";
            this.usersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usersComboBox.Location = new System.Drawing.Point(57, 30);
            this.usersComboBox.Name = "usersComboBox";
            this.usersComboBox.Size = new System.Drawing.Size(328, 21);
            this.usersComboBox.TabIndex = 0;
            this.usersComboBox.ValueMember = "Id";
            this.usersComboBox.TextChanged += new System.EventHandler(this.usersComboBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordTextBox.Location = new System.Drawing.Point(23, 26);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(392, 26);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // confirmTextBox
            // 
            this.confirmTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.confirmTextBox.Location = new System.Drawing.Point(23, 26);
            this.confirmTextBox.Name = "confirmTextBox";
            this.confirmTextBox.PasswordChar = '*';
            this.confirmTextBox.Size = new System.Drawing.Size(392, 26);
            this.confirmTextBox.TabIndex = 1;
            this.confirmTextBox.UseSystemPasswordChar = true;
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "UsersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERSBindingSource
            // 
            this.uSERSBindingSource.DataMember = "USERS";
            this.uSERSBindingSource.DataSource = this.usersDataSet;
            // 
            // uSERSTableAdapter
            // 
            this.uSERSTableAdapter.ClearBeforeFill = true;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 342);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ResetPassword";
            this.Text = "Reset Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResetPassword_FormClosing);
            this.Load += new System.EventHandler(this.ResetPassword_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label participationLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox usersComboBox;
        private System.Windows.Forms.TextBox confirmTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private UsersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource uSERSBindingSource;
        private UsersDataSetTableAdapters.USERSTableAdapter uSERSTableAdapter;
    }
}