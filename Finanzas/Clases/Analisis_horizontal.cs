using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Finanzas.Clases
{
    public class analisis
    {
        public string Cuenta;
        public double Año1,Año2;
        

       public analisis() { 
       }

        public analisis(string cuenta, double año1, double año2) {

            Cuenta = cuenta;
            Año1 = año1;
            Año2 = año2;

        }

        public string _cuentaV{

            get { return Cuenta; }
        }

        public double _ano1V {

            get { return Año1; }
        }

        public double _ano2V
        {
            get { return Año2;}

        }
    
        public static List<analisis>Lista_analisis_horizontalE=new List<analisis>();
        public static List<analisis>Lista_analisis_horizontalB=new List<analisis>();
            

    }


}
