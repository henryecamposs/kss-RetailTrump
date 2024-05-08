using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;
using System.IO;
using System.Data;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using ksslib;
using System.Collections.Generic;
using static RetailTrump.Program;
using DevComponents.Editors;
using System.Linq;
using System.Threading;
using DevComponents.DotNetBar.SuperGrid;

namespace RetailTrump
{
    public partial class frmMain : Form
    {

        #region  ATRIBUTOS Y PROPIEDADES 
        dsPpalSqlServerTableAdapters.INVENTableAdapter INVENTableAdapter_SQL;
        dsPpalSqlServerTableAdapters.MONEDASTableAdapter MONEDASTableAdapter_SQL;
        dsPpalSqlServerTableAdapters.ESTACIONESTableAdapter ESTACIONESTableAdapter_SQL;
        dsPpalSqlServerTableAdapters.GRUINVTableAdapter GRUINVTableAdapter_SQL;
        dsPpalSqlServerTableAdapters.TIPO_EMPATableAdapter TIPO_EMPATableAdapter_SQL;
        dsPpalSqlServerTableAdapters.PROMOTableAdapter PROMOTableAdapter_SQL;
        dsPpalSqlServerTableAdapters.TAXTableAdapter TAXTableAdapter_SQL;
        dsPpalSqlServerTableAdapters.tmpINVENTableAdapter tmpINVENTableAdapter;
        dsPpalSqlServerTableAdapters.DPTO_CAJASTableAdapter DPTO_CAJASTableAdapter_SQL;

        private clsCargarDialogControl CargarDialogControl
        {
            get
            {
                if (cargarDialogControl == null)
                {
                    cargarDialogControl = new clsCargarDialogControl(this);
                    cargarDialogControl.DialogClosed += CargarDialogControl_DialogClosed;
                }
                return cargarDialogControl;
            }
        }
        private void CargarDialogControl_DialogClosed(object sender)
        {
        }
        public bool esTieneFiltro
        {
            get => estienefiltro;
            private set
            {
                estienefiltro = value;
                this.btnFiltrar.Symbol = value ? "" : "";

            }
        }
        #region BUSQUEDA
        private int PosSrch
        {
            set
            {
                if (value > totalSrchDatosEncontrados - 1)
                    value = totalSrchDatosEncontrados - 1;
                else if (totalSrchDatosEncontrados == 0)
                    value = 0;
                if (value < 0) value = 0;
                _PosSrch = value;
            }
            get => _PosSrch;
        }
        private bool esConectado
        {
            get
            {
                //Establecer COnexion
                if (!esSQLServer)
                    esconectado = Program.esConexionconBD<OleDbConnection>(cnnString);
                else
                    esconectado = Program.esConexionconBD<System.Data.SqlClient.SqlConnection>(cnnString);
                try
                {
                    if (!esconectado)
                    {
                        MessageBox.Show("" +
                       "No éxiste conexión en " + cnnString + "\nVerifique la dirección e intente de nuevo!",
                       "Intento Conexión fallido",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    ksslib.clsUtilErrors.Manejador_errores(ex, false);
                }

                if (esconectado)
                    guardarDatos();

                lblNumRegistros.Visible = esconectado;
                return esconectado;
            }
        }
        //Search
        private DataTable dtSrchEncontred;
        private int _PosSrch;
        private int _totalSrchDatosEncontrados;
        private int totalSrchDatosEncontrados
        {
            get => _totalSrchDatosEncontrados;
            set
            {
                if (value <= 1)
                    panelMoveSearch.Visible = false;
                else
                    panelMoveSearch.Visible = true;

                if (value == 0)
                {
                    panelProductoPrecios.Enabled = false;
                    panelProductoDescr.Enabled = false;
                }
                else
                {
                    panelProductoPrecios.Enabled = true;
                    panelProductoDescr.Enabled = true;
                }

                _totalSrchDatosEncontrados = value;
            }
        }
        private Control selectedControl;
        private clsCargarDialogControl cargarDialogControl;
        private int statusSize;
        #endregion

        #region TRANSMITIR DATOS

        #endregion

        #region REGISTROS
        private dsPpalTableAdapters.invenTableAdapter invenTableAdapterSrch;
        private dsPpalSqlServerTableAdapters.INVENTableAdapter INVENTableAdapterSrch_SQL;
        private DataRow rowEdit;
        private decimal _srchOLDlastPrecio;
        private decimal _srchOLDlastdivisa;
        private decimal _srchOLDlastdivisafactor;
        private decimal _srchOLDlastdivisacosto;
        private decimal _srchOLDlastdivisaMargen;
        private decimal lastDivisaMargenFactor_app;
        private string descrMoneda;
        private decimal _lastPrecio;
        private decimal _lastdivisa;
        private decimal _lastdivisafactor;
        private decimal _lastdivisacosto;
        private decimal _lastdivisaMargen;
        private bool estienefiltro;
        private decimal codigoMoneda;
        private enTipoRedondeo TipoRedondeo;
        List<DataRow> lstItemsTransmitir;
        string lastCodigo = "";
        string cnnString = "";
        Color Rojo = Color.Red;
        Color Verde = Color.Lime;
        string cnnStringModel = @"Provider=VFPOLEDB.1;Data Source={0}";
        private bool esconectado;
        internal decimal FactorDivisaBs;
        internal decimal FactorDivisaCaja;
        private bool esChanging;
        List<CheckBox> gruposFiltrados;
        private bool esFiltrarTodos;
        private decimal MargenGanancia;
        private bool esChanginTodo;
        private int totalActualizacionesSesion;
        private int DecimalesCalculo;
        private string tipoUnidad_Default = "";
        private decimal lastPrecioMayor;
        private decimal lastDivisaMayor;
        private decimal lastDivisaCostoMayor;
        private decimal _lastDivisaMargenMayor;
        private decimal lastPrecioUltimo;
        private List<clsImpuestos> lstImpuestos;
        private decimal lastDivisaFactorProveedor;
        private string archivoDBFBack;
        private string archivoDBFOrig;
        private string archivoDBFOrigCDX;
        private string archivoUSA;
        private bool esControlPrecioBajo;
        private decimal totalUnidadesEmpaque;

        decimal lastDivisaMargenMayor
        {
            get
            {
                _lastDivisaMargenMayor = _lastDivisaMargenMayor <= 0 ? 0.001m : _lastDivisaMargenMayor >= 10000 ? 9999 : _lastDivisaMargenMayor;
                if (_lastDivisaMargenMayor < 0)
                    System.Diagnostics.Debug.Print($"Codigo: {lastCodigo} - Margen: {_lastDivisaMargenMayor}");
                return _lastDivisaMargenMayor;
            }
            set { _lastDivisaMargenMayor = value; }
        }
        decimal lastDivisa
        {
            get { return _lastdivisa == 0 ? 0.001m : _lastdivisa >= 10000000 ? 10000000 : _lastdivisa; }
            set { _lastdivisa = value; }
        }
        decimal lastDivisaFactor
        {
            get { return _lastdivisafactor <= 0 ? 0.001m : _lastdivisafactor >= 5000000 ? 5000000 : _lastdivisafactor; }
            set { _lastdivisafactor = value; }
        }
        decimal lastDivisaCosto
        {
            get { return _lastdivisacosto == 0 ? 0.001m : _lastdivisacosto >= 5000000 ? 5000000 : _lastdivisacosto; }
            set { _lastdivisacosto = value; }
        }

        decimal lastDivisaMargen
        {
            get { return _lastdivisaMargen <= 0 ? 0.001m : _lastdivisaMargen >= 10000 ? 9999 : _lastdivisaMargen; }
            set
            {
                if (totalSrchDatosEncontrados > 0 && panelSearch.Visible)
                {
                    timer1.Enabled = value >= 0 ? false : true;
                    lblAvisoPerdida.Visible = timer1.Enabled;
                }
                _lastdivisaMargen = value;
            }
        }
        decimal lastPrecio
        {
            get => _lastPrecio;
            set
            {
                loadDatos();
                _lastPrecio = chkRedondeo.Checked ? AplicarRedondeo(value, TipoRedondeo) : value;
            }
        }

        #endregion

        #endregion

        #region EVENTOS
        #region FORM
        private void txtDivisa_ValueChanged(object sender, EventArgs e)
        {
            lastDivisa = FactorDivisaBs = Convert.ToDecimal(txtDivisa.Text);
        }
        private void txtMargen_ValueChanged(object sender, EventArgs e)
        {
            //MargenGanancia = (decimal)txtMargen.Value;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                archivoDBFBack = Properties.Settings.Default.appDir_Datos + "\\inven_Back.dbf";
                archivoDBFOrig = Properties.Settings.Default.appDir_Datos + "\\inven.dbf";
                archivoDBFOrigCDX = Properties.Settings.Default.appDir_Datos + "\\inven.cdx";
                archivoUSA = Properties.Settings.Default.appDir_Datos + "\\inven_usa.dbf";
                lblDEMO.Visible = Program.esLicenciaDemo;
                lblDEMO.Text += " " + Program.nUsos.ToString("00") + " Usos";
                btnTransmitir.Text = "0";
                txtDivisa.Text = FactorDivisaBs.ToString();
                DecimalesCalculo = Properties.Settings.Default.DecimalCalculo;
                dsPpal.inven.ColumnChanged += Inven_ColumnChanged;
                if (dsPpalSQLServer == null)
                    dsPpalSQLServer = new dsPpalSqlServer();
                dsPpalSQLServer.INVEN.ColumnChanged += Inven_ColumnChanged;
                ProbarConexion();

                txtDivisa_ButtonCustom2Click(txtDivisaCajas, null);
                if (esconectado)
                {
                    MigrarPrecioMayor();
                    ProductosNuevos();
                }
                InicializarSearch();
                initColumnaGrupo();
                btnTransmitir.Text = "0";
                ((GridDoubleInputEditControl)gcPrecio.EditControl).ShowUpDown = false;
                ((GridDoubleInputEditControl)gcCosto.EditControl).ShowUpDown = false;
                ((GridDoubleInputEditControl)gcDivisa.EditControl).ShowUpDown = false;
                cmbAumMoneda.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                clsUtilErrors.Manejador_errores(ex);
            }
        }

        private void MigrarPrecioMayor()
        {

            decimal NoMigrados = !esSQLServer ? (decimal)invenTableAdapter.ScalarQueryNoMigradosPrecioMayor() : (decimal)INVENTableAdapter_SQL.ScalarQueryNoMigrados();
            int modi = 0;
            if (NoMigrados > 0)
            {
                try
                {
                    msjProgress(1, $"Migrando {NoMigrados} datos antiguos...\nEspere por favor");
                    if (!esSQLServer)
                        foreach (DataRow item in invenTableAdapter.GetDataByNoMigradosPrecioMayor().Rows)
                        {

                            modi += invenTableAdapter.UpdateQueryMigrarPrecioMayor(Convert.ToDecimal(item["margen3"]), Convert.ToDecimal(item["precio2m"]), Convert.ToDecimal(item["margen3m"]), item["codigo"].ToString());
                            msjProgress(CalcularProgreso(modi, Convert.ToInt32(NoMigrados)), msjStatus: $"{item["descr"]}\n" + string.Format("Actualizados {0} de {1}", modi, Convert.ToInt32(NoMigrados)));
                        }
                    else
                        foreach (DataRow item in INVENTableAdapter_SQL.GetDataByNomigradosPrecioMayor().Rows)
                        {
                            modi += INVENTableAdapter_SQL.UpdateQueryMigrarPrecioMayor(Convert.ToDecimal(item["margen3"]), Convert.ToDecimal(item["precio2m"]), Convert.ToDecimal(item["margen3m"]), item["codigo"].ToString());
                            msjProgress(CalcularProgreso(modi, Convert.ToInt32(NoMigrados)), msjStatus: $"{item["descr"]}\n" + string.Format("Actualizados {0} de {1}", modi, Convert.ToInt32(NoMigrados)));
                        }
                }
                catch
                {

                }
                finally
                {
                    msjProgress(esFin: true);
                    ProbarConexion();
                }

            }

        }
        private void Inven_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            try
            {
                if (!esChanginTodo)
                    if (!esChanging)
                    {
                        if (!esSQLServer)
                            if (dsPpal.inven_usa.Rows.Count > 0)
                                initGridFinal();
                        esChanging = true;
                        DataRow item = e.Row;
                        getDatosItem(item);
                        switch (e.Column.ColumnName)
                        {
                            case "PRECIO":
                            case "precio":
                                setCalcularTotales(lastPrecio, 0, true, esPorLote: true);
                                break;
                            case "DIVISA":
                            case "divisa":
                                setCalcularTotales(lastDivisa, 1, true, false, true);
                                break;
                            case "DIVISACOSTO":
                            case "divisacosto":
                                setCalcularTotales(lastDivisaCosto, 2, true, false);
                                break;
                        }
                        try
                        {
                            item.BeginEdit();
                            item["divisa"] = lastDivisa;
                            item["divisafactor"] = lastDivisaFactor;
                            item["divisacosto"] = lastDivisaCosto;
                            item["divisamargenfactor"] = lastDivisaMargen;
                            item["precio"] = lastPrecio;
                            if (esSQLServer)
                            {
                                item["regulado"] = item["regulado"] == DBNull.Value ? 0 : item["regulado"];
                                item["troquela"] = item["troquela"] == DBNull.Value ? 0 : item["troquela"];
                            }

                        }
                        catch (Exception ex)
                        {
                            ksslib.clsUtilErrors.Manejador_errores(ex, true);
                        }
                        finally
                        {
                            item.EndEdit();
                            esChanging = false;
                            activarTransmitir(item);
                        }
                    }
            }
            catch (Exception ex)
            {
                ksslib.clsUtilErrors.Manejador_errores(ex, false);
            }


        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Cerrar la Aplicación?", "Cerrar Aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MessageBox.Show("Desea Guardar los Cambios?", "Guardar Cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    guardarDatos();
                this.Close();
                Application.Exit();
            }
        }
        private void Simular_Click(object sender, EventArgs e)
        {
            simularCambios(true);
        }
        private void btnProbar_Click(object sender, EventArgs e)
        {
            ProbarConexion();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridFinal.PrimaryGrid.Rows.Count > 0)
                {
                    if (
                         MessageBox.Show("" +
                               "Se van a MODIFICAR los datos." +
                               "\nEsta operación es probable NO PUEDE SER REVERTIDA." +
                               "\n¿Desea Continuar?",
                               "Cambio de Precios",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes
                        )
                    {
                        msjProgress(1, "Actualizando Archivo BD...\nEspere por favor");
                        if (!esSQLServer)
                        {
                            File.Copy(archivoDBFOrig, archivoDBFBack, true);
                            File.Copy(archivoDBFOrig, archivoUSA, true);
                        }
                        TransmitirDatosEstaciones(true);
                    }

                }
            }
            finally
            {
                msjProgress(esFin: true);
                ProbarConexion();
                btnActualizar.Enabled = false;
            }
        }

