using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3PSW
{
    /// <summary>
    /// Klasa na statyczne funkcje, które nie mają jakiegoś wspólnego tematu przewodniego, a są potrzebne pozostałym klasą 
    /// </summary>
    class Misc
    {
        public static void sendEmail(string email)
        {
            //TODO: zmienić wysyłanie ode mnie!!!!!!!!!!
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.Credentials = new System.Net.NetworkCredential(DatabaseControl.ControlerInstance.getUserFromDataBase("mati").Email,"TU WSTAWIĆ TYMCZASOWY EMAIL!!!");
            client.EnableSsl = true;
            MailAddress from = new MailAddress(DatabaseControl.ControlerInstance.getUserFromDataBase("mati").Email,
                                                "Mateusz Szczepański",
                                                System.Text.Encoding.UTF8);
            MailAddress to = new MailAddress(email);
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Rejestracja udana!";
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            StringBuilder msg = new StringBuilder();
            msg.Append("Witaj, " + Environment.NewLine);
            msg.Append("Twoja rejestracja przebiegła pomyślnie"+Environment.NewLine);
            msg.Append("Pozdrawiam");
            message.Body = msg.ToString();
            client.Send(message);
            message.Dispose();


        }

        public static void successDialog(String message, String title)
        {
            String messageBoxText = message;
            String caption = title;
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            MessageBox.Show(messageBoxText, caption, button, icon);
        }
    }
}
