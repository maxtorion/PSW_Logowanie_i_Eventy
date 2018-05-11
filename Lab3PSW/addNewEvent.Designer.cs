namespace Lab3PSW
{
    partial class addNewEvent
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.eventDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.participationLabel1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.agendaRichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.agendaLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userEventName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.88489F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.11511F));
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(556, 428);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(107, 344);
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
            this.splitContainer1.Size = new System.Drawing.Size(446, 81);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 7;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(57, 23);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(98, 32);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(74, 23);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(98, 32);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "CANCEL";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 344);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(98, 81);
            this.panel7.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.eventDateTimePicker);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(107, 259);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(446, 79);
            this.panel6.TabIndex = 5;
            // 
            // eventDateTimePicker
            // 
            this.eventDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.eventDateTimePicker.Location = new System.Drawing.Point(113, 31);
            this.eventDateTimePicker.Name = "eventDateTimePicker";
            this.eventDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.eventDateTimePicker.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.participationLabel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 259);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(98, 79);
            this.panel5.TabIndex = 4;
            // 
            // participationLabel1
            // 
            this.participationLabel1.AutoSize = true;
            this.participationLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.participationLabel1.Location = new System.Drawing.Point(45, 32);
            this.participationLabel1.Name = "participationLabel1";
            this.participationLabel1.Size = new System.Drawing.Size(50, 20);
            this.participationLabel1.TabIndex = 4;
            this.participationLabel1.Text = "Date:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.agendaRichTextBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(107, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(446, 165);
            this.panel4.TabIndex = 3;
            // 
            // agendaRichTextBox
            // 
            this.agendaRichTextBox.Location = new System.Drawing.Point(42, 22);
            this.agendaRichTextBox.Name = "agendaRichTextBox";
            this.agendaRichTextBox.Size = new System.Drawing.Size(364, 114);
            this.agendaRichTextBox.TabIndex = 0;
            this.agendaRichTextBox.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.agendaLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(98, 165);
            this.panel3.TabIndex = 2;
            // 
            // agendaLabel
            // 
            this.agendaLabel.AutoSize = true;
            this.agendaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.agendaLabel.Location = new System.Drawing.Point(25, 70);
            this.agendaLabel.Name = "agendaLabel";
            this.agendaLabel.Size = new System.Drawing.Size(70, 20);
            this.agendaLabel.TabIndex = 3;
            this.agendaLabel.Text = "Agenda:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.eventNameTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(107, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 79);
            this.panel2.TabIndex = 1;
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Location = new System.Drawing.Point(42, 30);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(364, 20);
            this.eventNameTextBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userEventName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(98, 79);
            this.panel1.TabIndex = 0;
            // 
            // userEventName
            // 
            this.userEventName.AutoSize = true;
            this.userEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.userEventName.Location = new System.Drawing.Point(-4, 30);
            this.userEventName.Name = "userEventName";
            this.userEventName.Size = new System.Drawing.Size(102, 20);
            this.userEventName.TabIndex = 2;
            this.userEventName.Text = "Event name:";
            // 
            // addNewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 428);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "addNewEvent";
            this.Text = "Add New Event";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addNewEvent_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label userEventName;
        private System.Windows.Forms.Label agendaLabel;
        private System.Windows.Forms.Label participationLabel1;
        private System.Windows.Forms.DateTimePicker eventDateTimePicker;
        private System.Windows.Forms.RichTextBox agendaRichTextBox;
        private System.Windows.Forms.TextBox eventNameTextBox;

        
        private UsersDataSetTableAdapters.EVENTTableAdapter eVENTTableAdapter=new UsersDataSetTableAdapters.EVENTTableAdapter();
    }
}