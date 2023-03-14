using CsvHelper;
using Models.Pools;
using ModuleLogic;
using System.Globalization;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace Comparar
{
    public partial class CargarPool : Form
    {
        string url = "";
        bool continuar = false;
        List<ModelPool> ListaCasosPrueba = new List<ModelPool>();
        OrquestadorCasosPrueba Orquestador = new OrquestadorCasosPrueba();
        public CargarPool()
        {
            InitializeComponent();
        }

        private void CargarPool_Load(object sender, EventArgs e) { }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {

                using (var reader = new StreamReader(url, Encoding.Default, false))

                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    try
                    {
                        ListaCasosPrueba = csv.GetRecords<ModelPool>().ToList();
                        MessageBox.Show(string.Format("Pool de Datos Cargado correctamente."));
                        continuar = true;
                        

                    }
                    catch (Exception)
                    {
                        btnexecute.Visible = false;
                        throw new Exception("El elemento no es válido");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ha ocurrido un error al leer tu Pool de Datos por Favor Revisalo. {0}. ", ex.Message));
                Environment.Exit(-1);
            }
        }

        private void btnexecute_Click(object sender, EventArgs e)
        {
            Orquestador.ListaCasosPrueba = ListaCasosPrueba;
            Orquestador.Orquestador();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Archivos CSV (*.csv)|*.csv";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    url = openFileDialog1.FileName;


                    if (url != null | url != "")
                    {
                        btnLoad.Visible = true;
                    }

                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (!continuar)
            {
                if (PreClosingConfirmation() == DialogResult.Yes)
                {

                    Environment.Exit(-1);
                }
                else
                {
                    e.Cancel = true;

                }

            }
        }
        private DialogResult PreClosingConfirmation()
        {
            DialogResult res = MessageBox.Show("¿Esta seguro de Que quiere cerrar la aplicacion?", "Cerrar la Aplicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (PreClosingConfirmation() == DialogResult.Yes)
                {

                    Environment.Exit(-1);
                }
               
        }
    }
}