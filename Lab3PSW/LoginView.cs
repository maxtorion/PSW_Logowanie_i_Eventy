using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3PSW
{
    public partial class LoginView : Form
    {
        private byte failedAttemptsCounter = 0;

        public byte FailedAttemptsCounter { get => failedAttemptsCounter; set => failedAttemptsCounter = value; }

        public LoginView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Register button
            new RegistrationView().Show();
            Application.OpenForms[0].Visible = false;
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //CheckBox do pokazywania hasła
            PasswordTextBox.PasswordChar = (PasswordTextBox.PasswordChar == '*') ? '\0' : '*';
               
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            //próba zalogowania pod podany login
            String login = LogintextBox.Text;
         
            
           

            User user = DatabaseControl.ControlerInstance.getUserFromDataBase(login);
            if (user == null)
            {
                //komunikat, iż użytkownnik o podany loginie nie istnieje
                String messageBoxText = "User with this login does not exist!";
                String caption = "No Such User";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Asterisk;
                MessageBox.Show(messageBoxText, caption, button, icon);
                return;
            }
            else
            {
                if (user.Password.Equals(PasswordTextBox.Text))
                {
                    FailedAttemptsCounter = 0;
                    if (user.Access.Equals("admin"))

                        new AdminView().Show();
                    else
                    {
                        UserView userView = new UserView();
                        userView.UserID = user.Id;
                        userView.Show();

                    }

                    this.LogintextBox.Text = null;
                    this.PasswordTextBox.Text = null;
                    
                    Application.OpenForms[0].Visible=false;
                }
                else
                {
                    //wyświetlam komunikat gdy hasło nie pasuje
                    FailedAttemptsCounter++;
                    String messageBoxText;
                    if (FailedAttemptsCounter < 3)
                    {
                        messageBoxText = String.Format("Given password dosen't match the login.\n Remaining attempts: {0}", 3 - FailedAttemptsCounter);
                    }
                    else
                    {
                        messageBoxText = "Exceeded login attempts. Access is now blocked.";
                        this.LoginButton.Enabled = false;
                    }
                    String caption = "Wrong password";
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBox.Show(messageBoxText, caption, button, icon);


                    return;

                }


            }
            


        }
       

        
    }
}
