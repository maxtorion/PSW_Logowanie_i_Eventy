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
    public partial class RemoveUser : Form
    {
        public RemoveUser()
        {
            InitializeComponent();
            ((ListBox)this.usersToRemoveCheckedListBox).DataSource = this.usersDataSet.USERS;
            ((ListBox)this.usersToRemoveCheckedListBox).DisplayMember = "login";
            ((ListBox)this.usersToRemoveCheckedListBox).ValueMember = "Id";
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            foreach (System.Data.DataRowView item in usersToRemoveCheckedListBox.CheckedItems)
            {
                this.uSERSTableAdapter.Delete(item.Row.Field<int>("Id"));
            }
            this.uSERSTableAdapter.Fill(this.usersDataSet.USERS);
        }

        private void RemoveUser_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'usersDataSet.USERS' . Możesz go przenieść lub usunąć.
            this.uSERSTableAdapter.Fill(this.usersDataSet.USERS);

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            new AdminView().Show();
        }
    }
}
