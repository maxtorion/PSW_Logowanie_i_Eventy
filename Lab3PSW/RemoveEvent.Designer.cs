namespace Lab3PSW
{
    partial class RemoveEvent
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
            this.eventsToRemoveCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.usersDataSet = new Lab3PSW.UsersDataSet();
            this.eVENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eVENTTableAdapter = new Lab3PSW.UsersDataSetTableAdapters.EVENTTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENTBindingSource)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(546, 343);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 263);
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
            this.splitContainer1.Size = new System.Drawing.Size(540, 77);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.TabIndex = 8;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(84, 23);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(98, 32);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(93, 23);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(98, 32);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "CANCEL";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.eventsToRemoveCheckedListBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 254);
            this.panel2.TabIndex = 1;
            // 
            // eventsToRemoveCheckedListBox
            // 
            this.eventsToRemoveCheckedListBox.FormattingEnabled = true;
            this.eventsToRemoveCheckedListBox.Location = new System.Drawing.Point(74, 34);
            this.eventsToRemoveCheckedListBox.Name = "eventsToRemoveCheckedListBox";
            this.eventsToRemoveCheckedListBox.Size = new System.Drawing.Size(402, 184);
            this.eventsToRemoveCheckedListBox.TabIndex = 0;
            this.eventsToRemoveCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.eventsToRemoveCheckedListBox_SelectedIndexChanged);
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "UsersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eVENTBindingSource
            // 
            this.eVENTBindingSource.DataMember = "EVENT";
            this.eVENTBindingSource.DataSource = this.usersDataSet;
            // 
            // eVENTTableAdapter
            // 
            this.eVENTTableAdapter.ClearBeforeFill = true;
            // 
            // RemoveEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 343);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RemoveEvent";
            this.Text = "Remove Event";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RemoveEvent_FormClosing);
            this.Load += new System.EventHandler(this.RemoveEvent_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UsersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource eVENTBindingSource;
        private UsersDataSetTableAdapters.EVENTTableAdapter eVENTTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox eventsToRemoveCheckedListBox;
         
    }
}