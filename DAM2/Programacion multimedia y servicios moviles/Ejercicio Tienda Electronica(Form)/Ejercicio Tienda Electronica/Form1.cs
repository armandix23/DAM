using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Tienda_Electronica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Combobox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label5.Visible = false;
                textBox5.Visible = false;

                label7.Visible = false;
                textBox7.Visible = false;

                label8.Visible = false;
                textBox8.Visible = false;

                label9.Visible = false;
                textBox9.Visible = false;

                label3.Visible = true;
                textBox3.Visible = true;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                label3.Visible = false;
                textBox3.Visible = false;

                label9.Visible = true;
                textBox9.Visible = true;

                label5.Visible = true;
                textBox5.Visible = true;

                label8.Visible = false;
                textBox8.Visible = false;

                label7.Visible = false;
                textBox7.Visible = false;


            }

            if (comboBox1.SelectedIndex == 2)
            {
                label8.Visible = true;
                textBox8.Visible = true;

                label7.Visible = true;
                textBox7.Visible = true;

                label5.Visible = true;
                textBox5.Visible = true;

                label3.Visible = false;
                textBox3.Visible = false;

                label9.Visible = false;
                textBox9.Visible = false;
            }





        }

        // Inicio del form
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        // Anotar
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add( comboBox1.SelectedItem + " " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text + " " + textBox5.Text + " " + textBox6.Text + " " + textBox7.Text + " " + textBox8.Text + " " + textBox9.Text);
        }

        // Eliminar
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            
        }
    }
}
