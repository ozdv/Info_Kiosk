using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1
{

    class Navigate
    {
        public static MainWindow pageSwitchWindow;

        /// <summary>
        /// Switch which UserControl Page for MainWindow to display
        /// </summary>
        /// <param name="newPage"></param>
        public static void Move(UserControl newPage)
        {
            pageSwitchWindow.To(newPage);
        }
    }
}
