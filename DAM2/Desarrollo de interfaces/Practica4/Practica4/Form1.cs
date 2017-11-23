using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica4
{
    public partial class Form1 : Form
    {
        List<CheckBox> chkLst = new List<CheckBox>();
      


        public Form1()
        {
            InitializeComponent();

            // Lista de checkboxes
            var checks = new List<CheckBox>();
            checks.Add(checkBox1);
            checks.Add(checkBox2);
            checks.Add(checkBox3);
            checks.Add(checkBox4);
            checks.Add(checkBox5);
            checks.Add(checkBox6);
            checks.Add(checkBox7);
            checks.Add(checkBox8);
            checks.Add(checkBox9);
            checks.Add(checkBox10);
            checks.Add(checkBox11);
            checks.Add(checkBox12);
            checks.Add(checkBox13);
            checks.Add(checkBox14);
            checks.Add(checkBox15);
            checks.Add(checkBox16);
            // Opciones combo de apuestas
            var apuestas = new List<KeyValuePair<string, int>>
    {
        new KeyValuePair<string, int>("", 0),
        new KeyValuePair<string, int>("Sencilla (4)", 4),
        new KeyValuePair<string, int>("Compleja (6)", 6)
    };


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public void bloquear()
        {
            panel1.Enabled = false;
        }
        public void desbloquear()
        {
            panel1.Enabled = true;
        }
        public void limpiar()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string mensage = "¿Esta seguro?";
            string titulo = "Salir";
            MessageBoxButtons opciones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensage, titulo, opciones, MessageBoxIcon.Question);
            
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            } 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checks = new List<CheckBox>();
            checks.Add(checkBox1);
            checks.Add(checkBox2);
            checks.Add(checkBox3);
            checks.Add(checkBox4);
            checks.Add(checkBox5);
            checks.Add(checkBox6);
            checks.Add(checkBox7);
            checks.Add(checkBox8);
            checks.Add(checkBox9);
            checks.Add(checkBox10);
            checks.Add(checkBox11);
            checks.Add(checkBox12);
            checks.Add(checkBox13);
            checks.Add(checkBox14);
            checks.Add(checkBox15);
            checks.Add(checkBox16);

            //SENCILLA
            if (comboBox1.SelectedIndex == 0) { 
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                dateTimePicker1.Enabled = true;
                button3.Enabled = true;

                if(radioButton1.Checked == true)
                panel1.Enabled = true;
                else
                panel1.Enabled = false;

            for (int i = 0; i <= 4; i++)
            {

                var r = random.Next(0, checks.Count);
                var checkbox = checks[r];
                checkbox.Checked = true;
            }
            }
            // MULTIPLE
            if (comboBox1.SelectedIndex == 1) { 
                
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                dateTimePicker1.Enabled = true;
                button3.Enabled = true;

                 if (radioButton1.Checked == true)
                panel1.Enabled = true;
                else
                panel1.Enabled = false;

            for (int i = 0; i <= 6; i++)
            {

                var r = random.Next(0, checks.Count);
                var checkbox = checks[r];
                checkbox.Checked = true;
            }
            }
            //EXTREMO
            if (comboBox1.SelectedIndex == 2) { 
                
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                dateTimePicker1.Enabled = true;
                button3.Enabled = true;

                if (radioButton1.Checked == true)
                panel1.Enabled = true;
                 else
                panel1.Enabled = false;

                 for (int i = 0; i <= 8; i++)
                  {

                var r = random.Next(0, checks.Count);
                var checkbox = checks[r];
                checkbox.Checked = true;
                 }
            }

            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            if (comboBox1.SelectedItem == "SENCILLA") 
                textBox1.Text = Convert.ToString(rnd.Next(1, 10));
                if (comboBox1.SelectedItem == "MULTIPLE")
                textBox1.Text = Convert.ToString(rnd.Next(1, 10));
                     if (comboBox1.SelectedItem == "EXTREMA")
                         textBox1.Text = Convert.ToString(rnd.Next(1, 10));

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            desbloquear();
            // Reintegro
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            if (radioButton2.Checked == true)
                textBox1.Text = Convert.ToString(rnd.Next(1, 10));

            //Numeros apuesta
            limpiar();

        }
        private static Random random = new Random();
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            bloquear();
            //Reintegro
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            if (radioButton2.Checked == true)
                 textBox1.Text = Convert.ToString(rnd.Next(1, 10));

            //Numeros apuesta
            if (radioButton2.Checked == true);
                var checks = new List<CheckBox>();
            checks.Add(checkBox1);
            checks.Add(checkBox2);
            checks.Add(checkBox3);
            checks.Add(checkBox4);
            checks.Add(checkBox5);
            checks.Add(checkBox6);
            checks.Add(checkBox7);
            checks.Add(checkBox8);
            checks.Add(checkBox9);
            checks.Add(checkBox10);
            checks.Add(checkBox11);
            checks.Add(checkBox12);
            checks.Add(checkBox13);
            checks.Add(checkBox14);
            checks.Add(checkBox15);
            checks.Add(checkBox16);

            if (comboBox1.SelectedItem == "SENCILLA")
                
            for (int i = 0; i <= 3; i++)
            {
                
                var r = random.Next(0, checks.Count);
                var checkbox = checks[r];
                checkbox.Checked = true;
            }
            if (comboBox1.SelectedItem == "MULTIPLE")
                
            for (int i = 0; i <= 5; i++)
                {
                    
                    var r = random.Next(0, checks.Count);
                    var checkbox = checks[r];
                    checkbox.Checked = true;
                }
            if (comboBox1.SelectedItem == "EXTREMA")
                
            for (int i = 0; i <= 8; i++)
                {
                    
                    var r = random.Next(0, checks.Count);
                    var checkbox = checks[r];
                    checkbox.Checked = true;
                }
        }
    }
 }

