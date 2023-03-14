using Models.Enums;
using Models.Pools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleLogic.RutinaCompareXML.RutinaCasos
{
    internal class ValidaCasoPrueba
    {
        ValidaSubCasoPrueba _validaSubCasoPrueba = new ValidaSubCasoPrueba();
        internal void ComparaFacturaComercio(ModelPool casodePrueba)
        {
            throw new NotImplementedException();
        }

        internal void ComparaFacturaResidencial(ModelPool casodePrueba)
        {
            switch (casodePrueba.subcaso_prueba)
            {
                case SubCasoPrueba.Ip:
                    _validaSubCasoPrueba.ComparaSubcasoIp(casodePrueba);
                    break;
                case SubCasoPrueba.IpTv:
                    _validaSubCasoPrueba.ComparaSubcasoIpTv(casodePrueba);
                    break;
                default:
                    break;
            }
        }
    }
}
