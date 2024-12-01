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
        double Monto_1;
        double Monto_2;

        public Apalancamiento()
        {
        }
        public Apalancamiento(string cuenta, double monto_1, double monto_2)
        {
            Cuenta = cuenta;
            Monto_1 = monto_1;
            Monto_2 = monto_2;
        }

        public string _cuenta { get { return Cuenta; } }
        public double _monto { get { return Monto_1; } }
        public double _monto2 { get { return Monto_2; } }

        public static List<Apalancamiento> Lista_apalancamiento_E = new List<Apalancamiento>();

    }
}
