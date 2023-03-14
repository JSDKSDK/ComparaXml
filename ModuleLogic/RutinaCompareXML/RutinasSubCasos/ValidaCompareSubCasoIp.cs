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

            Dictionary<string, string> DiferenciasTagsXml1Xml2 = CompareXML.CompareXmlFilesByTag(filePath1, filePath2, casodePrueba);

            foreach (var etiqueta in DiferenciasTagsXml1Xml2.Keys)
            {
                string diferencia = "La etiqueta "+ etiqueta+" tiene diferencias: "+DiferenciasTagsXml1Xml2[etiqueta];
                AgregaListaReporte.agregaListaReporte(casodePrueba, diferencia);

            }
        }
    }
}
