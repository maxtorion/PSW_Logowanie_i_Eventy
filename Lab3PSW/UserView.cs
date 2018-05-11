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
    public partial class UserView : Form
    {
        private Int32 userID;

        internal int UserID { get => userID; set => userID = value; }

        public UserView()
        {
            InitializeComponent();
        }

        private void UserView_FormClosed(object sender, FormClosedEventArgs e)
        {
            
                Application.OpenForms[0].Visible = true;
           
        }

       

      

        private void eventComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.AgendatextBox.Text
        }

        private void UserView_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'usersDataSet.EVENT' . Możesz go przenieść lub usunąć.
            this.eVENTTableAdapter.Fill(this.usersDataSet.EVENT);

            

        }
        private Boolean checkIfUserAlreadyIn()
        {
            //Chroni przed ponownym zapisaniem na to samo wydarzenie
            DataView dataView = this.qUERYTableAdapter.GetEventsWithUser(this.UserID).AsDataView();

            dataView.Sort = "eventID ASC";

            if (dataView.Find(eventComboBox.SelectedValue) == -1)
                return false;
            else
                return true;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.eventComboBox.SelectedValue != null &&
                (this.ParticipationComboBox.SelectedItem != null) &&
                this.alimentationComboBox.SelectedItem != null)
                {


                    if (!checkIfUserAlreadyIn())
                    {
                        this.vENTPARTICIPATORSTableAdapter.Insert((Int32)this.eventComboBox.SelectedValue,
                                   this.userID,
                                   this.ParticipationComboBox.SelectedItem.ToString(),
                                   this.alimentationComboBox.SelectedItem.ToString(), false);

                        Misc.successDialog("You have successfully signed to the event", "Successfull Event Registration");
                    }
                    else
                    {
                        throw new MyException("You are already signed in for this event", "Already Signed");
                    }
                }
                else
                {
                    throw new MyException("One of the fields is empty", "Empty Field");
                }
            }
            catch (MyException me)
            {
                
            }
            
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
