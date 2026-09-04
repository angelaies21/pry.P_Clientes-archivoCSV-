using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pry.P_Clientes_archivoCSV_
{
    internal class clsArchivo
    {

        public string NombreArchivo = "clientes.csv";

        public void Grabar(string cod, string nom,string deu,string lim)
        {
            StringWriter ad = new StringWriter();

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
             
           


             
    }
}
