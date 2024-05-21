using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProsekOcena
{
    public partial class Form1 : Form
    {
        List<Prosek> listaOcjena = new List<Prosek>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prosek prosek = new Prosek(cmbPredmeti.Text, Convert.ToInt32(textBox1.Text));
            // napravi da provjeri mora bit od 1 do 5
            // predmet ne smije biti prazan string
            listaOcjena.Add(prosek);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        {
                foreach (Prosek prosek in listaOcjena)
                    textBox2.AppendText(prosek.NazivPredmeta
                        + "\t" +
                        prosek.Ocjena + "\r\n");
            }
        }

        private void button4_Click(object sender, EventArgs e)
            { 

            }
            
        
    }
}
