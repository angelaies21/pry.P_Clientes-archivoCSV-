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
    public partial class frmOrdenarClientesPor : Form
    {
        public frmOrdenarClientesPor()
        {
            InitializeComponent();
        }
        clsArchivo x= new clsArchivo();

        private void btnListar_Click(object sender, EventArgs e)
        { 
            
            switch (cmbCampo.SelectedIndex)
            {
                case 0:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        x.ordenarporCodigoAscendente();

                    }
                    else
                    {
                        x.ordenarporCodigoDescendente();
                    }
                    break;
                case 1:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        x.ordenarporNombreAscendente();

                    }
                    else
                    {
                        x.ordenarporNombreDescendente();
                    }
                    break;
                case 2:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        x.ordenarporLimiteAscendente();

                    }
                    else
                    {
                        x.ordenarporLimiteDescendente();
                    }
                    break;
                case 3:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        x.ordenarporDeudaAscendente();

                    }
                    else
                    {
                        x.ordenarporDeudaDescendente();
                    }
                    break;
            }

            dgvClientes.Rows.Clear();
            for (Int32 i = 0; i < clsArchivo.IND; i++)
            {
                dgvClientes.Rows.Add(clsArchivo.Clinetes[i].codigo, clsArchivo.Clinetes[i].usuario, clsArchivo.Clinetes[i].Limite , clsArchivo.Clinetes[i].Deuda );

            }
        }
    }
}
