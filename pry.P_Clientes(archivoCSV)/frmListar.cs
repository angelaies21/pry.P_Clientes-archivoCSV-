using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry.P_Clientes_archivoCSV_
{
    public partial class frmListar : Form
    {
        public frmListar()
        {
            InitializeComponent();
        }
        clsArchivo x = new clsArchivo();

        private void btnListar_Click(object sender, EventArgs e)
        {
            x.Listar(dgvClientes);
            lblCant.Text = x.CantClientes().ToString();
            lblTotal.Text = x.DeudaClientes().ToString();
            lblProm.Text = x.Prom().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x.GenerarReporte();
            MessageBox.Show("Reporte generado correctamente");
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            x.OrdenarArchivo();
            MessageBox.Show("Archivo ordenado");
            x.Listar(dgvClientes);
        }






        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalDeuda_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
