using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppOffice
{
    public partial class AboutForm1 : Form
    {
        public AboutForm1()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
