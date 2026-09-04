using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry.P_Clientes_archivoCSV_
{
    internal class clsArchivo
    {

        public string NombreArchivo = "clientes.csv";

        public void Grabar(string cod, string nom, string deu, string lim)
        {
            StreamWriter ad = new StreamWriter(NombreArchivo, true);

            ad.Write(cod);
            ad.Write(";");
            ad.Write(nom);
            ad.Write(";");
            ad.Write(deu);
            ad.Write(";");
            ad.Write(lim);

            ad.Close();
            ad.Dispose();
        }

        public void Listar(DataGridView grilla)
        {
            string DatosLeidos = "";
            string[] vecDatos = new string[4];


            StreamReader ad = new StreamReader(NombreArchivo);

            DatosLeidos = ad.ReadLine(); //lo lee 



            while (DatosLeidos != null)
            {
                vecDatos = DatosLeidos.Split(';');

                grilla.Rows.Add(vecDatos[1], vecDatos[2], vecDatos[3]);

                DatosLeidos = ad.ReadLine();
            }

            ad.Close();
            ad.Dispose();
        }

        public int CantClientes()
        {
            int a = 0;

            string DatosLeidos = "";
            StreamReader ad = new StreamReader(NombreArchivo);
            DatosLeidos = ad.ReadLine();
            while (DatosLeidos != null)
            {
                a++;
                DatosLeidos = ad.ReadLine();
            }
            ad.Close();
            ad.Dispose();
            return a;
        }


        public decimal DeudaClientes()
        {
            string DatosLeidos = "";
            string[] vecDatos = new string[4];
            decimal total = 0;


            StreamReader ad = new StreamReader(NombreArchivo);

            DatosLeidos = ad.ReadLine(); //lo lee 



            while (DatosLeidos != null)
            {
                vecDatos = DatosLeidos.Split(';');

                total= total + Convert.ToDecimal(vecDatos[2]);

                DatosLeidos = ad.ReadLine();
            }

            ad.Close();
            ad.Dispose();

            return total;

        }

            

    }


}
    
