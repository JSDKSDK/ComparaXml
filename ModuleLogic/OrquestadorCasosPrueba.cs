using Models.Enums;
using Models.Pools;
using Models.Reportes;
using ModuleLogic.RutinaCompareXML.RutinaCasos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.reportes;

namespace ModuleLogic
{
    public class OrquestadorCasosPrueba
    {
        ValidaCasoPrueba Validarxml= new ValidaCasoPrueba();
        public List<ModelPool> ListaCasosPrueba = new List<ModelPool>();
        public static List<ReporteDiferencia> Lista_diferencias_archivos = new List<ReporteDiferencia>();



        public void Orquestador()
        {
            foreach (ModelPool CasodePrueba in ListaCasosPrueba)
            {

                switch (CasodePrueba.tipo_archivo)
                {
                    case Tipo_Archivo.xml:
                        ComparaXml(CasodePrueba);
                        break;
                    case Tipo_Archivo.pdf:
                        ComparaPdf(CasodePrueba);
                        break;
                    default:
                        break;
                }
            }

            GenerarXLS();

        }

        private void ComparaPdf(ModelPool casodePrueba)
        {
            throw new NotImplementedException();
        }

        private void ComparaXml(ModelPool casodePrueba)
        {
            switch (casodePrueba.caso_factura)
            {
                case Casos_Factura.Factura_residencial:
                    Validarxml.ComparaFacturaResidencial(casodePrueba);
                    break;
                case Casos_Factura.Factura_Comercio:
                    Validarxml.ComparaFacturaComercio(casodePrueba);
                    break;
                default:
                    break;
            }
        }


        private void GenerarXLS()
        {


            var demoTable = new DataTable("Respuestas");
            string archivo = Guid.NewGuid().ToString() + ".xlsx";
            demoTable.Columns.Add("Tipo_Archivo");
            demoTable.Columns.Add("Caso_prueba");
            demoTable.Columns.Add("Subcaso_prueba");
            demoTable.Columns.Add("file1");
            demoTable.Columns.Add("file2");
            demoTable.Columns.Add("diferencias");

            foreach (ReporteDiferencia Respuesta in Lista_diferencias_archivos)
            {

                demoTable.Rows.Add(new Object[] {
                    Respuesta.tipo_archivo,
                    Respuesta.caso_prueba,
                    Respuesta.subcaso_prueba,
                    Respuesta.file1,
                    Respuesta.file2,
                    Respuesta.diferencias
                     });

            }

            GeneraReporte.BuildExcel(demoTable, archivo);
            Process.Start(archivo);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("!!!!!PROCESO TERMINADO!!!!!!");
           
        }
    }
}
