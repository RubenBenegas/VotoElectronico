using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotoElectronicoBeta
{
    public partial class CandidatosGridForm : Form
    {
        public CandidatosGridForm()
        {
            InitializeComponent();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            var cf = new CandidatoForm();
            cf.Show();
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            var cf = new CandidatoForm();
            cf.Show();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            var cf = new CandidatoForm();
            cf.Show();
        }
    }
}