        private void btnMonitorve_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Program.ConsultaMonitorve();
            if (Program.dolarBCV > 0)
            {
                if (MessageBox.Show("Desea Usar los datos:\n" + Program.sEstadoMoneda, "Usar Datos Recopilados", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtDivisa.Text = Program.dolarBCV.ToString();
                    txtDivisaCajas.Text = Program.dolarBCV.ToString();
                }
            }
            Cursor = Cursors.Default;
        }
        internal decimal loadMoneda()
        {

            try
            {
                if (esconectado)
                {
                    decimal result = 1;
                    DataRowCollection rows = !esSQLServer ? monedasTableAdapter1.GetData(codigoMoneda).Rows : MONEDASTableAdapter_SQL.GetData(codigoMoneda).Rows;
                    if (rows.Count > 0)
                    {
                        result = Convert.ToDecimal(rows[0]["Factor"]);
                        descMoneda();
                    }
                    rows = null;
                    return result;

                }
                return 0;
            }
            catch
            {
                return 0;

            }
        }
        private void txtDivisa_ButtonCustom2Click(object sender, EventArgs e)
        {
            txtDivisaCajas.Text = loadMoneda().ToString();
        }
        internal void modificarMoneda(decimal valor)
        {
            try
            {
                if (!esSQLServer) ConectarEstacion(cnnString);
                int i = 00;
                if (MessageBox.Show($"Se va a modificar la Moneda:\n{descrMoneda}\n¿Desea Continuar?", "Modificando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    i = !esSQLServer ? monedasTableAdapter1.UpdatebyCodigo(valor, codigoMoneda) : MONEDASTableAdapter_SQL.UpdateQuerybyCodigo(valor, codigoMoneda);
                else return;
            }
            catch (Exception ex)
            {
                ksslib.clsUtilErrors.Manejador_errores(ex, true);
            }

            try
            {
                if (!esSQLServer)
                {
                    DataRowCollection rows = !esSQLServer ? estacionesTableAdapter1.GetData().Rows : ESTACIONESTableAdapter_SQL.GetData().Rows;
                    foreach (DataRow rowEstacion in rows)
                    {
                        try
                        {
                            msjProgress(1, $"Enviando a: {rowEstacion["descr"].ToString().Trim().ToUpper()} \nEspere por favor", wait: 1);
                            ConectarEstacion(string.Format(cnnStringModel, rowEstacion["ruta"].ToString().Trim() + "\\data"));
                            using (OleDbConnection cnn = new OleDbConnection(monedasTableAdapter1.Connection.ConnectionString))
                                cnn.Open();
                            if (monedasTableAdapter1.UpdatebyCodigo(valor, codigoMoneda) > 0)
                                msjProgress(100, $"Transmición Exitosa!!\n{rowEstacion["descr"].ToString().Trim().ToUpper()}", wait: 2);
                            else
                                throw new Exception();
                        }
                        catch (Exception ex)
                        {
                            ksslib.clsUtilErrors.Manejador_errores(ex, false);
                            msjProgress(100, $"Transmición NO Exitosa!!\n{rowEstacion["descr"].ToString().Trim().ToUpper()}", msjStatus: ex.Message, wait: 2);
                        }
                    }

                }
            }
            finally
            {
                msjProgress(esFin: true);
                ProbarConexion();
            }
        }
        private void txtDivisa_ButtonCustomClick(object sender, EventArgs e)
        {
            modificarMoneda(Convert.ToDecimal(txtDivisaCajas.Text));
        }
        private void btnConfig_Click(object sender, EventArgs e)
        {
            new frmConfig()
            {
                StartPosition = FormStartPosition.CenterParent
            }.ShowDialog(this);
            loadDatos();
            ProbarConexion();
        }
        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (selectedControl == txtDivisa)
                        gridOriginal.Focus();
                    if (selectedControl == txtSearch)
                        btnSearch_Click(null, null);
                    break;
                default:
                    break;
            }
            if (panelSearch.Visible)
            {
                switch (e.KeyCode)
                {
                    case Keys.F3:
                        txtSearch.Focus();
                        break;
                    case Keys.Escape:
                        btnSrchClose.PerformClick();
                        break;
                    case Keys.F4:
                        btnsrchCancelCambio.PerformClick();
                        break;
                    case Keys.F5:
                        btnSrchAct.PerformClick();
                        break;
                    case Keys.F6:
                        btnSrchPrev_Click(btnSrchPrev, null);
                        break;
                    case Keys.F7:
                        btnSrchPrev_Click(btnSrchNext, null);
                        break;
                    case Keys.F8:
                        btnsrchProductoNuevo_Click(btnsrchProductoNuevo, null);
                        break;
                    case Keys.F9:
                        btnSrchPrev_Click(btnSrchNext, null);
                        break;
                    case Keys.F11:
                        btnsrchTransmitirDatosEstaciones.PerformClick();
                        break;
                }
            }
        }
        private void txtDivisa_Enter(object sender, EventArgs e)
        {
            selectedControl = txtDivisa;
        }
        private void txtDivisa_Leave(object sender, EventArgs e)
        {
            FactorDivisaBs = Convert.ToDecimal(txtDivisa.Text);
            guardarDatos();
        }
        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            if (statusSize == 0)
            {
                statusSize = 1;
                btnMinimize.Symbol = "";
                WindowState = FormWindowState.Normal;
                this.Size = new Size(50, 50);
            }
            else
            {
                btnMinimize.Symbol = "";
                WindowState = FormWindowState.Maximized;
                statusSize = 0;
            }

        }

        #endregion

        #region BUSQUEDA

        private void txtSrchPrecio_Leave(object sender, EventArgs e)
        {
            try
            {
                //if (totalSrchDatosEncontrados > 0)
                //{
                if (selectedControl.Text.Trim().Length == 0)
                    selectedControl.Text = "0";

                lastPrecio = Convert.ToDecimal(txtSrchPrecio.Text);
                lastDivisa = Convert.ToDecimal(txtSrchDivisa.Text);
                lastDivisaCosto = Convert.ToDecimal(txtSrchCosto.Text);
                lastDivisaMargen = Convert.ToDecimal(txtSrchMargen.Text);

                lastPrecioMayor = Convert.ToDecimal(txtPrecioM.Text);
                lastDivisaMayor = Convert.ToDecimal(txtDivisaM.Text);
                lastDivisaCostoMayor = Convert.ToDecimal(txtDivisaCostoM.Text);
                lastDivisaMargenMayor = Convert.ToDecimal(txtDivisaMargenM.Text);

                switch (((TextBoxX)sender).Tag.ToString())
                {
                    case "0":
                        setCalcularTotales(lastPrecio, 0);

                        //if (totalUnidadesEmpaque > 1)
                        //    setCalcularTotales(lastcost * totalUnidadesEmpaque, 5, true);
                        break;
                    case "1":
                        setCalcularTotales(lastDivisa, 1);

                        if (totalUnidadesEmpaque > 1)
                            setCalcularTotales(lastDivisa * totalUnidadesEmpaque, 6, true);
                        break;
                    case "2":
                        setCalcularTotales(lastDivisaCosto, 2);

                        if (totalUnidadesEmpaque > 1)
                            setCalcularTotales(lastDivisaCosto * totalUnidadesEmpaque, 7, true);
                        break;
                    case "3":
                        setCalcularTotales(lastDivisaMargen, 3);
                        break;
                    case "4":
                        lastDivisaFactorProveedor = txtTasaDivisaProveedor.Text.Trim().Length == 0 ? 0 : Convert.ToDecimal(txtTasaDivisaProveedor.Text);
                        txtTasaDivisaProveedor.Text = lastDivisaFactorProveedor.ToString("N2");
                        txtSrchPrecio.Focus();
                        break;
                    case "5":
                        setCalcularTotales(lastPrecioMayor, 5);
                        break;
                    case "6":
                        setCalcularTotales(lastDivisaMayor, 6);
                        break;
                    case "7":
                        setCalcularTotales(lastDivisaCostoMayor, 7);
                        break;
                    case "8":
                        setCalcularTotales(lastDivisaMargenMayor, 8);
                        break;
                    case "und":
                        if (selectedControl.Text.Equals("0"))
                            selectedControl.Text = 1.ToString($"N{DecimalesCalculo}");
                        else
                            selectedControl.Text = string.Format("{0:N2}", selectedControl.Text);
                        break;
                    default:
                        break;
                }

                verificarConsistencias();
                txtSrchDivisa.Text = lastDivisa.ToString($"N{DecimalesCalculo}");
                txtSrchPrecio.Text = lastPrecio.ToString("N2");
                txtSrchMargen.Text = lastDivisaMargen.ToString("N2");
                txtSrchCosto.Text = lastDivisaCosto.ToString($"N{DecimalesCalculo}");

                txtPrecioM.Text = lastPrecioMayor.ToString($"N{DecimalesCalculo}");
                txtDivisaM.Text = lastDivisaMayor.ToString($"N{DecimalesCalculo}");
                txtDivisaCostoM.Text = lastDivisaCostoMayor.ToString($"N{DecimalesCalculo}");
                txtDivisaMargenM.Text = lastDivisaMargenMayor.ToString($"N{DecimalesCalculo}");
                //if (lastPrecioMayor == 0 && lastDivisaMayor == 0)
                //{
                //    lastDivisaMargenMayor = 0;
                //}

            }
            catch (Exception)
            {

            }
        }
        private void txtSrchPrecio_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                dynamic txt = sender;
                if (e.KeyCode == Keys.Enter)
                {
                    switch (txt.Name)
                    {
                        case "txtICalcCantidad":
                            txtICalcTasaDivisaProveedor.Focus();
                            return;
                        case "txtICalcMontoTotal":
                            txtICalcCantidad.Focus();
                            return;
                        case "txtICalcMontoUnidadDivisa":
                            btnIOK_Click(btnICalcOK, null);
                            return;
                        case "txtICalcTasaDivisaProveedor":
                            txtICalcMontoUnidadDivisa.Focus();
                            return;
                        default:
                            break;
                    }
                    SendKeys.Send("{Tab}");
                    return;
                }
                string Texto = txt.Text;
                char charActual = Convert.ToChar(e.KeyValue);
                if (Texto.Length >= 19)
                    return;
                if (char.IsDigit(charActual) || charActual == '\b')
                {
                    int posicion = txt.SelectionStart;
                    string decimales = "";
                    if (Texto.Length > 0)
                    {
                        string[] BloquesIni = Texto.Split('.');
                        string txttmp = Texto;
                        if (Texto.Contains(','))
                        {
                            txttmp = Texto.Substring(0, Texto.IndexOf(","));
                            decimales = Texto.Substring(Texto.IndexOf(","), Texto.Length - Texto.IndexOf(","));
                        }
                        Texto = txttmp.Replace(".", "");
                        Texto = Convert.ToDouble(Texto).ToString("N0");
                        Texto = Texto + decimales;
                        txt.Text = Texto;

                        txt.SelectionStart =
                            Texto.Split('.').Length > BloquesIni.Length ? posicion + 1 :
                            Texto.Split('.').Length < BloquesIni.Length ? posicion - 1 : posicion;
                    }
                }
                else
                    e.Handled = false;
            }
            catch (Exception ex)
            {
                ksslib.clsUtilErrors.Manejador_errores(ex, false);
            }

        }
        private void timer1_Tick(object sender, EventArgs e) => lblAvisoPerdida.Visible = !lblAvisoPerdida.Visible;
        private void btnsrchTransmitirDatosEstaciones_Click(object sender, EventArgs e) => TransmitirDatosEstaciones();
        bool DatosCompletosActualizar(out string msj)
        {
            msj = "";
            if (txtCodigoInterno.Text.Trim().Length == 0)
            {
                msj = "Indique Código de producto";
                txtCodigoInterno.Focus();
                return false;
            }
            if (txtCodigoBarras.Text.Trim().Length == 0)
            {
                msj = "Indique Código Barras de producto";
                txtCodigoBarras.Focus();
                return false;
            }
            if (cmbSrchGrupo.SelectedValue == null)
            {
                cmbSrchGrupo.Focus();
                msj = "Indique el Grupo de Producto";
                return false;
            }
            if (txtDescripcionSearch.Text.Trim().Length == 0)
            {
                txtDescripcionSearch.Focus();
                msj = "Indique la Descripción Producto";
                return false;

            }
            if (txtSrchPrecio.Text.Trim().Length == 0)
            {
                msj = "Indique el Precio del Producto";
                txtSrchPrecio.Focus();
                return false;
            }

            return true;
        }
        private void btnAct_Click(object sender, EventArgs e)
        {
            try
            {
                string MsjResult = "";
                if (!DatosCompletosActualizar(out MsjResult))
                {
                    kss_msjDelay.Show(MsjResult, enuMsgBoxImag.msgCritical, SegundosMostrar: 2);
                }
                else
                {
                    rowEdit.BeginEdit();
                    rowEdit["divisafactor"] = lastDivisaFactor;

                    rowEdit["precio"] = Convert.ToDecimal(txtSrchPrecio.Text);
                    rowEdit["divisa"] = Convert.ToDecimal(txtSrchDivisa.Text);
                    rowEdit["divisacosto"] = Convert.ToDecimal(txtSrchCosto.Text);
                    rowEdit["divisamargenfactor"] = Convert.ToDecimal(txtSrchMargen.Text);

                    rowEdit["preciom"] = Convert.ToDecimal(txtPrecioM.Text);
                    rowEdit["divisamayor"] = Convert.ToDecimal(txtDivisaM.Text);
                    rowEdit["divisacostomayor"] = Convert.ToDecimal(txtDivisaCostoM.Text);
                    rowEdit["divisamargenfactormayor"] = Convert.ToDecimal(txtDivisaMargenM.Text);

                    rowEdit["dpto_cajas"] = cmbDptoCajas.SelectedValue ?? "";
                    rowEdit["grupo"] = cmbSrchGrupo.SelectedValue ?? "";
                    rowEdit["dgrupo"] = cmbSrchGrupo.Text ?? "";

                    //Descripcion
                    rowEdit["descr"] = txtDescripcionSearch.Text.Trim();
                    rowEdit["unidadc"] = cmbTipoEmpaque.SelectedValue ?? "";
                    rowEdit["unidadv"] = cmbTipoUnidad.SelectedValue ?? "";
                    //rowEdit["promo"] = cmbTipoPromocion.SelectedValue ?? "";
                    rowEdit["tiva"] = cmbTipoIVA.SelectedValue ?? 0;
                    rowEdit["unidade"] = Convert.ToDecimal(txtUndEmpaque.Text.Trim());
                    rowEdit["contenidou"] = Convert.ToDecimal(txtUndVenta.Text.Trim()).ToString("N2");
                    rowEdit["barra"] = txtCodigoBarras.Text.Trim();
                    rowEdit["codigo"] = txtCodigoInterno.Text.Trim();
                    rowEdit["codigoc"] = txtCodEmpaque.Text.Trim();

                    rowEdit["pbalanza"] = chkLeeBalanza.Checked;
                    rowEdit["pidecanti"] = chkPideCantidad.Checked;
                    rowEdit["pideobse"] = chkPideObservacion.Checked;
                    rowEdit["pidepre"] = chkPidePrecio.Checked;
                    rowEdit["ult_actu"] = DateTime.Now.ToString("dd/MM/yyyy");
                    if (esSQLServer)
                    {
                        rowEdit["regulado"] = chkRegulado.Checked;
                        rowEdit["troquela"] = chkTroquelado.Checked;
                        //rowEdit["REG_CANT"] = Convert.ToDecimal(txtRegCanti.Text);
                    }
                    else
                    {
                        rowEdit["tipo"] = chkTroquelado.Checked ? "1" : "0";
                    }

                    rowEdit.EndEdit();
                    if (!esSQLServer)
                        ConectarEstacion(cnnString);
                    if (setUpdateItem(rowEdit) > 0)
                    {
                        kss_msjDelay.Show("Datos Actualizados!", enuMsgBoxImag.msgSalvado, SegundosMostrar: 1);
                        InicializarSearch();
                    }
                    else
                        kss_msjDelay.Show("No se Actualizaron los Datos!", enuMsgBoxImag.msgCritical, SegundosMostrar: 1);
                }
            }
            catch (Exception ex)
            {
                ksslib.clsUtilErrors.Manejador_errores(ex, true);
            }
            finally
            {
                txtSearch.Text = "";
            }
        }
        void testConexiones()
        {
            string msj = INVENTableAdapter_SQL.Connection.ConnectionString + "\nINVENTableAdapter_SQL\n";
            msj += GRUINVTableAdapter_SQL.Connection.ConnectionString + "\nGRUINVTableAdapter_SQL\n";
            msj += TIPO_EMPATableAdapter_SQL.Connection.ConnectionString + "\nTIPO_EMPATableAdapter_SQL\n";
            msj += MONEDASTableAdapter_SQL.Connection.ConnectionString + "\nMONEDASTableAdapter\n";
            msj += PROMOTableAdapter_SQL.Connection.ConnectionString + "\nPROMOTableAdapter\n";
            msj += tmpINVENTableAdapter.Connection.ConnectionString + "\ntmpINVENTableAdapter\n";
            msj += TAXTableAdapter_SQL.Connection.ConnectionString + "\nTAXTableAdapter\n";
            MessageBox.Show(msj);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                PosSrch = 0;
                dtSrchEncontred = new DataTable();
                string textoBuscar = txtSearch.Text;
                //Busqueda por barra 
                dtSrchEncontred = !esSQLServer ? (DataTable)invenTableAdapterSrch.GetDataByBarra(textoBuscar) : (DataTable)INVENTableAdapterSrch_SQL.GetDataByBarra(textoBuscar);
                totalSrchDatosEncontrados = dtSrchEncontred.Rows.Count;
                if (totalSrchDatosEncontrados == 0)
                {
                    dtSrchEncontred = !esSQLServer ? (DataTable)invenTableAdapterSrch.GetDataByBarra(textoBuscar.ToUpper()) : INVENTableAdapterSrch_SQL.GetDataByBarra(textoBuscar.ToUpper());
                    totalSrchDatosEncontrados = dtSrchEncontred.Rows.Count;
                }

                if (totalSrchDatosEncontrados == 0)
                {
                    textoBuscar = "%" + txtSearch.Text.Trim() + "%";
                    //Busqueda por descripcion
                    dtSrchEncontred = !esSQLServer ? (DataTable)invenTableAdapterSrch.GetDataByDescr(textoBuscar) : (DataTable)INVENTableAdapterSrch_SQL.GetDataByDescr(textoBuscar);
                    totalSrchDatosEncontrados = dtSrchEncontred.Rows.Count;
                    if (totalSrchDatosEncontrados == 0)
                    {
                        dtSrchEncontred = !esSQLServer ? (DataTable)invenTableAdapterSrch.GetDataByDescr(textoBuscar.ToUpper()) : (DataTable)INVENTableAdapterSrch_SQL.GetDataByDescr(textoBuscar.ToUpper());
                        totalSrchDatosEncontrados = dtSrchEncontred.Rows.Count;
                    }
                }

                if (totalSrchDatosEncontrados > 0)
                {
                    lblProductoNoExiste.Visible = false;
                    //aqui
                    Application.DoEvents();
                    btnSrchPrev_Click(btnSrchPrev, new EventArgs());
                    txtSrchPrecio.SelectAll();
                    txtSrchPrecio.Focus();
                }
                else
                {
                    InicializarSearch();
                    Application.DoEvents();
                    txtSearch.SelectAll();
                    txtSearch.Focus();
                    lblProductoNoExiste.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ha ocurrido una excepcion: {0}", ex.Message), "Excepción");
            }
            finally
            {
                //dtSrchEncontred = null;
            }
        }
        private void btnSrchPrev_Click(object sender, EventArgs e)
        {
            try
            {

                itemContainer15.Size = new Size(280, 200);
                itemContainer15.Refresh();
                if (dtSrchEncontred != null)
                {
                    if (!sender.GetType().Name.Equals("ButtonX"))
                        switch (((SymbolBox)sender).Tag)
                        {
                            case "1"://prev
                                PosSrch--;
                                break;
                            case "2"://next
                                PosSrch++;
                                break;
                            case "3":

                                break;
                        }
                    lblSrchEncontrados.Text = string.Format("{0}/{1}", PosSrch + 1, totalSrchDatosEncontrados);
                    if (PosSrch >= 0 && PosSrch <= dtSrchEncontred.Rows.Count - 1)
                    {
                        rowEdit = dtSrchEncontred.Rows[PosSrch];
                        _srchOLDlastPrecio = Convert.ToDecimal(rowEdit["precio"]);
                        _srchOLDlastdivisa = Convert.ToDecimal(rowEdit["divisa"]);
                        _srchOLDlastdivisacosto = Convert.ToDecimal(rowEdit["divisacosto"]);
                        _srchOLDlastdivisaMargen = Convert.ToDecimal(rowEdit["divisamargenfactor"]);
                        _srchOLDlastdivisafactor = Convert.ToDecimal(rowEdit["divisafactor"]);

                        lastPrecioMayor = Convert.ToDecimal(rowEdit["preciom"]);
                        lastDivisaMayor = Convert.ToDecimal(rowEdit["divisamayor"]);
                        lastDivisaCostoMayor = Convert.ToDecimal(rowEdit["divisacostomayor"]);
                        lastDivisaMargenMayor = Convert.ToDecimal(rowEdit["divisamargenfactormayor"]);

                        if (_srchOLDlastPrecio > 0 && _srchOLDlastdivisa == 0)
                            setCalcularTotales(lastPrecio, 0);
                        else
                        {
                            lastDivisa = _srchOLDlastdivisa;
                            lastDivisaCosto = _srchOLDlastdivisacosto;
                            lastDivisaMargen = _srchOLDlastdivisaMargen;
                        }
                        lastPrecio = _srchOLDlastPrecio;

                        if (esSQLServer)
                        {
                            chkRegulado.Checked = Convert.ToBoolean(rowEdit["regulado"]);
                            chkTroquelado.Checked = Convert.ToBoolean(rowEdit["troquela"]);
                            //txtRegCanti.Text = Convert.ToDecimal(rowEdit["REG_CANT"]).ToString();
                        }
                        else
                        {
                            bool tipo = rowEdit["tipo"] is DBNull ? false : rowEdit["tipo"].ToString().Trim().Equals("1") ? true : false;
                            chkTroquelado.Checked = tipo;
                        }
                        txtDescripcionSearch.Text = rowEdit["descr"].ToString().Trim();
                        txtSrchPrecio.Text = chkTroquelado.Checked ? lastPrecio.ToString("N2") : (lastDivisa * lastDivisaFactor).ToString("N2");
                        txtSrchDivisa.Text = lastDivisa.ToString("N2");
                        txtSrchMargen.Text = lastDivisaMargen.ToString("N2");
                        txtSrchCosto.Text = lastDivisaCosto.ToString("N2");

                        txtDivisaM.Text = lastDivisaMayor.ToString("N2");
                        txtDivisaMargenM.Text = lastDivisaMargenMayor.ToString("N2");
                        txtDivisaCostoM.Text = lastDivisaCostoMayor.ToString("N2");
                        txtPrecioM.Text = (lastDivisaFactor * lastDivisaMayor).ToString("N2");
                        //Descripcion
                        cmbSrchGrupo.SelectedValue = rowEdit["grupo"].ToString().Trim();
                        cmbTipoUnidad.SelectedValue = rowEdit["unidadv"].ToString().Trim().Length == 0 ? tipoUnidad_Default : rowEdit["unidadv"].ToString().Trim();
                        cmbTipoEmpaque.SelectedValue = rowEdit["unidadc"].ToString().Trim().Length == 0 ? tipoUnidad_Default : rowEdit["unidadc"].ToString().Trim();
                        cmbDptoCajas.SelectedValue = rowEdit["dpto_cajas"].ToString().Trim().Length == 0 ? tipoUnidad_Default : rowEdit["dpto_cajas"].ToString().Trim();
                        //cmbTipoPromocion.SelectedValue = rowEdit["promo"].ToString().Trim();
                        cmbTipoIVA.SelectedValue = rowEdit["tiva"].ToString().Trim();
                        txtUndEmpaque.Text = Convert.ToDecimal(rowEdit["unidade"]) == 0 ? "1,00" : Convert.ToDecimal(rowEdit["unidade"]).ToString("N2");
                        txtUndVenta.Text = (rowEdit["contenidou"].ToString()).Trim().Length == 0 ? "1,00" : Convert.ToDecimal(rowEdit["contenidou"]).ToString("N2");
                        txtCodigoBarras.Text = rowEdit["barra"].ToString().Trim();
                        txtCodigoInterno.Text = rowEdit["codigo"].ToString().Trim();
                        txtCodEmpaque.Text = rowEdit["codigoc"].ToString().Trim();
                        //
                        chkLeeBalanza.Checked = Convert.ToBoolean(rowEdit["pbalanza"]);
                        chkPideCantidad.Checked = Convert.ToBoolean(rowEdit["pidecanti"]);
                        chkPideObservacion.Checked = Convert.ToBoolean(rowEdit["pideobse"]);
                        chkPidePrecio.Checked = Convert.ToBoolean(rowEdit["pidepre"]);
                        lblUltimaActu.Text = rowEdit["ult_actu"].ToString().Trim().Length == 0 ? DateTime.Now.ToString("dd/MM/yyyy") : Convert.ToDateTime(rowEdit["ult_actu"]).ToString("dd/MM/yyyy");
                        //Precios
                        txtSrchOldDivisa.Text = _srchOLDlastdivisa.ToString("N2");
                        txtSrchOldPrecio.Text = _srchOLDlastPrecio.ToString("N2");
                        txtSrchOldMargen.Text = _srchOLDlastdivisaMargen.ToString("N2");
                        txtSrchOldCosto.Text = _srchOLDlastdivisacosto.ToString("N2");
                        txtsrchOldDivisaFactor.Text = _srchOLDlastdivisafactor.ToString("N2");
                        btnEliminar.Visible = true;
                        lastCodigo = rowEdit["codigo"].ToString();
                        chkPrecioFijo.Checked = chkTroquelado.Checked;
                        Application.DoEvents();
                        txtSrchPrecio.SelectAll();
                        txtSrchPrecio.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                ksslib.clsUtilErrors.Manejador_errores(ex, true);
            }
        }
        private void panelSearch_VisibleChanged(object sender, EventArgs e)
        {
            if (panelSearch.Visible)
            {
                txtTasaDivisaProveedor.Text = 0.ToString("N2");
                InicializarSearch();
            }
            else
            {
                totalSrchDatosEncontrados = 0;
                chkPrecioFijo.Checked = false;
            }

        }
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.SelectionLength = txtSearch.Text.Length;
            txtSearch.SelectAll();
            selectedControl = txtSearch;
        }
        private void txtSrchPrecio_Enter(object sender, EventArgs e)
        {
            if (sender.GetType().BaseType.Name.Equals("TextBox"))
            {
                selectedControl = (Control)sender;
                if (selectedControl.Name.Equals("txtPrecioM") && lastPrecioMayor == 0)
                {
                    decimal undEmp = Convert.ToDecimal(txtUndEmpaque.Text) > 1 ? Convert.ToDecimal(txtUndEmpaque.Text) : 0;
                    txtDivisaCostoM.Text = (lastDivisaCosto * undEmp).ToString($"N{DecimalesCalculo}");
                    txtDivisaCostoM.Focus();
                }
            ((TextBox)selectedControl).SelectionLength = selectedControl.Text.Length;
                ((TextBox)selectedControl).SelectAll();
            }
            if (sender.GetType().BaseType.Name.Equals("ImageItem"))
            {
                ((TextBoxItem)sender).SelectionLength = ((TextBoxItem)sender).Text.Length;
                ((TextBoxItem)sender).SelectAll();
            }
        }
        private void txtSrchPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            dynamic txt = sender;
            string Texto = txt.Text;
            if (e.KeyChar.Equals('.'))
                e.KeyChar = ',';

            if (Texto.Contains(','))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;

                    if (Texto.Length > 0 && e.KeyChar.Equals(','))
                    {
                        int i = Texto.IndexOf(',');
                        txt.SelectionStart = i + 1;
                        txt.SelectionLength = txt.Text.Length - 1 - i;
                    }
                }
                if (e.KeyChar == '\b' || e.KeyChar == '\r' || e.KeyChar == '\u0003' || e.KeyChar == '\u0016')
                    e.Handled = false;
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                    e.Handled = true;

                if (e.KeyChar == '\b' || e.KeyChar == '\r' || e.KeyChar == '\u0003' || e.KeyChar == '\u0016')
                    e.Handled = false;

                if (e.KeyChar == ',')
                {
                    if (Texto.Length == 0)
                    {
                        e.Handled = true;
                        Texto = "0,";
                        txt.SelectionStart = Texto.Length;
                    }
                    else
                    {
                        txt.SelectionStart = Texto.Length;
                        e.Handled = false;
                    }

                }

            }
        }
        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (lstItemsTransmitir != null)
                if (lstItemsTransmitir.Count > 0)
                    if (MessageBox.Show($"Desea TRANSMITIR DATOS?\nMODIFICADOS={lstItemsTransmitir.Count} ", "Transmitir Modificados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes ? true : false)
                        btnsrchTransmitirDatosEstaciones.PerformClick();
            ProbarConexion();
            panelSearch.Visible = false;
        }
        private void btnPrecioManual_Click(object sender, EventArgs e) => CargarDialogControl.cargarDlgBackTransparent(panelSearch, true, true);

        #endregion

        #region TRANSMITIR DATOS

        private void btniTransmitir_Click(object sender, EventArgs e) => TransmitirDatosEstaciones();

        private void btniLimpiar_Click(object sender, EventArgs e)
        {
            if (lstItemsTransmitir != null)
            {
                lstItemsTransmitir.Clear();
                btnTransmitir.Text = lstItemsTransmitir.Count.ToString();
            }
            ProbarConexion();
        }

        private void btniVerTransmitir_Click(object sender, EventArgs e)
        {
            simularCambios(false);
        }
        private void timTransmitir_Tick(object sender, EventArgs e) => btnTransmitir.SymbolColor = btnTransmitir.SymbolColor == Color.Lime ? Color.LightGray : Color.Lime;
        private void btnTransmitir_Click(object sender, EventArgs e)
        { }
        #endregion

        #region REGISTROS
        private void gridOriginal_DataBindingComplete(object sender, GridDataBindingCompleteEventArgs e)
        {
            if (Program.esLicenciaDemo)
            {
                msjVersionDEMO("Solo se podrán editar 10 Registros");
                if (e.GridPanel.Rows.Count >= 10)
                {
                    int i = 0;
                    foreach (GridRow item in e.GridPanel.Rows)
                    {
                        if (i >= 10)
                        {
                            item.CellStyles.Default.Background.Color1 = Color.Coral;
                            item.CellStyles.Default.Background.Color2 = Color.Coral;
                            item.AllowEdit = false;
                        }
                        i++;
                    }
                }
            }
            ////columns 41
            foreach (GridColumn item in gridOriginal.PrimaryGrid.Columns)
            {
                if (item.Tag == null)
                    item.Visible = false;
            }
            //gcCosto.DataPropertyName = "divisacosto";
            //gcDivisa.DataPropertyName="divisa";

        }
        private void gridFinal_DataBindingComplete(object sender, GridDataBindingCompleteEventArgs e)
        {
            foreach (GridColumn item in gridFinal.PrimaryGrid.Columns)
            {
                if (item.Tag == null)
                    item.Visible = false;
                else
                {
                    item.DataPropertyName = !esSQLServer ? item.DataPropertyName.ToLower() : item.DataPropertyName.ToUpper();
                    if (item.DataPropertyName.ToLower().Contains("divisa"))
                        item.DataPropertyName = item.DataPropertyName.ToLower();
                }
            }
        }
        private void gridOriginal_CellDoubleClick(object sender, GridCellDoubleClickEventArgs e)
        {
            if (Program.esLicenciaDemo && !e.GridCell.GridRow.AllowEdit)
                msjVersionDEMO("No puede Hacer DobleClik");
            else
            {
                if (e.GridCell.GridColumn.DataPropertyName.ToUpper().Equals("DESCR") || e.GridCell.GridColumn.DataPropertyName.ToUpper().Equals("CODIGO"))
                {
                    if (e.GridCell.Value != null)
                    {
                        btnPrecioManual.PerformClick();
                        txtSearch.Text = e.GridCell.Value.ToString().Trim();
                        btnSearch_Click(null, null);
                        //txtSrchPrecio.Focus();
                    }
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e) => CargarDialogControl.cargarDlgBackTransparent(panelFiltro, true, true);
        private void panelFiltro_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (panelFiltro.Visible)
                {

                    flowGrupoItems.Controls.Clear();

                    DataRowCollection drGrupo = !esSQLServer ? gruinvTableAdapter.GetData().Rows : GRUINVTableAdapter_SQL.GetData().Rows;

                    CheckBox chkSinGrupo = new CheckBox();
                    chkSinGrupo.AutoSize = false;
                    chkSinGrupo.BackColor = System.Drawing.Color.LightGray;
                    chkSinGrupo.ForeColor = Color.MidnightBlue;
                    chkSinGrupo.Location = new System.Drawing.Point(8, 8);
                    chkSinGrupo.Name = "chk_SinGrupo";
                    chkSinGrupo.Size = new System.Drawing.Size(110, 17);
                    chkSinGrupo.Text = "Sin Grupos";
                    chkSinGrupo.Tag = "";
                    flowGrupoItems.Controls.Add(chkSinGrupo);
                    if (gruposFiltrados == null)
                        gruposFiltrados = new List<CheckBox>();

                    if (gruposFiltrados.Find(s => s.Name.Equals(chkSinGrupo.Name)) == null)
                        //if (!gruposFiltrados.Find(s => s.Name.Equals(chkSinGrupo.Name)).Name.Equals(chkSinGrupo.Name))
                        gruposFiltrados.Add(chkSinGrupo);

                    foreach (DataRow row in drGrupo)
                    {
                        CheckBox chk = new CheckBox();
                        chk.AutoSize = false;
                        chk.BackColor = System.Drawing.Color.LightGray;
                        chk.ForeColor = Color.MidnightBlue;
                        chk.Location = new System.Drawing.Point(8, 8);
                        chk.Name = "chk_" + row["codigo"].ToString();
                        chk.Size = new System.Drawing.Size(110, 17);
                        chk.Text = row["descr"].ToString().Trim();
                        chk.Tag = row["codigo"].ToString();
                        flowGrupoItems.Controls.Add(chk);

                        if (gruposFiltrados.Find(s => s.Name.Equals(chk.Name)) == null)
                            //if (!gruposFiltrados.Find(s => s.Name.Equals(chk.Name)).Name.Equals(chk.Name))
                            gruposFiltrados.Add(chk);
                    }
                    foreach (var item in flowGrupoItems.Controls)
                    {
                        var tmpchk = item as CheckBox;
                        if (tmpchk != null)
                            if (gruposFiltrados.Find(s => s.Name.Equals(tmpchk.Name)) != null)
                            {
                                ((CheckBox)item).Checked = gruposFiltrados.Find(s => s.Name.Equals(tmpchk.Name)).Checked;
                            }
                    }

                }
            }
            catch (Exception ex)
            {
                clsUtilErrors.Manejador_errores(ex);
            }
            finally
            {

            }
        }
        private void btnFiltrarTodos_Click(object sender, EventArgs e)
        {
            esFiltrarTodos = !esFiltrarTodos;
            btnFiltrarTodos.Text = esFiltrarTodos ? "Ninguno" : "Todos";
            foreach (Control chk in flowGrupoItems.Controls)
            {
                if (chk is CheckBox)
                    ((CheckBox)chk).Checked = esFiltrarTodos;
            }
        }
        private void btnOKFiltrar_Click(object sender, EventArgs e)
        {
            foreach (var item in flowGrupoItems.Controls)
            {
                var tmpchk = item as CheckBox;
                if (tmpchk != null)
                    if (gruposFiltrados.Find(s => s.Name.Equals(tmpchk.Name)) != null)
                    {
                        gruposFiltrados.Find(s => s.Name.Equals(tmpchk.Name)).Checked = ((CheckBox)item).Checked;
                    }
            }
            estienefiltro = gruposFiltrados.Count<CheckBox>(chk => chk.Checked == true) > 0 ? true : false;
            ProbarConexion();
            panelFiltro.Visible = false;
        }

        #endregion
        #endregion

        #region METHODOS
        private void toastNotificacion(Control control, string msg, int duracion = 3)
        {
            //global::RetailTrump.Properties.Resources.ICON_60,
            ToastNotification.Show(control,
                msg,
                null,
                duracion * 1000,
                eToastGlowColor.Blue,
                eToastPosition.TopRight);

        }
        private int CalcularProgreso(int ini, int fin) => ini * 100 / fin;
        void descMoneda()
        {
            DataRowCollection rows = !esSQLServer ? monedasTableAdapter1.GetData(codigoMoneda).Rows : MONEDASTableAdapter_SQL.GetData(codigoMoneda).Rows;
            if (rows.Count > 0)
                descrMoneda = rows[0]["descr"].ToString().Trim().ToUpper() + " Bs." + rows[0]["Factor"].ToString();

        }
        private void initColumnaGrupo()
        {
            gcGrupo.EditorType = typeof(GridComboBoxExEditControl);
            GridComboBoxExEditControl colGrupo = ((GridComboBoxExEditControl)gcGrupo.EditControl);
            colGrupo.DataSource = bindingSourceGrupos;
            colGrupo.DisplayMember = "descr";
            colGrupo.ValueMember = "codigo";
            colGrupo.Width = 130;
            if (colGrupo.DataBindings.Count == 0)
                colGrupo.DataBindings.Add(new System.Windows.Forms.Binding("Text", invenBindingSource, "descrGrupo", true));
            colGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void msjProgress(int Value = 0, string msjAccion = "", string msjStatus = "", bool esFin = false, double wait = 0)
        {
            if (!panelProgressBar.Visible)
                CargarDialogControl.cargarDlgBackTransparent(panelProgressBar, true, true);
            //if (Value == 1)
            //    panelProgressBar.Location = new Point(this.Width / 2 - (panelProgressBar.Width / 2), this.Height / 2 - (panelProgressBar.Height / 2));
            if (Value > 100)
                Value = 100;
            panelProgressBar.Visible = !esFin;
            if (esFin)
            {
                Cursor = Cursors.Default;
                progressBarX1.Value = 0;
                lblbarAccion.Text = "";
                lblbarStatusAccion.Text = "";
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                progressBarX1.Value = Value;
                lblbarAccion.Text = msjAccion.Length == 0 ? lblbarAccion.Text : msjAccion;
                lblbarStatusAccion.Text = msjStatus.Length == 0 ? lblbarStatusAccion.Text : msjStatus;
            }
            Application.DoEvents();
            if (wait > 0)
                Thread.Sleep(Convert.ToInt32(wait * 1000));

        }

        #region BUSQUEDA
        private void InicializarSearch()
        {
            if (!esSQLServer)
            {
                invenTableAdapterSrch = new dsPpalTableAdapters.invenTableAdapter();
                invenTableAdapterSrch.Connection.ConnectionString = cnnString;
            }
            else
            {
                INVENTableAdapterSrch_SQL = new dsPpalSqlServerTableAdapters.INVENTableAdapter();
                INVENTableAdapterSrch_SQL.Connection.ConnectionString = cnnString;
            }
            dtSrchEncontred = null;
            PosSrch = 0;
            totalSrchDatosEncontrados = 0;
            txtSearch.Text = "";
            txtDescripcionSearch.Text = "";
            lblSrchEncontrados.Text = "";
            txtDescripcionSearch.Text = "";
            txtCodigoBarras.Text = "";
            txtCodigoInterno.Text = "";
            txtCodEmpaque.Text = "";
            txtSrchDivisa.Text = "0,00";
            txtSrchPrecio.Text = "0,00";
            txtSrchMargen.Text = "0,00";
            txtSrchCosto.Text = "0,00";

            txtDivisaCostoM.Text = "0,00";
            txtDivisaM.Text = "0,00";
            txtDivisaMargenM.Text = "0,00";
            txtPrecioM.Text = "0,00";

            txtUndEmpaque.Text = "0,00";
            txtUndVenta.Text = "0,00";
            txtCodigoInterno.ReadOnly = true;
            txtCodigoBarras.ReadOnly = true;
            txtCodEmpaque.ReadOnly = true;
            txtDescripcionSearch.ReadOnly = true;

            chkLeeBalanza.Checked = false;
            chkPideCantidad.Checked = false;
            chkPideObservacion.Checked = false;
            chkPidePrecio.Checked = false;
            chkTroquelado.Visible = true;
            chkRegulado.Visible = esSQLServer;

            cmbTipoEmpaque.SelectedIndex = -1;
            cmbTipoIVA.SelectedIndex = -1;
            //cmbTipoPromocion.SelectedIndex = -1;
            cmbTipoUnidad.SelectedIndex = -1;
            cmbDptoCajas.SelectedIndex = -1;

            txtSrchOldDivisa.Text = "0,00";
            txtSrchOldPrecio.Text = "0,00";
            txtSrchOldMargen.Text = "0,00";
            txtSrchOldCosto.Text = "0,00";
            txtsrchOldDivisaFactor.Text = "0,00";
            lblUltimaActu.Text = "";
            lblSrchFactorDivisa.Text = lastDivisaFactor.ToString("N2");
            TipoRedondeo = (enTipoRedondeo)Properties.Settings.Default.TipoRedondeo;
            chkRedondeo.Checked = TipoRedondeo == enTipoRedondeo.Sin_Redondeo ? false : true;
            chkPrecioFijo.Checked = false;
            lblTipoRedondeo.Text = "Redondeo: " + TipoRedondeo.ToString().Replace("_", " ");
            //panelProductoDescr.Enabled = false;
            //panelProductoPrecios.Enabled = false;
            btnsrchTransmitirDatosEstaciones.Visible = !esSQLServer;
            btnEliminar.Visible = false;
            txtSearch.Focus();

        }

        #endregion
        #region TRANSMITIR DATOS

        private void activarTransmitir(DataRow row, bool isNew = false)
        {
            if (row != null)
            {
                if (lstItemsTransmitir == null)
                    lstItemsTransmitir = new List<DataRow>();
                timTransmitir.Enabled = true;
                try
                {
                    lstItemsTransmitir.Add(row);
                    if (!isNew)
                    {
                        var lst = lstItemsTransmitir.Find(r => r.RowState == DataRowState.Detached);
                        if (lst != null)
                            lstItemsTransmitir.Remove(lst);
                    }
                }
                catch (Exception ex)
                {
                    ksslib.clsUtilErrors.Manejador_errores(ex, false);
                }
                if (btnTransmitir.Visible)
                    btnTransmitir.Text = lstItemsTransmitir.Count.ToString();
            }
        }
        private void TransmitirDatosEstaciones(bool esDirecto = false)
        {
            //modificar aqui==>
            bool esError = false;
            List<DataRow> lstRowsNoTransferido = null;
            try
            {
                int modi = 0;
                string Estacion = "";
                if (!esSQLServer)
                {
                    if (dsPpal.inven_usa.GetChanges() != null)
                    {
                        List<DataRow> dt = dsPpal.inven_usa.GetChanges().Rows.Cast<DataRow>().ToList();
                        if (dt != null)
                            foreach (DataRow item in dt)
                            {
                                activarTransmitir(item);
                            }
                    }
                }
                else
                {
                    if (dsPpalSQLServer.tmpINVEN.GetChanges() != null)
                    {
                        List<DataRow> dt = dsPpalSQLServer.tmpINVEN.GetChanges().Rows.Cast<DataRow>().ToList();
                        if (dt != null)
                            foreach (DataRow item in dt)
                            {
                                activarTransmitir(item);
                            }
                    }
                }


                if (lstItemsTransmitir != null)
                {

                    if (lstItemsTransmitir.Count > 0)
                    {
                        msjProgress(1, msjAccion: "Actualizando SERVIDOR\nEspere por Favor", msjStatus: "...Preparando para enviar a Estaciones", wait: 2);
                        try
                        {
                            if (!esSQLServer)
                                ConectarEstacion(cnnString);
                            string producto = "";
                            foreach (DataRow item in lstItemsTransmitir)
                            {
                                try
                                {
                                    //if
                                    producto = item["descr"].ToString().Trim();
                                    producto = (producto.Length > 15 ? producto.Substring(0, 15) + "..." : producto) + "Bs." + lastPrecio.ToString("N2");
                                    modi += setUpdateItem(item, true);
                                    msjProgress(CalcularProgreso(modi, lstItemsTransmitir.Count), msjStatus: $"{producto}\n" + string.Format("Actualizados {0} de {1}", modi, lstItemsTransmitir.Count));
                                }
                                catch (Exception ex)
                                {
                                    ksslib.clsUtilErrors.Manejador_errores(ex, false);
                                    msjProgress(100, $"NO se pudo Actualizar\n{producto}", msjStatus: ex.Message, wait: 2);
                                    esError = true;
                                }
                                if (Program.esLicenciaDemo && modi >= 3)
                                {
                                    msjVersionDEMO("Solo se podrán ACTUALIZAR 3 Registros");
                                    break;
                                }
                            }
                        }
                        finally
                        {
                            msjProgress(esFin: true);
                        }
                    }
                    if (esDirecto)
                    {
                        btniTransmitirTodo_Click(btniTransmitirTodo, null);
                    }
                    else
                    {
                        if (dsPpal.estaciones.Rows.Count > 0)
                        {
                            foreach (DataRow rowEstacion in dsPpal.estaciones.Rows)
                            {
                                Estacion = rowEstacion["descr"].ToString().Trim().ToUpper();
                                try
                                {
                                    msjProgress(1, $"Enviando a: {Estacion}\nEspere por favor", wait: 1);
                                    ConectarEstacion(string.Format(cnnStringModel, rowEstacion["ruta"].ToString().Trim() + "\\data"));
                                    using (OleDbConnection cnn = new OleDbConnection(invenTableAdapter.Connection.ConnectionString))
                                        cnn.Open();
                                    modi = 0;
                                    string producto = "";
                                    foreach (DataRow item in lstItemsTransmitir)
                                    {
                                        try
                                        {

                                            producto = item["descr"].ToString().Trim();
                                            producto = (producto.Length > 15 ? producto.Substring(0, 15) + "..." : producto) + "Bs." + lastPrecio.ToString("N2");
                                            msjProgress(CalcularProgreso(modi, lstItemsTransmitir.Count), msjStatus: $"{producto}\n" + string.Format("Actualizados {0} de {1}", modi, lstItemsTransmitir.Count));
                                            if (setUpdateItem(item, true) > 0)
                                                modi++;
                                            else
                                                throw new Exception($"Producto Eliminado o no Existe en {Estacion}.\n{producto}");
                                        }
                                        catch (Exception ex)
                                        {
                                            ksslib.clsUtilErrors.Manejador_errores(ex, false);
                                            msjProgress(100, $"Producto NO Transmitido:\n{producto}", msjStatus: ex.Message, wait: 2);
                                            if (lstRowsNoTransferido == null)
                                                lstRowsNoTransferido = new List<DataRow>();
                                            lstRowsNoTransferido.Add(item);
                                            esError = true;
                                        }

                                        if (Program.esLicenciaDemo && modi >= 3)
                                        {
                                            msjVersionDEMO("Solo se podrán TRANSMITIR 3 Registros");
                                            break;
                                        }
                                    }
                                    string msj = $"Transferecia exitosa a {Estacion}\nMODIFICADOS:{modi.ToString("N0")}";
                                    if (modi > 0)
                                        msjProgress(!esError ? 100 : CalcularProgreso(modi, lstItemsTransmitir.Count), msjAccion: !esError ? msj : msj + "\nAlgunos NO Transmitidos!", wait: 4);
                                }
                                catch (Exception ex)
                                {
                                    ksslib.clsUtilErrors.Manejador_errores(ex, false);
                                    msjProgress(100, $"NO se pudo conectar a:\n{Estacion}", msjStatus: ex.Message, wait: 2);
                                    esError = true;
                                }
                                finally
                                {
                                    msjProgress(esFin: true);
                                }
                            }
                        }
                    }
                }
            }
            finally
            {
                if (!esError)
                {
                    if (lstItemsTransmitir != null)
                        lstItemsTransmitir.Clear();
                    ProbarConexion();
                }
                if (lstRowsNoTransferido != null)
                    lstItemsTransmitir = lstRowsNoTransferido;
                if (!esSQLServer)
                    btnTransmitir.Text = lstItemsTransmitir != null ? lstItemsTransmitir.Count.ToString() : "0";
                lstRowsNoTransferido = null;

            }
        }
        private void simularCambios(bool esDirecto)
        {
            initGridFinal();
            int modi = 0;
            string txt = "";
            if (!esSQLServer)
                txt = dsPpal.HasChanges() ? "MODIFICADOS" : "FILTRADOS";
            else
                txt = dsPpalSQLServer.HasChanges() ? "MODIFICADOS" : "FILTRADOS";

            msjProgress(1, $"Actualizando DIVISA\nProductos { txt}");
            List<DataRow> dt;
            if (esDirecto)
            {
                //TODO: Analizar cual ds tiene cambios
                if (!esSQLServer)
                    dt = dsPpal.inven.GetChanges() != null ? dsPpal.inven.GetChanges().Rows.Cast<DataRow>().ToList() : dsPpal.inven.Rows.Cast<DataRow>().ToList();
                else
                    dt = dsPpalSQLServer.INVEN.GetChanges() != null ? dsPpalSQLServer.INVEN.GetChanges().Rows.Cast<DataRow>().ToList() : dsPpalSQLServer.INVEN.Rows.Cast<DataRow>().ToList();

            }
            else
                dt = lstItemsTransmitir;
            try
            {

                if (dt != null)
                {
                    int Registros = dt.Count;
                    foreach (DataRow item in dt)
                    {
                        try
                        {
                            //TODO: Verificar datos de simulacion para SQL
                            getDatosItem(item);
                            //TODO: Copiado de una tabla a otra
                            if (!esSQLServer)
                                dsPpal.inven_usa.ImportRow(item);
                            else
                                dsPpalSQLServer.tmpINVEN.ImportRow(item);

                            DataRow[] tmpRow = null;
                            if (!esSQLServer)
                                tmpRow = dsPpal.inven_usa.Select($"codigo like '{item["codigo"]}'");
                            else
                                tmpRow = dsPpalSQLServer.tmpINVEN.Select($"codigo like '{item["codigo"]}'");


                            if (tmpRow != null)
                                foreach (var _tmprow in tmpRow)
                                {
                                    bool tipo = false;
                                    if (!esSQLServer)
                                        tipo = _tmprow["tipo"] is DBNull ? false : _tmprow["tipo"].ToString().Trim().Equals("1") ? true : false;
                                    else
                                        tipo = item["troquela"] is DBNull ? false : true;

                                    if (tipo)
                                        break;
                                    //chkPrecioFijo.Checked = false;
                                    //bool esCambioFactorDivisa = _tmprow["divisamargenfactor"] is DBNull ? true : Convert.ToDecimal(_tmprow["divisafactor"]) != lastDivisaFactor ? true : false;
                                    //tipo = esCambioFactorDivisa ? false : tipo;
                                    setCalcularTotales(lastDivisa, 1, esPrecioFijo: tipo);
                                    setCalcularTotales(lastDivisaMayor, 6);
                                    _tmprow.BeginEdit();
                                    _tmprow["divisa"] = lastDivisa;
                                    _tmprow["divisafactor"] = lastDivisaFactor;
                                    _tmprow["divisacosto"] = lastDivisaCosto;
                                    _tmprow["divisamargenfactor"] = lastDivisaMargen;
                                    _tmprow["precio"] = lastPrecio;

                                    _tmprow["divisamayor"] = lastDivisaMayor;
                                    _tmprow["divisacostomayor"] = lastDivisaCostoMayor;
                                    _tmprow["divisamargenfactormayor"] = lastDivisaMargenMayor;
                                    _tmprow["preciom"] = lastPrecioMayor;

                                    decimal pidecanti = item["pidecanti"] is DBNull ? 0 : Convert.ToDecimal(item["pidecanti"]);
                                    decimal pidepre = item["pidepre"] is DBNull ? 0 : Convert.ToDecimal(item["pidepre"]);
                                    decimal pideobse = item["pideobse"] is DBNull ? 0 : Convert.ToDecimal(item["pideobse"]);
                                    decimal unidade = item["unidade"] is DBNull ? 0 : Convert.ToDecimal(item["unidade"]);
                                    decimal pbalanza = item["pbalanza"] is DBNull ? 0 : Convert.ToDecimal(item["pbalanza"]);
                                    int tiva = item["tiva"] is DBNull ? 0 : Convert.ToInt16(item["tiva"]);
                                    string unidad = item["unidad"] is DBNull ? "" : item["unidad"].ToString();
                                    string promo = item["promo"] is DBNull ? "" : item["promo"].ToString();
                                    string unidadv = item["unidadv"] is DBNull ? "" : item["unidadv"].ToString();
                                    string unidadc = item["unidadc"] is DBNull ? "" : item["unidadc"].ToString();
                                    string contenidou = item["contenidou"] is DBNull ? "" : item["contenidou"].ToString();
                                    string grupo = item["grupo"] is DBNull ? "" : item["grupo"].ToString();
                                    string dgrupo = item["dgrupo"] is DBNull ? "" : item["dgrupo"].ToString();
                                    string barra = item["barra"] is DBNull ? "" : item["barra"].ToString();
                                    string descr = item["descr"] is DBNull ? "" : item["descr"].ToString();
                                    barra = barra.Trim().Length == 0 ? item["codigo"].ToString() : barra;
                                    string barraEmpaque = item["codigoc"] is DBNull ? "" : item["codigoc"].ToString();

                                    ////aqui
                                    //if (modi < 4)
                                    //    MessageBox.Show($"descr: {descr.ToString().Trim()} \nPrecio: {lastPrecio.ToString("N2")} \nDivisa: {lastDivisa.ToString("N2")}");

                                    if (esSQLServer)
                                    {
                                        _tmprow["regulado"] = item["regulado"] is DBNull ? 0 : Convert.ToDecimal(item["regulado"]);
                                        _tmprow["troquela"] = item["troquela"] is DBNull ? 0 : Convert.ToDecimal(item["troquela"]);
                                    }
                                    _tmprow.EndEdit();
                                    if (!esSQLServer)
                                    {
                                        modi += inven_usaTableAdapter.UpdateQueryByCodigo(lastPrecio, lastDivisa, lastDivisaFactor >= 1000000 ? 999999 : lastDivisaFactor, lastDivisaCosto, lastDivisaMargen, item["grupo"].ToString(), DateTime.Now, lastPrecioMayor, lastDivisaMayor, lastDivisaCostoMayor, lastDivisaMargenMayor, item["tipo"].ToString(), item["codigo"].ToString());
                                    }
                                    else
                                        modi++;
                                }
                            msjProgress(CalcularProgreso(modi, Registros), msjStatus: string.Format("Actualizados {0} de {1}", modi, Registros));
                        }
                        catch (Exception ex)
                        {
                            ksslib.clsUtilErrors.Manejador_errores(ex, true);
                        }
                    }

                }
            }
            finally
            {
                this.gridFinal.PrimaryGrid.DataSource = !esSQLServer ? (DataTable)dsPpal.inven_usa : (DataTable)dsPpalSQLServer.tmpINVEN;
                btnActualizar.Enabled = true;
                msjProgress(esFin: true);
            }
        }
        #endregion

        #region REGISTROS
        private void initGridFinal()
        {
            if (!esSQLServer)
                dsPpal.inven_usa.Clear();
            this.gridFinal.PrimaryGrid.DataSource = null;
        }
        int setUpdateItem(DataRow row, bool esTransmitir = false)
        {
            int result = 0;
            /**
             * precio2= divisa
             * margen3= divisafactor
             * margen3m= divisamargenfactor
             * precio2m = divisacosto
             **/
            bool isNew = false;
            if (Program.esLicenciaDemo && totalActualizacionesSesion >= 20)
            {
                if (Program.maxActualizaciones >= 1000)
                    msjVersionDEMO("Ha llegado al tope de Actualizaciones.Adquiera <b>Versión Completa</b>");
                else
                    msjVersionDEMO(
                        "Solo se podrán ACTUALIZAR 20 Registros por Sesión." +
                        "\nActualizacion Cancelada");
                return result;
            }
            else
            {
                if (row != null)
                {
                    decimal pidecanti = row["pidecanti"] is DBNull ? 0 : Convert.ToDecimal(row["pidecanti"]);
                    decimal pidepre = row["pidepre"] is DBNull ? 0 : Convert.ToDecimal(row["pidepre"]);
                    decimal pideobse = row["pideobse"] is DBNull ? 0 : Convert.ToDecimal(row["pideobse"]);
                    decimal unidade = row["unidade"] is DBNull ? 0 : Convert.ToDecimal(row["unidade"]);
                    decimal pbalanza = row["pbalanza"] is DBNull ? 0 : Convert.ToDecimal(row["pbalanza"]);
                    int tiva = row["tiva"] is DBNull ? 0 : Convert.ToInt16(row["tiva"]);
                    string unidad = row["unidad"] is DBNull ? "" : row["unidad"].ToString();
                    string promo = row["promo"] is DBNull ? "" : row["promo"].ToString();
                    string unidadv = row["unidadv"] is DBNull ? "" : row["unidadv"].ToString();
                    string unidadc = row["unidadc"] is DBNull ? "" : row["unidadc"].ToString();
                    string contenidou = row["contenidou"] is DBNull ? "" : row["contenidou"].ToString();
                    string grupo = row["grupo"] is DBNull ? "" : row["grupo"].ToString();
                    string dgrupo = row["dgrupo"] is DBNull ? "" : row["dgrupo"].ToString();
                    string barra = row["barra"] is DBNull ? "" : row["barra"].ToString();
                    barra = barra.Trim().Length == 0 ? row["codigo"].ToString() : barra;
                    string barraEmpaque = row["codigoc"] is DBNull ? "" : row["codigoc"].ToString();
                    //EL tipo en 1= Precio Troquelado
                    string descr = row["descr"] is DBNull ? "" : row["descr"].ToString();
                    string tipo = row["tipo"] is DBNull ? "0" : row["tipo"].ToString();
                    string dpto_cajas = row["dpto_cajas"] is DBNull ? "" : row["dpto_cajas"].ToString();
                    DateTime ult_actu = DateTime.Now;
                    int regulado = 0;
                    decimal troquela = 0;
                    if (esSQLServer)
                    {
                        regulado = row["regulado"] is DBNull ? 0 : Convert.ToInt16(row["regulado"]);
                        troquela = row["troquela"] is DBNull ? 0 : Convert.ToDecimal(row["troquela"]);
                    }

                    getDatosItem(row);
                    lastDivisaFactor = Convert.ToDecimal(txtDivisa.Text);
                    if (lastPrecio <= 0.001m && pidepre == 0 && troquela == 0 && esControlPrecioBajo)
                    {
                        lastPrecio = 0.001m;
                        lastDivisa = Decimal.Round(lastPrecio / lastDivisaFactor, DecimalesCalculo);
                        lastDivisaCosto = decimal.Round(lastDivisa / (1 + (lastDivisaMargenFactor_app / 100)), DecimalesCalculo);
                    }
                    //Producto nuevo
                    if (lastDivisa <= 0.001m && lastDivisaCosto <= 0.001m && lastDivisaMargen <= 0.001m)
                    {
                        setCalcularTotales(lastPrecio, 0);
                        setCalcularTotales(lastDivisaCosto, 2, esPrecioFijo: true);
                    }
                    lastPrecioUltimo = lastDivisaCosto * lastDivisaFactor > 0 ? 1 : lastDivisaFactor;
                    try
                    {
                        DataRowCollection rows = !esSQLServer ? invenTableAdapter.GetDataByCodigoInterno(lastCodigo).Rows : INVENTableAdapter_SQL.GetDataByCodigoInterno(lastCodigo).Rows;
                        DateTime newDateCero = new DateTime(2000, 01, 01);
                        if (lastPrecio <= 0.001m && lastDivisa == 0.001m && esControlPrecioBajo)
                        {
                            lastPrecio = 0.001m;
                            setCalcularTotales(lastPrecio, 0);
                        }
                        if (rows.Count == 0)
                        {
                            //Insertar producto
                            if (!esSQLServer)
                                result = invenTableAdapter.InsertQueryPRODUCTONUEVO(lastCodigo, descr, descr, barra, lastPrecio, lastDivisa, lastDivisaCosto, lastDivisaMargen, lastDivisaFactor >= 1000000 ? 999999 : lastDivisaFactor, lastPrecioMayor, lastDivisaMayor, lastDivisaCostoMayor, lastDivisaMargenMayor, lastPrecioUltimo, tiva, barraEmpaque, grupo, dgrupo, tipo, pbalanza, pideobse, pidepre, pidecanti, dpto_cajas, unidade, unidadc, contenidou, unidadv, ult_actu);
                            else
                                result = INVENTableAdapter_SQL.InsertQueryProductoNuevo(lastCodigo, descr, descr, barra, lastPrecio, lastDivisa, lastDivisaCosto, lastDivisaMargen, lastDivisaFactor >= 1000000 ? 999999 : lastDivisaFactor, lastPrecioMayor, lastDivisaMayor, lastDivisaCostoMayor, lastDivisaMargenMayor, lastPrecioUltimo, tiva, barraEmpaque, grupo, dgrupo, tipo, pbalanza, pideobse, pidepre, pidecanti, dpto_cajas, unidade, unidadc, contenidou, unidadv, ult_actu, regulado, troquela, new DateTime(2020, 01, 01), new DateTime(2020, 01, 01), new DateTime(2020, 01, 01), new DateTime(2020, 01, 01), new DateTime(2020, 01, 01), new DateTime(2020, 01, 01), new DateTime(2000, 01, 01), DateTime.Now);
                            isNew = true;
                        }
                        else
                        {
                            if (lastDivisaMargenMayor < 0)
                            {
                                System.Diagnostics.Debug.Print($"Codigo: {lastCodigo} - Margen: {lastDivisaMargenMayor}");
                            }
                            if (!esSQLServer)
                                result = invenTableAdapter.UpdateQueryByCodigo(lastPrecio, lastDivisa, lastDivisaFactor >= 1000000 ? 999999 : lastDivisaFactor, lastDivisaCosto, lastDivisaMargen, grupo, tiva, row["descr"].ToString(), unidadc, unidadv, promo, unidade, contenidou, barra, pbalanza, pidecanti, pideobse, pidepre, ult_actu, row["descr"].ToString(), lastPrecioUltimo, ult_actu, dgrupo, tipo, lastPrecioMayor, lastDivisaMayor, lastDivisaCostoMayor, lastDivisaMargenMayor, barraEmpaque, lastCodigo);
                            else
                                result = INVENTableAdapter_SQL.UpdateQuerybyCodigo(lastPrecio, lastDivisa, lastDivisaFactor >= 1000000 ? 999999 : lastDivisaFactor, lastDivisaCosto, lastDivisaMargen, grupo, tiva, row["descr"].ToString(), unidadc, unidadv, promo, unidade, contenidou, barra, pbalanza, pidecanti, pideobse, pidepre, ult_actu, row["descr"].ToString(), lastPrecioUltimo, ult_actu, dgrupo, tipo, lastPrecioMayor, lastDivisaMayor, lastDivisaCostoMayor, lastDivisaMargenMayor, barraEmpaque, troquela, regulado, lastCodigo);
                        }
                    }
                    catch (Exception ex)
                    {
                        clsUtilErrors.Manejador_errores(ex);
                    }
                    totalActualizacionesSesion += result;
                    maxActualizaciones += result;
                    if (!esSQLServer)
                        if (!esTransmitir) activarTransmitir(row, isNew);
                }
                return result;
            }

        }
        void initDatosItem()
        {
            lastDivisa = 0;
            lastDivisaFactor = 0;
            lastDivisaMargen = 0;
            lastPrecio = 0;
            lastDivisaCosto = 0;
            lastCodigo = "";
            lastDivisaMayor = 0;
            lastDivisaMargenMayor = 0;
            lastPrecioMayor = 0;
            lastDivisaCostoMayor = 0;
        }
        void getDatosItem(DataRow item)
        {
            initDatosItem();
            //bool esDataVieja = (Convert.ToDecimal(item["Divisa"]) > 1000 || Convert.ToDecimal(item["divisacosto"]) > 1000) && Convert.ToDecimal(item["divisafactor"]) == 0 && Convert.ToDecimal(item["divisamargenfactor"]) == 0;
            //if (esDataVieja)
            //{
            //    item["Divisa"] = 0;
            //    item["divisafactor"] = 0;
            //    item["divisamargenfactor"] = 0;
            //    item["divisacosto"] = 0;
            //}

            lastDivisa = decimal.Round(Convert.ToDecimal(item["Divisa"]), DecimalesCalculo);
            lastDivisaFactor = decimal.Round(Convert.ToDecimal(item["divisafactor"]), DecimalesCalculo, MidpointRounding.AwayFromZero);
            lastDivisaCosto = decimal.Round(Convert.ToDecimal(item["divisacosto"]), DecimalesCalculo);
            lastDivisaMargen = decimal.Round(Convert.ToDecimal(item["divisamargenfactor"]), DecimalesCalculo, MidpointRounding.AwayFromZero);
            lastPrecio = decimal.Round(Convert.ToDecimal(item["Precio"]), DecimalesCalculo, MidpointRounding.AwayFromZero);
            lastCodigo = item["Codigo"].ToString();

            lastDivisaMayor = decimal.Round(Convert.ToDecimal(item["divisamayor"]), DecimalesCalculo);
            lastDivisaCostoMayor = decimal.Round(Convert.ToDecimal(item["divisacostomayor"]), DecimalesCalculo, MidpointRounding.AwayFromZero);
            lastDivisaMargenMayor = decimal.Round(Convert.ToDecimal(item["divisamargenfactormayor"]), DecimalesCalculo, MidpointRounding.AwayFromZero); ;
            lastPrecioMayor = decimal.Round(Convert.ToDecimal(item["preciom"]), DecimalesCalculo, MidpointRounding.AwayFromZero);
        }
        private void verificarConsistencias()
        {
            if (FactorDivisaBs * lastDivisa != lastPrecio)
            {
                if (Properties.Settings.Default.esPrioridadPrecio)
                {
                    if (FactorDivisaBs * lastDivisa != lastPrecio)
                        lastDivisa = decimal.Round(lastPrecio / FactorDivisaBs, DecimalesCalculo);
                }
                else
                {
                    if (FactorDivisaBs / lastPrecio != FactorDivisaBs)
                        lastPrecio = decimal.Round(lastDivisa / FactorDivisaBs, 2, MidpointRounding.AwayFromZero);
                }
                if (lastDivisaCosto == 0)
                {
                    if (lastDivisaMargen == 0)
                        lastDivisaMargen = MargenGanancia;
                    lastDivisaCosto = decimal.Round(lastDivisa / (1 + (lastDivisaMargen / 100)), DecimalesCalculo);
                }
            }
        }
        void setCalcularTotalesMayorAuto(int opcion)
        {
            switch (opcion)
            {
                case 1: //preciomayor
                    break;
                case 2: //divisamayor
                    break;
                case 3: //divisamayorcosto
                    break;
                case 4: //margenmayor
                    break;
                default:
                    break;
            }
        }
        void setCalcularTotales(decimal Valor, int Opcion, bool esMargenFijo = false, bool esPrecioFijo = false, bool esPorLote = false)
        {
            if (lastDivisaFactor < 1)
                lastDivisaFactor = FactorDivisaBs;
            if (lastDivisaMargen == 0)
                lastDivisaMargen = MargenGanancia;
            if (lastDivisaCosto == 0)
                lastDivisaCosto = 0.001m;

            if (lastDivisaMargenMayor == 0)
                lastDivisaMargenMayor = MargenGanancia;
            if (lastDivisaCostoMayor == 0)
                lastDivisaCostoMayor = 0.001m;
            if (Valor <= 0 && Opcion < 3)
                Valor = 0.001m;

            //lastDivisaMargen = esMargenFijo ? lastDivisaMargenFactor_app : lastDivisaMargen;
            if (esPrecioFijo)
                chkPrecioFijo.Checked = esPrecioFijo;
            if (chkPrecioFijo.Checked)
                esPrecioFijo = true;

            switch (Opcion)
            {
                case 0://precio
                    lastDivisa = decimal.Round(Valor / lastDivisaFactor, DecimalesCalculo);
                    lastDivisaMargen = esMargenFijo ? lastDivisaMargen : decimal.Round(((lastDivisa - lastDivisaCosto) / lastDivisaCosto) * 100, 2, MidpointRounding.AwayFromZero);
                    if (esPorLote)
                        lastDivisaCosto = decimal.Round(lastDivisa / (1 + (lastDivisaMargen / 100)), 2);

                    break;
                case 1://divisa
                    if (!chkPrecioFijo.Checked || !esPrecioFijo)
                        lastPrecio = decimal.Round(Valor * lastDivisaFactor, 2, MidpointRounding.AwayFromZero);
                    lastDivisaMargen = esMargenFijo ? lastDivisaMargen : decimal.Round(((lastDivisa - lastDivisaCosto) / lastDivisaCosto) * 100, 2, MidpointRounding.AwayFromZero);
                    if (esPorLote)
                        lastDivisaCosto = decimal.Round(Valor / (1 + (lastDivisaMargen / 100)), 2);
                    break;
                case 2://costo
                    //if (Valor > 0.001m)
                    //{
                    //    decimal divisaProveedor = (Convert.ToDecimal(txtTasaDivisaProveedor.Text) > 0 ? Convert.ToDecimal(txtTasaDivisaProveedor.Text) : lastDivisaFactor);
                    //    lastDivisaCosto = Valor = decimal.Round(Valor / divisaProveedor, 2, MidpointRounding.AwayFromZero);
                    //}
                    if (Valor == 0.001m && lastDivisa > 0 && lastPrecio > 0)
                    {
                        if (lastDivisaMargen > 100 || lastDivisaMargen < 0)
                            lastDivisaMargen = lastDivisaMargenFactor_app;
                        lastDivisaCosto = decimal.Round(lastDivisa / ((lastDivisaMargen / 100) + 1), 2, MidpointRounding.AwayFromZero);
                        Valor = lastDivisaCosto;
                    }
                    lastDivisa = decimal.Round(Valor * (1 + (lastDivisaMargen / 100)), DecimalesCalculo);
                    if (!chkPrecioFijo.Checked || !esPrecioFijo)
                        lastPrecio = decimal.Round(lastDivisa * lastDivisaFactor, 2, MidpointRounding.AwayFromZero);
                    lastDivisaMargen = esMargenFijo ? lastDivisaMargen : decimal.Round(((lastDivisa - Valor) / Valor) * 100, 2, MidpointRounding.AwayFromZero);

                    break;
                case 3://margenFactor
                    if (!chkPrecioFijo.Checked || !esPrecioFijo)
                    {
                         
                            lastDivisa = decimal.Round(lastDivisaCosto * (1 + (Valor / 100)), DecimalesCalculo);
                            lastPrecio = decimal.Round(lastDivisa * lastDivisaFactor, 2, MidpointRounding.AwayFromZero);
                         
                    }
                    else
                        lastDivisaCosto = decimal.Round(lastDivisa / (1 + (Valor / 100)), 2);
                    break;
                case 5://preciomayor
                    if (lastDivisaMayor > 0)
                        Valor = lastDivisaFactor * lastDivisaMayor;
                    else
                        lastDivisaMayor = decimal.Round((Valor / lastDivisaFactor) * (1 + (lastDivisaMargenMayor / 100)), DecimalesCalculo);
                    lastDivisaCostoMayor = decimal.Round(lastDivisaMayor / (1 + (lastDivisaMargenMayor == 0 ? MargenGanancia : lastDivisaMargenMayor / 100)), 2);
                    lastDivisaMargenMayor = esMargenFijo ? lastDivisaMargenMayor : decimal.Round(((lastDivisaMayor - lastDivisaCostoMayor) / lastDivisaCostoMayor) * 100, 2, MidpointRounding.AwayFromZero);
                    break;
                case 6:// divisamayor 
                    lastDivisaMayor = Valor;
                    if (esMargenFijo)
                        lastDivisaMayor = decimal.Round(lastDivisaCostoMayor * (1 + (lastDivisaMargenMayor / 100)), DecimalesCalculo);
                    lastPrecioMayor = decimal.Round(lastDivisaMayor * lastDivisaFactor, 2, MidpointRounding.AwayFromZero);
                    lastDivisaMargenMayor = esMargenFijo ? lastDivisaMargenMayor : decimal.Round(((lastDivisaMayor - lastDivisaCostoMayor) / lastDivisaCostoMayor) * 100, 2, MidpointRounding.AwayFromZero);
                    if (esPorLote)
                        lastDivisaCostoMayor = decimal.Round(Valor / (1 + (lastDivisaMargenMayor / 100)), 2);
                    break;
                case 7://divisacostomayor

                    lastDivisaCostoMayor = Valor;
                    lastDivisaMayor = decimal.Round(lastDivisaCostoMayor * (1 + (lastDivisaMargenMayor / 100)), DecimalesCalculo);
                    lastPrecioMayor = decimal.Round(lastDivisaMayor * lastDivisaFactor, 2, MidpointRounding.AwayFromZero);
                    lastDivisaMargenMayor = esMargenFijo ? lastDivisaMargenMayor : decimal.Round(((lastDivisaMayor - Valor) / Valor) * 100, 2, MidpointRounding.AwayFromZero);
                    break;
                case 8://divisamargenmayor 
                    lastDivisaMayor = decimal.Round(lastDivisaCostoMayor * (1 + (Valor / 100)), DecimalesCalculo);
                    lastPrecioMayor = decimal.Round(lastDivisaMayor * lastDivisaFactor, 2, MidpointRounding.AwayFromZero);
                    lastDivisaCostoMayor = decimal.Round(lastDivisaMayor / (1 + (Valor / 100)), 2);
                    break;
                default:
                    break;
            }

        }
        private bool ProbarConexion()
        {
            loadDatos();
            bool esContinuar = true;
            if (lstItemsTransmitir != null)
            {
                if (lstItemsTransmitir.Count > 0 && !esSQLServer)
                    esContinuar = MessageBox.Show("Los datos pendientes por TRANSFERIR se BORRARAN.\n¿Desea ELIMINAR lista a Transmitir?", "Borrar Pendientes", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes ? true : false;
            }
            if (esContinuar)
            {
                try
                {
                    if (lstItemsTransmitir != null)
                    {
                        lstItemsTransmitir.Clear();
                        if (!esSQLServer)
                            btnTransmitir.Text = "0";
                    }
                    lstImpuestos = new List<clsImpuestos>();
                    gridOriginal.PrimaryGrid.DataSource = null;
                    gridFinal.PrimaryGrid.DataSource = null;
                    initGridFinal();
                    string sqlCommandGral =
                        @"SELECT   codigo, descr, precio, precio1, tiva, precio2 AS divisa, margen4 AS divisafactor, precio3 AS divisacosto, margen2 AS divisamargenfactor, grupo, unidad, unidade, nombre, barra, pidepre, pidecanti, promo, contenidou, ult_venta, 
                                   ult_compra, unidadv, unidadc, ult_actu, pbalanza, pideobse, tiva2, dgrupo, tipo, ultimo, min, max, codigoc,dpto_cajas, preciom, precio1m, precio2m AS divisamayor, precio3m AS divisacostomayor, 
                                   margen2m AS divisamargenfactormayor, precio2m, margen3m, margen3
                          FROM      inven";
                    string sqlCommandGralSQL =
                        @"SELECT   codigo, descr, precio, precio1, tiva, precio2 AS divisa, margen4 AS divisafactor, precio3 AS divisacosto, margen2 AS divisamargenfactor, grupo, unidad, unidade, nombre, barra, pidepre, pidecanti, promo, contenidou, ult_venta, 
                                   ult_compra, unidadv, unidadc, ult_actu, pbalanza, pideobse, tiva2, dgrupo, tipo, ultimo, min, max, codigoc,dpto_cajas, preciom, precio1m, precio2m AS divisamayor, precio3m AS divisacostomayor, 
                                   margen2m AS divisamargenfactormayor, precio2m, margen3m, margen3
                          FROM      inven";
                    if (esConectado)
                    {
                        if (!esSQLServer)
                        {
                            dsPpal.EnforceConstraints = false;
                            invenTableAdapter.Adapter.SelectCommand = null;
                            dsPpal.inven.Clear();
                            if (esTieneFiltro)
                            {
                                string filtro = "";
                                int i = 0;
                                foreach (CheckBox chk in gruposFiltrados)
                                {
                                    if (chk.Checked)
                                    {
                                        if (i > 0)
                                            filtro += " or ";
                                        filtro += "(grupo like '" + chk.Tag.ToString().Trim() + "')";
                                        i++;
                                    }
                                }
                                invenTableAdapter.FiltrarFilas(sqlCommandGral + " where " + filtro + (chkFilSoloTroquelados.Checked ? " and (tipo like'1')" : ""));
                            }
                            else
                                invenTableAdapter.FiltrarFilas(sqlCommandGral + (chkFilSoloTroquelados.Checked ? " where tipo='1'" : ""));

                            invenTableAdapter.Connection.ConnectionString = cnnString;
                            inven_usaTableAdapter.Connection.ConnectionString = cnnString;
                            taxTableAdapter.Connection.ConnectionString = cnnString;
                            estacionesTableAdapter1.Connection.ConnectionString = cnnString;
                            monedasTableAdapter1.Connection.ConnectionString = cnnString;
                            gruinvTableAdapter.Connection.ConnectionString = cnnString;
                            tipo_empaTableAdapter.Connection.ConnectionString = cnnString;
                            promoTableAdapter.Connection.ConnectionString = cnnString;
                            dpto_cajasTableAdapter1.Connection.ConnectionString = cnnString;

                            //ORdenar filas por ultima fecha Actualizada
                            //this.dsPpal.inven.DefaultView.Sort = "descr Asc";
                            //this.dsPpal.inven. = this.dsPpal.inven.DefaultView.ToTable();
                            invenTableAdapter.Fill(dsPpal.inven);
                            dpto_cajasTableAdapter1.Fill(dsPpal.dpto_cajas);
                            taxTableAdapter.Fill(dsPpal.tax);
                            estacionesTableAdapter1.Fill(dsPpal.estaciones);
                            monedasTableAdapter1.Fill(dsPpal.monedas, codigoMoneda);
                            gruinvTableAdapter.Fill(dsPpal.gruinv);
                            tipo_empaTableAdapter.Fill(dsPpal.tipo_empa);
                            promoTableAdapter.Fill(dsPpal.promo);

                            if (dsPpal.tax.Rows.Count > 0)
                                foreach (DataRow item in dsPpal.tax.Rows)
                                {
                                    lstImpuestos.Add(new clsImpuestos(Convert.ToDecimal(item["tipo"]), Convert.ToDecimal(item["valor"]), item["nombre"].ToString(), item["nomencla"].ToString(), item["descr"].ToString()));
                                }

                            if (tipo_empaTableAdapter.GetDataDescrUNIDAD().Rows.Count >= 1)
                                tipoUnidad_Default = tipo_empaTableAdapter.GetDataDescrUNIDAD().Rows[0]["codigo"].ToString();

                            invenBindingSource.DataMember = "inven";
                            invenBindingSource.DataSource = dsPpal;
                            foreach (GridColumn item in gridOriginal.PrimaryGrid.Columns)
                            {
                                item.DataPropertyName = item.DataPropertyName.ToLower();
                                if (item.DataPropertyName.Equals("ult_actu"))
                                {
                                    gridOriginal.PrimaryGrid.AddSort(item);
                                    item.SortDirection = SortDirection.Ascending;
                                    gridOriginal.PrimaryGrid.SetSort();
                                    item.ToggleSort();
                                }
                            }
                            crearArchivoEspejo();
                        }
                        else
                        {
                            INVENTableAdapter_SQL = new RetailTrump.dsPpalSqlServerTableAdapters.INVENTableAdapter();
                            MONEDASTableAdapter_SQL = new RetailTrump.dsPpalSqlServerTableAdapters.MONEDASTableAdapter();
                            ESTACIONESTableAdapter_SQL = new RetailTrump.dsPpalSqlServerTableAdapters.ESTACIONESTableAdapter();
                            GRUINVTableAdapter_SQL = new RetailTrump.dsPpalSqlServerTableAdapters.GRUINVTableAdapter();
                            TIPO_EMPATableAdapter_SQL = new RetailTrump.dsPpalSqlServerTableAdapters.TIPO_EMPATableAdapter();
                            PROMOTableAdapter_SQL = new RetailTrump.dsPpalSqlServerTableAdapters.PROMOTableAdapter();
                            TAXTableAdapter_SQL = new RetailTrump.dsPpalSqlServerTableAdapters.TAXTableAdapter();
                            tmpINVENTableAdapter = new RetailTrump.dsPpalSqlServerTableAdapters.tmpINVENTableAdapter();
                            DPTO_CAJASTableAdapter_SQL = new dsPpalSqlServerTableAdapters.DPTO_CAJASTableAdapter();
                            INVENTableAdapter_SQL.Adapter.SelectCommand = null;

                            dsPpalSQLServer.EnforceConstraints = false;
                            dsPpalSQLServer.INVEN.Clear();
                            if (esTieneFiltro)
                            {
                                string filtro = "";
                                int i = 0;
                                foreach (CheckBox chk in gruposFiltrados)
                                {
                                    if (chk.Checked)
                                    {
                                        if (i > 0)
                                            filtro += " or ";
                                        filtro += "(grupo like '" + chk.Tag.ToString().Trim() + "')";
                                        i++;
                                    }
                                }
                                INVENTableAdapter_SQL.FiltrarFilas(sqlCommandGral + " where " + filtro);
                                //MessageBox.Show("FILTRO:" + sqlCommandGral + " where " + filtro);
                            }
                            else
                                INVENTableAdapter_SQL.FiltrarFilas(sqlCommandGral);

                            INVENTableAdapter_SQL.Connection.ConnectionString = cnnString;
                            TAXTableAdapter_SQL.Connection.ConnectionString = cnnString;
                            MONEDASTableAdapter_SQL.Connection.ConnectionString = cnnString;
                            GRUINVTableAdapter_SQL.Connection.ConnectionString = cnnString;
                            TIPO_EMPATableAdapter_SQL.Connection.ConnectionString = cnnString;
                            PROMOTableAdapter_SQL.Connection.ConnectionString = cnnString;
                            tmpINVENTableAdapter.Connection.ConnectionString = cnnString;
                            DPTO_CAJASTableAdapter_SQL.Connection.ConnectionString = cnnString;

                            INVENTableAdapter_SQL.Fill(dsPpalSQLServer.INVEN);
                            TAXTableAdapter_SQL.Fill(dsPpalSQLServer.TAX);
                            MONEDASTableAdapter_SQL.Fill(dsPpalSQLServer.MONEDAS, codigoMoneda);
                            GRUINVTableAdapter_SQL.Fill(dsPpalSQLServer.GRUINV);
                            TIPO_EMPATableAdapter_SQL.Fill(dsPpalSQLServer.TIPO_EMPA);
                            PROMOTableAdapter_SQL.Fill(dsPpalSQLServer.PROMO);
                            DPTO_CAJASTableAdapter_SQL.Fill(dsPpalSQLServer.DPTO_CAJAS);

                            if (TIPO_EMPATableAdapter_SQL.GetDataDescrUNIDAD().Rows.Count >= 1)
                                tipoUnidad_Default = TIPO_EMPATableAdapter_SQL.GetDataDescrUNIDAD().Rows[0]["codigo"].ToString();
                            if (dsPpalSQLServer.TAX.Rows.Count > 0)
                                foreach (DataRow item in dsPpalSQLServer.TAX.Rows)
                                {
                                    lstImpuestos.Add(new clsImpuestos(Convert.ToDecimal(item["tipo"]), Convert.ToDecimal(item["valor"]), item["nombre"].ToString(), item["nomencla"].ToString(), item["descr"].ToString()));
                                }

                            invenBindingSource.DataMember = "INVEN";
                            invenBindingSource.DataSource = dsPpalSQLServer;

                            this.bindingSourceEmpaque.DataMember = "tipo_empa".ToUpper();
                            bindingSourceEmpaque.DataSource = dsPpalSQLServer;

                            this.bindingSourceGrupos.DataMember = "gruinv".ToUpper();
                            bindingSourceGrupos.DataSource = dsPpalSQLServer;

                            bindingSourceUnidades.DataMember = "tipo_empa".ToUpper();
                            bindingSourceUnidades.DataSource = dsPpalSQLServer;

                            this.bindingSourcePromocion.DataMember = "promo".ToUpper();
                            bindingSourcePromocion.DataSource = dsPpalSQLServer;

                            this.bindingSourceTax.DataMember = "tax".ToUpper();
                            bindingSourceTax.DataSource = dsPpalSQLServer;

                            this.BindingSourceDptos_Caja.DataMember = "dpto_cajas".ToUpper();
                            BindingSourceDptos_Caja.DataSource = dsPpalSQLServer;

                            foreach (GridColumn item in gridOriginal.PrimaryGrid.Columns)
                            {
                                item.DataPropertyName = item.DataPropertyName.ToUpper();
                            }

                        }

                        //add Items lst Impuestos
                        if (lstImpuestos.Count > 0)
                        {
                            cmbICalcTasa.Items.Clear();
                            foreach (var item in lstImpuestos)
                                cmbICalcTasa.Items.Add(item);
                            cmbICalcTasa.DisplayMember = "descr";
                        }
                        if (lstImpuestos.Count > 0)
                        {
                            cmbIImpuestosDptosCaja.Items.Clear();
                            foreach (var item in lstImpuestos)
                                cmbIImpuestosDptosCaja.Items.Add(item);
                            cmbIImpuestosDptosCaja.DisplayMember = "descr";
                            cmbIImpuestosDptosCaja.SelectedIndex = 0;
                        }
                        btnTransmitir.Visible = !esSQLServer;
                        descMoneda();
                        lblNumRegistros.Text = !esSQLServer ? dsPpal.inven.Rows.Count.ToString() + " Registros" : dsPpalSQLServer.INVEN.Rows.Count.ToString() + " Registros";
                        this.gridOriginal.PrimaryGrid.DataSource = this.invenBindingSource;
                        return true;
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    clsUtilErrors.Manejador_errores(ex);
                    return false;
                }

            }
            return false;
        }
        void ConectarEstacion(string cnn)
        {

            invenTableAdapter.Connection.ConnectionString = cnn;
            inven_usaTableAdapter.Connection.ConnectionString = cnn;
            monedasTableAdapter1.Connection.ConnectionString = cnn;

        }

        #endregion

        #region CONFIG
        private void guardarDatos()
        {
            guardarCnnString(cnnString);
            SettingsManager.AddUpdateAppSettings("LastDateUSe", encryptHelper.encryptus(DateTime.Now.ToShortDateString(), KeyClave));
            Properties.Settings.Default.LastDivisa = Convert.ToDouble(txtDivisa.Text);
            //Properties.Settings.Default.LastMargenGanancia = Convert.ToDecimal(txtMargen.Value);
            Properties.Settings.Default.TipoRedondeo = (int)TipoRedondeo;
            Properties.Settings.Default.esSQLServer = Program.esSQLServer;
            Properties.Settings.Default.Save();

            loadDatos();
        }
        private void loadDatos()
        {
            cnnString = Properties.Settings.Default.appCadenaConexionHuesped;
            txtDirDatos.Text = cnnString;
            lastDivisaFactor = Convert.ToDecimal(Properties.Settings.Default.LastDivisa);
            TipoRedondeo = (enTipoRedondeo)Properties.Settings.Default.TipoRedondeo;
            lastDivisaMargenFactor_app = Properties.Settings.Default.LastMargenGanancia;
            //txtMargen.Value = Convert.ToInt32(lastDivisaMargenFactor_app);
            Program.esSQLServer = Properties.Settings.Default.esSQLServer;
            FactorDivisaBs = (decimal)Properties.Settings.Default.LastDivisa;
            MargenGanancia = Properties.Settings.Default.LastMargenGanancia;
            codigoMoneda = Properties.Settings.Default.codigoMoneda;
            esControlPrecioBajo = Properties.Settings.Default.esControlPrecioBajo;
        }


        private void crearArchivoEspejo()
        {
            if (File.Exists(archivoDBFOrig))
                File.Copy(archivoDBFOrig, archivoDBFBack, true);
        }
        private void ProductosNuevos()
        {
            frmValor_Divisa frm = new frmValor_Divisa(this) { StartPosition = FormStartPosition.CenterParent };
            frm.ShowDialog(this);
            try
            {
                //FactorDivisaBs = (decimal)Properties.Settings.Default.LastDivisa;
                //txtDivisa_ButtonCustom2Click(txtDivisaCajas, null);
                loadDatos();
                txtDivisaCajas.Text = FactorDivisaCaja.ToString("N2");
                txtDivisa.Text = FactorDivisaBs.ToString("N2");
                int modi = 0;
                int rows = !esSQLServer ? invenTableAdapter.GetDataByProductosNuevos().Rows.Count : INVENTableAdapter_SQL.GetDataByProductosNuevos().Rows.Count;
                msjProgress(1, "Actualizando DIVISA\nProductos Nuevos!!!");
                if (frm.DialogResult == DialogResult.Yes)
                {
                    DataTable dataTable = !esSQLServer ? (DataTable)invenTableAdapter.GetDataByProductosNuevos() : (DataTable)INVENTableAdapter_SQL.GetDataByProductosNuevos();
                    foreach (DataRow item in dataTable.Rows)
                    {
                        try
                        {
                            item["Divisa"] = 0;
                            item["divisafactor"] = 0;
                            item["divisamargenfactor"] = 0;
                            item["divisacosto"] = 0;
                            modi += setUpdateItem(item);
                            msjProgress(CalcularProgreso(modi, rows), msjStatus: string.Format("Actualizados {0} de {1}", modi, rows));
                        }
                        catch (Exception ex)
                        {
                            ksslib.clsUtilErrors.Manejador_errores(ex, true);
                        }
                    }
                }
                else
                    if (rows > 0)
                    kss_msjDelay.Show("Aun Existen Productos sin DIVISA definida");
            }
            catch (Exception ex)
            {
                ksslib.clsUtilErrors.Manejador_errores(ex, true);
            }
            finally
            {
                ProbarConexion();
                msjProgress(esFin: true);
            }
        }

        #endregion

        #endregion


        public frmMain()
        {
            //==== Precio Detal
            //precio2 = divisa
            //precio3 = divisacosto
            //margen2 = divisamargenfactor
            //factor2 = divisafactor
            //==== Precio Mayor
            //precio2m = divisamayor
            //precio3m = divisacostomayor
            //margen2m = divisamargenfactormayor

            InitializeComponent();
            loadDatos();

        }

        private void btnTransmitir_TextChanged(object sender, EventArgs e)
        {
            if (btnTransmitir.Text.Equals("0"))
            {
                //btnTransmitir.Enabled = false;
                timTransmitir.Enabled = false;
                btniTransmitir.Enabled = false;
                btniLimpiar.Enabled = false;
                btniVerTransmitir.Enabled = false;
                btniLimpiarGrid.Enabled = false;
                btnTransmitir.SymbolColor = Color.Gray;
            }
            else
            {
                //btnTransmitir.Enabled = true;
                btniTransmitir.Enabled = true;
                btniLimpiar.Enabled = true;
                btniVerTransmitir.Enabled = true;
                btniLimpiarGrid.Enabled = true;
                timTransmitir.Enabled = true;
                btnTransmitir.SymbolColor = Color.Lime;
            }
        }

        private void btniLimpiarGrid_Click(object sender, EventArgs e)
        {
            gridFinal.PrimaryGrid.DataSource = null;
        }

        private void lblDEMO_Click(object sender, EventArgs e)
        {
            kss_msjDelay.Show(
                $"Usos Totales Versión DEMO <b>{Program.maxUsos}</b> de 50" +
                $"\nUsos Totales Verión DEMO Actual <b>{Program.nUsos}</b> de 5" +
                $"\nMáximo de Actualizaciones Versión DEMO <b>{Program.maxUsos}</b>  de 1000" +
                $"\nMáximo Actualizaciones por Sesión <b>{totalActualizacionesSesion}</b> de 20" +
                $"\n\n",
                enuMsgBoxImag.msgInformacion, "Reporte de Versión", 100
                );
        }

        void msjVersionDEMO(string msj)
        {
            kss_msjDelay.Show(msj + "\n<b>Función limitada por la Versión DEMO</b>\n", enuMsgBoxImag.msgCancel, "Actualice a Versión Completa", 50);
        }


        private void btnsrchProductoNuevo_Click(object sender, EventArgs e)
        {
            //Crear Producto
            rowEdit = !esSQLServer ? dsPpal.inven.NewRow() : dsPpalSQLServer.INVEN.NewRow();
            InicializarSearch();
            panelProductoDescr.Enabled = true;
            panelProductoPrecios.Enabled = true;
            txtCodigoBarras.ReadOnly = false;
            txtCodigoInterno.ReadOnly = false;
            txtCodEmpaque.ReadOnly = false;
            txtDescripcionSearch.ReadOnly = false;
            txtUndEmpaque.Text = "1,00";
            txtUndVenta.Text = "1,00";
            cmbTipoIVA.SelectedValue = 1;
            cmbTipoUnidad.SelectedValue = tipoUnidad_Default;
            cmbTipoEmpaque.SelectedValue = tipoUnidad_Default;
            //if (cmbDptoCajas.Items.Count > 0)
            //    cmbDptoCajas.SelectedIndex = -1;
            //    cmbDptoCajas.SelectedIndex = 0;
            txtCodigoInterno.Focus();
            selectedControl = null;
        }

        private void lblDescripcionSearch_DoubleClick(object sender, EventArgs e)
        {
            ((TextBox)sender).ReadOnly = !((TextBox)sender).ReadOnly;
        }

        private void txtCodigoBarras_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
                return;
            }
        }
        private bool esProductoExiste(string strBusqueda, int opc, bool esModificarExistente = true, string msg = "PRODUCTO YA EXISTE!", int tiempo = 4)
        {
            bool rowsEncontradas = false;
            strBusqueda = strBusqueda.Trim();
            switch (opc)
            {
                case 1:
                    rowsEncontradas = !esSQLServer
                        ? invenTableAdapterSrch.GetDataByCodigoInterno(strBusqueda).Rows.Count > 0 ? true : false
                        : INVENTableAdapterSrch_SQL.GetDataByCodigoInterno(strBusqueda).Rows.Count > 0 ? true : false;
                    break;
                case 2:
                    rowsEncontradas = !esSQLServer
                        ? invenTableAdapterSrch.GetDataByBarra(strBusqueda).Rows.Count > 0 ? true : false
                        : INVENTableAdapterSrch_SQL.GetDataByBarra(strBusqueda).Rows.Count > 0 ? true : false;
                    break;
                case 3:
                    rowsEncontradas = !esSQLServer
                        ? invenTableAdapterSrch.GetDataByDescr(strBusqueda).Rows.Count > 0 ? true : false
                        : INVENTableAdapterSrch_SQL.GetDataByDescr(strBusqueda).Rows.Count > 0 ? true : false;
                    break;
                default:
                    break;
            }
            if (rowsEncontradas)
            {
                if (msg.Length > 0)
                    toastNotificacion(panelSearch, msg, tiempo);
                if (esModificarExistente)
                {
                    InicializarSearch();
                    txtSearch.Text = strBusqueda;
                    btnSearch_Click(txtSearch, null);
                }
            }
            return rowsEncontradas;
        }
        private void txtCodigoBarras_Leave(object sender, EventArgs e)
        {
            if (!txtCodigoInterno.ReadOnly)
                if (txtCodigoInterno.Text.Trim().Length > 0 && !esProductoExiste(txtCodigoInterno.Text, 1))
                    if (txtCodigoBarras.Text.Trim().Length == 0)
                        txtCodigoBarras.Text = txtCodigoInterno.Text;
        }

        private void txtCodigoBarras_Leave_1(object sender, EventArgs e)
        {
            if (!txtCodigoBarras.ReadOnly)
                esProductoExiste(txtCodigoBarras.Text, 2);
        }

        private void txtDescripcionSearch_Leave(object sender, EventArgs e)
        {
            //Producto existe
            bool ProductoenBD = false;
            ProductoenBD = esProductoExiste(txtDescripcionSearch.Text, 3, false, msg: "") & esProductoExiste(txtCodigoInterno.Text, 2, false, msg: "");
            if (!txtDescripcionSearch.ReadOnly)
                if (!ProductoenBD && esProductoExiste(txtDescripcionSearch.Text, 3, false, "Este NOMBRE EXISTE.\nIntente de nuevo."))
                    txtDescripcionSearch.Focus();

        }

        private void txtCodigoInterno_Enter(object sender, EventArgs e)
        {
            if (((TextBox)sender).ReadOnly)
                toastNotificacion(panelSearch, "Haga DobleClick para EDITAR");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Eliminar Producto
            /*
             -Verificar que producto no tenga ventas recientes (1año en tabla movi)
             -Verificar que existencias == 0
             -
             */
            int Result = 0;
            if (ksslib.kss_msjDelay.Show("Desea ELIMINAR el Registro?", enuMsgBoxImag.msgCuidado, enuMsgBoxResult.msgYesNO, 5, "Eliminar Registro") == DialogResult.Yes)
                if (!esSQLServer)
                    Result = invenTableAdapter.DeleteQueryByCodigo(rowEdit["codigo"].ToString().Trim());
                else
                    Result = INVENTableAdapter_SQL.DeleteQueryByCodigo(rowEdit["codigo"].ToString().Trim());
            if (!esSQLServer && Result >= 1)
                activarTransmitir(rowEdit);
            if (Result > 0)
            {
                kss_msjDelay.Show("Datos Eliminados!", enuMsgBoxImag.btnCancel, SegundosMostrar: 1);
                string Estacion = "";
                if (!esSQLServer)
                    foreach (DataRow rowEstacion in dsPpal.estaciones.Rows)
                    {
                        Estacion = rowEstacion["descr"].ToString().Trim().ToUpper();
                        try
                        {
                            msjProgress(1, $"ELiminando en: {Estacion}\nEspere por favor", wait: 1);
                            ConectarEstacion(string.Format(cnnStringModel, rowEstacion["ruta"].ToString().Trim() + "\\data"));
                            using (OleDbConnection cnn = new OleDbConnection(invenTableAdapter.Connection.ConnectionString))
                                cnn.Open();
                            int modi = 1;
                            string producto = "";
                            if (lstItemsTransmitir != null)
                                foreach (DataRow item in lstItemsTransmitir)
                                {
                                    try
                                    {
                                        producto = rowEdit["descr"].ToString().Trim();
                                        producto = (producto.Length > 15 ? producto.Substring(0, 15) + "..." : producto);
                                        Result = invenTableAdapter.DeleteQueryByCodigo(rowEdit["codigo"].ToString().Trim());
                                        if (Result == 0)
                                            throw new Exception($"NO se pudo Eliminar.\nProducto Eliminado o no Existe en {Estacion}.\n{producto}");
                                        else
                                            msjProgress(CalcularProgreso(modi, 1), msjStatus: $"{producto}\n" + string.Format("Eliminados {0} de {1}", modi, 1));

                                    }
                                    catch (Exception ex)
                                    {
                                        ksslib.clsUtilErrors.Manejador_errores(ex, false);
                                        msjProgress(100, $"Producto NO ELIMINADO:\n{producto}", msjStatus: ex.Message, wait: 2);
                                    }
                                }
                        }
                        catch (Exception ex)
                        {
                            ksslib.clsUtilErrors.Manejador_errores(ex, false);
                            msjProgress(100, $"NO se pudo conectar a:\n{Estacion}", msjStatus: ex.Message, wait: 2);
                        }
                        finally
                        {
                            msjProgress(esFin: true);
                        }
                    }
                ProbarConexion();
                CargarDialogControl.cargarDlgBackTransparent(panelSearch, true, true);
            }

        }


        private void btnSaveGrupo_Click(object sender, EventArgs e)
        {
            if (txtICodigoGrupo.Text.Trim().Length != 0 && txtIDescrGrupo.Text.Trim().Length != 0)
            {
                txtIDescrGrupo.Text = txtIDescrGrupo.Text.ToUpper();
                txtIGastoGrupo.Text = !ksslib_c.Utiles.clsUtil_Strings.IsNumeric(txtIGastoGrupo.Text) ? "0" : txtIGastoGrupo.Text;

                string codigo = txtICodigoGrupo.Text.ToUpper();
                int result = 0;
                DataRowCollection rows = null;
                rows = !esSQLServer
                    ? gruinvTableAdapter.GetDataByCodigo(txtICodigoGrupo.Text.ToUpper()).Rows
                    : GRUINVTableAdapter_SQL.GetDataByCodigo(txtICodigoGrupo.Text.ToUpper()).Rows;
                if (rows.Count > 0)
                {
                    codigo = rows[0]["codigo"].ToString();
                    result = !esSQLServer
                        ? gruinvTableAdapter.UpdateQuery(codigo, txtIDescrGrupo.Text, Convert.ToDecimal(txtIGastoGrupo.Text), codigo)
                        : GRUINVTableAdapter_SQL.UpdateQuery(txtIDescrGrupo.Text, Convert.ToDecimal(txtIGastoGrupo.Text), codigo);
                }
                else
                {
                    result = !esSQLServer
                        ? gruinvTableAdapter.InsertQuery(txtIDescrGrupo.Text, codigo, Convert.ToDecimal(txtIGastoGrupo.Text))
                        : GRUINVTableAdapter_SQL.InsertQuery(txtIDescrGrupo.Text, codigo, Convert.ToDecimal(txtIGastoGrupo.Text));
                }

                if (result > 0)
                {
                    if (!esSQLServer)
                        gruinvTableAdapter.Fill(dsPpal.gruinv);
                    else
                        GRUINVTableAdapter_SQL.Fill(dsPpalSQLServer.GRUINV);
                    txtIDescrGrupo.Text = "";
                    txtIGastoGrupo.Text = "";
                    txtICodigoGrupo.Text = "0";
                    cmbSrchGrupo.SelectedValue = codigo;

                }
            }
            else
                kss_msjDelay.Show("Datos Incompletos!");
        }
        private void addEmpaque(string descr, string Abreviatura, int opcion)
        {
            if (descr.Trim().Length != 0 && Abreviatura.Trim().Length != 0)
            {
                descr = descr.ToUpper();
                Abreviatura = Abreviatura.ToUpper();
                string codigo = lblICodigoEmpaque.Text.Trim().Length == 0 ? "" : lblICodigoEmpaque.Text;
                int result = 0;
                DataRowCollection rows = null;
                rows = !esSQLServer
                    ? tipo_empaTableAdapter.GetDataByCodigo(codigo).Rows
                    : TIPO_EMPATableAdapter_SQL.GetDataByCodigo(codigo).Rows;
                if (rows.Count > 0)
                {
                    codigo = rows[0]["codigo"].ToString();
                    result = !esSQLServer
                        ? tipo_empaTableAdapter.UpdateQuery(descr, Abreviatura, codigo)
                        : TIPO_EMPATableAdapter_SQL.UpdateQuery(descr, Abreviatura, codigo);
                }
                else
                {
                    codigo = !esSQLServer
                    ? tipo_empaTableAdapter.ScalarQueryUltimoCodigo() == null ? "0001" : (Convert.ToInt16(tipo_empaTableAdapter.ScalarQueryUltimoCodigo()) + 1).ToString("0000")
                    : TIPO_EMPATableAdapter_SQL.ScalarQueryUltimoCodigo() == null ? "0001" : (Convert.ToInt16(TIPO_EMPATableAdapter_SQL.ScalarQueryUltimoCodigo()) + 1).ToString("0000");

                    result = !esSQLServer
                        ? tipo_empaTableAdapter.InsertQuery(codigo, descr, Abreviatura)
                        : TIPO_EMPATableAdapter_SQL.InsertQuery(codigo, descr, Abreviatura);
                }

                if (result > 0)
                {
                    string empaqueSelected = (string)cmbTipoEmpaque.SelectedValue ?? "";
                    string unidadSelected = (string)cmbTipoUnidad.SelectedValue ?? "";
                    if (!esSQLServer)
                        tipo_empaTableAdapter.Fill(dsPpal.tipo_empa);
                    else
                        TIPO_EMPATableAdapter_SQL.Fill(dsPpalSQLServer.TIPO_EMPA);
                    switch (opcion)
                    {
                        case 0:
                            txtIDescrEmpaque.Text = "";
                            txtIAbreviaturaEmpaque.Text = "";
                            lblICodigoEmpaque.Text = "";
                            cmbTipoEmpaque.SelectedValue = codigo;
                            cmbTipoUnidad.SelectedValue = unidadSelected;
                            break;
                        case 1:
                            txtIDescrUnidades.Text = "";
                            txtIAbreviaturaUnidades.Text = "";
                            lbliCodigoUnidad.Text = "";
                            cmbTipoUnidad.SelectedValue = codigo;
                            cmbTipoEmpaque.SelectedValue = empaqueSelected;
                            break;
                        default:
                            break;
                    }
                }
            }
            else
                kss_msjDelay.Show("Datos Incompletos!");
        }
        private void btnSaveEmpaque_Click(object sender, EventArgs e)
        {
            switch (((ButtonItem)sender).Name)
            {
                case "btnSaveEmpaque":
                    addEmpaque(txtIDescrEmpaque.Text, txtIAbreviaturaEmpaque.Text, 0);
                    break;
                case "btnSaveUnidad":
                    addEmpaque(txtIDescrUnidades.Text, txtIAbreviaturaUnidades.Text, 1);
                    break;
                default:
                    break;
            }

        }


        private void txtICodigoGrupo_LostFocus(object sender, EventArgs e)
        {
            //Buscar si codigo existe
            DataRowCollection rows = null;
            rows = !esSQLServer
                ? tipo_empaTableAdapter.GetDataByCodigo(txtIDescrEmpaque.Text.ToUpper()).Rows
                : TIPO_EMPATableAdapter_SQL.GetDataByCodigo(txtIDescrEmpaque.Text.ToUpper()).Rows;
            if (rows.Count > 0)
            {
                txtIDescrEmpaque.Text = rows[0]["descr"].ToString();
                txtIAbreviaturaEmpaque.Text = rows[0]["descr1"].ToString();
            }
        }


        private void txtIDescrEmpaque_LostFocus(object sender, EventArgs e)
        {
            DataRowCollection rows = null;
            rows = !esSQLServer
                ? tipo_empaTableAdapter.GetDataByDescr(txtIDescrEmpaque.Text).Rows
                : TIPO_EMPATableAdapter_SQL.GetDataByDescr(txtIDescrEmpaque.Text).Rows;
            if (rows.Count > 0)
            {
                txtIDescrEmpaque.Text = rows[0]["descr"].ToString();
                txtIAbreviaturaEmpaque.Text = rows[0]["descr1"].ToString();
                lblICodigoEmpaque.Text = rows[0]["codigo"].ToString();
            }
        }

        private void btnAddGrupos_Click(object sender, EventArgs e)
        {
            txtIGastoGrupo.Text = "0";
            txtICodigoGrupo.Text = "";
            txtIDescrGrupo.Text = "";
            txtICodigoGrupo.Focus();
        }

        private void btnAddUnidades_Click(object sender, EventArgs e)
        {
            txtIAbreviaturaUnidades.Text = "";
            txtIDescrUnidades.Text = "";
            txtIDescrUnidades.Focus();
        }

        private void btnAddEmpaques_Click(object sender, EventArgs e)
        {
            txtIDescrEmpaque.Text = "";
            txtIAbreviaturaEmpaque.Text = "";
            txtIDescrEmpaque.Focus();
        }


        private void chkTroquelado_CheckedChanged(object sender, EventArgs e)
        {
            chkPrecioFijo.Checked = chkTroquelado.Checked;
        }
        void calcularCostoUnidad()
        {
            decimal cantidad = Convert.ToDecimal(txtICalcCantidad.Text) > 0 ? Convert.ToDecimal(txtICalcCantidad.Text) : 1; ;
            decimal montoTotal = Convert.ToDecimal(txtICalcMontoTotal.Text) > 0 ? Convert.ToDecimal(txtICalcMontoTotal.Text) : 1;
            if (cmbICalcTasa.SelectedItem == null)
                cmbICalcTasa.SelectedIndex = 0;
            decimal ValorIva = ((clsImpuestos)cmbICalcTasa.SelectedItem).valor;
            decimal montoUndBs = 0;
            montoUndBs = ValorIva > 0 ? (montoTotal / cantidad) * (1 + (ValorIva / 100)) : (montoTotal / cantidad);
            lastDivisaFactorProveedor = Convert.ToDecimal(txtICalcTasaDivisaProveedor.Text);
            decimal montoUndDivisa = montoUndBs / (lastDivisaFactorProveedor > 0 ? lastDivisaFactorProveedor : 1);
            lblICalcCostoUndBs.Text = montoUndBs.ToString("N2");
            txtICalcMontoUnidadDivisa.Text = montoUndDivisa.ToString("N2");
            //lblICalcCostoUndBs.Text =string.Format(tmplblIcalMontoUndBs, montoUndBs);
            lastDivisaCosto = montoUndDivisa;
        }
        private void btnIOK_Click(object sender, EventArgs e)
        {
            txtSrchCosto.Text = Convert.ToDecimal(txtICalcMontoUnidadDivisa.Text) != lastDivisaCosto ? txtICalcMontoUnidadDivisa.Text : lastDivisaCosto.ToString($"N{DecimalesCalculo}");
            lastDivisaCosto = Convert.ToDecimal(txtSrchCosto.Text);
            buttonX6.Expanded = false;
            txtSrchCosto.Focus();
        }

        private void buttonX6_PopupShowing(object sender, EventArgs e)
        {
            try
            {
                txtICalcCantidad.TextAlign = HorizontalAlignment.Right;
                txtICalcMontoTotal.TextAlign = HorizontalAlignment.Right;
                txtICalcMontoUnidadDivisa.TextAlign = HorizontalAlignment.Right;
                txtICalcTasaDivisaProveedor.TextAlign = HorizontalAlignment.Right;
                if (lastDivisaFactorProveedor > 0)
                    txtICalcTasaDivisaProveedor.Text = lastDivisaFactorProveedor.ToString("N2");
                else
                    txtICalcTasaDivisaProveedor.Text = lastDivisaFactor.ToString("N2");
                lastDivisaFactorProveedor = Convert.ToDecimal(txtICalcTasaDivisaProveedor.Text);
                txtICalcCantidad.Text = txtUndEmpaque.Text;// "0,00";
                txtICalcMontoTotal.Text = "0,00";
                txtICalcMontoUnidadDivisa.Text = "0,00";
                txtICalcMontoUnidadDivisa.Text = txtSrchCosto.Text;
                lblICalcCostoUndBs.Text = 0.ToString("N2");
                txtICalcMontoTotal.Focus();
                Application.DoEvents();

            }
            catch (Exception)
            {


            }
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {

        }

        private void txtICalcMontoTotal_LostFocus(object sender, EventArgs e)
        {
            calcularCostoUnidad();
        }

        private void txtPrecioM_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbICalcTasa_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcularCostoUnidad();
        }

        private void btnISaveDpto_Cajas_Click(object sender, EventArgs e)
        {
            if (txtIDptosCaja.Text.Length >= 0)
            {
                txtIDptosCaja.Text = txtIDptosCaja.Text.ToUpper();

                string codigo = !esSQLServer ?
                    string.IsNullOrEmpty(dpto_cajasTableAdapter1.ScalarQueryUltimoCodigo()) ? "00" : dpto_cajasTableAdapter1.ScalarQueryUltimoCodigo() :
                    string.IsNullOrEmpty(DPTO_CAJASTableAdapter_SQL.ScalarQueryUltimoID()) ? "00" : DPTO_CAJASTableAdapter_SQL.ScalarQueryUltimoID();
                codigo = (Convert.ToInt32(codigo) + 1).ToString("00");
                int encontrados = !esSQLServer
                    ? Convert.ToInt16(dpto_cajasTableAdapter1.ScalarQueryCodigoExiste(txtIDptosCaja.Text.ToUpper()))
                    : Convert.ToInt16(DPTO_CAJASTableAdapter_SQL.ScalarQueryCodigoExiste(txtIDptosCaja.Text.ToUpper()));
                decimal ValorIva = ((clsImpuestos)cmbIImpuestosDptosCaja.SelectedItem).tipo;
                int result = 0;
                if (encontrados > 0)
                {
                    result = !esSQLServer
                        ? dpto_cajasTableAdapter1.UpdateQuery(txtIDptosCaja.Text.ToUpper(), ValorIva, codigo)
                        : DPTO_CAJASTableAdapter_SQL.UpdateQuery(txtIDptosCaja.Text.ToUpper(), ValorIva, codigo);
                }
                else
                {
                    codigo = (Convert.ToInt16(codigo) + 1).ToString("00");
                    result = !esSQLServer
                        ? dpto_cajasTableAdapter1.InsertQuery(codigo, txtIDptosCaja.Text.ToUpper(), ValorIva)
                        : DPTO_CAJASTableAdapter_SQL.InsertQuery(codigo, txtIDptosCaja.Text.ToUpper(), ValorIva);
                }

                if (result > 0)
                {
                    if (!esSQLServer)
                        dpto_cajasTableAdapter1.Fill(dsPpal.dpto_cajas);
                    else
                        DPTO_CAJASTableAdapter_SQL.Fill(dsPpalSQLServer.DPTO_CAJAS);
                    txtIDptosCaja.Text = "";
                    cmbDptoCajas.SelectedValue = codigo;
                }
            }
            else
                kss_msjDelay.Show("Datos Incompletos!");
        }

        private void btnAddDptosCaja_Click(object sender, EventArgs e)
        {
            txtIDptosCaja.Text = "";
        }

        private void txtIDptosCaja_LostFocus(object sender, EventArgs e)
        {
            //Buscar si codigo existe
            DataRowCollection rows = null;
            rows = !esSQLServer
                ? dpto_cajasTableAdapter1.GetDataByCodigo(txtIDptosCaja.Text.ToUpper()).Rows
                : DPTO_CAJASTableAdapter_SQL.GetDataByCodigo(txtIDptosCaja.Text.ToUpper()).Rows;
            if (rows.Count > 0)
            {
                txtIDptosCaja.Text = rows[0]["codigo"].ToString();
                cmbDptoCajas.SelectedValue = Convert.ToInt16(rows[0]["tiva"]);
            }
        }

        private void txtIDescrUnidades_LostFocus(object sender, EventArgs e)
        {
            //Buscar si codigo existe
            DataRowCollection rows = null;
            rows = !esSQLServer
                ? tipo_empaTableAdapter.GetDataByCodigo(txtIDescrUnidades.Text.ToUpper()).Rows
                : TIPO_EMPATableAdapter_SQL.GetDataByCodigo(txtIDescrUnidades.Text.ToUpper()).Rows;
            if (rows.Count > 0)
            {
                txtIDescrUnidades.Text = rows[0]["descr"].ToString();
                txtIAbreviaturaUnidades.Text = rows[0]["descr1"].ToString();
            }
        }

        private void cmbDptoCajas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDptoCajas.SelectedIndex >= 0)
            {
                try
                {
                    var row = cmbDptoCajas.SelectedItem;
                    int tiva = Convert.ToInt32(((System.Data.DataRowView)row).Row.ItemArray[2]);
                    cmbTipoIVA.SelectedValue = tiva;
                    cmbICalcTasa.SelectedIndex = tiva;
                }
                catch (Exception)
                {

                }
            }
        }

        #region BuscarGrid
        private void txtFilterGridOriginal_ButtonCustomClick(object sender, EventArgs e)
        {
            //if (txtFilterGridOriginal.ButtonCustom2.Checked)
            //{
            txtFilterGridOriginal.Text = "";
            txtFilterbtnChecked(false);
            //}
        }
        void txtFilterbtnChecked(bool esChecked)
        {
            txtFilterGridOriginal.ButtonCustom2.Checked = esChecked;
            if (esChecked)
            {
                txtFilterGridOriginal.ButtonCustom2.Text = "Código";
                txtFilterGridOriginal.ButtonCustom2.Symbol = "";
            }
            else
            {
                txtFilterGridOriginal.ButtonCustom2.Text = "Descripción";
                txtFilterGridOriginal.ButtonCustom2.Symbol = "";
            }
            BuscarDbGridPor();
        }
        private void txtFilterGridOriginal_ButtonCustom2Click(object sender, EventArgs e)
        {

            txtFilterbtnChecked(!txtFilterGridOriginal.ButtonCustom2.Checked);
        }
        private void txtFilterGridOriginal_TextChanged(object sender, EventArgs e) => BuscarDbGridPor();
        void BuscarDbGridPor()
        {
            Cursor = Cursors.WaitCursor;
            if (!txtFilterGridOriginal.ButtonCustom2.Checked)
                invenBindingSource.Filter = $"descr like '%{txtFilterGridOriginal.Text}%'";
            else
                invenBindingSource.Filter = $"codigo= '{txtFilterGridOriginal.Text}'";
            Cursor = Cursors.Default;
        }
        #endregion

        private void btniTransmitirTodo_Click(object sender, EventArgs e)
        {
            if (!esSQLServer)
            {
                string Estacion = "";
                int modi = 0;
                if (dsPpal.estaciones.Rows.Count > 0)
                {
                    bool esError = false;
                    int nEstaciones = dsPpal.estaciones.Rows.Count;
                    string msj = "";
                    foreach (DataRow rowEstacion in dsPpal.estaciones.Rows)
                    {
                        Estacion = rowEstacion["descr"].ToString().Trim().ToUpper();
                        try
                        {
                            esError = false;
                            msjProgress(1, $"Enviando a: {Estacion}\nEspere por favor", wait: 1);
                            modi++;
                            if (Program.esLicenciaDemo && modi >= 2)
                            {
                                msjVersionDEMO("Solo se podrán TRANSMITIR 3 Registros");
                                break;
                            }
                            try
                            {
                                string invenRemoto = System.IO.Path.Combine(rowEstacion["ruta"].ToString().Trim() + "\\data\\", "inven.dbf");
                                string invenCDXRemoto = System.IO.Path.Combine(rowEstacion["ruta"].ToString().Trim() + "\\data\\", "inven.cdx");
                                File.Copy(archivoDBFOrig, invenRemoto, true);
                                File.Copy(archivoDBFOrigCDX, invenCDXRemoto, true);
                                msjProgress(CalcularProgreso(modi, nEstaciones), msjStatus: $"{Estacion}\n" + string.Format("Actualizados {0} de {1}", modi, nEstaciones));

                                if (File.Exists(invenRemoto))
                                    msj = $"Transferecia exitosa a {Estacion}\nENVIADOS:{modi.ToString("N0")}";
                                else
                                {
                                    esError = true;
                                    msj = $"Datos NO TRANSMITIDO a {Estacion}";
                                }
                                if (modi > 0)
                                    msjProgress(!esError ? 100 : CalcularProgreso(modi, nEstaciones), msjAccion: !esError ? msj : msj + "\nAlgunos NO Transmitidos!", wait: 4);
                            }
                            catch (Exception ex)
                            {
                                ksslib.clsUtilErrors.Manejador_errores(ex, false);
                                msjProgress(100, $"Datos NO Transmitido:\n{Estacion}", msjStatus: ex.Message, wait: 2);
                                esError = true;
                            }
                        }
                        finally
                        {
                            msjProgress(esFin: true);
                        }
                    }
                }
            }
        }

        #region Global

        #endregion

        #region Eventos

        #endregion

        #region Metodos

        #endregion

        private void gridFinal_Click(object sender, EventArgs e)
        {

        }

        private void txtUndEmpaque_TextChanged(object sender, EventArgs e)
        {
            if (txtUndEmpaque.Text.Trim().Length > 0)
            {
                try
                {
                    totalUnidadesEmpaque = Convert.ToDecimal(txtUndEmpaque.Text);
                }
                catch
                {
                    totalUnidadesEmpaque = 0;
                }
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        #region AUMENTO REBAJA

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gTipoAumento.Text = rAumento.Checked ? "TipoAumento" : "Tipo Rebaja";
        }

        private void rPorcentaje_CheckedChanged(object sender, EventArgs e)
        {
            cmbAumMoneda.Enabled = !rPorcentaje.Checked;
        }

        private void buttonX2_Click_1(object sender, EventArgs e)
        {
            decimal v = 0;
            try
            {
                v = Convert.ToDecimal(txtAumValor.Text);
            }
            catch
            {

            }
            if (v > 0)
            {
                //recorre registros y cambiar
                int aa = 0;
                if (rAplicaCosto.Checked)
                    aa = 1;
                if (rAplicaDivisa.Checked)
                    aa = 2;
                if (rAplicaPrecio.Checked)
                    aa = 3;
                bool d = cmbAumMoneda.SelectedIndex == 0 ? true : false;

                AplicarAumentoRebaja(rAumento.Checked, rPorcentaje.Checked, aa, d, v);
            }
            else
            {
                MessageBox.Show("Debe indicar Valor de Cálculo");
            }
            panAumentoRebaja.Visible = false;
        }
        private void AplicarAumentoRebaja(bool esAumento, bool esPorPorcentaje, int AplicarA, bool esDivisa, decimal ValorCalculo)
        {
            string svalor = "";
            switch (AplicarA)
            {
                case 1:
                    svalor = "COSTO";
                    break;
                case 2:
                    svalor = "DIVISA";
                    break;
                case 3:
                    svalor = "PRECIO";
                    break;
                default:
                    break;
            }
            msjProgress(1, $"Actualizando Margen GANANCIA\nEn {svalor} de Productos");
            try
            {
                lstItemsTransmitir = null;
                int modi = 0;
                this.Cursor = Cursors.WaitCursor;
                //esChanginTodo = true;
                int count = dsPpal.inven.Rows.Count;
                DataRowCollection rows = !esSQLServer ? invenTableAdapter.GetData().Rows : INVENTableAdapter_SQL.GetData().Rows;
                decimal prcValor = 1 + (ValorCalculo / 100);
                foreach (DataRow item in rows)
                {
                    bool esTroquel = false;
                    try
                    {
                        if (esSQLServer)
                        {
                            item["regulado"] = item["regulado"] == DBNull.Value ? 0 : item["regulado"];
                            item["troquela"] = item["troquela"] == DBNull.Value ? 0 : item["troquela"];

                            if (Convert.ToInt16(item["regulado"]) > 0)
                                esTroquel = true;
                            if (Convert.ToInt16(item["troquela"]) > 0)
                                esTroquel = true;
                        }
                        else
                        {
                            item["tipo"] = item["tipo"] == DBNull.Value ? 0 : string.IsNullOrEmpty(item["tipo"].ToString()) ? 0 : item["tipo"];
                            if (Convert.ToInt16(item["tipo"]) > 0)
                                esTroquel = true;
                        }
                    }
                    catch
                    {
                        esTroquel = false;
                    }

                    if (!esTroquel)
                    {
                        try
                        {
                            getDatosItem(item);
                            if (esAumento)
                            {
                                switch (AplicarA)
                                {
                                    case 1:
                                        if (esPorPorcentaje)
                                            lastDivisaCosto = Convert.ToDecimal(item["divisacosto"]) * prcValor;
                                        else
                                        {
                                            if (esDivisa)
                                                lastDivisaCosto = Convert.ToDecimal(item["divisacosto"]) + ValorCalculo;
                                            else
                                                lastDivisaCosto = Convert.ToDecimal(item["divisacosto"]) + (ValorCalculo / FactorDivisaBs);
                                        }
                                        setCalcularTotales(lastDivisaCosto, 2);
                                        break;
                                    case 2:

                                        if (esPorPorcentaje)
                                            lastDivisa = Convert.ToDecimal(item["divisa"]) * prcValor;
                                        else
                                        {
                                            if (esDivisa)
                                                lastDivisa = Convert.ToDecimal(item["divisa"]) + ValorCalculo;
                                            else
                                                lastDivisa = Convert.ToDecimal(item["divisa"]) + (ValorCalculo / FactorDivisaBs);
                                        }
                                        setCalcularTotales(lastDivisa, 1);
                                        break;
                                    case 3:

                                        if (esPorPorcentaje)
                                            lastPrecio = Convert.ToDecimal(item["precio"]) * prcValor;
                                        else
                                        {
                                            if (esDivisa)
                                                lastPrecio = (Convert.ToDecimal(item["precio"]) / FactorDivisaBs) + ValorCalculo;
                                            else
                                                lastPrecio = Convert.ToDecimal(item["precio"]) + ValorCalculo;
                                        }
                                        setCalcularTotales(lastPrecio, 0);
                                        break;
                                    default:

                                        break;
                                }
                            }
                            else
                            {
                                switch (AplicarA)
                                {
                                    case 1:
                                        if (esPorPorcentaje)
                                            lastDivisaCosto = Convert.ToDecimal(item["divisacosto"]) - ((ValorCalculo * Convert.ToDecimal(item["divisacosto"])) / 100);
                                        else
                                        {
                                            if (esDivisa)
                                                lastDivisaCosto = Convert.ToDecimal(item["divisacosto"]) - ValorCalculo;
                                            else
                                                lastDivisaCosto = Convert.ToDecimal(item["divisacosto"]) - (ValorCalculo / FactorDivisaBs);
                                        }
                                        setCalcularTotales(lastDivisaCosto, 2);
                                        break;
                                    case 2:

                                        if (esPorPorcentaje)
                                            lastDivisa = Convert.ToDecimal(item["divisa"]) - ((ValorCalculo * Convert.ToDecimal(item["divisa"])) / 100);
                                        else
                                        {
                                            if (esDivisa)
                                                lastDivisa = Convert.ToDecimal(item["divisa"]) - ValorCalculo;
                                            else
                                                lastDivisa = Convert.ToDecimal(item["divisa"]) - (ValorCalculo / FactorDivisaBs);
                                        }
                                        setCalcularTotales(lastDivisa, 1);
                                        break;
                                    case 3:

                                        if (esPorPorcentaje)
                                            lastPrecio = Convert.ToDecimal(item["precio"]) - ((ValorCalculo * Convert.ToDecimal(item["precio"])) / 100);
                                        else
                                        {
                                            if (esDivisa)
                                                lastPrecio = (Convert.ToDecimal(item["precio"]) / FactorDivisaBs) - ValorCalculo;
                                            else
                                                lastPrecio = Convert.ToDecimal(item["precio"]) - ValorCalculo;
                                        }
                                        setCalcularTotales(lastPrecio, 0);
                                        break;
                                    default:

                                        break;
                                }
                            }
                            item["divisamargenfactor"] = lastDivisaMargen;
                            item["precio"] = lastPrecio;
                            item["divisa"] = lastDivisa;
                            item["divisacosto"] = lastDivisaCosto;

                            try
                            {
                                item["divisamargenfactormayor"] = lastDivisaMargenMayor;
                                item["preciom"] = lastPrecioMayor;
                                item["divisamayor"] = lastDivisaMayor;
                                item["divisacostomayor"] = lastDivisaCostoMayor;
                            }
                            catch
                            {

                            }
                            activarTransmitir(item);
                            modi++;
                            msjProgress(CalcularProgreso(modi, count), msjStatus: string.Format("Actualizados {0} de {1}", modi, count));
                        }
                        catch (Exception ex)
                        {
                            ksslib.clsUtilErrors.Manejador_errores(ex, false);
                        }
                        finally
                        {

                        }

                    }

                }
            }
            finally
            {
                if (lstItemsTransmitir != null)
                    simularCambios(false);
                msjProgress(esFin: true);
                //esChanginTodo = false;
                this.Cursor = Cursors.Default;
            }
        }
        #endregion

        private void buttonX1_Click(object sender, EventArgs e) => CargarDialogControl.cargarDlgBackTransparent(panAumentoRebaja, false, true);

        private void panAumentoRebaja_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.dpana.com.ve");
        }
    }
}
