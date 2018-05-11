namespace Lab3PSW
{
    partial class AddUser
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.alimentationComboBox = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.eventCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.usersComboBox = new System.Windows.Forms.ComboBox();
            this.uSERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet = new Lab3PSW.UsersDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userEventName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.ParticipationComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.OkButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.createUserButton = new System.Windows.Forms.Button();
            this.uSERSTableAdapter = new Lab3PSW.UsersDataSetTableAdapters.USERSTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.62797F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.37203F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(576, 532);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Controls.Add(this.panel11, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel9, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel10, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(570, 412);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.alimentationComboBox);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(117, 331);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(450, 78);
            this.panel11.TabIndex = 7;
            // 
            // alimentationComboBox
            // 
            this.alimentationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alimentationComboBox.FormattingEnabled = true;
            this.alimentationComboBox.Items.AddRange(new object[] {
            "No preferences",
            "Vegetarian",
            "Gluten free"});
            this.alimentationComboBox.Location = new System.Drawing.Point(29, 29);
            this.alimentationComboBox.Name = "alimentationComboBox";
            this.alimentationComboBox.Size = new System.Drawing.Size(397, 21);
            this.alimentationComboBox.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label3);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 331);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(108, 78);
            this.panel9.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(4, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alimentation:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.eventCheckedListBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(117, 85);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 158);
            this.panel4.TabIndex = 3;
            // 
            // eventCheckedListBox
            // 
            this.eventCheckedListBox.FormattingEnabled = true;
            this.eventCheckedListBox.Location = new System.Drawing.Point(29, 43);
            this.eventCheckedListBox.Name = "eventCheckedListBox";
            this.eventCheckedListBox.Size = new System.Drawing.Size(397, 79);
            this.eventCheckedListBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.usersComboBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(117, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 76);
            this.panel3.TabIndex = 2;
            // 
            // usersComboBox
            // 
            this.usersComboBox.DataSource = this.uSERSBindingSource;
            this.usersComboBox.DisplayMember = "login";
            this.usersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usersComboBox.FormattingEnabled = true;
            this.usersComboBox.Location = new System.Drawing.Point(29, 30);
            this.usersComboBox.Name = "usersComboBox";
            this.usersComboBox.Size = new System.Drawing.Size(397, 21);
            this.usersComboBox.TabIndex = 0;
            this.usersComboBox.ValueMember = "Id";
            this.usersComboBox.SelectedIndexChanged += new System.EventHandler(this.usersComboBox_SelectedIndexChanged);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.userEventName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(108, 76);
            this.panel2.TabIndex = 1;
            // 
            // userEventName
            // 
            this.userEventName.AutoSize = true;
            this.userEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.userEventName.Location = new System.Drawing.Point(52, 28);
            this.userEventName.Name = "userEventName";
            this.userEventName.Size = new System.Drawing.Size(50, 20);
            this.userEventName.TabIndex = 3;
            this.userEventName.Text = "User:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 158);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(37, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Events:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 249);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(108, 76);
            this.panel8.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Participation:";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.ParticipationComboBox);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(117, 249);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(450, 76);
            this.panel10.TabIndex = 6;
            // 
            // ParticipationComboBox
            // 
            this.ParticipationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParticipationComboBox.FormattingEnabled = true;
            this.ParticipationComboBox.Items.AddRange(new object[] {
            "Listener",
            "Author",
            "Sponsor",
            "Organizator"});
            this.ParticipationComboBox.Location = new System.Drawing.Point(29, 29);
            this.ParticipationComboBox.Name = "ParticipationComboBox";
            this.ParticipationComboBox.Size = new System.Drawing.Size(397, 21);
            this.ParticipationComboBox.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.panel7, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel6, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 421);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(570, 108);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.CancelButton);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(383, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(184, 102);
            this.panel7.TabIndex = 2;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(51, 36);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(98, 32);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "CANCEL";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.OkButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(193, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(184, 102);
            this.panel6.TabIndex = 1;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(42, 36);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(98, 32);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.createUserButton);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(184, 102);
            this.panel5.TabIndex = 0;
            // 
            // createUserButton
            // 
            this.createUserButton.Location = new System.Drawing.Point(41, 36);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(98, 32);
            this.createUserButton.TabIndex = 1;
            this.createUserButton.Text = "CREATE USER";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // uSERSTableAdapter
            // 
            this.uSERSTableAdapter.ClearBeforeFill = true;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 532);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddUser";
            this.Text = "Add User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddUser_FormClosing);
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label userEventName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.ComboBox usersComboBox;
        private UsersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource uSERSBindingSource;
        private UsersDataSetTableAdapters.USERSTableAdapter uSERSTableAdapter;
        private System.Windows.Forms.CheckedListBox eventCheckedListBox;

        private UsersDataSetTableAdapters.EVENTTableAdapter eVENTTableAdapter =
            new UsersDataSetTableAdapters.EVENTTableAdapter();

        private UsersDataSetTableAdapters.EVENTPARTICIPATORSTableAdapter eVENTPARTICIPATORSTableAdapter =
            new UsersDataSetTableAdapters.EVENTPARTICIPATORSTableAdapter();

        private UsersDataSetTableAdapters.QUERYTableAdapter qUERYTableAdapter =
             new UsersDataSetTableAdapters.QUERYTableAdapter();
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox ParticipationComboBox;
        private System.Windows.Forms.ComboBox alimentationComboBox;


    }
}