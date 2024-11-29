using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finanzas.Clases
{
    public class Apalancamiento
    {
        string Cuenta;
        double Monto;

        public Apalancamiento()
        {
        }
        public Apalancamiento(string cuenta, double monto)
        {
            Cuenta = cuenta;
            Monto = monto;
        }

        public string _cuenta { get { return Cuenta; } }
        public double _monto { get { return Monto; } }

        public static List<Analisi_vvertical> Lista_apalancamiento_E = new List<Analisi_vvertical>();

    }
}
