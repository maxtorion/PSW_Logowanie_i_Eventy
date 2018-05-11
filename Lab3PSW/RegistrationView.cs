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
    public partial class RegistrationView : Form
    {
        private Boolean wasCalledFromAdmin = false;

        public bool WasCalledFromAdmin { get => wasCalledFromAdmin; set => wasCalledFromAdmin = value; }

        public RegistrationView()
        {
            InitializeComponent();
        }

        private void RegistrationView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!WasCalledFromAdmin)
                Application.OpenForms[0].Visible = true;
            else
            {
                WasCalledFromAdmin = false;

                new AddUser().Show();
            }
               

        }


        private void cleanTextBoxes()
        {

            nameTextBox.Text = "";
            surnameTextBox.Text = "";
            loginTextBox.Text = "";
            passwordTextBox.Text = "";
            emailTextBox.Text = "";
            confirmTextBox.Text = "";
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            User user;
            try
            {
                 user = new User(
                nameTextBox.Text,
                surnameTextBox.Text,
                loginTextBox.Text,
                passwordTextBox.Text,
                emailTextBox.Text);
            }
            catch(MyException) {
                
                return;

            }
           

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

           

            DatabaseControl.ControlerInstance.addUserToTheDatabase(user);


            cleanTextBoxes();

           // Misc.sendEmail(user.Email);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
