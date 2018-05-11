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
    public partial class addNewEvent : Form
    {
        public addNewEvent()
        {
            InitializeComponent();
            this.eventDateTimePicker.Value = new DateTime(System.DateTime.Now.Year,
                System.DateTime.Now.Month,
                System.DateTime.Now.Day);
            
        }



        private void RegisterButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.eventNameTextBox.Text != "" && agendaRichTextBox.Text != "")
                {
                    this.eVENTTableAdapter.Insert(this.eventNameTextBox.Text,
                      this.agendaRichTextBox.Text,
                      this.eventDateTimePicker.Value.Date);

                    this.eventNameTextBox.Text = null;
                    this.agendaRichTextBox.Text = null;
                    this.eventDateTimePicker.Value = new DateTime(System.DateTime.Now.Year,
                        System.DateTime.Now.Month,
                        System.DateTime.Now.Day);

                    Misc.successDialog("You have successfully added new event", "Event Added");
                }
                else
                {
                    throw new MyException("One of the fields is empty", "Empty Field");
                }
            }
            catch (MyException)
            {

                
            }
        }

        private void addNewEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            new AdminView().Show();
        }

      
    }
}
