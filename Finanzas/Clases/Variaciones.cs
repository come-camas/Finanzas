using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finanzas.Clases
{
    public  class Variaciones
    {
         public double Variacion_UAII, Variacion_Ventas, Variacion_upa;


        public Variaciones() { }

        public Variaciones(double variacion_UAII, double variacion_ventas, double variacion_upa) { 


            Variacion_UAII = variacion_UAII;
            Variacion_Ventas = variacion_ventas;
            Variacion_upa = variacion_upa;
        
        }

        public double _UAII { get { return Variacion_UAII; } }

        public double _Ventas { get { return Variacion_Ventas; } }
        public double _upa { get {  return Variacion_upa; } }   

        public static List<Variaciones>lista_variaciones = new List<Variaciones>();

    }
}
