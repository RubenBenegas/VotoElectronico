using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Reglas;


namespace VotoElectronicoBeta
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            var contraseñaABuscar = contraseñaTextBox.Text;

            var ca = new JornadaRule();
            var admin = ca.ComprobarVotante(contraseñaABuscar);

            if (admin == null)
            {

                MessageBox.Show("Contraseña incorrecta.");
                return;

            }

            Close();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
