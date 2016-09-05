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

namespace VotoElectronicoBeta
{
    public partial class CandidatoGridForm : Form
    {
        public CandidatoGridForm()
        {
            InitializeComponent();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            var cf = new CandidatoForm();
            cf.Show();
        }
    }
}
