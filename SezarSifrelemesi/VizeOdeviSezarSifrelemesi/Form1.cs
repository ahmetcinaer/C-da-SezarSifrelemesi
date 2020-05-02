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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Şifrelemek İçin Bir Anhtar Değeri Giriniz!", "Bilgiler Eksik!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            if (richTextBox1.Text=="")
            {
                MessageBox.Show("Lütfen Şifrelemek İçin Bir Metin Giriniz!", "Bilgiler Eksik!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            int anahtar =Int32.Parse(textBox1.Text);
            string metin = richTextBox1.Text.Trim();
            string mesajbox="";
            char[] karakter = metin.ToCharArray();
            foreach (char i in karakter)
            {
                mesajbox += Convert.ToChar(i + anahtar);
            }

            MessageBox.Show("Şifreli Cümlemiz: "+ mesajbox);
 
            switch (MessageBox.Show( "Şifrelenmiş Mesajı Kopyalamak İçin Evet Basınız","",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                case DialogResult.Yes: Clipboard.SetText(mesajbox);
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
