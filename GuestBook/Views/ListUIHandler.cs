using GuestBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuestBook.Views
{
   public class ListUIHandler
    {
        int messageIndex;
       public   List<Button> buttons;
        public Panel panel;


        public bool FindIndexByButton(Button button)
        {

            for(int i = 0; i <  buttons.Count;i++)
            {
                if(button == buttons[i])
                {
                    return true;
                }
            }
            return false;

        }

       
    }
}
