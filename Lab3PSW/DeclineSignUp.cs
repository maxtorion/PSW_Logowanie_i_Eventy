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
    public partial class DeclineSignUp : Form
    {
        public DeclineSignUp()
        {
            InitializeComponent();
            
        }
        private void setCheckBox()
        {
            try
            {

                ((ListBox)this.eventCheckedListBox).DataSource = this.eVENTPARTICIPATORSTableAdapter.GetEventsToConfirm((Int32)this.usersComboBox.SelectedValue);
                ((ListBox)this.eventCheckedListBox).DisplayMember = "eventName";
                ((ListBox)this.eventCheckedListBox).ValueMember = "OrderID";
            }
            catch (Exception)
            {

            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            foreach (System.Data.DataRowView item in eventCheckedListBox.CheckedItems)
            {
                this.eVENTPARTICIPATORSTableAdapter.Delete(item.Row.Field<Int32>("OrderID"),
                    item.Row.Field<Int32>("eventID"),
                    item.Row.Field<Int32>("userID"),
                    item.Row.Field<String>("participationType"),
                    item.Row.Field<String>("alimentation"),
                    item.Row.Field<bool>("confirmed"));
                
            }
            this.eVENTPARTICIPATORSTableAdapter.Update(usersDataSet.EVENTPARTICIPATORS);
            this.setCheckBox();
            this.eventCheckedListBox.ClearSelected();
        }

       

        private void DeclineSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            new AdminView().Show();
        }

        private void DeclineSignUp_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'usersDataSet.USERS' . Możesz go przenieść lub usunąć.
            this.uSERSTableAdapter.Fill(this.usersDataSet.USERS);

            this.eVENTTableAdapter.Fill(this.usersDataSet.EVENT);

            this.eVENTPARTICIPATORSTableAdapter.Fill(this.usersDataSet
                .EVENTPARTICIPATORS);
            this.setCheckBox();
        }

        private void usersComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.setCheckBox();
        }
    }
}
