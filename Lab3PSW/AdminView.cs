using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3PSW
{
    public partial class AdminView : Form
    {
        public AdminView()
        {
            InitializeComponent();
        }
        private const int SC_CLOSE = 61536;
        private const int WM_SYSCOMMAND = 274;
        private bool close = false;

        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == WM_SYSCOMMAND && msg.WParam.ToInt32() == SC_CLOSE)
            {
                this.close = true;
            }

            base.WndProc(ref msg);
        }


        private void AdminView_FormClosing(object sender, FormClosedEventArgs e)
        {
           
            if(this.DialogResult==DialogResult.Cancel || this.close)
                Application.OpenForms[0].Visible = true;
            else
                Application.OpenForms[0].Visible = false;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            new AddUser().Show();
            this.Close();
           


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void remoUserButton_Click(object sender, EventArgs e)
        {
            new RemoveUser().Show();
            this.Close();
        }

        private void resetPassButton_Click(object sender, EventArgs e)
        {
            new ResetPassword().Show();
            this.Close();
        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            new addNewEvent().Show();
            this.Close();
            
        }

        private void removeEventButton_Click(object sender, EventArgs e)
        {
            new RemoveEvent().Show();
            this.Close();
        }

        private void decSignButton_Click(object sender, EventArgs e)
        {
            new DeclineSignUp().Show();
            this.Close();
        }

        private void confSignButton_Click(object sender, EventArgs e)
        {
            new ConfirmSignUp().Show();
            this.Close();
        }
    }
}
