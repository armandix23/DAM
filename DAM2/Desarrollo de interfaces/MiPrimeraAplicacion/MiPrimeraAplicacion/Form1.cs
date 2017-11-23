using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraAplicacion
{
    public partial class botonPulsar : Form
    {
        public botonPulsar()
        {
            InitializeComponent();
        }

        private void botonPulsar_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            tabControl1.SelectedIndex = 3;

            
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Texto|*.txt|Todos|*.*";
            openFileDialog1.FilterIndex = 3;
                //"txt files (*.txt)|*.txt|All files (*.*)|*.*"

            if(openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        textBox1.Text = openFileDialog1.FileName;
                    }
                
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = comboBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime elegido = dateTimePicker1.Value;
            DateTime hoy = DateTime.Today;

            if (elegido.Date > hoy.Date)
                textBox3.Text = "Mayor a hoy";
            if (elegido.Date == hoy.Date)
                textBox3.Text = "Son iguales";
            if (elegido.Date < hoy.Date)
                textBox3.Text = "Menor a hoy";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.Text = listBox1.SelectedItem.ToString();
        }
    }
}
