using Models.Pools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Utilities.MetodosGenericos;

namespace ModuleLogic.RutinaCompareXML
{

    public  class CompareXML
    {
        static ValidarStructuraXml validarXml = new ValidarStructuraXml();
        public static Dictionary<string, string> CompareXmlFilesByTag(string filePath1, string filePath2)
        {

            XmlDocument doc1 = new XmlDocument();
            XmlDocument doc2 = new XmlDocument();

            Dictionary<string, string> DiferenciasTagsXml1Xml2 = new Dictionary<string, string>();

            // Cargamos los archivos XML
            doc1.Load(filePath1);
            doc2.Load(filePath2);

            //// Validamos si tienen la misma estructura

            // Obtener lista de todas las etiquetas presentes en cada documento
            List<string> tagsXml1 = validarXml.GetXmlTags(doc1.DocumentElement);
            List<string> tagsXml2 = validarXml.GetXmlTags(doc2.DocumentElement);
          
            // Comparar si las listas de etiquetas son iguales
            if (tagsXml1.SequenceEqual(tagsXml2))
            {
                Console.WriteLine("Los archivos tienen la misma estructura de etiquetas");

                //Obtenemos los valores de las etiquetas
                Dictionary<string, string> tagsXml1value = validarXml.ObtenerEtiquetasConValor(filePath1);
                Dictionary<string, string> tagsXml2value = validarXml.ObtenerEtiquetasConValor(filePath2);

                //Comparamos los valores de las etiquetas
                DiferenciasTagsXml1Xml2 = validarXml.CompararEtiquetas(tagsXml1value, tagsXml2value);

            }
            else
            {
                Console.WriteLine("Los archivos no tienen la misma estructura de etiquetas");
            }



            return DiferenciasTagsXml1Xml2;
        }

    }
}
