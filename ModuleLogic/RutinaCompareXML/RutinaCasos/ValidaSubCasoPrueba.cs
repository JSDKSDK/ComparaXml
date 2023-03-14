using Models.Pools;
using ModuleLogic.RutinaCompareXML.RutinasSubCasos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleLogic.RutinaCompareXML.RutinaCasos
{
    internal class ValidaSubCasoPrueba
    {
        internal void ComparaSubcasoIp(ModelPool casodePrueba)
        {
            ValidaCompareSubCasoIp.Compararxml(casodePrueba);
        }

        internal void ComparaSubcasoIpTv(ModelPool casodePrueba)
        {
            throw new NotImplementedException();
        }
    }
}
