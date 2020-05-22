using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace задача_6._1
{
    public partial class forma : Form
    {
        public forma()
        {
            InitializeComponent();
        }


        private void buttonB_Click(object sender, EventArgs e)
        {
            if (buttonA.Size.Width > buttonA.MinimumSize.Width + 2) buttonA.Width -= 2;
            else if (buttonA.Size.Width > buttonA.MinimumSize.Width) buttonA.Width = buttonA.MinimumSize.Width;
            else buttonA.Width = buttonA.MaximumSize.Width;
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            if (buttonB.Left > 10) buttonB.Left -= 10;
            else if (buttonB.Left > 0) buttonB.Left = 0;
            else buttonB.Left = this.Size.Width - buttonB.Width;
        }
    }
}
