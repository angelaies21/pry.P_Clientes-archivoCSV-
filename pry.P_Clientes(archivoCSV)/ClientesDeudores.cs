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
    public partial class ClientesDeudores : Form
    {
        public ClientesDeudores()
        {
            InitializeComponent();
        }

        clsArchivo x = new clsArchivo();

        private void btnListarD_Click(object sender, EventArgs e)
        {
            x.ListarDeudores(dgvClientesD);
            lblCantD.Text = x.CantDeudores().ToString();
            lblTotalD.Text = x.DeudaClientes().ToString();
            lblPromD.Text = x.PromDeudores().ToString();
        }
    }
}
