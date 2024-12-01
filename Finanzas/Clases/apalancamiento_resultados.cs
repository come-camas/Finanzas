using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finanzas.Clases
{
    public class Apalancamiento_resultados
    {
        public double apalancamiento_operativo;
        public double apalancamiento_financiero;
        public double apalamcamiento_total;

        public Apalancamiento_resultados(double Apalancamiento_Operativo, double Apalancamiento_Financiero, double Apalancamiento_Total) { 
            
            apalamcamiento_total = Apalancamiento_Total;
            apalancamiento_operativo = Apalancamiento_Operativo;
            apalancamiento_financiero = Apalancamiento_Financiero;
        
        }

        public Apalancamiento_resultados() { }

        public double _apalancamientooperativo { get { return apalancamiento_operativo; } }
        public double _apalancamientofinan {  get { return apalancamiento_financiero; } }
        public double _apalancamientototal { get { return apalamcamiento_total; } }

        public static List<Apalancamiento_resultados> lista_resultados_apalancamiento = new List<Apalancamiento_resultados>();





    }
}
