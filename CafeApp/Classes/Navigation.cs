using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CafeApp.Classes
{
    public class Navigation
    {
        public static Frame CustomFrame { get; set; } = new Frame();

        public static void OpenPage(Page page)
        {
            CustomFrame.Content = page;
        }
    }
}
