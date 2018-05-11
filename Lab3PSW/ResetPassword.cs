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
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            new AdminView().Show();
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'usersDataSet.USERS' . Możesz go przenieść lub usunąć.
            this.uSERSTableAdapter.Fill(this.usersDataSet.USERS);

        }

        private void usersComboBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OkButton_Click(object sender, EventArgs e)
        {

            if (!passwordTextBox.Text.Equals(confirmTextBox.Text))
            {
                //komunikat, iż hasła do siebie nie pasują
                String messageBoxText = "Passwords are not the same!";
                String caption = "Passwords mismatch";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(messageBoxText, caption, button, icon);
                return;
            }


            try
            {
                if (passwordTextBox.Text != "")
                {
                    this.usersDataSet.USERS.FindById((Int32)usersComboBox.SelectedValue).BeginEdit();
                    this.usersDataSet.USERS.FindById((Int32)usersComboBox.SelectedValue).hasło = passwordTextBox.Text;
                    this.usersDataSet.USERS.FindById((Int32)usersComboBox.SelectedValue).EndEdit();


                    this.uSERSTableAdapter.Update(usersDataSet.USERS);

                    this.passwordTextBox.Text = null;
                    this.confirmTextBox.Text = null;
                    Misc.successDialog("Password changed!","Pasword Changed");
                }
                else
                {
                    throw new MyException("Password field cannot be empty.","Empty Password Field");
                }
            }
            catch (MyException)
            {

                
            }
            
        }
    }
}
