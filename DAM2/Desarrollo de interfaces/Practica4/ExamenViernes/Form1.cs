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
       // ArrayList checks = new ArrayList();
        List<CheckBox> checks = new List<CheckBox>();
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
            checks.Add(checkBox6);
            checks.Add(checkBox5);
            checks.Add(checkBox14);
            checks.Add(checkBox13);
            checks.Add(checkBox10);
            checks.Add(checkBox9);
            checks.Add(checkBox16);
            checks.Add(checkBox15);
            checks.Add(checkBox12);
            checks.Add(checkBox11);
            checks.Add(checkBox8);
            checks.Add(checkBox7);
            checks.Add(checkBox4);
            checks.Add(checkBox3);

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
            listBox1.Items.Clear();
            textBox1.Text = "";
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            button3.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Value = DateTime.Today;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex != -1)
            {
                if (radioButton2.Checked)
                {
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0:// TIPO DE APUESTA: SIMPLE
                            for (int i = 0; i < 16; i++)
                                ((CheckBox)checks[i]).Checked = false;
                            numSel = 0;
                            numMax = 4;
                            automatico();
                            numReintegro();
                            break;
                        case 1:// TIPO DE APUESTA: MULTIPLE
                            for (int i = 0; i < 16; i++)
                                ((CheckBox)checks[i]).Checked = false;
                            numMax = 6;
                            numSel = 0;
                            automatico();
                            numReintegro();
                            break;
                        case 2:// TIPO DE APUESTA: EXTREMA
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
                        case 0:// TIPO DE APUESTA: SIMPLE
                            activa();
                            numReintegro();
                            numMax = 4;                  
                            break;

                        case 1:// TIPO DE APUESTA: MULTIPLE
                            activa();
                            numReintegro();
                            numMax = 6;
                            break;

                        case 2:// TIPO DE APUESTA: EXTREMA                          
                            activa();
                            numReintegro();
                            numMax = 8;
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
                    listBox1.Items.Add(apuesta);
                    aux++;
                }
            }
            listBox1.Items.Add ("Reintegro: " + textBox1.Text);
        }

       

        // Sacar un numero al azar para el reintegro
        private void numReintegro()
        {
            Random rndm = new Random();
            textBox1.Text = rndm.Next(1, 11).ToString();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked)
             {
                 if (numMax > 0)
                 {
                     checkBox1.Checked = true;
                     numMax--;
                 }
                 else
                 {
                     checkBox1.Checked = false;
                 }
             }
             else
             {
                 numMax++;
             }          
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                if (numMax > 0)
                {
                    checkBox2.Checked = true;
                    numMax--;
                }
                else
                {
                    checkBox2.Checked = false;
                }
            }
            else
            {
                numMax++;
            }
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                if (numMax > 0)
                {
                    checkBox3.Checked = true;
                    numMax--;
                }
                else
                {
                    checkBox3.Checked = false;
                }
            }
            else
            {
                numMax++;
            }
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (numMax > 0)
                {
                    checkBox4.Checked = true;
                    numMax--;
                }
                else
                {
                    checkBox4.Checked = false;
                }
            }
            else
            {
                numMax++;
            }
        }

        private void checkBox5_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                if (numMax > 0)
                {
                    checkBox5.Checked = true;
                    numMax--;
                }
                else
                {
                    checkBox5.Checked = false;
                }
            }
            else
            {
                numMax++;
            }
        }

        private void checkBox6_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                if (numMax > 0)
                {
                    checkBox6.Checked = true;
                    numMax--;
                }
                else
                {
                    checkBox6.Checked = false;
                }
            }
            else
            {
                numMax++;
            }
        }

        private void checkBox7_Click(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                if (numMax > 0)
                {
                    checkBox7.Checked = true;
                    numMax--;
                }
                else
                {
                    checkBox7.Checked = false;
                }
            }
            else
            {
                numMax++;
            }
        }

        private void checkBox8_Click(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                if (numMax > 0)
                {
                    checkBox8.Checked = true;
                    numMax--;
                }
                else
                {
                    checkBox8.Checked = false;
                }
            }
            else
            {
                numMax++;
            }
        }

        private void checkBox9_Click(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                if (numMax > 0)
                {
                    checkBox9.Checked = true;
                    numMax--;
                }
                else
                {
                    checkBox9.Checked = false;
                }
            }
            else
            {
                numMax++;
            }
        }

        private void checkBox10_Click(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                if (numMax > 0)
                {
                    checkBox10.Checked = true;
                    numMax--;
                }
                else
                {
                    checkBox10.Checked = false;
                }
            }
            else
            {
                numMax++;
            }
        }

        private void checkBox11_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                if (numMax > 0)
                {
                    checkBox11.Checked = true;
                    numMax--;
                }
                else
                {
                    checkBox11.Checked = false;
                }
            }
            else
            {
                numMax++;
            }
        }

        private void checkBox12_Click(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                if (numMax > 0)
                {
                    checkBox12.Checked = true;
                    numMax--;
                }
                else
                {
                    checkBox12.Checked = false;
                }
            }
            else
            {
                numMax++;
            }
        }

        private void checkBox13_Click(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                if (numMax > 0)
                {
                    checkBox13.Checked = true;
                    numMax--;
                }
                else
                {
                    checkBox13.Checked = false;
                }
            }
            else
            {
                numMax++;
            }
        }

        private void checkBox14_Click(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {
                if (numMax > 0)
                {
                    checkBox14.Checked = true;
                    numMax--;
                }
                else
                {
                    checkBox14.Checked = false;
                }
            }
            else
            {
                numMax++;
            }
        }

        private void checkBox15_Click(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                if (numMax > 0)
                {
                    checkBox15.Checked = true;
                    numMax--;
                }
                else
                {
                    checkBox15.Checked = false;
                }
            }
            else
            {
                numMax++;
            }
        }

        private void checkBox16_Click_1(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {
                if (numMax > 0)
                {
                    checkBox16.Checked = true;
                    numMax--;
                }
                else
                {
                    checkBox16.Checked = false;
                }
            }
            else
            {
                numMax++;
            }
        }

    



        // Funcion activar pestañas
        public void activa()
        {
            panel1.Enabled = true;
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

