using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry.P_Clientes_archivoCSV_
{
    internal class clsArchivo
    {

        public string NombreArchivo = "../../Archivos/clientes.csv";

        public struct RegCli
        {
            public Int32 codigo;
            public String usuario;
            public Decimal Deuda;
            public Decimal Limite;
        };


        //declarar el vector
        static public RegCli[] Clinetes = new RegCli[100];

        //declarar el indice
        static public int IND = 0;


        private void CargarVect()
        {
            string DatosLeidos = "";
            string[] vecDatos = new string[4];
            IND = 0;

            StreamReader ad = new StreamReader(NombreArchivo);

            DatosLeidos = ad.ReadLine(); //lo lee 

            //grilla.Rows.Clear();

            while (DatosLeidos != null)
            {
                vecDatos = DatosLeidos.Split(';');

                Clinetes[IND].codigo = Convert.ToInt32(vecDatos[0]);
                Clinetes[IND].usuario = vecDatos[1];
                Clinetes[IND].Deuda = Convert.ToDecimal(vecDatos[2]);
                Clinetes[IND].Limite = Convert.ToDecimal(vecDatos[3]);
                IND++;
                DatosLeidos = ad.ReadLine();
                //grilla.Rows.Add(vecDatos[0], vecDatos[1], vecDatos[2], vecDatos[3]);
            }

            ad.Close();
            ad.Dispose();
        }

        private void OrdenarVect()
        {
            RegCli aux;

            for (Int32 c = 0; c < IND - 1; c++)
            {
                for (Int32 i = 0; i < IND - 1; i++)
                {
                    if (Clinetes[i].codigo > Clinetes[i + 1].codigo)
                    {
                        aux = Clinetes[i];
                        Clinetes[i] = Clinetes[i + 1];
                        Clinetes[i + 1] = aux;
                    }
                }
            }

        }

        private void ReescribirArchivo()
        {
            StreamWriter ad = new StreamWriter(NombreArchivo, false);

            for (Int32 i = 0; i < IND; i++)
            {
                ad.Write(Clinetes[i].codigo);
                ad.Write(";");
                ad.Write(Clinetes[i].usuario);
                ad.Write(";");
                ad.Write(Clinetes[i].Deuda);
                ad.Write(";");
                ad.WriteLine(Clinetes[i].Limite);
            }
            ad.Close();
            ad.Dispose();
        }


        public void OrdenarArchivo()
        {
            CargarVect();
            OrdenarVect();
            ReescribirArchivo();
        }

        public void Grabar(string cod, string nom, string deu, string lim)
        {
            StreamWriter ad = new StreamWriter(NombreArchivo, true);

            ad.Write(cod);
            ad.Write(";");
            ad.Write(nom);
            ad.Write(";");
            ad.Write(deu);
            ad.Write(";");
            ad.WriteLine(lim);

            ad.Close();
            ad.Dispose();
        }

        public void Listar(DataGridView grilla)
        {
            string DatosLeidos = "";
            string[] vecDatos = new string[4];


            StreamReader ad = new StreamReader(NombreArchivo);

            DatosLeidos = ad.ReadLine(); //lo lee 

            grilla.Rows.Clear();

            while (DatosLeidos != null)
            {
                vecDatos = DatosLeidos.Split(';');

                grilla.Rows.Add(vecDatos[0], vecDatos[1], vecDatos[2], vecDatos[3]);

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

                total = total + Convert.ToDecimal(vecDatos[2]);

                DatosLeidos = ad.ReadLine();
            }

            ad.Close();
            ad.Dispose();

            return total;

        }

        public decimal Prom()
        {
            string DatosLeidos = "";
            string[] vecDatos = new string[4];
            decimal total = 0;
            Int32 c = 0;

            StreamReader ad = new StreamReader(NombreArchivo);
            DatosLeidos = ad.ReadLine();

            while (DatosLeidos != null)
            {
                vecDatos = DatosLeidos.Split(';');

                total = total + Convert.ToDecimal(vecDatos[2]);
                c++;

                DatosLeidos = ad.ReadLine();
            }

            ad.Close();
            ad.Dispose();

            return total / c;

        }


        public void ListarDeudores(DataGridView grilla)
        {
            string DatosLeidos = "";
            string[] vecDatos = new string[4];


            StreamReader ad = new StreamReader(NombreArchivo);

            DatosLeidos = ad.ReadLine(); //lo lee 

            grilla.Rows.Clear();

            while (DatosLeidos != null)
            {
                vecDatos = DatosLeidos.Split(';');

                if (Convert.ToDecimal(vecDatos[2]) > 0)
                {
                    grilla.Rows.Add(vecDatos[0], vecDatos[1], vecDatos[2], vecDatos[3]);
                }

                DatosLeidos = ad.ReadLine();
            }

            ad.Close();
            ad.Dispose();
        }

        public decimal CantDeudores()
        {
            string DatosLeidos = "";
            string[] vecDatos = new string[4];

            Int32 c = 0;

            StreamReader ad = new StreamReader(NombreArchivo);
            DatosLeidos = ad.ReadLine();


            while (DatosLeidos != null)
            {
                vecDatos = DatosLeidos.Split(';');


                if (Convert.ToDecimal(vecDatos[2]) > 0)
                {
                    c++;
                }

                DatosLeidos = ad.ReadLine();
            }

            ad.Close();
            ad.Dispose();

            return c;

        }

        public decimal PromDeudores()
        {
            string DatosLeidos = "";
            string[] vecDatos = new string[4];
            decimal total = 0;
            Int32 c = 0;

            StreamReader ad = new StreamReader(NombreArchivo);
            DatosLeidos = ad.ReadLine();

            while (DatosLeidos != null)
            {
                vecDatos = DatosLeidos.Split(';');

                if (Convert.ToDecimal(vecDatos[2]) > 0)
                {

                    //grilla.Rows.Add(vecDatos[1], vecDatos[2], vecDatos[3]);
                    total = total + Convert.ToDecimal(vecDatos[2]);
                    c++;
                }

                DatosLeidos = ad.ReadLine();
            }

            ad.Close();
            ad.Dispose();

            return total / c;

        }

        public void GenerarReporte()
        {
            string DatosLeidos = "";
            string[] vecDatos = new string[4];

            Int32 cant = 0;
            decimal total = 0;

            StreamWriter reporte = new StreamWriter("../../Archivos/Reporte.csv", false, Encoding.UTF8); //utf8 toma los acentos y la ñ
            reporte.WriteLine("");
            reporte.WriteLine("Listado de clientes");
            reporte.WriteLine("");
            reporte.WriteLine("Código; nombre; Limite; Deuda");

            StreamReader ad = new StreamReader(NombreArchivo);
            DatosLeidos = ad.ReadLine();

            while (DatosLeidos != null)
            {
                vecDatos = DatosLeidos.Split(';');
                reporte.Write(vecDatos[0]);
                reporte.Write(";");
                reporte.Write(vecDatos[1]);
                reporte.Write(";");
                reporte.Write(vecDatos[2]);
                reporte.Write(";");
                reporte.Write(vecDatos[3]);
                cant++;
                total = total + Convert.ToDecimal(vecDatos[2]);

                DatosLeidos = ad.ReadLine();
            }

            ad.Close();
            ad.Dispose();
            reporte.WriteLine("");
            reporte.Write("Total de deuda: ;;");
            reporte.Write(total);
            reporte.Write("cantidad de clientes: ;;");
            reporte.WriteLine(cant);
            reporte.Write("promedio de deuda: ;;");
            reporte.WriteLine(total / cant);

            reporte.Close();
            reporte.Dispose();


        }

        private void CargarVector()
        {
            string DatosLeidos = "";
            string[] vecDatos = new string[4];

            StreamReader ad = new StreamReader(NombreArchivo);

            while (DatosLeidos != null)
            {
                vecDatos = DatosLeidos.Split(';');

                Clinetes[IND].codigo = Convert.ToInt32(vecDatos[0]);
                Clinetes[IND].usuario = vecDatos[1];
                Clinetes[IND].Deuda = Convert.ToDecimal(vecDatos[2]);
                Clinetes[IND].Limite = Convert.ToDecimal(vecDatos[3]);
                IND++;
                DatosLeidos = ad.ReadLine();
            }

            ad.Close();
            ad.Dispose();
        }


        public void ordenarporCodigoDescendente(DataGridView Grilla)
        {

            CargarVect();

            RegCli aux;
            Int32 i = 0;
            Int32 c = 0;

            while (i < IND - 1)
            {
                c = 0;
                while (c < IND - 1)
                {
                    if (Clinetes[c].codigo < Clinetes[c + 1].codigo)
                    {
                        aux = Clinetes[c];
                        Clinetes[c] = Clinetes[c + 1];
                        Clinetes[c + 1] = aux;
                    }
                    c++;

                }
                i++;

            }
            Grilla.Rows.Clear();
            for (Int32 z = 0; z < IND; z++)
            {
                Grilla.Rows.Add(Clinetes[i].codigo, Clinetes[i].usuario, Clinetes[i].Limite, Clinetes[i].Deuda);

            }
        }


        public void ordenarporCodigoAscendente(DataGridView Grilla)
        {
            CargarVect();

            RegCli aux;
            Int32 i = 0;
            Int32 c = 0;

            while (i < IND - 1)
            {
                c = 0;
                while (c < IND - 1)
                {
                    if (Clinetes[c].codigo > Clinetes[c + 1].codigo)
                    {
                        aux = Clinetes[c];
                        Clinetes[c] = Clinetes[c + 1];
                        Clinetes[c + 1] = aux;
                    }
                    c++;

                }
                i++;

            }
            Grilla.Rows.Clear();
            for (Int32 z = 0; z < IND; z++)
            {
                Grilla.Rows.Add(Clinetes[i].codigo, Clinetes[i].usuario, Clinetes[i].Limite, Clinetes[i].Deuda);

            }
        }




        public void ordenarporNombreDescendente(DataGridView Grilla)
        {

            CargarVect();

            RegCli aux;
            Int32 i = 0;
            Int32 c = 0;

            while (i < IND - 1)
            {
                c = 0;
                while (c < IND - 1)
                {
                    if (Clinetes[c].usuario.CompareTo(Clinetes[c + 1].usuario) < 0)
                    {
                        aux = Clinetes[c];
                        Clinetes[c] = Clinetes[c + 1];
                        Clinetes[c + 1] = aux;
                    }
                    c++;

                }
                i++;

            }
            Grilla.Rows.Clear();
            for (Int32 z = 0; z < IND; z++)
            {
                Grilla.Rows.Add(Clinetes[i].codigo, Clinetes[i].usuario, Clinetes[i].Limite, Clinetes[i].Deuda);

            }
        }


        public void ordenarporNombreAscendente(DataGridView Grilla)
        {
            CargarVect();

            RegCli aux;
            Int32 i = 0;
            Int32 c = 0;

            while (i < IND - 1)
            {
                c = 0;
                while (c < IND - 1)
                {
                    if (Clinetes[c].usuario.CompareTo(Clinetes[c +1].usuario) > 0)
                    {
                        aux = Clinetes[c];
                        Clinetes[c] = Clinetes[c + 1];
                        Clinetes[c + 1] = aux;
                    }
                    c++;

                }
                i++;

            }
            Grilla.Rows.Clear();
            for (Int32 z = 0; z < IND; z++)
            {
                Grilla.Rows.Add(Clinetes[i].codigo, Clinetes[i].usuario, Clinetes[i].Limite, Clinetes[i].Deuda);

            }
        }




        public void ordenarporLimiteDescendente(DataGridView Grilla)
        {

            CargarVect();

            RegCli aux;
            Int32 i = 0;
            Int32 c = 0;

            while (i < IND - 1)
            {
                c = 0;
                while (c < IND - 1)
                {
                    if (Clinetes[c].Limite < Clinetes[c + 1].Limite)
                    {
                        aux = Clinetes[c];
                        Clinetes[c] = Clinetes[c + 1];
                        Clinetes[c + 1] = aux;
                    }
                    c++;

                }
                i++;

            }
            Grilla.Rows.Clear();
            for (Int32 z = 0; z < IND; z++)
            {
                Grilla.Rows.Add(Clinetes[i].codigo, Clinetes[i].usuario, Clinetes[i].Limite, Clinetes[i].Deuda);

            }
        }


        public void ordenarporLimiteAscendente(DataGridView Grilla)
        {
            CargarVect();

            RegCli aux;
            Int32 i = 0;
            Int32 c = 0;

            while (i < IND - 1)
            {
                c = 0;
                while (c < IND - 1)
                {
                    if (Clinetes[c].Limite > Clinetes[c + 1].Limite)
                    {
                        aux = Clinetes[c];
                        Clinetes[c] = Clinetes[c + 1];
                        Clinetes[c + 1] = aux;
                    }
                    c++;

                }
                i++;

            }
            Grilla.Rows.Clear();
            for (Int32 z = 0; z < IND; z++)
            {
                Grilla.Rows.Add(Clinetes[i].codigo, Clinetes[i].usuario, Clinetes[i].Limite, Clinetes[i].Deuda);

            }
        }
                


    
    public void ordenarporDeudaDescendente(DataGridView Grilla)
        {

            CargarVect();
            RegCli aux;
            Int32 i = 0;
            Int32 c = 0;

            while (i < IND - 1)
            {
                c = 0;
                while (c < IND - 1)
                {
                    if (Clinetes[c].Deuda < Clinetes[c + 1].Deuda)
                    {
                        aux = Clinetes[c];
                        Clinetes[c] = Clinetes[c + 1];
                        Clinetes[c + 1] = aux;
                    }
                    c++;

                }
                i++;

            }
            Grilla.Rows.Clear();
            for (Int32 z = 0; z < IND; z++)
            {
                Grilla.Rows.Add(Clinetes[i].codigo, Clinetes[i].usuario, Clinetes[i].Limite, Clinetes[i].Deuda);

            }
        }


        public void ordenarporDeudaAscendente(DataGridView Grilla)
        {
            CargarVect();

            RegCli aux;
            Int32 i = 0;
            Int32 c = 0;

            while (i < IND - 1)
            {
                c = 0;
                while (c < IND - 1)
                {
                    if (Clinetes[c].Deuda > Clinetes[c + 1].Deuda)
                    {
                        aux = Clinetes[c];
                        Clinetes[c] = Clinetes[c + 1];
                        Clinetes[c + 1] = aux;
                    }
                    c++;

                }
                i++;

            }
            Grilla.Rows.Clear();
            for (Int32 z = 0; z < IND; z++)
            {
                Grilla.Rows.Add(Clinetes[i].codigo, Clinetes[i].usuario, Clinetes[i].Limite, Clinetes[i].Deuda);

            }
        }
    }






}
    
