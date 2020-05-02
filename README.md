# SezarSifrelemesi
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sezarsifrelenmesi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("Lüftn anahatar değeri giriniz","Değer Eksik",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            if (richTextBox1.Text=="")
            {
                MessageBox.Show("Lüftn şifreleneck metini giriniz", "Değer Eksik", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            int anahtar = Int32.Parse(textBox1.Text);
            string metin = richTextBox1.Text.Trim();
            char[] karakter = metin.ToCharArray(); 
            string mb = "";
            foreach (char İ in karakter)
            {
                mb += Convert.ToChar(İ + anahtar);
            }
            MessageBox.Show("Şifrelenmiş Metinimiz: "+mb);
            switch (MessageBox.Show("Şifrelenmiş Metini Koyplamak İster misiniz? "," ",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                case DialogResult.Yes: Clipboard.SetText(mb);
                    ;
                    break;
                case DialogResult.No:;
                    break;
            }

            textBox1.Clear();
            richTextBox1.Clear();
            textBox1.Focus();

        }
    }
}
