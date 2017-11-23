using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Lista de checkboxes
            var checks = new List<CheckBox>();
            // Límite actual de checks que se pueden marcar
            var limite = 0;

            // Opciones combo de apuestas
            var apuestas = new List<KeyValuePair<string, int>>
    {
        new KeyValuePair<string, int>("", 0),
        new KeyValuePair<string, int>("Sencilla (4)", 4),
        new KeyValuePair<string, int>("Compleja (6)", 6),
        new KeyValuePair<string, int>("Extrema (8)", 6)
    };
            var cbo = new ComboBox
            {
                Left = 10,
                Top = 10,
                DisplayMember = "Key",
                ValueMember = "Value",
                DataSource = apuestas
            };
            // Evento cuando el combo cambia de valor
            cbo.SelectedIndexChanged += (sender, args) =>
            {
                // Se establece el nuevo límite en función de la opción seleccionada
                limite = (int)((ComboBox)sender).SelectedValue;
                // Se desactivan todos los checks
                checks.ForEach(x => x.Checked = false);
            };
            // Añade el combobox al formulario
            Controls.Add(cbo);
            // Se crean los checkbox
            for (var i = 0; i < 17; i++)
            {
                var chk = new CheckBox
                {
                    Text = i.ToString(),
                    Top = 60 + i / 4 * 60,
                    Left = 10 + i % 4 * 80,
                    Width = 60
                };
                // Evento que se genera al cambiar el estado de un checkbox
                chk.CheckedChanged += (sender, args) =>
                {
                    // Se suman los checks marcados y se compara con el límite
                    if (checks.Count(c => c.Checked) > limite)
                    {
                        // Si se ha superado el límite se desmarca el check
                        ((CheckBox)sender).Checked = false;
                    }
                };
                // Añade el checkbox al formulario y a la lista de checks
                Controls.Add(chk);
                checks.Add(chk);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
