using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizeOdeviSezarSifrelemesi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 sifrele = new Form1();
            sifrele.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 coz = new Form2();
            coz.ShowDialog();
        }
    }
}
