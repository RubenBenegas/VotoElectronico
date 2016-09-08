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
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }

        private void imprimirButton_Click(object sender, EventArgs e)
        {

            ImprimirTicket();

            MessageBox.Show("Su comprobante fue impreso");

            Close();

        }

        private void ImprimirTicket()

        {
            var path = System.Windows.Forms.Application.StartupPath;

            Bitmap imagen;
            Graphics g = this.CreateGraphics();
            Size s = this.Size;
            imagen = new Bitmap(s.Width, s.Height, g);
            Graphics g2 = Graphics.FromImage(imagen);
            g2.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);

            imagen.Save(path + "\\" + "imagen.jPEG");

        }
    }
}
