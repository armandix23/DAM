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
using System.Text.RegularExpressions;

namespace ExamenViernes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //Limpiar registro
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            pictureBox1.Image = null;
        }


        //Jugar loteria
        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox4.Text == textBox1.Text && textBox3.Text == textBox2.Text)
                MessageBox.Show("Acceso Correcto", "Correcto");
           // Form2_Load.Close();
            else
                MessageBox.Show("Error Incorrecto", "Error");

        }

        // Limpiar Login
        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            checkBox1.Checked = false;
        }

        //Limpiar imagen
        private void limpia()
        {
          //  pictureBox1.Clear;
        }

        // Cargar imagen
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Archivos de imágenes|*.bmp;*.jpg;*.png";
            openFileDialog1.FilterIndex = 3;
           

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    string imagen = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(imagen);
                }


            }
        }
        private bool EsValido()
        {
            // El método IsNullOrWhiteSpace devuelve TRUE cuando el parametro string pasado es NULL o tiene una cadena de caracteres de espacios o vacía.
            // Usamos el operador ! para invertir el bool devuelvo. 
            return !string.IsNullOrWhiteSpace(this.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {

            string palabra;
            palabra = textBox1.Text;
            // if ((palabra + "@gmail.com").Equals(string.Empty))
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                string mensage = "Correo Incorrecto";
                string titulo = "Error";
                MessageBoxButtons opciones = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(mensage, titulo, opciones, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                string mensage1 = "Contraseña Incorrecta";
                string titulo1 = "Error";
                MessageBoxButtons opciones1 = MessageBoxButtons.OK;
                DialogResult result1 = MessageBox.Show(mensage1, titulo1, opciones1, MessageBoxIcon.Error);
                return;
            }
            if (dateTimePicker1.Value >= DateTime.Today)
            {
                string mensage2 = "Debes ser  mayor de 18 años";
                string titulo2 = "Error";
                MessageBoxButtons opciones2 = MessageBoxButtons.OK;
                DialogResult result2 = MessageBox.Show(mensage2, titulo2, opciones2, MessageBoxIcon.Error);
                return;
            }

            //No funciona
            /* if (pictureBox1.BackgroundImage == null)
                    {
                 string mensage3 = "Debes seleccionar una imagen";
                 string titulo3 = "Error";
                  MessageBoxButtons opciones3 = MessageBoxButtons.OK;
                   DialogResult result3 = MessageBox.Show(mensage3, titulo3, opciones3, MessageBoxIcon.Error);
                    return;
               }*/
            else 
                textBox2.MaxLength = 6;

                groupBox1.Enabled = false;
                groupBox2.Enabled = true;

            }
         


          



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Text = textBox3.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
       
    }
}
