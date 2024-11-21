using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finanzas.Clases
{
    public class Analisi_vvertical
    {
        string Cuenta;
        double Monto;

        public Analisi_vvertical() { 
        }
        public Analisi_vvertical(string cuenta, double monto)
        {
            Cuenta = cuenta;
            Monto = monto;
        }

        public string _cuenta { get { return Cuenta; } }
        public double _monto { get { return Monto; } }

        public static List<Analisi_vvertical> Lista_analisis_verticalB = new List<Analisi_vvertical>();
        public static List<Analisi_vvertical> Lista_analisis_verticalE = new List<Analisi_vvertical>();
    }
}
