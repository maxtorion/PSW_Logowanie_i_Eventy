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
    public partial class AddUser : Form
    {
        private void fillCheckBox()
        {
            try
            {
                ((ListBox)this.eventCheckedListBox).DataSource = this.qUERYTableAdapter.GetEventsNotPart((Int32)this.usersComboBox.SelectedValue);
                ((ListBox)this.eventCheckedListBox).DisplayMember = "eventName";
                ((ListBox)this.eventCheckedListBox).ValueMember = "eventID";
            }
            catch (Exception) { }
        }
        public AddUser()
        {
            InitializeComponent();
           
        }

        private void AddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.DialogResult!=DialogResult.OK)
            new AdminView().Show();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            RegistrationView regView = new RegistrationView();
            regView.WasCalledFromAdmin = true;
            regView.Show();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try {
                if (this.alimentationComboBox.SelectedItem != null && this.ParticipationComboBox.SelectedItem != null)
                {
                    foreach (System.Data.DataRowView item in eventCheckedListBox.CheckedItems)
                    {
                        this.eVENTPARTICIPATORSTableAdapter.Insert(item.Row.Field<int>("eventID"),
                            (Int32)this.usersComboBox.SelectedValue,
                            this.ParticipationComboBox.SelectedItem.ToString(),
                            this.alimentationComboBox.SelectedItem.ToString(),
                            true);
                    }
                    this.fillCheckBox();
                    this.eventCheckedListBox.ClearSelected();
                    Misc.successDialog("User succesfully added to the event", "Success");
                }
                else
                {
                    throw new MyException("One/all of fields is/are empty", "Empty Field");
                }
            } catch (MyException) { }
            
            
            
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'usersDataSet.USERS' . Możesz go przenieść lub usunąć.
            this.uSERSTableAdapter.Fill(this.usersDataSet.USERS);
            

            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'usersDataSet.EVENT' . Możesz go przenieść lub usunąć.
            this.eVENTTableAdapter.Fill(this.usersDataSet.EVENT);

            this.fillCheckBox();

        }

        private void usersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.fillCheckBox();
            
        }
    }
}
