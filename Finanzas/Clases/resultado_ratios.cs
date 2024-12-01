using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finanzas.Clases
{
    public class resultado_ratios
    {
        public double capital_trabajo;//
        public double razon_circulante;//
        public double razon_acido;//
        public double rotacion_inventarios;//
        public double rotacion_inventario_meses;//
        public double rotacion_inventario_diario;//
        public double rotacion_cuentas_cobrar;//
        public double periodo_promedio_cobro;//
        public double periodo_promedio_pago;//
        public double periodo_promedio_pago_meses;//
        public double rotacion_activos_fijos;//
        public double rotacion_activos_totales;//
        public double razon_deuda_total;//
        public double capacidad_pago_intereses;//
        public double margen_utilidad_bruta;//
        public double margen_utilidad_operativa;//
        public double margen_utilidad_neta;//
        public double rendimiento_activos;//
        public double rendimiento_capital_contable;//
        public double razon_precio_utilidades;//
        public double utilidad_por_accion;//
        public double razon_valor_de_mercado;//
        public double valor_en_libro_por_accion;//

        public resultado_ratios() {

        }

        public resultado_ratios(double Capital_Trabajo, double Razon_Circulante, double Razon_Acido, double Rotacion_Inventarios, double Rotacion_Inventario_Meses,
            double Rotacion_Inventario_diario, double Rotacion_Cuentas_Cobrar, double Periodo_Promedio_Cobro, double Periodo_promedio_pago, double Periodo_Promedio_Pago_Meses,
            double Rotacion_Activos_Fijos, double Rotacion_Activos_Totales, double Razon_deuda_Total, double Capacidad_pago_Intereses, double Margen_Utilidad_Bruta,
            double Margen_Utilidad_Operativa, double Margen_Utilidad_Neta, double rendimiento_Activos, double rendimiento_Capital_Contable, double Razon_Precio_Utilidades,
            double Utilidad_por_Accion, double Razon_valor_Mercado, double Valor_en_Libro_por_Accion)
        {

            capital_trabajo = Capital_Trabajo;
            razon_circulante = Razon_Circulante;
            razon_acido = Razon_Acido;
            rotacion_inventarios = Rotacion_Inventarios;
            rotacion_inventario_meses = Rotacion_Inventario_Meses;
            rotacion_inventario_diario = Rotacion_Inventario_diario;
            rotacion_cuentas_cobrar = Rotacion_Cuentas_Cobrar;
            periodo_promedio_cobro = Periodo_Promedio_Cobro;
            periodo_promedio_pago = Periodo_promedio_pago;
            periodo_promedio_pago_meses = Periodo_Promedio_Pago_Meses;
            rotacion_activos_fijos = Rotacion_Activos_Fijos;
            rotacion_activos_totales = Rotacion_Activos_Totales;
            razon_deuda_total = Razon_deuda_Total;
            capacidad_pago_intereses = Capacidad_pago_Intereses;
            margen_utilidad_bruta = Margen_Utilidad_Bruta;
            margen_utilidad_operativa = Margen_Utilidad_Operativa;
            margen_utilidad_neta = Margen_Utilidad_Neta;
            rendimiento_activos = rendimiento_Activos;
            rendimiento_capital_contable = rendimiento_Capital_Contable;
            razon_precio_utilidades = Razon_Precio_Utilidades;
            utilidad_por_accion = Utilidad_por_Accion;
            razon_valor_de_mercado = Razon_valor_Mercado;
            valor_en_libro_por_accion = Valor_en_Libro_por_Accion;


        }

        public double _capitaltrabajo { get { return capital_trabajo; } }
        public double _razoncirculante { get { return razon_circulante; } }
        public double _razonacido { get { return razon_acido; } }
        public double _rotacioninventario { get { return rotacion_inventarios; } }
        public double _rotinvmeses { get { return rotacion_inventario_meses; } }
        public double _rotinvdiario { get { return rotacion_inventario_diario; } }
        public double _rotcuentascobrar { get { return rotacion_cuentas_cobrar; } }
        public double _periodopromediocobro { get { return periodo_promedio_cobro; } }
        public double _periodoprompago { get { return periodo_promedio_pago; } }
        public double _periodoprompagomeses { get { return periodo_promedio_pago_meses; } }
        public double _rotacionactivosfijos { get { return rotacion_activos_fijos; } }
        public double _rotacionactivostotales { get { return rotacion_activos_totales; } }
        public double _razondeudatotal { get { return razon_deuda_total; } }
        public double _capacidadintereses {  get { return capacidad_pago_intereses; } }
        public double _margenutilidadbruta { get { return margen_utilidad_bruta; } }
        public double _margenutilidadneta { get { return margen_utilidad_neta; } }
        public double _rendimientoactivos { get { return rendimiento_activos; } }
        public double _rendimientocapitalcontable { get { return rendimiento_capital_contable; } }
        public double _razonprecioutilidades { get { return razon_precio_utilidades;} }
        public double _utilidadporaccion { get { return utilidad_por_accion; } }
        public double _razonvalormercado { get { return razon_valor_de_mercado;} }
        public double _valorlibroacciones { get { return valor_en_libro_por_accion; } }


        public static List<resultado_ratios> Lista_Resultado_Ratios = new List<resultado_ratios>();



            
            

    }
}
