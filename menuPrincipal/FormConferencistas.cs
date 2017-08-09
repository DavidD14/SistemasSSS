using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menuPrincipal
{
    public partial class FormConferencistas : Form
    {
        public FormConferencistas()
        {
            InitializeComponent();
        }

        private void FormConferencistas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f = new Form1();
            f.barButtonItem2.Enabled = true;
        }
    }
}
