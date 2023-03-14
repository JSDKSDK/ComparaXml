using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Pools
{
    public class ModelPool
    {
        public Tipo_Archivo tipo_archivo
        {
            get { return _tipo_archivo; }
            set { _tipo_archivo = value; }
        }
        private Tipo_Archivo _tipo_archivo;
        public Casos_Factura caso_factura
        {
            get { return _caso_factura; }
            set { _caso_factura = value; }
        }
        private Casos_Factura _caso_factura;

        public SubCasoPrueba subcaso_prueba
        {
            get { return _subcasoprueba; }
            set { _subcasoprueba = value; }
        }
        private SubCasoPrueba _subcasoprueba;

        public string file1
        {
            get { return _file1; }
            set { _file1 = value.Trim(); }
        }
        private string _file1;
        public string file2
        {
            get { return _file2; }
            set { _file2 = value.Trim(); }
        }
        private string _file2;
        public string ubicacion
        {
            get { return _ubicacion; }
            set { _ubicacion = value.Trim(); }
        }
        private string _ubicacion;


    }
}
