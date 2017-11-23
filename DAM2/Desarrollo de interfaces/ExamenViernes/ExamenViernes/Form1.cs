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
        public Form1()
        {
            InitializeComponent();
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

        public void activa()
        {
            numSel = 0;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            button1.Enabled = true;
            dateTimePicker1.Enabled = true;
            for (int i = 0; i < 16; i++)
                ((CheckBox)checks[i]).Enabled = true;
            for (int i = 0; i < 16; i++)
                ((CheckBox)checks[i]).Checked = false;
        }

        private void automatico() { 
        

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
        private void numReintegro()
        {
            Random rndm = new Random();
            textBox1.Text = rndm.Next(1, 11).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
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
            button1.Enabled = false;
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
    }
}

