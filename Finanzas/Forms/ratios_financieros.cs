using Finanzas.Clases;
using OfficeOpenXml;
using ReaLTaiizor.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace Finanzas.Forms
{
    public partial class ratios_financieros : Form
    {
        public ratios_financieros()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //IMPORTE DEL ESTADO DE RESULTADO

            ESTADOS_RESULTADO();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //IMPORTE DEL BALANCE GENERAL
            BALANCEGENERAL();

        }

        private void airButton1_Click(object sender, EventArgs e)
        {
            calculos();
            creacionpdf(resultado_ratios.Lista_Resultado_Ratios);
            limpiar();
            
        }

        private void limpiar()
        {
            Ratios_Finanacieros.Lista_Ratios_E.Clear();
            Ratios_Finanacieros.Lista_Ratios_B.Clear();
            resultado_ratios.Lista_Resultado_Ratios.Clear();
        }

        private void calculos()
        {
            if (!Ratios_Finanacieros.Lista_Ratios_E.Any() || !Ratios_Finanacieros.Lista_Ratios_B.Any())
            {
                MessageBox.Show("Hace falta recursos para realilzar el analisis");

            }else
            {
                //capital de trabajo
                var activos_circulante = Ratios_Finanacieros.Lista_Ratios_B.FirstOrDefault(p => p._cuenta == "activos circulantes");
                var pasivo_circulante = Ratios_Finanacieros.Lista_Ratios_B.FirstOrDefault(p => p._cuenta == "pasivos circulantes");
                double capital_trabajo;
                if (activos_circulante != null && pasivo_circulante != null)
                {
                    capital_trabajo = Convert.ToDouble(activos_circulante._monto - pasivo_circulante._monto);
                    MessageBox.Show($"el resultado de esto es: {capital_trabajo.ToString("F4")}");

                }
                else
                {
                    capital_trabajo = 0;
                    MessageBox.Show("hace falta una cuenta para realizar el capital de trabajo");
                }

                //razon circulante

                double razon_circulante;

                if (activos_circulante != null && pasivo_circulante != null)
                {
                    razon_circulante = Convert.ToDouble(activos_circulante._monto / pasivo_circulante._monto);
                    MessageBox.Show($"el resultado de la razon circulante es de:{razon_circulante.ToString("F4")} ");

                }
                else
                {
                    MessageBox.Show("no se ha encontrado las cuentas del activo y pasivo circulante por lo tanto no se ha podido realizar la razon circulante");
                    razon_circulante = 0;
                }

                //prueba del acido

                var inventarios = Ratios_Finanacieros.Lista_Ratios_B.FirstOrDefault(p => p._cuenta == "inventarios");
                double razon_acido;
                if (inventarios != null)
                {

                    razon_acido = Convert.ToDouble((activos_circulante._monto - inventarios._monto) / pasivo_circulante._monto);
                    MessageBox.Show($"la prueba del acido dio un resultado de: {razon_acido.ToString("F4")}");

                }
                else
                {
                    razon_acido = 0;
                    MessageBox.Show("no se ha encontrado una cuenta para realizar la prueba del acido");

                }

                //rotacion de inventarios

                var costo_venta = Ratios_Finanacieros.Lista_Ratios_E.FirstOrDefault(p => p._cuenta == "costo de venta");
                double rotacion_inventario;
                double rotacion_inventario_meses;
                double rotacion_inventario_diario;

                if (costo_venta != null)
                {
                    rotacion_inventario = Convert.ToDouble(costo_venta._monto / inventarios._monto);
                    MessageBox.Show($"la rotacion de inventarios anual es de: {rotacion_inventario.ToString("F4")}");

                    rotacion_inventario_meses = rotacion_inventario / 12;
                    MessageBox.Show($"la rotacion de inventario en mese es de: {rotacion_inventario_meses.ToString("F4")}");

                    rotacion_inventario_diario = rotacion_inventario / 360;
                    MessageBox.Show($"La rotacion de invetario en dias es de: {rotacion_inventario_diario.ToString("F4")}");
                }
                else
                {
                    rotacion_inventario = 0;
                    rotacion_inventario_diario = 0;
                    rotacion_inventario_meses = 0;
                    MessageBox.Show("no se ha encontrado el costo de venta para realizar la rotacion de inventario");
                }

                //rotacion de cuentas por cobrar
                var ventas_al_credito = Ratios_Finanacieros.Lista_Ratios_B.FirstOrDefault(p => p._cuenta == "ventas al credito");
                var cuentas_cobrar_netas = Ratios_Finanacieros.Lista_Ratios_B.FirstOrDefault(p => p._cuenta == "cuentas por cobrar netas");
                double rotacion_cuentas_cobrar;

                if (ventas_al_credito != null && cuentas_cobrar_netas != null)
                {
                    rotacion_cuentas_cobrar = Convert.ToDouble(ventas_al_credito._monto / cuentas_cobrar_netas._monto);
                    MessageBox.Show($"el resultado de la rotacion de cuentas por cobrar es de: {rotacion_cuentas_cobrar.ToString("F2")}");
                }
                else
                {
                    MessageBox.Show("No se ha realizado la razon de la cuentas por cobrar por falta de datos");
                    rotacion_cuentas_cobrar = 0;
                }

                //periodo promedio de cobro

                var ventas_netas = Ratios_Finanacieros.Lista_Ratios_E.FirstOrDefault(p => p._cuenta == "VENTAS NETAS");

                double periodo_promedio_cobro;

                if (cuentas_cobrar_netas != null)
                {

                    double ventas_diarias = Convert.ToDouble(ventas_netas._monto / 360);
                    periodo_promedio_cobro = Convert.ToDouble(cuentas_cobrar_netas._monto / ventas_diarias);
                    MessageBox.Show($"el periodo promedio de cobro es de: {periodo_promedio_cobro.ToString("F2")}");

                }
                else
                {
                    MessageBox.Show("no se ha encontrado la cuentas de cuenta por cobrar netas");
                    periodo_promedio_cobro = 0;

                }

                //periodo promedio de pago
                var cuentas_pagar = Ratios_Finanacieros.Lista_Ratios_B.FirstOrDefault(p => p._cuenta == "cuentas por pagar");
                var compras = Ratios_Finanacieros.Lista_Ratios_E.FirstOrDefault(p => p._cuenta == "compras totales");

                double periodo_promedio_pago;

                if (cuentas_pagar != null && compras != null)
                {

                    double compras_diarias = compras._monto / 360;
                    periodo_promedio_pago = Convert.ToDouble(cuentas_pagar._monto / compras_diarias);
                    MessageBox.Show($"el resultado de promedio de pago es de:{periodo_promedio_pago.ToString("F4")} ");

                    // periodo promedio de pago en meses
                    periodo_promedio_pago = Convert.ToDouble((cuentas_pagar._monto * 12) / compras_diarias);
                    MessageBox.Show($"el resultado de promedio de pago en meses es de:{periodo_promedio_pago.ToString("F4")} ");

                }
                else
                {

                    MessageBox.Show("no se ha encontrado una de las siguientes cuentas: cuentas por pagar o compras totales");
                    periodo_promedio_pago = 0;
                }

                //rotacion de activos fijos
                var activos_fijos = Ratios_Finanacieros.Lista_Ratios_B.FirstOrDefault(p => p._cuenta == "activos fijos netos");
                double rotacion_activos_fijos;

                if (activos_fijos != null && ventas_netas != null)
                {
                    rotacion_activos_fijos = Convert.ToDouble(ventas_netas._monto / activos_fijos._monto);
                    MessageBox.Show($"el resultado de la rotacin de los activos fijos es de: {rotacion_activos_fijos.ToString("F4")}");

                }
                else
                {

                    MessageBox.Show("no se ha podido encontrar la cuenta: activos fijos netos o ventas netas");
                    rotacion_activos_fijos = 0;

                }

                //rotacion de activos totales
                var activos_totales = Ratios_Finanacieros.Lista_Ratios_B.FirstOrDefault(p => p._cuenta == "activos totales");
                double rotacion_activos_totales;

                if (activos_totales != null)
                {
                    rotacion_activos_totales = Convert.ToDouble(ventas_netas._monto / activos_totales._monto);
                    MessageBox.Show($"la rotacin de los activos totales es de: {rotacion_activos_totales.ToString("F4")}");

                }
                else
                {

                    MessageBox.Show("no se ha encontrado la cuenta de activos totales ");
                    rotacion_activos_totales = 0;
                }

                //razon de deuda total

                var pasivo_total = Ratios_Finanacieros.Lista_Ratios_B.FirstOrDefault(p => p._cuenta == "pasivo total");
                double razon_deuda_total;

                if (pasivo_total != null)
                {

                    razon_deuda_total = Convert.ToDouble(pasivo_total._monto / activos_totales._monto);
                    MessageBox.Show($"el resultado de la razon de deuda total es de: {razon_deuda_total.ToString("F4")}");
                }
                else
                {
                    MessageBox.Show("No se ha podido encontrar cuenta para realizar la razon de endeudamiento total");
                    razon_deuda_total = 0;
                }

                //capacidad de pago de los intereses
                var UAII = Ratios_Finanacieros.Lista_Ratios_E.FirstOrDefault(p => p._cuenta == "UAII");
                var intereses = Ratios_Finanacieros.Lista_Ratios_E.FirstOrDefault(p => p._cuenta == "Intereses");
                double capacidad_pago_intereses;

                if (UAII != null)
                {

                    capacidad_pago_intereses = Convert.ToDouble(UAII._monto / intereses._monto);
                    MessageBox.Show($"la capacidad de pago de los intereses es de: {capacidad_pago_intereses.ToString("F4")}");

                }
                else
                {
                    MessageBox.Show("no se ha encontrado la utilidad antes de intereses e impuesto");
                    capacidad_pago_intereses = 0;
                }

                //margen de utilidad bruta

                double margen_utilidad_bruta;

                if (ventas_netas != null)
                {
                    margen_utilidad_bruta = Convert.ToDouble((ventas_netas._monto - costo_venta._monto) / ventas_netas._monto);
                    MessageBox.Show($"el margen de utilidad bruta es de :{margen_utilidad_bruta.ToString("F4")}");

                }
                else
                {
                    MessageBox.Show("No se ha encontrado las ventas netas o costo de venta  para realizar el margen de utilidad bruta");
                    margen_utilidad_bruta = 0;
                }

                //margen de utilidad operativa

                var utilidad_operativa = Ratios_Finanacieros.Lista_Ratios_E.FirstOrDefault(p => p._cuenta == "utilidad operativa");
                double margen_utilidad_operativa;

                if (utilidad_operativa != null)
                {
                    margen_utilidad_operativa = Convert.ToDouble(utilidad_operativa._monto / ventas_netas._monto);
                    MessageBox.Show($"el margen de utilidad operativa es de: {margen_utilidad_operativa.ToString("F4")}");

                }
                else
                {
                    MessageBox.Show("No se ha encontrado la cuenta de utilidad operativa para calcular el margen de utilidad operativa");
                    margen_utilidad_operativa = 0;
                }

                //margen utilidad neta

                var UDII = Ratios_Finanacieros.Lista_Ratios_E.FirstOrDefault(p => p._cuenta == "UDII");
                double margen_utilidad_neta;

                if (UDII != null)
                {

                    margen_utilidad_neta = Convert.ToDouble(UDII._monto / ventas_netas._monto);
                    MessageBox.Show($"el margen de utilidad neta es de: {margen_utilidad_neta.ToString("F4")}");
                }
                else
                {
                    MessageBox.Show("No se ha encontrado la cuenta UDDI para el margen de utilidad neta");
                    margen_utilidad_neta = 0;
                }

                //rendimiento de los activos

                double rendiiento_activos;

                if (UDII != null)
                {

                    rendiiento_activos = Convert.ToDouble(UDII._monto / activos_totales._monto);
                    MessageBox.Show($"El rendimiento de los activos es de: {rendiiento_activos.ToString("F4")} ");

                }
                else
                {
                    MessageBox.Show("no se ha encontrado la cuenta UDII para realizar el rendimiento de los activos");
                    rendiiento_activos = 0;
                }

                //Rendimiento sobre e capital

                var capital_contable = Ratios_Finanacieros.Lista_Ratios_B.FirstOrDefault(p => p._cuenta == "capital contable");
                double rendimiento_sobre_capital;

                if (capital_contable != null)
                {
                    rendimiento_sobre_capital = Convert.ToDouble(UDII._monto / capital_contable._monto);
                    MessageBox.Show($"el rendimiento sobre el capital contavle es de: {rendimiento_sobre_capital.ToString("F4")}");

                }
                else
                {
                    MessageBox.Show("no e ha encontrado  el capital contable para realizar el rendimiento sobre el capital");
                    rendimiento_sobre_capital = 0;
                }

                //razon precio/utilidades
                var precio_accion = Ratios_Finanacieros.Lista_Ratios_E.FirstOrDefault(p => p._cuenta == "Precio por accion");
                var UPA = Ratios_Finanacieros.Lista_Ratios_E.FirstOrDefault(p => p._cuenta == "utilidad por accion");
                double Razon_precio_utilidades;

                if (precio_accion != null && UPA != null)
                {

                    Razon_precio_utilidades = Convert.ToDouble(precio_accion._monto / UPA._monto);
                    MessageBox.Show($"la razon precio-utilidad es de: {Razon_precio_utilidades.ToString("F4")}");
                }
                else
                {
                    MessageBox.Show("hace falta cuentas para hacer la razon precio/utilidad : precio por accion o UPA");
                    Razon_precio_utilidades = 0;
                }

                //utilidades por accion
                var utilidad_disponible = Ratios_Finanacieros.Lista_Ratios_E.FirstOrDefault(p => p._cuenta == "utilidad neta para accionistas");
                var numero_acciones_comunes = Ratios_Finanacieros.Lista_Ratios_E.FirstOrDefault(p => p._cuenta == "numero de acciones comunes");
                double utilidad_accion;

                if (utilidad_disponible != null && numero_acciones_comunes != null)
                {
                    utilidad_accion = Convert.ToDouble(utilidad_disponible._monto / numero_acciones_comunes._monto);
                    MessageBox.Show($"La utilidad por accion es de: {utilidad_accion.ToString("F4")}");

                }
                else
                {
                    MessageBox.Show("no se ha podido encontarr una de las siguientes cuentas para realizar el calculo de utilidad por accion: " +
                        "utilidad neta para accionistas o numero de acciones comunes");
                }
                utilidad_accion = 0;

                //rendiento capital contable


                resultado_ratios resultados = new resultado_ratios(capital_trabajo, razon_circulante, razon_acido, rotacion_inventario, rotacion_inventario_meses, rotacion_inventario_diario, rotacion_cuentas_cobrar,
                    periodo_promedio_cobro, periodo_promedio_pago, rotacion_activos_fijos, rotacion_activos_totales, razon_deuda_total, capacidad_pago_intereses, margen_utilidad_bruta, margen_utilidad_operativa, margen_utilidad_neta,
                    rendiiento_activos, rendimiento_sobre_capital, Razon_precio_utilidades, utilidad_accion);

                resultado_ratios.Lista_Resultado_Ratios.Add(resultados);

            }

        }

        private void creacionpdf(List<resultado_ratios> lista_Resultado_Ratios)

        {
            if (!Ratios_Finanacieros.Lista_Ratios_E.Any() || !Ratios_Finanacieros.Lista_Ratios_B.Any())
            {
                MessageBox.Show("Hace falta recursos para realilzar el analisis");
            }
            else
            {
                var capital_trabajo = lista_Resultado_Ratios.FirstOrDefault(p => p.capital_trabajo != null);
                string capital_t = capital_trabajo._capitaltrabajo.ToString("N4");
                // var razon_circulante = lista_Resultado_Ratios.FirstOrDefault(p => p.razon_circulante != null);
                string razon_cir = capital_trabajo._razoncirculante.ToString("N4");
                string prueba_acido = capital_trabajo._razonacido.ToString("N4");
                string rotacion_inventario = capital_trabajo._rotacioninventario.ToString("N4");
                string rotacion_inventario_meses = capital_trabajo._rotinvmeses.ToString("N4");
                string rotacion_inventario_dias = capital_trabajo._rotinvdiario.ToString("N4");
                string cuentas_cobrar = capital_trabajo.rotacion_cuentas_cobrar.ToString("N4");
                string periodo_promedio_cobro = capital_trabajo._periodopromediocobro.ToString("N4");
                string perrido_promedio_pago = capital_trabajo._periodoprompago.ToString("N4");
                string rotacion_activos_fijo = capital_trabajo._rotacionactivosfijos.ToString("N4");
                string rotacion_activos_totales = capital_trabajo._rotacionactivostotales.ToString("N4");
                string razon_deuda_total = capital_trabajo._razondeudatotal.ToString("N4");
                string capacidad_pago_inetreses = capital_trabajo._capacidadintereses.ToString("N4");
                string margen_utilidad_bruta = capital_trabajo._margenutilidadbruta.ToString("N4");
                string margen_utilidad_operativa = capital_trabajo._margenutilidadop.ToString("N4");
                string margen_utilidad_neta = capital_trabajo._margenutilidadneta.ToString("N4");
                string rendimiento_activos = capital_trabajo._rendimientoactivos.ToString("N4");//                    
                string rendimiento_capital_contable = capital_trabajo._rendimientocapitalcontable.ToString("N4");//
                string Razon_precio_utilidades = capital_trabajo._razonprecioutilidades.ToString("N4");//
                string utilidad_accion = capital_trabajo._utilidadporaccion.ToString("N4");//

                var ratios = new List<(string Nombre, string Valor)>
            {


                 ("Capital trabajo",capital_t),
                 ("Razón circulante", razon_cir),
                 ("Razon Prueba del acido",prueba_acido),
                 ("Rotacion de Inventario",rotacion_inventario),
                 ("Rotacion de inventario en meses",rotacion_inventario_meses),
                 ("Rotacion de inventario rn dias",rotacion_inventario_dias),
                 ("Rotacion de cuentas por cobrar",cuentas_cobrar),
                 ("Periodo Promedio de Cobro",periodo_promedio_cobro),
                 ("Periodo Promedio de pago",perrido_promedio_pago ),
                 ("Rotacion de activos fijos", rotacion_activos_fijo),
                 ("Rotacion de activos totales", rotacion_activos_totales),
                 ("Razon Deuda total",razon_deuda_total),
                 ("Capacidad de pago de intereses",capacidad_pago_inetreses),
                 ("Margen de utilidad Bruta", margen_utilidad_bruta),
                 ("Margen Utilidad Operativa",margen_utilidad_operativa),
                 ("Margen de Utilidad Neta",margen_utilidad_neta),
                 ("rendimiento de los activos", rendimiento_activos),
                 ("Rendimiento del capital contable",rendimiento_capital_contable),
                 ("Razon Precio Utilidad",Razon_precio_utilidades),
                 ("Utilidad por Accion", utilidad_accion)

                // Aquí no se incluirán valores no calculables
            };

                string directorio = Directory.GetCurrentDirectory();
                string fecha = DateTime.Now.ToString("yyyy/MM/dd");
                string archivo = "Ratios Financieros_.pdf";
                string path = Path.Combine(directorio, archivo);


                using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    iTextSharp.text.Document documento = new iTextSharp.text.Document(PageSize.A4);
                    PdfWriter writer = PdfWriter.GetInstance(documento, fs);
                    documento.Open();

                    iTextSharp.text.Font titleFont = FontFactory.GetFont("Arial", 16);
                    Paragraph title = new Paragraph("Reporte de Ratios Financieros", titleFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    documento.Add(title);
                    documento.Add(new Paragraph("\n"));

                    PdfPTable table = new PdfPTable(2);
                    table.AddCell("Ratio");
                    table.AddCell("Valor");

                    foreach (var g in ratios)
                    {
                        if (Convert.ToDouble(g.Valor) != 0)
                        {
                            table.AddCell(g.Nombre);
                            table.AddCell(g.Valor);
                        }

                    }

                    documento.Add(table);

                    MessageBox.Show($"{Convert.ToDouble(capital_t)}");
                    documento.Add(new Paragraph("\n"));

                    if (Convert.ToDouble(capital_t) != 0)
                    {
                        if (Convert.ToDouble(capital_t) > 0)
                        {
                            documento.Add(new Paragraph("Como el capital de trbajo es positivo este excedente se puede ocupra para la generacion de mas utilidades"));
                        }
                        else
                        {
                            documento.Add(new Paragraph("Como el capital de trbajo es negativo nos quiere decir que todavia no se ha recuperado el dinero por lo tanto se esta utillizando"));
                        }
                    }
                    
                    documento.Add(new Paragraph("\n"));
                    if (Convert.ToDouble(razon_cir) != 0)
                    {
                        documento.Add(new Paragraph($"La razon circulante nos indica que los pasivos circulantes estan cubierto un {razon_cir} veces por los activos circulantes que " +
                            $"se esperan que se conviertan en efectivo. "));
                        documento.Add(new Paragraph("\n"));
                    }
                    
                    if (Convert.ToDouble(prueba_acido) != 0)
                    {
                        documento.Add(new Paragraph($"La razon rapida o la prueba del acido nos indica que los pasivos circulantes estan cubiertos un {prueba_acido} veces por los activos circulantes " +
                            $"sin contar con que el inventario se convierta en efectvo."));
                        documento.Add(new Paragraph("\n"));
                    }
                    
                    if (Convert.ToDouble(rotacion_inventario) != 0)
                    {
                        documento.Add(new Paragraph($"El inventario rotó {rotacion_inventario} veces anualmente, rotando mensualmente un {rotacion_inventario_meses} veces y diariamente rotando un" +
                            $" {rotacion_inventario_dias} veces."));
                        documento.Add(new Paragraph("\n"));
                    }
                    
                    if (Convert.ToDouble(cuentas_cobrar) != 0)
                    {
                        documento.Add(new Paragraph($"El Grado de liquidez de las cuentas de clientes es de: {cuentas_cobrar}"));
                        documento.Add(new Paragraph("\n"));

                    }
                    
                    if (Convert.ToDouble(periodo_promedio_cobro) !=0 )
                    {
                        documento.Add(new Paragraph($"El periodo promedio de cobro de las cuentas por cobrar es de: {periodo_promedio_cobro} dias"));
                        documento.Add(new Paragraph("\n"));

                    }
                   
                    if (Convert.ToDouble(perrido_promedio_pago) != 0)
                    {
                        documento.Add(new Paragraph($"El promedio de dias que la empresa le toma pagar sus compras al credito fue de: {perrido_promedio_pago} dias" ));
                        documento.Add(new Paragraph("\n"));
                    }
                    
                    if (Convert.ToDouble(rotacion_activos_fijo) != 0)
                    {
                        documento.Add(new Paragraph($"Los activos fijos rotaron anualmente un {rotacion_activos_fijo} veces."));
                        documento.Add(new Paragraph("\n"));

                    }
                    
                    if (Convert.ToDouble(rotacion_activos_totales) != 0)
                    {
                        documento.Add(new Paragraph($"La rotacion de todos los activos totales representa una eficacia para de {rotacion_activos_totales} con la que la empresa" +
                            $"utiliza sus activos para la generacion de ventas"));
                        documento.Add(new Paragraph("\n"));
                    }
                   
                    if (Convert.ToDouble(razon_deuda_total) != 0)
                    {
                        documento.Add(new Paragraph($"La proporcion de los activos totales estan financiados por los acreedores es de {razon_deuda_total}"));
                        documento.Add(new Paragraph("\n"));
                    }
                    
                    if (Convert.ToDouble(capacidad_pago_inetreses) != 0 )
                    {
                        documento.Add(new Paragraph($"La capacidad de pago de los intereses de la empresa es de: {capacidad_pago_inetreses}"));
                        documento.Add(new Paragraph("\n"));
                    }
                    
                    if (Convert.ToDouble(margen_utilidad_bruta) != 0)
                    {
                        documento.Add(new Paragraph($"El porcentaje de cada unidad de dinero que queda cuando la empresa paga sus productos es de: {margen_utilidad_bruta}"));
                        documento.Add(new Paragraph("\n"));

                    }
                    
                    if (Convert.ToDouble(margen_utilidad_operativa) != 0)
                    {
                        documento.Add(new Paragraph($"El porcentaje de cada unidad de dinero que queda despues de reducir todos los costos" +
                            $" y gastos que no sean intereses e impuesto es de: {margen_utilidad_operativa}"));
                        documento.Add(new Paragraph("\n"));
                    }
                  
                    if (Convert.ToDouble(margen_utilidad_neta) != 0)
                    {
                        documento.Add(new Paragraph($"El porcetaje de cada unidad de dinero que queda despues de deducir los costos y gastos incluyendo los intereses e " +
                            $"impuestos es de: {margen_utilidad_neta}"));
                        documento.Add(new Paragraph("\n"));
                    }

                    if (Convert.ToDouble(rendimiento_activos) != 0)
                    {
                        documento.Add(new Paragraph($"La eficacia de la generncia para obtener utilidades con los activos disponibles despues de intereses e " +
                            $"impuestos es de : {rendimiento_activos}"));
                        documento.Add(new Paragraph("\n"));
                    }

                    if (Convert.ToDouble(rendimiento_capital_contable) != 0)
                    {
                        documento.Add(new Paragraph($"El rendimiento obtenido de la inversion de los propietarios es de: {rendimiento_capital_contable}"));
                        documento.Add(new Paragraph("\n"));
                    }

                    if (Convert.ToDouble(Razon_precio_utilidades) != 0)
                    {
                        documento.Add(new Paragraph($"La unidades de dinero que los inversionistas pagaran por cada unidad de utilidades actuales es de: {Razon_precio_utilidades} "));

                    }


                    documento.Close();
                }

                MessageBox.Show($"el archivo se ha creado exitosamente con el nombre {archivo}");


            }



        }

        private void BALANCEGENERAL()
        {
            OpenFileDialog import = new OpenFileDialog();
            import.Filter = "Archivos Excel|*.xlsx;*.xlsm";

            if (import.ShowDialog() == DialogResult.OK)
            {
                string archivo = import.FileName;

                try
                {
                    using (var package = new ExcelPackage(new FileInfo(archivo)))
                    {

                        var worksheet = package.Workbook.Worksheets[0];

                        // Leer las filas (comenzando desde la fila 2 si la primera fila tiene encabezados)
                        int filas = worksheet.Dimension.Rows;

                        for (int i = 2; i <= filas; i++) // Comenzamos desde 2 para saltar el encabezado
                        {
                            Ratios_Finanacieros ratios = new Ratios_Finanacieros(worksheet.Cells[i, 1].Text, Convert.ToDouble(worksheet.Cells[i, 2].Text));
                            Ratios_Finanacieros.Lista_Ratios_B.Add(ratios);

                        };
                    }

                   // dataGridView1.DataSource = Ratios_Finanacieros.Lista_Ratios_E;



                }
                catch (IOException)
                {

                    MessageBox.Show("NO SE HA PODIDO REALIZAR LA IMPORTACION DEL ARCHIVO");
                }
            }

        }

        private void ESTADOS_RESULTADO()
        {
            OpenFileDialog import = new OpenFileDialog();
            import.Filter = "Archivos Excel|*.xlsx;*.xlsm";

            if (import.ShowDialog() == DialogResult.OK)
            {
                string archivo = import.FileName;

                try
                {
                    using (var package = new ExcelPackage(new FileInfo(archivo)))
                    {

                        var worksheet = package.Workbook.Worksheets[0];

                        // Leer las filas (comenzando desde la fila 2 si la primera fila tiene encabezados)
                        int filas = worksheet.Dimension.Rows;

                        for (int i = 2; i <= filas; i++) // Comenzamos desde 2 para saltar el encabezado
                        {
                            Ratios_Finanacieros ratios = new Ratios_Finanacieros(worksheet.Cells[i, 1].Text, Convert.ToDouble(worksheet.Cells[i, 2].Text));
                            Ratios_Finanacieros.Lista_Ratios_E.Add(ratios);

                        };
                    }

                    // dataGridView1.DataSource = analisis.Lista_analisis_horizontalE;



                }
                catch (IOException)
                {

                    MessageBox.Show("NO SE HA PODIDO REALIZAR LA IMPORTACION DEL ARCHIVO");
                }
            }
        }


    }
}

