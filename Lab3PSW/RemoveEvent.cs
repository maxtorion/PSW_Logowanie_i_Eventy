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
    public partial class RemoveEvent : Form
    {
        public RemoveEvent()
        {
            InitializeComponent();
            ((ListBox)this.eventsToRemoveCheckedListBox).DataSource = this.usersDataSet.EVENT;
            ((ListBox)this.eventsToRemoveCheckedListBox).DisplayMember = "eventName";
            ((ListBox)this.eventsToRemoveCheckedListBox).ValueMember = "eventID";
        }

        private void RemoveEvent_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'usersDataSet.EVENT' . Możesz go przenieść lub usunąć.
            this.eVENTTableAdapter.Fill(this.usersDataSet.EVENT);

        }

        private void eventsToRemoveCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            foreach (System.Data.DataRowView item in eventsToRemoveCheckedListBox.CheckedItems)
            {
                this.eVENTTableAdapter.Delete(item.Row.Field<int>("eventID"));
            }
            this.eVENTTableAdapter.Fill(this.usersDataSet.EVENT);



        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            new AdminView().Show();
        }
    }
}
