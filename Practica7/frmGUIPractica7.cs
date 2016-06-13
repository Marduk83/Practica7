using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practica7
{
    public partial class frmGUIPractica7 : Form
    {
        public frmGUIPractica7()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TeclasPulsadas(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char) (Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
