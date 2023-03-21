using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisheriesAgency.Utils
{
    internal static class btnMouse
    {
        public static void btnEnter(Button button)
        {
            button.ForeColor = Color.Black;
            button.BackColor = Color.Aqua;
        }
        public static void btnLeave(Button button)
        {
            button.ForeColor = Color.Aqua;
            button.BackColor = Color.DimGray;
        }
    }
}
