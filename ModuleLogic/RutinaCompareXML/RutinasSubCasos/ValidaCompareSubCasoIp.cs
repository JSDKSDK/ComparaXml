using Models.Pools;
using Models.Reportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleLogic.RutinaCompareXML.RutinasSubCasos
{
    internal class ValidaCompareSubCasoIp
    {
        public static void Compararxml(ModelPool casodePrueba)
        {
            string filePath1 = casodePrueba.ubicacion + casodePrueba.file1;
            string filePath2 = casodePrueba.ubicacion + casodePrueba.file2;

            Dictionary<string, string> DiferenciasTagsXml1Xml2 = CompareXML.CompareXmlFilesByTag(filePath1, filePath2);



            foreach (var etiqueta in DiferenciasTagsXml1Xml2.Keys)
            {

                ReporteDiferencia reporteDiferencia = new ReporteDiferencia();

                reporteDiferencia.tipo_archivo=casodePrueba.tipo_archivo;
                reporteDiferencia.caso_prueba = casodePrueba.caso_factura;
                reporteDiferencia.subcaso_prueba = casodePrueba.subcaso_prueba;
                reporteDiferencia.file1 = casodePrueba.file1;
                reporteDiferencia.file2 = casodePrueba.file2;
                string diferencia = "La etiqueta "+ etiqueta+" tiene diferencias: "+DiferenciasTagsXml1Xml2[etiqueta];
                reporteDiferencia.diferencias = diferencia;

                OrquestadorCasosPrueba.Lista_diferencias_archivos.Add(reporteDiferencia);


                Console.WriteLine($"La etiqueta {etiqueta} tiene diferencias: {DiferenciasTagsXml1Xml2[etiqueta]}");
            }
        }
    }
}
