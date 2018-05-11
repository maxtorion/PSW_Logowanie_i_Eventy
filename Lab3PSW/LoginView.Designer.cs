namespace Lab3PSW
{
    partial class LoginView
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LogintextBox = new System.Windows.Forms.TextBox();
            this.LoginLayoutPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginLayoutPanel
            // 
            this.LoginLayoutPanel.ColumnCount = 2;
            this.LoginLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.86331F));
            this.LoginLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.13669F));
            this.LoginLayoutPanel.Controls.Add(this.panel4, 1, 1);
            this.LoginLayoutPanel.Controls.Add(this.panel2, 0, 0);
            this.LoginLayoutPanel.Controls.Add(this.splitContainer1, 1, 2);
            this.LoginLayoutPanel.Controls.Add(this.panel1, 0, 1);
            this.LoginLayoutPanel.Controls.Add(this.panel3, 1, 0);
            this.LoginLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginLayoutPanel.MaximumSize = new System.Drawing.Size(556, 261);
            this.LoginLayoutPanel.MinimumSize = new System.Drawing.Size(556, 261);
            this.LoginLayoutPanel.Name = "LoginLayoutPanel";
            this.LoginLayoutPanel.RowCount = 3;
            this.LoginLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LoginLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LoginLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.LoginLayoutPanel.Size = new System.Drawing.Size(556, 261);
            this.LoginLayoutPanel.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.PasswordTextBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(119, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(434, 94);
            this.panel4.TabIndex = 4;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PasswordTextBox.Location = new System.Drawing.Point(3, 33);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(392, 26);
            this.PasswordTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 94);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(119, 203);
            this.splitContainer1.MinimumSize = new System.Drawing.Size(444, 55);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LoginButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.RegisterButton);
            this.splitContainer1.Size = new System.Drawing.Size(444, 55);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 0;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(51, 11);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(98, 32);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Log in";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(83, 14);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(98, 32);
            this.RegisterButton.TabIndex = 0;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ShowPasswordCheckBox);
            this.panel1.Controls.Add(this.PasswordLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 94);
            this.panel1.TabIndex = 1;
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(7, 57);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(101, 17);
            this.ShowPasswordCheckBox.TabIndex = 1;
            this.ShowPasswordCheckBox.Text = "Show password";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.PasswordLabel.Location = new System.Drawing.Point(3, 30);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(97, 24);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "Password:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LogintextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(119, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(434, 94);
            this.panel3.TabIndex = 3;
            // 
            // LogintextBox
            // 
            this.LogintextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LogintextBox.Location = new System.Drawing.Point(3, 33);
            this.LogintextBox.Name = "LogintextBox";
            this.LogintextBox.Size = new System.Drawing.Size(392, 26);
            this.LogintextBox.TabIndex = 0;
            // 
            // LoginView
            // 
            this.ClientSize = new System.Drawing.Size(556, 261);
            this.Controls.Add(this.LoginLayoutPanel);
            this.MaximumSize = new System.Drawing.Size(572, 300);
            this.MinimumSize = new System.Drawing.Size(572, 300);
            this.Name = "LoginView";
            this.Text = "Login";
            this.LoginLayoutPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.TableLayoutPanel LoginLayoutPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox LogintextBox;
    }
}

