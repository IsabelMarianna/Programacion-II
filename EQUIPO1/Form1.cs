using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EQUIPO1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdtamaño_Click(object sender, EventArgs e)
        {
            cManejoCadenas obj1 = new cManejoCadenas();//instancia a la clase
            txtcaracteres.Text = Convert.ToString(obj1.tamaño(txtfrase.Text));
        }

        private void cmdnumvocales_Click(object sender, EventArgs e)
        {
            cManejoCadenas obj2 = new cManejoCadenas();
            Int16 largo = 0;
            largo = Convert.ToInt16(txtcaracteres.Text.Length);
            txtvocales.Text = Convert.ToString(obj2.vocales(txtfrase.Text));
        }

        private void cmdnumconso_Click(object sender, EventArgs e)
        {
            cManejoCadenas obj3 = new cManejoCadenas();
            Int16 largo = 0;
            largo = Convert.ToInt16(txtcaracteres.Text.Length);
            txtconsonantes.Text = Convert.ToString(obj3.consonantes(txtfrase.Text));
        }

        private void cmdnumpalabras_Click(object sender, EventArgs e)
        {
            cManejoCadenas obj4 = new cManejoCadenas();
            Int16 largo = 0;
            largo = Convert.ToInt16(txtcaracteres.Text.Length);
            txtpalabras.Text = Convert.ToString(obj4.palabras(txtfrase.Text));
        }

        private void cmdlimpiar_Click(object sender, EventArgs e)
        {
            txtfrase.Text = " ";
            txtcaracteres.Text = " ";
            txtvocales.Text = " ";
            txtconsonantes.Text = " ";
            txtpalabras.Text = " ";
        }

        private void cmdsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
