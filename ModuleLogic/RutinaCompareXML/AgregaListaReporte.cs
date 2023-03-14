using Models.Pools;
using Models.Reportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleLogic.RutinaCompareXML
{
    public class AgregaListaReporte
    {
        public static void agregaListaReporte(ModelPool casodePrueba, string diferencia) {

            ReporteDiferencia reporteDiferencia = new ReporteDiferencia();

            reporteDiferencia.tipo_archivo = casodePrueba.tipo_archivo;
            reporteDiferencia.caso_prueba = casodePrueba.caso_factura;
            reporteDiferencia.subcaso_prueba = casodePrueba.subcaso_prueba;
            reporteDiferencia.file1 = casodePrueba.file1;
            reporteDiferencia.file2 = casodePrueba.file2;
            reporteDiferencia.diferencias = diferencia;

            OrquestadorCasosPrueba.Lista_diferencias_archivos.Add(reporteDiferencia);
        }
    }
}
