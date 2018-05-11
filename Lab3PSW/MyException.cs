using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3PSW
{
    class MyException:Exception
    {
        public MyException()
        {

        }
        public MyException(string message,string title):base(message)
        {
            
            String messageBoxText = message;
            String caption = title;
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Error;
            MessageBox.Show(messageBoxText, caption, button, icon);

        }

    }
}
