using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finanzas.Clases
{
    public class Ratios_Finanacieros
    {
        string Cuenta;
        double Monto;

        public Ratios_Finanacieros()
        {

        }
        public Ratios_Finanacieros(string cuenta, double monto)
        {
            Cuenta = cuenta;
            Monto = monto;
        }

        public string _cuenta { get { return Cuenta; } }
        public double _monto { get { return Monto; } }

        public static List<Ratios_Finanacieros> Lista_Ratios_B = new List<Ratios_Finanacieros>();
        public static List<Ratios_Finanacieros> Lista_Ratios_E = new List<Ratios_Finanacieros>();

    }
}
