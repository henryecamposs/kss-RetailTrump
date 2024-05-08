using System;
using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using static RetailTrump.Program;

namespace RetailTrump
{
    public partial class frmConfig : Form
    {
        private string cnnString;
        private bool esConectado;

        public frmConfig()
        {
            InitializeComponent();
            this.Load += FrmConfig_Load;
        }
        private void FrmConfig_Load(object sender, EventArgs e)
        {
            try
            {
                usuario.Text = Properties.Settings.Default.UsuarioInstagram;
                startwith.Text = Properties.Settings.Default.StartWith;
                codigomoneda.Text = Properties.Settings.Default.codigoMoneda.ToString();
                cnnString = conexionString.Text = Properties.Settings.Default.appCadenaConexionHuesped;
                cmbredondeo.SelectedIndex = Properties.Settings.Default.TipoRedondeo;
                chkSQLServer.Checked = Properties.Settings.Default.esSQLServer;
                txtdirdatos.Text = Properties.Settings.Default.appDir_Datos;
                chkesControlPreciosBajos.Checked = Properties.Settings.Default.esControlPrecioBajo;
            }
            catch (Exception ex)
            {
                ksslib.clsUtilErrors.Manejador_errores(ex, false);
            }
        }
        private void buttonX1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Sin_Redondeo\n=========================\n" + "Valor Original:    9\nValor Final:         " + AplicarRedondeo(9, enTipoRedondeo.Sin_Redondeo));
            MessageBox.Show("Unidades a Cero(< 10 = 0)\n=========================\n" + "Valor Original:    106\nValor Final:         " + AplicarRedondeo(106, enTipoRedondeo.Unidades_a_Cero));
            MessageBox.Show("5 Unidades a Decimas(> 5 = 10)\n=========================\n" + "Valor Original:    106\nValor Final:         " + AplicarRedondeo(106, enTipoRedondeo.Cinco_Unidades_a_Decimas));
            MessageBox.Show("Unidades a Decimas(> 1 = 10)\n=========================\n" + "Valor Original:    103\nValor Final:         " + AplicarRedondeo(103, enTipoRedondeo.Unidades_a_Decimas));
            MessageBox.Show("Unidades a Centesimas(> 1 = 100)\n=========================\n" + "Valor Original:    109\nValor Final:         " + AplicarRedondeo(109, enTipoRedondeo.Unidades_a_Centesimas));
            MessageBox.Show("Decimas a Cero(< 100 = 0)\n\n=========================\n" + "Valor Original:    110\nValor Final:         " + AplicarRedondeo(110, enTipoRedondeo.Decimas_a_Cero));
            MessageBox.Show("5 Decimas a Centesimas(> 50 = 100)\n=========================\n" + "Valor Original:    55\nValor Final:         " + AplicarRedondeo(55, enTipoRedondeo.Cinco_Decimas_a_Centesimas));
            MessageBox.Show("Decimas a Centesimas(> 10 = 100)\n=========================\n" + "Valor Original:    117\nValor Final:         " + AplicarRedondeo(117, enTipoRedondeo.Decimas_a_Centesimas));
            MessageBox.Show("Centesimas a Cero(< 1000 = 0)\n=========================\n" + "Valor Original:    1553\nValor Final:         " + AplicarRedondeo(1553, enTipoRedondeo.Centesimas_a_Cero));
            MessageBox.Show("5 Centesimas a Milesimas(< 500 = 1000)\n=========================\n" + "Valor Original:    1503\nValor Final:         " + AplicarRedondeo(1503, enTipoRedondeo.CincoCentesimas_a_Milesimas));
            MessageBox.Show("Centesimas a Milesimas(> 100 = 1000)\n=========================\n" + "Valor Original:    2100\nValor Final:         " + AplicarRedondeo(2100, enTipoRedondeo.Centesimas_a_Milesimas));

        }
        private void guardarDatos()
        {
            guardadCnnString();
            Properties.Settings.Default.UsuarioInstagram = usuario.Text;
            Properties.Settings.Default.StartWith = startwith.Text;
            Properties.Settings.Default.codigoMoneda = Convert.ToInt32(codigomoneda.Text);
            Properties.Settings.Default.TipoRedondeo = cmbredondeo.SelectedIndex;
            Properties.Settings.Default.esSQLServer = chkSQLServer.Checked;
            Properties.Settings.Default.appCadenaConexionHuesped = cnnString;
            Properties.Settings.Default.appDir_Datos = txtdirdatos.Text;
            Properties.Settings.Default.esControlPrecioBajo = chkesControlPreciosBajos.Checked;
            Properties.Settings.Default.Save();
        }
        private void guardadCnnString()
        {
            cnnString = conexionString.Text;
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStrings = config.ConnectionStrings;
            foreach (ConnectionStringSettings connectionString in connectionStrings.ConnectionStrings)
            {
                if (!esSQLServer)
                {
                    if (connectionString.Name == "RetailTrump.Properties.Settings.cnnRetailTrump")
                        connectionString.ConnectionString = cnnString;
                }
                else
                {
                    if (connectionString.Name == "RetailTrump.Properties.Settings.cnnRetailTrump_SQLServer")
                        connectionString.ConnectionString = cnnString;
                }
            }
            config.Save(ConfigurationSaveMode.Modified);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            guardarDatos();
            this.Close();
            
        }

        private void btnTestConexion_Click(object sender, EventArgs e)
        {

            esSQLServer = chkSQLServer.Checked;
            if (!esSQLServer)
                esConectado = Program.esConexionconBD<OleDbConnection>(conexionString.Text);
            else
                esConectado = Program.esConexionconBD<SqlConnection>(conexionString.Text);
            if (esConectado)
            {
                cnnString =  Properties.Settings.Default.appCadenaConexionHuesped;
                conexionString.Text = cnnString;
            }
            else
                MessageBox.Show("No se pudo establecer CONEXIÓN!");
        }
    }
}
