using System;
using System.Collections;
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

        ArrayList sucompra = new ArrayList();
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

                label10.Visible = true;
                textBox10.Visible = true;
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

                label10.Visible = false;
                textBox10.Visible = false;


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

                label10.Visible = false;
                textBox10.Visible = false;
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
            // Ordenador
            if (comboBox1.SelectedIndex == 0)
            {
                string marca = textBox1.Text.ToString();
                string nombre = textBox2.Text.ToString();
                int precio = Int32.Parse(textBox6.Text.ToString());
                int memoriaRAM = Int32.Parse(textBox4.Text.ToString());
                int npuertos = Int32.Parse(textBox3.Text.ToString());
                int velocidad = Int32.Parse(textBox3.Text.ToString());
                Class.Ordenador ordenador = new Class.Ordenador(velocidad, npuertos, nombre, marca, memoriaRAM, precio);
                sucompra.Add(ordenador);
                listBox1.Items.Add(comboBox1.SelectedItem + " " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " "
                          + textBox4.Text + " " + textBox5.Text + " " + textBox6.Text + " " + textBox7.Text
                          + " " + textBox8.Text + " " + textBox9.Text);
            }

            // Tablet
            if (comboBox1.SelectedIndex == 1)
            {
                string marca = textBox1.Text.ToString();
                string nombre = textBox2.Text.ToString();
                int precio = Int32.Parse(textBox6.Text.ToString());
                int memoriaRAM = Int32.Parse(textBox4.Text.ToString());
                int resolucion = Int32.Parse(textBox9.Text.ToString());
                int duracionBat = Int32.Parse(textBox5.Text.ToString());
                Class.Tablet tablet = new Class.Tablet(resolucion, duracionBat, nombre, marca, memoriaRAM, precio);
                sucompra.Add(tablet);
                listBox1.Items.Add(comboBox1.SelectedItem + " " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " 
                    + textBox4.Text + " " + textBox5.Text + " " + textBox6.Text + " " + textBox7.Text + " " + textBox8.Text + " " 
                    + textBox9.Text);
            }

            //Movil
            if (comboBox1.SelectedIndex == 2)
            {
                string marca = textBox1.Text.ToString();
                string nombre = textBox2.Text.ToString();
                int precio = Int32.Parse(textBox6.Text.ToString());
                int memoriaRAM = Int32.Parse(textBox4.Text.ToString());
                string sistOpe = textBox2.Text.ToString();
                int duracionBat = Int32.Parse(textBox6.Text.ToString());
                int almacenamiento = Int32.Parse(textBox4.Text.ToString());
                Class.Movil movil = new Class.Movil(sistOpe, duracionBat, almacenamiento, nombre, marca, memoriaRAM, precio);
                sucompra.Add(movil);
                listBox1.Items.Add(comboBox1.SelectedItem + " " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " "
                    + textBox4.Text + " " + textBox5.Text + " " + textBox6.Text + " " + textBox7.Text + " " + textBox8.Text + " " 
                    + textBox9.Text);
            }
            
        }

        // Eliminar
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            
        }
    }
}
