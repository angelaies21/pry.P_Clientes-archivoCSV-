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
    public partial class frmCargaClientes : Form
    {
        public frmCargaClientes()
        {
            InitializeComponent();
        }

        clsArchivo x= new clsArchivo();

        private void frmCargaClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            x.Grabar(txtCodig.Text, txtUsuario.Text, txtDeuda.Text, txtLimite.Text);
            MessageBox.Show("Cliente grabado");
            txtCodig.Clear();
            txtUsuario.Clear();
            txtDeuda.Clear();
            txtLimite.Clear();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
