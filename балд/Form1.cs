using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace балд
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Sec = 0;
        Form2 f1 = new Form2();
        private void timer1_Tick(object sender, EventArgs e)
        {
            Sec++;
            if (Sec == 15) { f1.Show();
            this.Visible = false;
            }
        }
    }
}
