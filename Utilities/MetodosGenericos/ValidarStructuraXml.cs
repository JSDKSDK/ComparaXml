using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Utilities.MetodosGenericos
{
    public class ValidarStructuraXml
    {
        public List<string> GetXmlTags(XmlNode node)
        {
            List<string> tags = new List<string>();

            // Obtener etiqueta del nodo actual
            string tag = node.Name;
            if (!tags.Contains(tag))
            {
                tags.Add(tag);
            }

            // Obtener etiquetas de los nodos hijos
            foreach (XmlNode child in node.ChildNodes)
            {
                tags.AddRange(GetXmlTags(child));
            }

            return tags;
        }

        public  Dictionary<string, string> ObtenerEtiquetasConValor(string rutaArchivoXml)
        {
            // Cargar el archivo XML
            XmlDocument doc = new XmlDocument();
            doc.Load(rutaArchivoXml);

            // Crear un diccionario para almacenar los pares de clave-valor
            Dictionary<string, string> etiquetas = new Dictionary<string, string>();

            // Obtener todas las etiquetas del documento que tienen un valor
            XmlNodeList nodes = doc.SelectNodes("//*[string-length(text()) > 0]");

            // Recorrer todas las etiquetas del documento que tienen un valor
            foreach (XmlNode node in nodes)
            {
                // Agregar la etiqueta y su valor al diccionario
                etiquetas.Add(node.Name, node.InnerText);
            }

            // Devolver el diccionario
            return etiquetas;
        }

        public Dictionary<string, string> CompararEtiquetas(Dictionary<string, string> dic1, Dictionary<string, string> dic2)
        {
            var diferencias = new Dictionary<string, string>();

            foreach (var etiqueta in dic1.Keys)
            {
                if (dic2.ContainsKey(etiqueta) && dic1[etiqueta] != dic2[etiqueta])
                {
                    diferencias.Add(etiqueta, $"Valor en archivo 1: {dic1[etiqueta]}. Valor en archivo 2: {dic2[etiqueta]}");
                }
                else if (!dic2.ContainsKey(etiqueta))
                {
                    diferencias.Add(etiqueta, $"Valor en archivo 1: {dic1[etiqueta]}. Valor en archivo 2: No se encontró la etiqueta");
                }
            }

            foreach (var etiqueta in dic2.Keys)
            {
                if (!dic1.ContainsKey(etiqueta))
                {
                    diferencias.Add(etiqueta, $"Valor en archivo 1: No se encontró la etiqueta. Valor en archivo 2: {dic2[etiqueta]}");
                }
            }

            return diferencias;
        }

    }
}
