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

namespace ExamenViernes
{
    public partial class Form1 : Form
    {
        int numMax, numSel;
        ArrayList checks = new ArrayList();
        //CheckBox[] caja = new CheckBox;

        public Form1()
        {
            InitializeComponent();
            /*caja[1] = checkBox1;
            caja[2] = checkBox2;
            caja[3] = checkBox3;
            caja[4] = checkBox4;
            caja[5] = checkBox5;
            caja[6] = checkBox6;
            caja[7] = checkBox7;
            caja[8] = checkBox8;
            caja[9] = checkBox9;
            caja[10] = checkBox10;
            caja[11] = checkBox11;
            caja[12] = checkBox12;
            caja[13] = checkBox13;
            caja[14] = checkBox14;
            caja[15] = checkBox15;
            caja[16] = checkBox16;*/

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

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < DateTime.Today)
            {
                MessageBox.Show("No se puede participar en un sorteo anterior", "Error");
                dateTimePicker1.Value = DateTime.Today;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "¿Realmente quieres salir?";
            string caption = "Salir";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked && comboBox1.SelectedIndex != -1)
                activa();
        }

        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                automatico();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (numSel != numMax)
                MessageBox.Show("Quedan números por seleccionar", "Error");
            else
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
                imprime();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
            numSel = 0;
            for (int i = 0; i < 16; i++)
                ((CheckBox)checks[i]).Enabled = false;
            for (int i = 0; i < 16; i++)
                ((CheckBox)checks[i]).Checked = false;
            textBox2.Text = "";
            textBox1.Text = "";
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            button3.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Value = DateTime.Today;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            comprueba(0);
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            comprueba(1);
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            comprueba(2);
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            comprueba(3);
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            comprueba(4);
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            comprueba(5);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            comprueba(6);
        }
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            comprueba(7);
        }
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            comprueba(8);
        }
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            comprueba(9);
        }
        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            comprueba(10);
        }
        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            comprueba(11);
        }
        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            comprueba(12);
        }
        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            comprueba(13);
        }
        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            comprueba(14);
        }
        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            comprueba(15);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex != -1)
            {
                if (radioButton2.Checked)
                {
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0://SIMPLE
                            for (int i = 0; i < 16; i++)
                                ((CheckBox)checks[i]).Checked = false;
                            numSel = 0;
                            numMax = 4;
                            automatico();
                            numReintegro();
                            break;
                        case 1://MULTIPLE
                            for (int i = 0; i < 16; i++)
                                ((CheckBox)checks[i]).Checked = false;
                            numMax = 6;
                            numSel = 0;
                            automatico();
                            numReintegro();
                            break;
                        case 2://EXTREMA
                            for (int i = 0; i < 16; i++)
                                ((CheckBox)checks[i]).Checked = false;
                            numMax = 8;
                            numSel = 0;
                            automatico();
                            numReintegro();
                            break;
                    }
                }
                else
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0://SIMPLE
                            numMax = 4;
                            activa();
                            numReintegro();
                            
                            break;
                        case 1://MULTIPLE
                            numMax = 6;
                            activa();
                            numReintegro();
                            
                            break;
                        case 2://EXTREMA
                            numMax = 8;
                            activa();
                            numReintegro();
                           
                            break;
                    }
            }
        }

        //Funciones/Metodos

            // Para cuando activamos automatico
        private void automatico()
        {


            numSel = 0;
            for (int i = 0; i < checks.Count; i++)
                ((CheckBox)checks[i]).Enabled = false;
            while (numSel < numMax)
            {
                Random rndm = new Random();
                int aux = rndm.Next(0, 16);
                if (((CheckBox)checks[aux]).Checked == false)
                {
                    ((CheckBox)checks[aux]).Checked = true;
                    numSel++;
                }

            }
        }

        // Imprimir en el textbox los numeros seleccionados
        private void imprime()
        {
            string apuesta;
            int aux = 1;
            for (int i = 0; i < checks.Count; i++)
            {
                if (((CheckBox)checks[i]).Checked)
                {
                    apuesta = "Número " + aux + ": " + ((CheckBox)checks[i]).Text + "\r\n";
                    textBox2.Text += apuesta;
                    aux++;
                }
            }
            textBox2.Text += "Reintegro: " + textBox1.Text;
        }


        // Comprobar de forma manual los numeros /No funciona
        private void comprueba(int check)
        {
            if (numSel == numMax)
                if (((CheckBox)checks[check]).Checked)
                    ((CheckBox)checks[check]).Checked = false;
                else
                    numSel--;
            else
                if (((CheckBox)checks[check]).Checked)
                numSel++;
            else
                numSel--;
        }

        // Sacar un numero al azar para el reintegro
        private void numReintegro()
        {
            Random rndm = new Random();
            textBox1.Text = rndm.Next(1, 11).ToString();
        }

        // Funcion activar pestañas
        public void activa()
        {
            numSel = 0;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            button3.Enabled = true;
            dateTimePicker1.Enabled = true;
            for (int i = 0; i < 16; i++)
                ((CheckBox)checks[i]).Enabled = true;
            for (int i = 0; i < 16; i++)
                ((CheckBox)checks[i]).Checked = false;
        }
    }

}

