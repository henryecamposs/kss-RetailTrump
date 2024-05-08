using DevComponents.DotNetBar;

namespace RetailTrump
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            DevComponents.DotNetBar.SuperGrid.Style.Background background1 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.Style.Background background2 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.Style.Background background3 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.Style.Background background4 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.txtDivisaCajas = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumRegistros = new DevComponents.DotNetBar.LabelX();
            this.txtDirDatos = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnMinimize = new DevComponents.DotNetBar.ButtonX();
            this.btnProbar = new DevComponents.DotNetBar.ButtonX();
            this.btnTransmitir = new DevComponents.DotNetBar.ButtonX();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.btniTransmitir = new DevComponents.DotNetBar.ButtonItem();
            this.btniLimpiar = new DevComponents.DotNetBar.ButtonItem();
            this.btniVerTransmitir = new DevComponents.DotNetBar.ButtonItem();
            this.btniLimpiarGrid = new DevComponents.DotNetBar.ButtonItem();
            this.btniTransmitirTodo = new DevComponents.DotNetBar.ButtonItem();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.txtDivisa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSalir = new DevComponents.DotNetBar.ButtonX();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnPrecioManual = new DevComponents.DotNetBar.ButtonX();
            this.btnFiltrar = new DevComponents.DotNetBar.ButtonX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.txtFilterGridOriginal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSimular = new DevComponents.DotNetBar.ButtonX();
            this.gridOriginal = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.gridColumn16 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gcDescr = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gcPrecio = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gcDivisa = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gcCosto = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gcGrupo = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.invenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPpal = new RetailTrump.dsPpal();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnActualizar = new DevComponents.DotNetBar.ButtonX();
            this.gridFinal = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn18 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.invenUsaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelProgressBar = new System.Windows.Forms.Panel();
            this.lblbarAccion = new DevComponents.DotNetBar.LabelX();
            this.progressBarX1 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.lblbarStatusAccion = new DevComponents.DotNetBar.LabelX();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.lblProductoNoExiste = new DevComponents.DotNetBar.LabelX();
            this.panelProductoDescr = new System.Windows.Forms.Panel();
            this.cmbTipoIVA = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.bindingSourceTax = new System.Windows.Forms.BindingSource(this.components);
            this.labelX20 = new DevComponents.DotNetBar.LabelX();
            this.btnAddDptosCaja = new DevComponents.DotNetBar.ButtonX();
            this.itemContainer23 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer24 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem19 = new DevComponents.DotNetBar.LabelItem();
            this.txtIDptosCaja = new DevComponents.DotNetBar.TextBoxItem();
            this.itemContainer25 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem20 = new DevComponents.DotNetBar.LabelItem();
            this.cmbIImpuestosDptosCaja = new DevComponents.DotNetBar.ComboBoxItem();
            this.itemContainer26 = new DevComponents.DotNetBar.ItemContainer();
            this.btnISaveDptos_Caja = new DevComponents.DotNetBar.ButtonItem();
            this.btnAddUnidades = new DevComponents.DotNetBar.ButtonX();
            this.itemContainer11 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer12 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem6 = new DevComponents.DotNetBar.LabelItem();
            this.txtIDescrUnidades = new DevComponents.DotNetBar.TextBoxItem();
            this.itemContainer13 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem7 = new DevComponents.DotNetBar.LabelItem();
            this.txtIAbreviaturaUnidades = new DevComponents.DotNetBar.TextBoxItem();
            this.lbliCodigoUnidad = new DevComponents.DotNetBar.LabelItem();
            this.itemContainer14 = new DevComponents.DotNetBar.ItemContainer();
            this.btnSaveUnidad = new DevComponents.DotNetBar.ButtonItem();
            this.btnAddGrupos = new DevComponents.DotNetBar.ButtonX();
            this.itemContainer7 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer16 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem9 = new DevComponents.DotNetBar.LabelItem();
            this.txtICodigoGrupo = new DevComponents.DotNetBar.TextBoxItem();
            this.itemContainer8 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem4 = new DevComponents.DotNetBar.LabelItem();
            this.txtIDescrGrupo = new DevComponents.DotNetBar.TextBoxItem();
            this.itemContainer9 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem5 = new DevComponents.DotNetBar.LabelItem();
            this.txtIGastoGrupo = new DevComponents.DotNetBar.TextBoxItem();
            this.itemContainer10 = new DevComponents.DotNetBar.ItemContainer();
            this.btnSaveGrupo = new DevComponents.DotNetBar.ButtonItem();
            this.btnAddEmpaques = new DevComponents.DotNetBar.ButtonX();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.txtIDescrEmpaque = new DevComponents.DotNetBar.TextBoxItem();
            this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.txtIAbreviaturaEmpaque = new DevComponents.DotNetBar.TextBoxItem();
            this.lblICodigoEmpaque = new DevComponents.DotNetBar.LabelItem();
            this.itemContainer5 = new DevComponents.DotNetBar.ItemContainer();
            this.btnSaveEmpaque = new DevComponents.DotNetBar.ButtonItem();
            this.cmbTipoEmpaque = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.bindingSourceEmpaque = new System.Windows.Forms.BindingSource(this.components);
            this.chkTroquelado = new System.Windows.Forms.CheckBox();
            this.chkRegulado = new System.Windows.Forms.CheckBox();
            this.lblUltimaActu = new DevComponents.DotNetBar.LabelX();
            this.cmbSrchGrupo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.bindingSourceGrupos = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTipoUnidad = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.bindingSourceUnidades = new System.Windows.Forms.BindingSource(this.components);
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX21 = new DevComponents.DotNetBar.LabelX();
            this.cmbDptoCajas = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.BindingSourceDptos_Caja = new System.Windows.Forms.BindingSource(this.components);
            this.labelX24 = new DevComponents.DotNetBar.LabelX();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.labelX22 = new DevComponents.DotNetBar.LabelX();
            this.chkPideObservacion = new System.Windows.Forms.CheckBox();
            this.txtDescripcionSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.chkPideCantidad = new System.Windows.Forms.CheckBox();
            this.txtCodigoInterno = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCodEmpaque = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCodigoBarras = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.chkLeeBalanza = new System.Windows.Forms.CheckBox();
            this.labelX25 = new DevComponents.DotNetBar.LabelX();
            this.labelX18 = new DevComponents.DotNetBar.LabelX();
            this.chkPidePrecio = new System.Windows.Forms.CheckBox();
            this.lblDpto = new DevComponents.DotNetBar.LabelX();
            this.txtUndEmpaque = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUndVenta = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelProductoPrecios = new DevComponents.DotNetBar.PanelEx();
            this.buttonX6 = new DevComponents.DotNetBar.ButtonX();
            this.itemContainer15 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer18 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem10 = new DevComponents.DotNetBar.LabelItem();
            this.cmbICalcTasa = new DevComponents.DotNetBar.ComboBoxItem();
            this.itemContainer17 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem15 = new DevComponents.DotNetBar.LabelItem();
            this.txtICalcMontoTotal = new DevComponents.DotNetBar.TextBoxItem();
            this.labelItem8 = new DevComponents.DotNetBar.LabelItem();
            this.txtICalcCantidad = new DevComponents.DotNetBar.TextBoxItem();
            this.itemContainer20 = new DevComponents.DotNetBar.ItemContainer();
            this.lbl1 = new DevComponents.DotNetBar.LabelItem();
            this.lblICalcCostoUndBs = new DevComponents.DotNetBar.LabelItem();
            this.itemContainer22 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem11 = new DevComponents.DotNetBar.LabelItem();
            this.txtICalcTasaDivisaProveedor = new DevComponents.DotNetBar.TextBoxItem();
            this.labelItem16 = new DevComponents.DotNetBar.LabelItem();
            this.itemContainer21 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem17 = new DevComponents.DotNetBar.LabelItem();
            this.txtICalcMontoUnidadDivisa = new DevComponents.DotNetBar.TextBoxItem();
            this.labelItem18 = new DevComponents.DotNetBar.LabelItem();
            this.itemContainer19 = new DevComponents.DotNetBar.ItemContainer();
            this.btnICalcOK = new DevComponents.DotNetBar.ButtonItem();
            this.txtTasaDivisaProveedor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.chkPrecioFijo = new System.Windows.Forms.CheckBox();
            this.chkRedondeo = new System.Windows.Forms.CheckBox();
            this.lblAvisoPerdida = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtsrchOldDivisaFactor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDivisaMargenM = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSrchOldMargen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblUltimoCosto = new DevComponents.DotNetBar.LabelX();
            this.txtDivisaM = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSrchOldDivisa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDivisaCostoM = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSrchOldCosto = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtSrchDivisa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.txtPrecioM = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSrchMargen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSrchOldPrecio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtSrchPrecio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSrchCosto = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX26 = new DevComponents.DotNetBar.LabelX();
            this.labelX19 = new DevComponents.DotNetBar.LabelX();
            this.panelMoveSearch = new System.Windows.Forms.Panel();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lblSrchEncontrados = new DevComponents.DotNetBar.LabelX();
            this.btnSrchPrev = new DevComponents.DotNetBar.Controls.SymbolBox();
            this.btnSrchNext = new DevComponents.DotNetBar.Controls.SymbolBox();
            this.btnsrchTransmitirDatosEstaciones = new DevComponents.DotNetBar.ButtonX();
            this.btnEliminar = new DevComponents.DotNetBar.ButtonX();
            this.btnsrchProductoNuevo = new DevComponents.DotNetBar.ButtonX();
            this.btnsrchCancelCambio = new DevComponents.DotNetBar.ButtonX();
            this.btnSrchAct = new DevComponents.DotNetBar.ButtonX();
            this.btnSrchClose = new DevComponents.DotNetBar.ButtonX();
            this.lblSrchFactorDivisa = new DevComponents.DotNetBar.LabelX();
            this.lblTipoRedondeo = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnSrch = new DevComponents.DotNetBar.Controls.SymbolBox();
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.bindingSourcePromocion = new System.Windows.Forms.BindingSource(this.components);
            this.panelFiltro = new System.Windows.Forms.Panel();
            this.chkFilSoloTroquelados = new System.Windows.Forms.CheckBox();
            this.flowGrupoItems = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFiltrarTodos = new DevComponents.DotNetBar.ButtonX();
            this.btnOKFiltrar = new DevComponents.DotNetBar.ButtonX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.invenTableAdapter = new RetailTrump.dsPpalTableAdapters.invenTableAdapter();
            this.tableAdapterManager = new RetailTrump.dsPpalTableAdapters.TableAdapterManager();
            this.inven_usaTableAdapter = new RetailTrump.dsPpalTableAdapters.inven_usaTableAdapter();
            this.taxTableAdapter = new RetailTrump.dsPpalTableAdapters.taxTableAdapter();
            this.monedasTableAdapter1 = new RetailTrump.dsPpalTableAdapters.monedasTableAdapter();
            this.estacionesTableAdapter1 = new RetailTrump.dsPpalTableAdapters.estacionesTableAdapter();
            this.gruinvTableAdapter = new RetailTrump.dsPpalTableAdapters.gruinvTableAdapter();
            this.timTransmitir = new System.Windows.Forms.Timer(this.components);
            this.lblDEMO = new DevComponents.DotNetBar.LabelX();
            this.tipo_empaTableAdapter = new RetailTrump.dsPpalTableAdapters.tipo_empaTableAdapter();
            this.promoTableAdapter = new RetailTrump.dsPpalTableAdapters.promoTableAdapter();
            this.itemContainer6 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem3 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem12 = new DevComponents.DotNetBar.LabelItem();
            this.textBoxItem3 = new DevComponents.DotNetBar.TextBoxItem();
            this.labelItem13 = new DevComponents.DotNetBar.LabelItem();
            this.textBoxItem4 = new DevComponents.DotNetBar.TextBoxItem();
            this.labelItem14 = new DevComponents.DotNetBar.LabelItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.dpto_cajasTableAdapter1 = new RetailTrump.dsPpalTableAdapters.dpto_cajasTableAdapter();
            this.panAumentoRebaja = new System.Windows.Forms.Panel();
            this.panelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.gAplicarA = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.rAplicaPrecio = new System.Windows.Forms.RadioButton();
            this.rAplicaDivisa = new System.Windows.Forms.RadioButton();
            this.rAplicaCosto = new System.Windows.Forms.RadioButton();
            this.gTipoAumento = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmbAumMoneda = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.rMonto = new System.Windows.Forms.RadioButton();
            this.rPorcentaje = new System.Windows.Forms.RadioButton();
            this.gTipo = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.rRebaja = new System.Windows.Forms.RadioButton();
            this.rAumento = new System.Windows.Forms.RadioButton();
            this.labelX27 = new DevComponents.DotNetBar.LabelX();
            this.txtAumValor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPpal)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invenUsaBindingSource)).BeginInit();
            this.panelProgressBar.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelProductoDescr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmpaque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUnidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceDptos_Caja)).BeginInit();
            this.panelProductoPrecios.SuspendLayout();
            this.panelMoveSearch.SuspendLayout();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePromocion)).BeginInit();
            this.panelFiltro.SuspendLayout();
            this.panAumentoRebaja.SuspendLayout();
            this.panelEx4.SuspendLayout();
            this.gAplicarA.SuspendLayout();
            this.gTipoAumento.SuspendLayout();
            this.gTipo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.ForeColor = System.Drawing.Color.Black;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.Black;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.Black;
            this.splitContainer1.Size = new System.Drawing.Size(1300, 725);
            this.splitContainer1.SplitterDistance = 53;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 231F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 670F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.buttonX3, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelEx2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonX4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTransmitir, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelEx3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 6, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1300, 53);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.BackColor = System.Drawing.Color.Transparent;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.buttonX3.Location = new System.Drawing.Point(687, 8);
            this.buttonX3.Margin = new System.Windows.Forms.Padding(5);
            this.buttonX3.MaximumSize = new System.Drawing.Size(91, 52);
            this.buttonX3.Name = "buttonX3";
            this.tableLayoutPanel1.SetRowSpan(this.buttonX3, 2);
            this.buttonX3.Size = new System.Drawing.Size(24, 40);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.Symbol = "";
            this.buttonX3.SymbolColor = System.Drawing.Color.Gold;
            this.buttonX3.TabIndex = 12;
            this.buttonX3.Click += new System.EventHandler(this.btnMonitorve_Click);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelEx2.Controls.Add(this.txtDivisaCajas);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(207, 6);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.SetRowSpan(this.panelEx2, 2);
            this.panelEx2.Size = new System.Drawing.Size(225, 44);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.Color = System.Drawing.Color.Gold;
            this.panelEx2.Style.BackColor2.Color = System.Drawing.Color.Gold;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 2;
            this.panelEx2.Text = "En CAJA:";
            // 
            // txtDivisaCajas
            // 
            // 
            // 
            // 
            this.txtDivisaCajas.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDivisaCajas.ButtonCustom.Symbol = "";
            this.txtDivisaCajas.ButtonCustom.SymbolColor = System.Drawing.Color.Red;
            this.txtDivisaCajas.ButtonCustom.Tooltip = "Salvar en PosTouch";
            this.txtDivisaCajas.ButtonCustom.Visible = true;
            this.txtDivisaCajas.ButtonCustom2.Symbol = "";
            this.txtDivisaCajas.ButtonCustom2.SymbolColor = System.Drawing.Color.Green;
            this.txtDivisaCajas.ButtonCustom2.Tooltip = "Descargar de PosTouch";
            this.txtDivisaCajas.ButtonCustom2.Visible = true;
            this.txtDivisaCajas.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtDivisaCajas.FocusHighlightEnabled = true;
            this.txtDivisaCajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivisaCajas.Location = new System.Drawing.Point(52, 2);
            this.txtDivisaCajas.MaximumSize = new System.Drawing.Size(180, 40);
            this.txtDivisaCajas.MinimumSize = new System.Drawing.Size(90, 40);
            this.txtDivisaCajas.Name = "txtDivisaCajas";
            this.txtDivisaCajas.Size = new System.Drawing.Size(171, 40);
            this.txtDivisaCajas.TabIndex = 6;
            this.txtDivisaCajas.Text = "1";
            this.txtDivisaCajas.ButtonCustomClick += new System.EventHandler(this.txtDivisa_ButtonCustomClick);
            this.txtDivisaCajas.ButtonCustom2Click += new System.EventHandler(this.txtDivisa_ButtonCustom2Click);
            this.txtDivisaCajas.TextChanged += new System.EventHandler(this.txtDivisa_ValueChanged);
            this.txtDivisaCajas.Enter += new System.EventHandler(this.txtDivisa_Enter);
            this.txtDivisaCajas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSrchPrecio_KeyPress);
            this.txtDivisaCajas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSrchPrecio_KeyUp);
            this.txtDivisaCajas.Leave += new System.EventHandler(this.txtDivisa_Leave);
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.BackColor = System.Drawing.Color.Transparent;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.buttonX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX4.Location = new System.Drawing.Point(579, 8);
            this.buttonX4.Margin = new System.Windows.Forms.Padding(5);
            this.buttonX4.Name = "buttonX4";
            this.tableLayoutPanel1.SetRowSpan(this.buttonX4, 2);
            this.buttonX4.Size = new System.Drawing.Size(18, 40);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.Symbol = "";
            this.buttonX4.SymbolColor = System.Drawing.Color.WhiteSmoke;
            this.buttonX4.TabIndex = 15;
            this.buttonX4.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblNumRegistros);
            this.panel1.Controls.Add(this.txtDirDatos);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnProbar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(198, 44);
            this.panel1.TabIndex = 0;
            // 
            // lblNumRegistros
            // 
            this.lblNumRegistros.AutoSize = true;
            this.lblNumRegistros.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.lblNumRegistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNumRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRegistros.ForeColor = System.Drawing.Color.White;
            this.lblNumRegistros.Location = new System.Drawing.Point(132, 24);
            this.lblNumRegistros.Name = "lblNumRegistros";
            this.lblNumRegistros.PaddingRight = 5;
            this.lblNumRegistros.Size = new System.Drawing.Size(52, 18);
            this.lblNumRegistros.TabIndex = 14;
            this.lblNumRegistros.Text = "999999";
            this.lblNumRegistros.TextAlignment = System.Drawing.StringAlignment.Far;
            this.lblNumRegistros.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtDirDatos
            // 
            this.txtDirDatos.BackColor = System.Drawing.Color.SteelBlue;
            // 
            // 
            // 
            this.txtDirDatos.Border.Class = "TextBoxBorder";
            this.txtDirDatos.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDirDatos.DisabledBackColor = System.Drawing.Color.SlateBlue;
            this.txtDirDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDirDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirDatos.ForeColor = System.Drawing.Color.Black;
            this.txtDirDatos.Location = new System.Drawing.Point(53, 0);
            this.txtDirDatos.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtDirDatos.MaxLength = 255;
            this.txtDirDatos.MinimumSize = new System.Drawing.Size(0, 40);
            this.txtDirDatos.Multiline = true;
            this.txtDirDatos.Name = "txtDirDatos";
            this.txtDirDatos.PreventEnterBeep = true;
            this.txtDirDatos.ReadOnly = true;
            this.txtDirDatos.Size = new System.Drawing.Size(110, 40);
            this.txtDirDatos.TabIndex = 1;
            // 
            // btnMinimize
            // 
            this.btnMinimize.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Location = new System.Drawing.Point(5, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(48, 39);
            this.btnMinimize.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMinimize.Symbol = "";
            this.btnMinimize.SymbolColor = System.Drawing.Color.Gold;
            this.btnMinimize.TabIndex = 15;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click_1);
            // 
            // btnProbar
            // 
            this.btnProbar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnProbar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnProbar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnProbar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnProbar.Location = new System.Drawing.Point(163, 0);
            this.btnProbar.MaximumSize = new System.Drawing.Size(60, 40);
            this.btnProbar.MinimumSize = new System.Drawing.Size(30, 40);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(30, 40);
            this.btnProbar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnProbar.Symbol = "";
            this.btnProbar.SymbolColor = System.Drawing.Color.Red;
            this.btnProbar.TabIndex = 1;
            this.btnProbar.Click += new System.EventHandler(this.btnProbar_Click);
            // 
            // btnTransmitir
            // 
            this.btnTransmitir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTransmitir.AutoExpandOnClick = true;
            this.btnTransmitir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTransmitir.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnTransmitir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTransmitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransmitir.ImageTextSpacing = -30;
            this.btnTransmitir.Location = new System.Drawing.Point(608, 8);
            this.btnTransmitir.Margin = new System.Windows.Forms.Padding(5);
            this.btnTransmitir.Name = "btnTransmitir";
            this.tableLayoutPanel1.SetRowSpan(this.btnTransmitir, 2);
            this.btnTransmitir.Size = new System.Drawing.Size(69, 40);
            this.btnTransmitir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTransmitir.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.btnTransmitir.Symbol = "";
            this.btnTransmitir.SymbolColor = System.Drawing.Color.LightGray;
            this.btnTransmitir.SymbolSize = 15F;
            this.btnTransmitir.TabIndex = 1;
            this.btnTransmitir.Text = "0";
            this.btnTransmitir.TextChanged += new System.EventHandler(this.btnTransmitir_TextChanged);
            this.btnTransmitir.Click += new System.EventHandler(this.btnTransmitir_Click);
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.itemContainer1.BackgroundStyle.BackColor2 = System.Drawing.Color.WhiteSmoke;
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btniTransmitir,
            this.btniLimpiar,
            this.btniVerTransmitir,
            this.btniLimpiarGrid,
            this.btniTransmitirTodo});
            // 
            // 
            // 
            this.itemContainer1.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btniTransmitir
            // 
            this.btniTransmitir.Name = "btniTransmitir";
            this.btniTransmitir.Text = "Transmitir";
            this.btniTransmitir.Click += new System.EventHandler(this.btniTransmitir_Click);
            // 
            // btniLimpiar
            // 
            this.btniLimpiar.Name = "btniLimpiar";
            this.btniLimpiar.Text = "Limpiar";
            this.btniLimpiar.Click += new System.EventHandler(this.btniLimpiar_Click);
            // 
            // btniVerTransmitir
            // 
            this.btniVerTransmitir.Name = "btniVerTransmitir";
            this.btniVerTransmitir.Text = "Ver Productos";
            this.btniVerTransmitir.Click += new System.EventHandler(this.btniVerTransmitir_Click);
            // 
            // btniLimpiarGrid
            // 
            this.btniLimpiarGrid.Name = "btniLimpiarGrid";
            this.btniLimpiarGrid.Text = "Limpiar Simulación";
            this.btniLimpiarGrid.Click += new System.EventHandler(this.btniLimpiarGrid_Click);
            // 
            // btniTransmitirTodo
            // 
            this.btniTransmitirTodo.Name = "btniTransmitirTodo";
            this.btniTransmitirTodo.Text = "Transmitir TODO";
            this.btniTransmitirTodo.Click += new System.EventHandler(this.btniTransmitirTodo_Click);
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelEx3.Controls.Add(this.txtDivisa);
            this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx3.Location = new System.Drawing.Point(438, 6);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.SetRowSpan(this.panelEx3, 2);
            this.panelEx3.Size = new System.Drawing.Size(133, 44);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 2;
            this.panelEx3.Text = "Admin:";
            // 
            // txtDivisa
            // 
            // 
            // 
            // 
            this.txtDivisa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDivisa.ButtonCustom.Symbol = "";
            this.txtDivisa.ButtonCustom.SymbolColor = System.Drawing.Color.Red;
            this.txtDivisa.ButtonCustom.Tooltip = "Salvar en PosTouch";
            this.txtDivisa.ButtonCustom2.Symbol = "";
            this.txtDivisa.ButtonCustom2.SymbolColor = System.Drawing.Color.Green;
            this.txtDivisa.ButtonCustom2.Tooltip = "Descargar de PosTouch";
            this.txtDivisa.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtDivisa.FocusHighlightEnabled = true;
            this.txtDivisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivisa.Location = new System.Drawing.Point(41, 2);
            this.txtDivisa.MaximumSize = new System.Drawing.Size(180, 40);
            this.txtDivisa.MinimumSize = new System.Drawing.Size(90, 40);
            this.txtDivisa.Name = "txtDivisa";
            this.txtDivisa.Size = new System.Drawing.Size(90, 40);
            this.txtDivisa.TabIndex = 6;
            this.txtDivisa.Text = "1";
            this.txtDivisa.ButtonCustomClick += new System.EventHandler(this.txtDivisa_ButtonCustomClick);
            this.txtDivisa.ButtonCustom2Click += new System.EventHandler(this.txtDivisa_ButtonCustom2Click);
            this.txtDivisa.TextChanged += new System.EventHandler(this.txtDivisa_ValueChanged);
            this.txtDivisa.Enter += new System.EventHandler(this.txtDivisa_Enter);
            this.txtDivisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSrchPrecio_KeyPress);
            this.txtDivisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSrchPrecio_KeyUp);
            this.txtDivisa.Leave += new System.EventHandler(this.txtDivisa_Leave);
            // 
            // btnSalir
            // 
            this.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSalir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(721, 8);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalir.Name = "btnSalir";
            this.tableLayoutPanel1.SetRowSpan(this.btnSalir, 2);
            this.btnSalir.Size = new System.Drawing.Size(74, 40);
            this.btnSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSalir.Symbol = "";
            this.btnSalir.SymbolColor = System.Drawing.Color.Red;
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.ForeColor = System.Drawing.Color.Black;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.MinimumSize = new System.Drawing.Size(500, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer2.Panel1.ForeColor = System.Drawing.Color.Black;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer2.Panel2.ForeColor = System.Drawing.Color.Black;
            this.splitContainer2.Size = new System.Drawing.Size(1300, 668);
            this.splitContainer2.SplitterDistance = 559;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Green;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSimular, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.gridOriginal, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.137055F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.86295F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(559, 668);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.Controls.Add(this.buttonX1);
            this.panel2.Controls.Add(this.btnPrecioManual);
            this.panel2.Controls.Add(this.btnFiltrar);
            this.panel2.Controls.Add(this.labelX16);
            this.panel2.Controls.Add(this.txtFilterGridOriginal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(8, 8);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(543, 48);
            this.panel2.TabIndex = 1;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.BackColor = System.Drawing.Color.DarkMagenta;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.buttonX1.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(132, 5);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(38, 38);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.TabIndex = 10;
            this.buttonX1.TextColor = System.Drawing.Color.White;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnPrecioManual
            // 
            this.btnPrecioManual.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrecioManual.BackColor = System.Drawing.Color.Green;
            this.btnPrecioManual.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnPrecioManual.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrecioManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecioManual.Location = new System.Drawing.Point(67, 5);
            this.btnPrecioManual.Name = "btnPrecioManual";
            this.btnPrecioManual.Size = new System.Drawing.Size(65, 38);
            this.btnPrecioManual.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrecioManual.TabIndex = 7;
            this.btnPrecioManual.Text = "Producto";
            this.btnPrecioManual.TextColor = System.Drawing.Color.White;
            this.btnPrecioManual.Click += new System.EventHandler(this.btnPrecioManual_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFiltrar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnFiltrar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnFiltrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(5, 5);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(62, 38);
            this.btnFiltrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.TextColor = System.Drawing.Color.White;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // labelX16
            // 
            this.labelX16.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelX16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX16.ForeColor = System.Drawing.Color.Black;
            this.labelX16.Location = new System.Drawing.Point(124, 5);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(113, 38);
            this.labelX16.TabIndex = 8;
            this.labelX16.Text = "Buscar por:";
            // 
            // txtFilterGridOriginal
            // 
            this.txtFilterGridOriginal.BackColor = System.Drawing.Color.LightYellow;
            // 
            // 
            // 
            this.txtFilterGridOriginal.Border.Class = "TextBoxBorder";
            this.txtFilterGridOriginal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFilterGridOriginal.ButtonCustom.Symbol = "";
            this.txtFilterGridOriginal.ButtonCustom.Visible = true;
            this.txtFilterGridOriginal.ButtonCustom2.Text = "Descripción";
            this.txtFilterGridOriginal.ButtonCustom2.Visible = true;
            this.txtFilterGridOriginal.DisabledBackColor = System.Drawing.Color.White;
            this.txtFilterGridOriginal.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtFilterGridOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterGridOriginal.ForeColor = System.Drawing.Color.Black;
            this.txtFilterGridOriginal.Location = new System.Drawing.Point(237, 5);
            this.txtFilterGridOriginal.MaxLength = 255;
            this.txtFilterGridOriginal.MinimumSize = new System.Drawing.Size(180, 35);
            this.txtFilterGridOriginal.Name = "txtFilterGridOriginal";
            this.txtFilterGridOriginal.PreventEnterBeep = true;
            this.txtFilterGridOriginal.Size = new System.Drawing.Size(301, 35);
            this.txtFilterGridOriginal.TabIndex = 1;
            this.txtFilterGridOriginal.Tag = "1";
            this.txtFilterGridOriginal.ButtonCustomClick += new System.EventHandler(this.txtFilterGridOriginal_ButtonCustomClick);
            this.txtFilterGridOriginal.ButtonCustom2Click += new System.EventHandler(this.txtFilterGridOriginal_ButtonCustom2Click);
            this.txtFilterGridOriginal.TextChanged += new System.EventHandler(this.txtFilterGridOriginal_TextChanged);
            // 
            // btnSimular
            // 
            this.btnSimular.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSimular.BackColor = System.Drawing.Color.LightGreen;
            this.btnSimular.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnSimular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimular.Image = ((System.Drawing.Image)(resources.GetObject("btnSimular.Image")));
            this.btnSimular.ImageFixedSize = new System.Drawing.Size(200, 50);
            this.btnSimular.Location = new System.Drawing.Point(8, 599);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(543, 61);
            this.btnSimular.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSimular.TabIndex = 1;
            this.btnSimular.Text = "Simular Cambios ->    ";
            this.btnSimular.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnSimular.Click += new System.EventHandler(this.Simular_Click);
            // 
            // gridOriginal
            // 
            this.gridOriginal.BackColor = System.Drawing.Color.White;
            this.gridOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOriginal.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.None;
            this.gridOriginal.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.gridOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridOriginal.ForeColor = System.Drawing.Color.Black;
            this.gridOriginal.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.gridOriginal.Location = new System.Drawing.Point(8, 62);
            this.gridOriginal.Name = "gridOriginal";
            // 
            // 
            // 
            this.gridOriginal.PrimaryGrid.Columns.Add(this.gridColumn16);
            this.gridOriginal.PrimaryGrid.Columns.Add(this.gcDescr);
            this.gridOriginal.PrimaryGrid.Columns.Add(this.gcPrecio);
            this.gridOriginal.PrimaryGrid.Columns.Add(this.gcDivisa);
            this.gridOriginal.PrimaryGrid.Columns.Add(this.gcCosto);
            this.gridOriginal.PrimaryGrid.Columns.Add(this.gcGrupo);
            this.gridOriginal.PrimaryGrid.Columns.Add(this.gridColumn4);
            this.gridOriginal.PrimaryGrid.DataSource = this.invenBindingSource;
            // 
            // 
            // 
            this.gridOriginal.PrimaryGrid.Header.AllowSelection = false;
            this.gridOriginal.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row;
            this.gridOriginal.PrimaryGrid.MultiSelect = false;
            this.gridOriginal.PrimaryGrid.UseAlternateRowStyle = true;
            this.gridOriginal.ShowCustomFilterHelp = false;
            this.gridOriginal.Size = new System.Drawing.Size(543, 531);
            this.gridOriginal.SizingStyle = DevComponents.DotNetBar.SuperGrid.Style.StyleType.NotSelectable;
            this.gridOriginal.TabIndex = 3;
            this.gridOriginal.TabSelection = DevComponents.DotNetBar.SuperGrid.TabSelection.CellSameRow;
            this.gridOriginal.Text = "superGridControl1";
            this.gridOriginal.CellDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellDoubleClickEventArgs>(this.gridOriginal_CellDoubleClick);
            this.gridOriginal.DataBindingComplete += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridDataBindingCompleteEventArgs>(this.gridOriginal_DataBindingComplete);
            // 
            // gridColumn16
            // 
            this.gridColumn16.DataPropertyName = "codigo";
            this.gridColumn16.Name = "Codigo";
            this.gridColumn16.Tag = "1";
            this.gridColumn16.Width = 70;
            // 
            // gcDescr
            // 
            this.gcDescr.AllowEdit = false;
            this.gcDescr.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.gcDescr.DataPropertyName = "descr";
            this.gcDescr.DefaultNewRowCellValue = "";
            this.gcDescr.MinimumWidth = 200;
            this.gcDescr.Name = "Descripcion";
            this.gcDescr.Tag = "1";
            this.gcDescr.Width = 250;
            // 
            // gcPrecio
            // 
            this.gcPrecio.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gcPrecio.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            this.gcPrecio.CellStyles.Default.TextColor = System.Drawing.Color.Blue;
            background1.Color1 = System.Drawing.Color.LightGreen;
            this.gcPrecio.CellStyles.Selected.Background = background1;
            this.gcPrecio.DataPropertyName = "precio";
            this.gcPrecio.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            this.gcPrecio.Name = "Precio";
            this.gcPrecio.NullString = "0";
            this.gcPrecio.Tag = "1";
            this.gcPrecio.Width = 70;
            // 
            // gcDivisa
            // 
            this.gcDivisa.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gcDivisa.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            this.gcDivisa.CellStyles.Default.TextColor = System.Drawing.Color.Green;
            background2.Color1 = System.Drawing.Color.LightGreen;
            this.gcDivisa.CellStyles.Selected.Background = background2;
            this.gcDivisa.DataPropertyName = "divisa";
            this.gcDivisa.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            this.gcDivisa.Name = "Divisa";
            this.gcDivisa.NullString = "0";
            this.gcDivisa.Tag = "1";
            this.gcDivisa.Width = 50;
            // 
            // gcCosto
            // 
            this.gcCosto.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gcCosto.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            background3.Color1 = System.Drawing.Color.White;
            background3.Color2 = System.Drawing.Color.White;
            this.gcCosto.CellStyles.Default.Background = background3;
            this.gcCosto.CellStyles.Default.TextColor = System.Drawing.Color.Blue;
            background4.Color1 = System.Drawing.Color.LightGreen;
            this.gcCosto.CellStyles.Selected.Background = background4;
            this.gcCosto.DataPropertyName = "divisacosto";
            this.gcCosto.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            this.gcCosto.Name = "Costo";
            this.gcCosto.NullString = "0";
            this.gcCosto.ResizeMode = DevComponents.DotNetBar.SuperGrid.ColumnResizeMode.MaintainTotalWidth;
            this.gcCosto.Tag = "1";
            this.gcCosto.Width = 50;
            // 
            // gcGrupo
            // 
            this.gcGrupo.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.gcGrupo.DataPropertyName = "grupo";
            this.gcGrupo.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridComboBoxExEditControl);
            this.gcGrupo.HeaderText = "Grupo";
            this.gcGrupo.Name = "Grupo";
            this.gcGrupo.Tag = "1";
            this.gcGrupo.Width = 50;
            // 
            // gridColumn4
            // 
            this.gridColumn4.DataPropertyName = "divisamargenfactor";
            this.gridColumn4.Name = "Margen";
            this.gridColumn4.Tag = "1";
            // 
            // invenBindingSource
            // 
            this.invenBindingSource.DataMember = "inven";
            this.invenBindingSource.DataSource = this.dsPpal;
            // 
            // dsPpal
            // 
            this.dsPpal.DataSetName = "dsPpal";
            this.dsPpal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.SeaGreen;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnActualizar, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.gridFinal, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(737, 668);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnActualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnActualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(3, 604);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(731, 61);
            this.btnActualizar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar Datos";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // gridFinal
            // 
            this.gridFinal.BackColor = System.Drawing.Color.White;
            this.gridFinal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gridFinal.BackgroundImage")));
            this.gridFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFinal.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.None;
            this.gridFinal.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.gridFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridFinal.ForeColor = System.Drawing.Color.Black;
            this.gridFinal.HScrollBarVisible = false;
            this.gridFinal.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.gridFinal.Location = new System.Drawing.Point(3, 3);
            this.gridFinal.Name = "gridFinal";
            // 
            // 
            // 
            this.gridFinal.PrimaryGrid.Columns.Add(this.gridColumn1);
            this.gridFinal.PrimaryGrid.Columns.Add(this.gridColumn2);
            this.gridFinal.PrimaryGrid.Columns.Add(this.gridColumn3);
            this.gridFinal.PrimaryGrid.Columns.Add(this.gridColumn18);
            this.gridFinal.PrimaryGrid.DataSource = this.invenUsaBindingSource;
            // 
            // 
            // 
            this.gridFinal.PrimaryGrid.Header.AllowSelection = false;
            this.gridFinal.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row;
            this.gridFinal.PrimaryGrid.MultiSelect = false;
            this.gridFinal.PrimaryGrid.UseAlternateRowStyle = true;
            this.gridFinal.ShowCustomFilterHelp = false;
            this.gridFinal.Size = new System.Drawing.Size(731, 595);
            this.gridFinal.SizingStyle = DevComponents.DotNetBar.SuperGrid.Style.StyleType.NotSelectable;
            this.gridFinal.TabIndex = 2;
            this.gridFinal.TabSelection = DevComponents.DotNetBar.SuperGrid.TabSelection.CellSameRow;
            this.gridFinal.Text = "superGridControl1";
            this.gridFinal.DataBindingComplete += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridDataBindingCompleteEventArgs>(this.gridFinal_DataBindingComplete);
            this.gridFinal.Click += new System.EventHandler(this.gridFinal_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.gridColumn1.DataPropertyName = "descr";
            this.gridColumn1.DefaultNewRowCellValue = "";
            this.gridColumn1.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            this.gridColumn1.Name = "Descripción";
            this.gridColumn1.Tag = "1";
            this.gridColumn1.Width = 250;
            // 
            // gridColumn2
            // 
            this.gridColumn2.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            this.gridColumn2.DataPropertyName = "precio";
            this.gridColumn2.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            this.gridColumn2.Name = "Precio";
            this.gridColumn2.ReadOnly = true;
            this.gridColumn2.Tag = "1";
            // 
            // gridColumn3
            // 
            this.gridColumn3.AllowEdit = false;
            this.gridColumn3.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gridColumn3.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            this.gridColumn3.DataPropertyName = "divisa";
            this.gridColumn3.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            this.gridColumn3.Name = "Divisa";
            this.gridColumn3.ReadOnly = true;
            this.gridColumn3.ResizeMode = DevComponents.DotNetBar.SuperGrid.ColumnResizeMode.MaintainTotalWidth;
            this.gridColumn3.Tag = "1";
            this.gridColumn3.Width = 70;
            // 
            // gridColumn18
            // 
            this.gridColumn18.AllowEdit = false;
            this.gridColumn18.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            this.gridColumn18.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            this.gridColumn18.DataPropertyName = "divisacosto";
            this.gridColumn18.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            this.gridColumn18.Name = "Costo";
            this.gridColumn18.ReadOnly = true;
            this.gridColumn18.Tag = "1";
            this.gridColumn18.Width = 70;
            // 
            // invenUsaBindingSource
            // 
            this.invenUsaBindingSource.DataMember = "inven_usa";
            this.invenUsaBindingSource.DataSource = this.dsPpal;
            // 
            // panelProgressBar
            // 
            this.panelProgressBar.BackColor = System.Drawing.Color.LightGray;
            this.panelProgressBar.Controls.Add(this.lblbarAccion);
            this.panelProgressBar.Controls.Add(this.progressBarX1);
            this.panelProgressBar.Controls.Add(this.lblbarStatusAccion);
            this.panelProgressBar.Location = new System.Drawing.Point(519, 82);
            this.panelProgressBar.Name = "panelProgressBar";
            this.panelProgressBar.Padding = new System.Windows.Forms.Padding(7);
            this.panelProgressBar.Size = new System.Drawing.Size(283, 133);
            this.panelProgressBar.TabIndex = 2;
            this.panelProgressBar.Visible = false;
            // 
            // lblbarAccion
            // 
            // 
            // 
            // 
            this.lblbarAccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblbarAccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblbarAccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbarAccion.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblbarAccion.Location = new System.Drawing.Point(7, 7);
            this.lblbarAccion.Name = "lblbarAccion";
            this.lblbarAccion.Size = new System.Drawing.Size(269, 67);
            this.lblbarAccion.TabIndex = 1;
            this.lblbarAccion.Text = "Actualizando Datos";
            this.lblbarAccion.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // progressBarX1
            // 
            // 
            // 
            // 
            this.progressBarX1.BackgroundStyle.BackColor = System.Drawing.Color.Red;
            this.progressBarX1.BackgroundStyle.BackColor2 = System.Drawing.Color.Blue;
            this.progressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarX1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarX1.Location = new System.Drawing.Point(7, 74);
            this.progressBarX1.Name = "progressBarX1";
            this.progressBarX1.Size = new System.Drawing.Size(269, 23);
            this.progressBarX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.progressBarX1.TabIndex = 0;
            this.progressBarX1.Value = 70;
            // 
            // lblbarStatusAccion
            // 
            // 
            // 
            // 
            this.lblbarStatusAccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblbarStatusAccion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblbarStatusAccion.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblbarStatusAccion.Location = new System.Drawing.Point(7, 97);
            this.lblbarStatusAccion.Name = "lblbarStatusAccion";
            this.lblbarStatusAccion.Size = new System.Drawing.Size(269, 29);
            this.lblbarStatusAccion.TabIndex = 1;
            this.lblbarStatusAccion.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.LightGray;
            this.panelSearch.Controls.Add(this.lblProductoNoExiste);
            this.panelSearch.Controls.Add(this.panelProductoDescr);
            this.panelSearch.Controls.Add(this.panelProductoPrecios);
            this.panelSearch.Controls.Add(this.panelMoveSearch);
            this.panelSearch.Controls.Add(this.btnsrchTransmitirDatosEstaciones);
            this.panelSearch.Controls.Add(this.btnEliminar);
            this.panelSearch.Controls.Add(this.btnsrchProductoNuevo);
            this.panelSearch.Controls.Add(this.btnsrchCancelCambio);
            this.panelSearch.Controls.Add(this.btnSrchAct);
            this.panelSearch.Controls.Add(this.btnSrchClose);
            this.panelSearch.Controls.Add(this.lblSrchFactorDivisa);
            this.panelSearch.Controls.Add(this.lblTipoRedondeo);
            this.panelSearch.Controls.Add(this.labelX12);
            this.panelSearch.Controls.Add(this.panelEx1);
            this.panelSearch.Controls.Add(this.labelX3);
            this.panelSearch.Location = new System.Drawing.Point(667, 86);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Padding = new System.Windows.Forms.Padding(7);
            this.panelSearch.Size = new System.Drawing.Size(693, 617);
            this.panelSearch.TabIndex = 0;
            this.panelSearch.Visible = false;
            this.panelSearch.VisibleChanged += new System.EventHandler(this.panelSearch_VisibleChanged);
            // 
            // lblProductoNoExiste
            // 
            this.lblProductoNoExiste.BackColor = System.Drawing.Color.Yellow;
            // 
            // 
            // 
            this.lblProductoNoExiste.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblProductoNoExiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoNoExiste.ForeColor = System.Drawing.Color.Red;
            this.lblProductoNoExiste.Location = new System.Drawing.Point(7, 158);
            this.lblProductoNoExiste.Name = "lblProductoNoExiste";
            this.lblProductoNoExiste.Size = new System.Drawing.Size(679, 33);
            this.lblProductoNoExiste.TabIndex = 8;
            this.lblProductoNoExiste.Text = "PRODUCTO NO EXISTE";
            this.lblProductoNoExiste.TextAlignment = System.Drawing.StringAlignment.Center;
            this.lblProductoNoExiste.Visible = false;
            // 
            // panelProductoDescr
            // 
            this.panelProductoDescr.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelProductoDescr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProductoDescr.Controls.Add(this.cmbTipoIVA);
            this.panelProductoDescr.Controls.Add(this.labelX20);
            this.panelProductoDescr.Controls.Add(this.btnAddDptosCaja);
            this.panelProductoDescr.Controls.Add(this.btnAddUnidades);
            this.panelProductoDescr.Controls.Add(this.btnAddGrupos);
            this.panelProductoDescr.Controls.Add(this.btnAddEmpaques);
            this.panelProductoDescr.Controls.Add(this.cmbTipoEmpaque);
            this.panelProductoDescr.Controls.Add(this.chkTroquelado);
            this.panelProductoDescr.Controls.Add(this.chkRegulado);
            this.panelProductoDescr.Controls.Add(this.lblUltimaActu);
            this.panelProductoDescr.Controls.Add(this.cmbSrchGrupo);
            this.panelProductoDescr.Controls.Add(this.cmbTipoUnidad);
            this.panelProductoDescr.Controls.Add(this.labelX6);
            this.panelProductoDescr.Controls.Add(this.labelX21);
            this.panelProductoDescr.Controls.Add(this.cmbDptoCajas);
            this.panelProductoDescr.Controls.Add(this.labelX24);
            this.panelProductoDescr.Controls.Add(this.labelX17);
            this.panelProductoDescr.Controls.Add(this.labelX22);
            this.panelProductoDescr.Controls.Add(this.chkPideObservacion);
            this.panelProductoDescr.Controls.Add(this.txtDescripcionSearch);
            this.panelProductoDescr.Controls.Add(this.chkPideCantidad);
            this.panelProductoDescr.Controls.Add(this.txtCodigoInterno);
            this.panelProductoDescr.Controls.Add(this.txtCodEmpaque);
            this.panelProductoDescr.Controls.Add(this.txtCodigoBarras);
            this.panelProductoDescr.Controls.Add(this.chkLeeBalanza);
            this.panelProductoDescr.Controls.Add(this.labelX25);
            this.panelProductoDescr.Controls.Add(this.labelX18);
            this.panelProductoDescr.Controls.Add(this.chkPidePrecio);
            this.panelProductoDescr.Controls.Add(this.lblDpto);
            this.panelProductoDescr.Controls.Add(this.txtUndEmpaque);
            this.panelProductoDescr.Controls.Add(this.txtUndVenta);
            this.panelProductoDescr.Location = new System.Drawing.Point(7, 195);
            this.panelProductoDescr.Name = "panelProductoDescr";
            this.panelProductoDescr.Size = new System.Drawing.Size(677, 170);
            this.panelProductoDescr.TabIndex = 1;
            // 
            // cmbTipoIVA
            // 
            this.cmbTipoIVA.DataSource = this.bindingSourceTax;
            this.cmbTipoIVA.DisplayMember = "descr";
            this.cmbTipoIVA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoIVA.DropDownWidth = 200;
            this.cmbTipoIVA.FocusHighlightEnabled = true;
            this.cmbTipoIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoIVA.FormattingEnabled = true;
            this.cmbTipoIVA.ItemHeight = 22;
            this.cmbTipoIVA.Location = new System.Drawing.Point(568, 89);
            this.cmbTipoIVA.Name = "cmbTipoIVA";
            this.cmbTipoIVA.Size = new System.Drawing.Size(100, 28);
            this.cmbTipoIVA.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbTipoIVA.TabIndex = 9;
            this.cmbTipoIVA.Tag = "";
            this.cmbTipoIVA.ValueMember = "tipo";
            this.cmbTipoIVA.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarras_KeyUp);
            // 
            // bindingSourceTax
            // 
            this.bindingSourceTax.DataMember = "tax";
            this.bindingSourceTax.DataSource = this.dsPpal;
            // 
            // labelX20
            // 
            this.labelX20.AutoSize = true;
            this.labelX20.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX20.ForeColor = System.Drawing.Color.Blue;
            this.labelX20.Location = new System.Drawing.Point(567, 69);
            this.labelX20.Name = "labelX20";
            this.labelX20.Size = new System.Drawing.Size(54, 18);
            this.labelX20.TabIndex = 8;
            this.labelX20.Text = "Tipo IVA";
            // 
            // btnAddDptosCaja
            // 
            this.btnAddDptosCaja.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddDptosCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDptosCaja.AutoExpandOnClick = true;
            this.btnAddDptosCaja.BackColor = System.Drawing.Color.LightYellow;
            this.btnAddDptosCaja.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnAddDptosCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDptosCaja.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAddDptosCaja.Location = new System.Drawing.Point(536, 88);
            this.btnAddDptosCaja.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddDptosCaja.Name = "btnAddDptosCaja";
            this.btnAddDptosCaja.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
            this.btnAddDptosCaja.ShowSubItems = false;
            this.btnAddDptosCaja.Size = new System.Drawing.Size(27, 29);
            this.btnAddDptosCaja.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddDptosCaja.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer23});
            this.btnAddDptosCaja.Symbol = "";
            this.btnAddDptosCaja.SymbolSize = 20F;
            this.btnAddDptosCaja.TabIndex = 44;
            this.btnAddDptosCaja.TabStop = false;
            this.btnAddDptosCaja.Tag = "";
            this.btnAddDptosCaja.Click += new System.EventHandler(this.btnAddDptosCaja_Click);
            // 
            // itemContainer23
            // 
            // 
            // 
            // 
            this.itemContainer23.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer23.FixedSize = new System.Drawing.Size(300, 100);
            this.itemContainer23.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer23.Name = "itemContainer23";
            this.itemContainer23.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer24,
            this.itemContainer25,
            this.itemContainer26});
            // 
            // 
            // 
            this.itemContainer23.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer23.TitleStyle.BackColor = System.Drawing.Color.SteelBlue;
            this.itemContainer23.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer23.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemContainer23.TitleStyle.PaddingBottom = 5;
            this.itemContainer23.TitleStyle.PaddingLeft = 5;
            this.itemContainer23.TitleStyle.PaddingRight = 5;
            this.itemContainer23.TitleStyle.PaddingTop = 5;
            this.itemContainer23.TitleStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.itemContainer23.TitleStyle.TextColor = System.Drawing.Color.White;
            this.itemContainer23.TitleText = "Agregar Dptos";
            // 
            // itemContainer24
            // 
            // 
            // 
            // 
            this.itemContainer24.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer24.FixedSize = new System.Drawing.Size(300, 30);
            this.itemContainer24.Name = "itemContainer24";
            this.itemContainer24.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem19,
            this.txtIDptosCaja});
            // 
            // 
            // 
            this.itemContainer24.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer24.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer24.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // labelItem19
            // 
            this.labelItem19.Name = "labelItem19";
            this.labelItem19.Text = "Descripción:";
            this.labelItem19.Width = 100;
            // 
            // txtIDptosCaja
            // 
            this.txtIDptosCaja.FocusHighlightEnabled = true;
            this.txtIDptosCaja.MaxLength = 30;
            this.txtIDptosCaja.Name = "txtIDptosCaja";
            this.txtIDptosCaja.TextBoxWidth = 170;
            this.txtIDptosCaja.WatermarkColor = System.Drawing.SystemColors.GrayText;
            this.txtIDptosCaja.LostFocus += new System.EventHandler(this.txtIDptosCaja_LostFocus);
            // 
            // itemContainer25
            // 
            // 
            // 
            // 
            this.itemContainer25.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer25.FixedSize = new System.Drawing.Size(300, 30);
            this.itemContainer25.Name = "itemContainer25";
            this.itemContainer25.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem20,
            this.cmbIImpuestosDptosCaja});
            // 
            // 
            // 
            this.itemContainer25.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer25.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer25.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // labelItem20
            // 
            this.labelItem20.Name = "labelItem20";
            this.labelItem20.Text = "Impuesto:";
            this.labelItem20.Width = 100;
            // 
            // cmbIImpuestosDptosCaja
            // 
            this.cmbIImpuestosDptosCaja.AutoCollapseOnClick = false;
            this.cmbIImpuestosDptosCaja.ComboWidth = 120;
            this.cmbIImpuestosDptosCaja.DropDownHeight = 106;
            this.cmbIImpuestosDptosCaja.Name = "cmbIImpuestosDptosCaja";
            this.cmbIImpuestosDptosCaja.Text = "comboBoxItem1";
            // 
            // itemContainer26
            // 
            // 
            // 
            // 
            this.itemContainer26.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer26.FixedSize = new System.Drawing.Size(300, 30);
            this.itemContainer26.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainer26.Name = "itemContainer26";
            this.itemContainer26.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnISaveDptos_Caja});
            // 
            // 
            // 
            this.itemContainer26.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer26.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer26.TitleVisible = false;
            this.itemContainer26.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // btnISaveDptos_Caja
            // 
            this.btnISaveDptos_Caja.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnISaveDptos_Caja.EnableImageAnimation = true;
            this.btnISaveDptos_Caja.ForeColor = System.Drawing.Color.Red;
            this.btnISaveDptos_Caja.Name = "btnISaveDptos_Caja";
            this.btnISaveDptos_Caja.ShowSubItems = false;
            this.btnISaveDptos_Caja.Stretch = true;
            this.btnISaveDptos_Caja.Symbol = "";
            this.btnISaveDptos_Caja.Text = "Guardar";
            this.btnISaveDptos_Caja.Click += new System.EventHandler(this.btnISaveDpto_Cajas_Click);
            // 
            // btnAddUnidades
            // 
            this.btnAddUnidades.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddUnidades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUnidades.AutoExpandOnClick = true;
            this.btnAddUnidades.BackColor = System.Drawing.Color.LightYellow;
            this.btnAddUnidades.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnAddUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUnidades.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAddUnidades.Location = new System.Drawing.Point(369, 88);
            this.btnAddUnidades.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddUnidades.Name = "btnAddUnidades";
            this.btnAddUnidades.ShowSubItems = false;
            this.btnAddUnidades.Size = new System.Drawing.Size(27, 29);
            this.btnAddUnidades.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddUnidades.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer11});
            this.btnAddUnidades.Symbol = "";
            this.btnAddUnidades.SymbolSize = 20F;
            this.btnAddUnidades.TabIndex = 44;
            this.btnAddUnidades.TabStop = false;
            this.btnAddUnidades.Tag = "";
            this.btnAddUnidades.Click += new System.EventHandler(this.btnAddUnidades_Click);
            // 
            // itemContainer11
            // 
            // 
            // 
            // 
            this.itemContainer11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer11.FixedSize = new System.Drawing.Size(300, 100);
            this.itemContainer11.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer11.Name = "itemContainer11";
            this.itemContainer11.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer12,
            this.itemContainer13,
            this.itemContainer14});
            // 
            // 
            // 
            this.itemContainer11.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer11.TitleStyle.BackColor = System.Drawing.Color.SteelBlue;
            this.itemContainer11.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer11.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemContainer11.TitleStyle.PaddingBottom = 5;
            this.itemContainer11.TitleStyle.PaddingLeft = 5;
            this.itemContainer11.TitleStyle.PaddingRight = 5;
            this.itemContainer11.TitleStyle.PaddingTop = 5;
            this.itemContainer11.TitleStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.itemContainer11.TitleStyle.TextColor = System.Drawing.Color.White;
            this.itemContainer11.TitleText = "Agregar Unidades";
            // 
            // itemContainer12
            // 
            // 
            // 
            // 
            this.itemContainer12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer12.FixedSize = new System.Drawing.Size(300, 30);
            this.itemContainer12.Name = "itemContainer12";
            this.itemContainer12.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem6,
            this.txtIDescrUnidades});
            // 
            // 
            // 
            this.itemContainer12.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer12.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer12.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // labelItem6
            // 
            this.labelItem6.Name = "labelItem6";
            this.labelItem6.Text = "Descripción:";
            this.labelItem6.Width = 100;
            // 
            // txtIDescrUnidades
            // 
            this.txtIDescrUnidades.FocusHighlightEnabled = true;
            this.txtIDescrUnidades.MaxLength = 30;
            this.txtIDescrUnidades.Name = "txtIDescrUnidades";
            this.txtIDescrUnidades.TextBoxWidth = 170;
            this.txtIDescrUnidades.WatermarkColor = System.Drawing.SystemColors.GrayText;
            this.txtIDescrUnidades.LostFocus += new System.EventHandler(this.txtIDescrUnidades_LostFocus);
            // 
            // itemContainer13
            // 
            // 
            // 
            // 
            this.itemContainer13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer13.FixedSize = new System.Drawing.Size(300, 30);
            this.itemContainer13.Name = "itemContainer13";
            this.itemContainer13.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem7,
            this.txtIAbreviaturaUnidades,
            this.lbliCodigoUnidad});
            // 
            // 
            // 
            this.itemContainer13.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer13.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer13.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // labelItem7
            // 
            this.labelItem7.Name = "labelItem7";
            this.labelItem7.Text = "Abreviatura:";
            this.labelItem7.Width = 100;
            // 
            // txtIAbreviaturaUnidades
            // 
            this.txtIAbreviaturaUnidades.FocusHighlightEnabled = true;
            this.txtIAbreviaturaUnidades.MaxLength = 4;
            this.txtIAbreviaturaUnidades.Name = "txtIAbreviaturaUnidades";
            this.txtIAbreviaturaUnidades.TextBoxWidth = 30;
            this.txtIAbreviaturaUnidades.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // lbliCodigoUnidad
            // 
            this.lbliCodigoUnidad.Name = "lbliCodigoUnidad";
            this.lbliCodigoUnidad.Visible = false;
            this.lbliCodigoUnidad.Width = 100;
            // 
            // itemContainer14
            // 
            // 
            // 
            // 
            this.itemContainer14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer14.FixedSize = new System.Drawing.Size(300, 30);
            this.itemContainer14.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainer14.Name = "itemContainer14";
            this.itemContainer14.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSaveUnidad});
            // 
            // 
            // 
            this.itemContainer14.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer14.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer14.TitleVisible = false;
            this.itemContainer14.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // btnSaveUnidad
            // 
            this.btnSaveUnidad.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSaveUnidad.EnableImageAnimation = true;
            this.btnSaveUnidad.ForeColor = System.Drawing.Color.Red;
            this.btnSaveUnidad.Name = "btnSaveUnidad";
            this.btnSaveUnidad.ShowSubItems = false;
            this.btnSaveUnidad.Stretch = true;
            this.btnSaveUnidad.Symbol = "";
            this.btnSaveUnidad.Text = "Guardar";
            this.btnSaveUnidad.Click += new System.EventHandler(this.btnSaveEmpaque_Click);
            // 
            // btnAddGrupos
            // 
            this.btnAddGrupos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddGrupos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddGrupos.AutoExpandOnClick = true;
            this.btnAddGrupos.BackColor = System.Drawing.Color.LightYellow;
            this.btnAddGrupos.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnAddGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGrupos.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAddGrupos.Location = new System.Drawing.Point(642, 36);
            this.btnAddGrupos.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddGrupos.Name = "btnAddGrupos";
            this.btnAddGrupos.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
            this.btnAddGrupos.ShowSubItems = false;
            this.btnAddGrupos.Size = new System.Drawing.Size(27, 29);
            this.btnAddGrupos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddGrupos.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer7});
            this.btnAddGrupos.Symbol = "";
            this.btnAddGrupos.SymbolSize = 20F;
            this.btnAddGrupos.TabIndex = 5;
            this.btnAddGrupos.TabStop = false;
            this.btnAddGrupos.Tag = "";
            this.btnAddGrupos.Click += new System.EventHandler(this.btnAddGrupos_Click);
            // 
            // itemContainer7
            // 
            // 
            // 
            // 
            this.itemContainer7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer7.FixedSize = new System.Drawing.Size(300, 130);
            this.itemContainer7.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer7.Name = "itemContainer7";
            this.itemContainer7.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer16,
            this.itemContainer8,
            this.itemContainer9,
            this.itemContainer10});
            // 
            // 
            // 
            this.itemContainer7.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer7.TitleStyle.BackColor = System.Drawing.Color.SteelBlue;
            this.itemContainer7.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer7.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemContainer7.TitleStyle.PaddingBottom = 5;
            this.itemContainer7.TitleStyle.PaddingLeft = 5;
            this.itemContainer7.TitleStyle.PaddingRight = 5;
            this.itemContainer7.TitleStyle.PaddingTop = 5;
            this.itemContainer7.TitleStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.itemContainer7.TitleStyle.TextColor = System.Drawing.Color.White;
            this.itemContainer7.TitleText = "Agregar Grupo";
            // 
            // itemContainer16
            // 
            // 
            // 
            // 
            this.itemContainer16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer16.FixedSize = new System.Drawing.Size(300, 30);
            this.itemContainer16.Name = "itemContainer16";
            this.itemContainer16.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem9,
            this.txtICodigoGrupo});
            // 
            // 
            // 
            this.itemContainer16.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer16.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer16.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // labelItem9
            // 
            this.labelItem9.Name = "labelItem9";
            this.labelItem9.Text = "Código:";
            this.labelItem9.Width = 100;
            // 
            // txtICodigoGrupo
            // 
            this.txtICodigoGrupo.FocusHighlightEnabled = true;
            this.txtICodigoGrupo.MaxLength = 4;
            this.txtICodigoGrupo.Name = "txtICodigoGrupo";
            this.txtICodigoGrupo.TextBoxWidth = 100;
            this.txtICodigoGrupo.WatermarkColor = System.Drawing.SystemColors.GrayText;
            this.txtICodigoGrupo.LostFocus += new System.EventHandler(this.txtICodigoGrupo_LostFocus);
            // 
            // itemContainer8
            // 
            // 
            // 
            // 
            this.itemContainer8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer8.FixedSize = new System.Drawing.Size(300, 30);
            this.itemContainer8.Name = "itemContainer8";
            this.itemContainer8.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem4,
            this.txtIDescrGrupo});
            // 
            // 
            // 
            this.itemContainer8.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer8.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer8.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // labelItem4
            // 
            this.labelItem4.Name = "labelItem4";
            this.labelItem4.Text = "Descripción:";
            this.labelItem4.Width = 100;
            // 
            // txtIDescrGrupo
            // 
            this.txtIDescrGrupo.FocusHighlightEnabled = true;
            this.txtIDescrGrupo.MaxLength = 30;
            this.txtIDescrGrupo.Name = "txtIDescrGrupo";
            this.txtIDescrGrupo.TextBoxWidth = 170;
            this.txtIDescrGrupo.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // itemContainer9
            // 
            // 
            // 
            // 
            this.itemContainer9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer9.FixedSize = new System.Drawing.Size(300, 30);
            this.itemContainer9.Name = "itemContainer9";
            this.itemContainer9.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem5,
            this.txtIGastoGrupo});
            // 
            // 
            // 
            this.itemContainer9.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer9.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer9.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // labelItem5
            // 
            this.labelItem5.Name = "labelItem5";
            this.labelItem5.Text = "%Gasto:";
            this.labelItem5.Width = 100;
            // 
            // txtIGastoGrupo
            // 
            this.txtIGastoGrupo.FocusHighlightEnabled = true;
            this.txtIGastoGrupo.MaxLength = 5;
            this.txtIGastoGrupo.Name = "txtIGastoGrupo";
            this.txtIGastoGrupo.TextBoxWidth = 30;
            this.txtIGastoGrupo.WatermarkColor = System.Drawing.SystemColors.GrayText;
            this.txtIGastoGrupo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSrchPrecio_KeyUp);
            // 
            // itemContainer10
            // 
            // 
            // 
            // 
            this.itemContainer10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer10.FixedSize = new System.Drawing.Size(300, 30);
            this.itemContainer10.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainer10.Name = "itemContainer10";
            this.itemContainer10.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSaveGrupo});
            // 
            // 
            // 
            this.itemContainer10.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer10.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer10.TitleVisible = false;
            this.itemContainer10.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // btnSaveGrupo
            // 
            this.btnSaveGrupo.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSaveGrupo.EnableImageAnimation = true;
            this.btnSaveGrupo.ForeColor = System.Drawing.Color.Red;
            this.btnSaveGrupo.Name = "btnSaveGrupo";
            this.btnSaveGrupo.ShowSubItems = false;
            this.btnSaveGrupo.Stretch = true;
            this.btnSaveGrupo.Symbol = "";
            this.btnSaveGrupo.Text = "Guardar";
            this.btnSaveGrupo.Click += new System.EventHandler(this.btnSaveGrupo_Click);
            // 
            // btnAddEmpaques
            // 
            this.btnAddEmpaques.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddEmpaques.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEmpaques.AutoExpandOnClick = true;
            this.btnAddEmpaques.BackColor = System.Drawing.Color.LightYellow;
            this.btnAddEmpaques.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnAddEmpaques.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmpaques.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAddEmpaques.Location = new System.Drawing.Point(174, 88);
            this.btnAddEmpaques.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddEmpaques.Name = "btnAddEmpaques";
            this.btnAddEmpaques.ShowSubItems = false;
            this.btnAddEmpaques.Size = new System.Drawing.Size(27, 29);
            this.btnAddEmpaques.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddEmpaques.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer2});
            this.btnAddEmpaques.Symbol = "";
            this.btnAddEmpaques.SymbolSize = 20F;
            this.btnAddEmpaques.TabIndex = 8;
            this.btnAddEmpaques.TabStop = false;
            this.btnAddEmpaques.Tag = "";
            this.btnAddEmpaques.Click += new System.EventHandler(this.btnAddEmpaques_Click);
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.FixedSize = new System.Drawing.Size(300, 100);
            this.itemContainer2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer3,
            this.itemContainer4,
            this.itemContainer5});
            // 
            // 
            // 
            this.itemContainer2.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer2.TitleStyle.BackColor = System.Drawing.Color.SteelBlue;
            this.itemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemContainer2.TitleStyle.PaddingBottom = 5;
            this.itemContainer2.TitleStyle.PaddingLeft = 5;
            this.itemContainer2.TitleStyle.PaddingRight = 5;
            this.itemContainer2.TitleStyle.PaddingTop = 5;
            this.itemContainer2.TitleStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.itemContainer2.TitleStyle.TextColor = System.Drawing.Color.White;
            this.itemContainer2.TitleText = "Agregar Empaque";
            this.itemContainer2.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // itemContainer3
            // 
            // 
            // 
            // 
            this.itemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer3.FixedSize = new System.Drawing.Size(300, 30);
            this.itemContainer3.Name = "itemContainer3";
            this.itemContainer3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1,
            this.txtIDescrEmpaque});
            // 
            // 
            // 
            this.itemContainer3.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer3.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "Descripción:";
            this.labelItem1.Width = 100;
            // 
            // txtIDescrEmpaque
            // 
            this.txtIDescrEmpaque.FocusHighlightEnabled = true;
            this.txtIDescrEmpaque.MaxLength = 30;
            this.txtIDescrEmpaque.Name = "txtIDescrEmpaque";
            this.txtIDescrEmpaque.TextBoxWidth = 170;
            this.txtIDescrEmpaque.WatermarkColor = System.Drawing.SystemColors.GrayText;
            this.txtIDescrEmpaque.LostFocus += new System.EventHandler(this.txtICodigoGrupo_LostFocus);
            // 
            // itemContainer4
            // 
            // 
            // 
            // 
            this.itemContainer4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer4.FixedSize = new System.Drawing.Size(300, 30);
            this.itemContainer4.Name = "itemContainer4";
            this.itemContainer4.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem2,
            this.txtIAbreviaturaEmpaque,
            this.lblICodigoEmpaque});
            // 
            // 
            // 
            this.itemContainer4.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer4.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // labelItem2
            // 
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "Abreviatura:";
            this.labelItem2.Width = 100;
            // 
            // txtIAbreviaturaEmpaque
            // 
            this.txtIAbreviaturaEmpaque.FocusHighlightEnabled = true;
            this.txtIAbreviaturaEmpaque.MaxLength = 4;
            this.txtIAbreviaturaEmpaque.Name = "txtIAbreviaturaEmpaque";
            this.txtIAbreviaturaEmpaque.TextBoxWidth = 30;
            this.txtIAbreviaturaEmpaque.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // lblICodigoEmpaque
            // 
            this.lblICodigoEmpaque.Name = "lblICodigoEmpaque";
            this.lblICodigoEmpaque.Visible = false;
            this.lblICodigoEmpaque.Width = 100;
            // 
            // itemContainer5
            // 
            // 
            // 
            // 
            this.itemContainer5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer5.FixedSize = new System.Drawing.Size(300, 30);
            this.itemContainer5.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainer5.Name = "itemContainer5";
            this.itemContainer5.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSaveEmpaque});
            // 
            // 
            // 
            this.itemContainer5.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer5.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer5.TitleVisible = false;
            this.itemContainer5.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // btnSaveEmpaque
            // 
            this.btnSaveEmpaque.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSaveEmpaque.EnableImageAnimation = true;
            this.btnSaveEmpaque.ForeColor = System.Drawing.Color.Red;
            this.btnSaveEmpaque.Name = "btnSaveEmpaque";
            this.btnSaveEmpaque.ShowSubItems = false;
            this.btnSaveEmpaque.Stretch = true;
            this.btnSaveEmpaque.Symbol = "";
            this.btnSaveEmpaque.Text = "Guardar";
            this.btnSaveEmpaque.Click += new System.EventHandler(this.btnSaveEmpaque_Click);
            // 
            // cmbTipoEmpaque
            // 
            this.cmbTipoEmpaque.DataSource = this.bindingSourceEmpaque;
            this.cmbTipoEmpaque.DisplayMember = "descr";
            this.cmbTipoEmpaque.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoEmpaque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEmpaque.DropDownWidth = 200;
            this.cmbTipoEmpaque.FocusHighlightEnabled = true;
            this.cmbTipoEmpaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoEmpaque.FormattingEnabled = true;
            this.cmbTipoEmpaque.ItemHeight = 22;
            this.cmbTipoEmpaque.Location = new System.Drawing.Point(57, 89);
            this.cmbTipoEmpaque.Name = "cmbTipoEmpaque";
            this.cmbTipoEmpaque.Size = new System.Drawing.Size(114, 28);
            this.cmbTipoEmpaque.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbTipoEmpaque.TabIndex = 6;
            this.cmbTipoEmpaque.ValueMember = "codigo";
            this.cmbTipoEmpaque.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarras_KeyUp);
            // 
            // bindingSourceEmpaque
            // 
            this.bindingSourceEmpaque.DataMember = "tipo_empa";
            this.bindingSourceEmpaque.DataSource = this.dsPpal;
            // 
            // chkTroquelado
            // 
            this.chkTroquelado.AutoSize = true;
            this.chkTroquelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTroquelado.ForeColor = System.Drawing.Color.Blue;
            this.chkTroquelado.Location = new System.Drawing.Point(474, 127);
            this.chkTroquelado.Name = "chkTroquelado";
            this.chkTroquelado.Size = new System.Drawing.Size(100, 21);
            this.chkTroquelado.TabIndex = 14;
            this.chkTroquelado.Text = "Troquelado";
            this.chkTroquelado.UseVisualStyleBackColor = true;
            this.chkTroquelado.CheckedChanged += new System.EventHandler(this.chkTroquelado_CheckedChanged);
            this.chkTroquelado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarras_KeyUp);
            // 
            // chkRegulado
            // 
            this.chkRegulado.AutoSize = true;
            this.chkRegulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRegulado.ForeColor = System.Drawing.Color.Blue;
            this.chkRegulado.Location = new System.Drawing.Point(582, 127);
            this.chkRegulado.Name = "chkRegulado";
            this.chkRegulado.Size = new System.Drawing.Size(88, 21);
            this.chkRegulado.TabIndex = 15;
            this.chkRegulado.Text = "Regulado";
            this.chkRegulado.UseVisualStyleBackColor = true;
            this.chkRegulado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarras_KeyUp);
            // 
            // lblUltimaActu
            // 
            this.lblUltimaActu.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblUltimaActu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblUltimaActu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimaActu.ForeColor = System.Drawing.Color.Red;
            this.lblUltimaActu.Location = new System.Drawing.Point(598, 143);
            this.lblUltimaActu.Name = "lblUltimaActu";
            this.lblUltimaActu.Size = new System.Drawing.Size(70, 18);
            this.lblUltimaActu.TabIndex = 41;
            this.lblUltimaActu.Text = "21/12/2020";
            this.lblUltimaActu.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cmbSrchGrupo
            // 
            this.cmbSrchGrupo.DataSource = this.bindingSourceGrupos;
            this.cmbSrchGrupo.DisplayMember = "descr";
            this.cmbSrchGrupo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSrchGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSrchGrupo.DropDownWidth = 200;
            this.cmbSrchGrupo.FocusHighlightEnabled = true;
            this.cmbSrchGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSrchGrupo.FormattingEnabled = true;
            this.cmbSrchGrupo.ItemHeight = 22;
            this.cmbSrchGrupo.Location = new System.Drawing.Point(495, 37);
            this.cmbSrchGrupo.MinimumSize = new System.Drawing.Size(100, 0);
            this.cmbSrchGrupo.Name = "cmbSrchGrupo";
            this.cmbSrchGrupo.Size = new System.Drawing.Size(146, 28);
            this.cmbSrchGrupo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbSrchGrupo.TabIndex = 4;
            this.cmbSrchGrupo.ValueMember = "codigo";
            this.cmbSrchGrupo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarras_KeyUp);
            // 
            // bindingSourceGrupos
            // 
            this.bindingSourceGrupos.DataMember = "gruinv";
            this.bindingSourceGrupos.DataSource = this.dsPpal;
            // 
            // cmbTipoUnidad
            // 
            this.cmbTipoUnidad.DataSource = this.bindingSourceUnidades;
            this.cmbTipoUnidad.DisplayMember = "descr";
            this.cmbTipoUnidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUnidad.DropDownWidth = 200;
            this.cmbTipoUnidad.FocusHighlightEnabled = true;
            this.cmbTipoUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoUnidad.FormattingEnabled = true;
            this.cmbTipoUnidad.ItemHeight = 22;
            this.cmbTipoUnidad.Location = new System.Drawing.Point(254, 90);
            this.cmbTipoUnidad.Name = "cmbTipoUnidad";
            this.cmbTipoUnidad.Size = new System.Drawing.Size(114, 28);
            this.cmbTipoUnidad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbTipoUnidad.TabIndex = 8;
            this.cmbTipoUnidad.ValueMember = "codigo";
            this.cmbTipoUnidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarras_KeyUp);
            // 
            // bindingSourceUnidades
            // 
            this.bindingSourceUnidades.DataMember = "tipo_empa";
            this.bindingSourceUnidades.DataSource = this.dsPpal;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(10, 42);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(58, 21);
            this.labelX6.TabIndex = 8;
            this.labelX6.Text = "Descr.:";
            // 
            // labelX21
            // 
            this.labelX21.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX21.ForeColor = System.Drawing.Color.Black;
            this.labelX21.Location = new System.Drawing.Point(440, 42);
            this.labelX21.Name = "labelX21";
            this.labelX21.Size = new System.Drawing.Size(49, 21);
            this.labelX21.TabIndex = 8;
            this.labelX21.Text = "Grupo:";
            // 
            // cmbDptoCajas
            // 
            this.cmbDptoCajas.DataSource = this.BindingSourceDptos_Caja;
            this.cmbDptoCajas.DisplayMember = "descr";
            this.cmbDptoCajas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDptoCajas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDptoCajas.DropDownWidth = 200;
            this.cmbDptoCajas.FocusHighlightEnabled = true;
            this.cmbDptoCajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDptoCajas.FormattingEnabled = true;
            this.cmbDptoCajas.ItemHeight = 22;
            this.cmbDptoCajas.Location = new System.Drawing.Point(401, 89);
            this.cmbDptoCajas.Name = "cmbDptoCajas";
            this.cmbDptoCajas.Size = new System.Drawing.Size(132, 28);
            this.cmbDptoCajas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbDptoCajas.TabIndex = 10;
            this.cmbDptoCajas.Tag = "";
            this.cmbDptoCajas.ValueMember = "codigo";
            this.cmbDptoCajas.SelectedIndexChanged += new System.EventHandler(this.cmbDptoCajas_SelectedIndexChanged);
            this.cmbDptoCajas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarras_KeyUp);
            // 
            // BindingSourceDptos_Caja
            // 
            this.BindingSourceDptos_Caja.DataMember = "dpto_cajas";
            this.BindingSourceDptos_Caja.DataSource = this.dsPpal;
            // 
            // labelX24
            // 
            this.labelX24.AutoSize = true;
            this.labelX24.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX24.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX24.ForeColor = System.Drawing.Color.Black;
            this.labelX24.Location = new System.Drawing.Point(10, 7);
            this.labelX24.Name = "labelX24";
            this.labelX24.Size = new System.Drawing.Size(58, 21);
            this.labelX24.TabIndex = 8;
            this.labelX24.Text = "Código:";
            // 
            // labelX17
            // 
            this.labelX17.AutoSize = true;
            this.labelX17.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX17.ForeColor = System.Drawing.Color.Black;
            this.labelX17.Location = new System.Drawing.Point(433, 7);
            this.labelX17.Name = "labelX17";
            this.labelX17.Size = new System.Drawing.Size(100, 21);
            this.labelX17.TabIndex = 8;
            this.labelX17.Text = "Cod. Empaq.:";
            // 
            // labelX22
            // 
            this.labelX22.AutoSize = true;
            this.labelX22.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX22.ForeColor = System.Drawing.Color.Black;
            this.labelX22.Location = new System.Drawing.Point(208, 7);
            this.labelX22.Name = "labelX22";
            this.labelX22.Size = new System.Drawing.Size(84, 21);
            this.labelX22.TabIndex = 8;
            this.labelX22.Text = "Cod. Barra:";
            // 
            // chkPideObservacion
            // 
            this.chkPideObservacion.AutoSize = true;
            this.chkPideObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPideObservacion.ForeColor = System.Drawing.Color.Blue;
            this.chkPideObservacion.Location = new System.Drawing.Point(240, 127);
            this.chkPideObservacion.Name = "chkPideObservacion";
            this.chkPideObservacion.Size = new System.Drawing.Size(107, 21);
            this.chkPideObservacion.TabIndex = 12;
            this.chkPideObservacion.Text = "Observación";
            this.chkPideObservacion.UseVisualStyleBackColor = true;
            this.chkPideObservacion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarras_KeyUp);
            // 
            // txtDescripcionSearch
            // 
            this.txtDescripcionSearch.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDescripcionSearch.Border.Class = "TextBoxBorder";
            this.txtDescripcionSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDescripcionSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcionSearch.DisabledBackColor = System.Drawing.Color.White;
            this.txtDescripcionSearch.FocusHighlightEnabled = true;
            this.txtDescripcionSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionSearch.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcionSearch.Location = new System.Drawing.Point(73, 39);
            this.txtDescripcionSearch.Name = "txtDescripcionSearch";
            this.txtDescripcionSearch.PreventEnterBeep = true;
            this.txtDescripcionSearch.ReadOnly = true;
            this.txtDescripcionSearch.Size = new System.Drawing.Size(353, 26);
            this.txtDescripcionSearch.TabIndex = 3;
            this.txtDescripcionSearch.Tag = "0";
            this.txtDescripcionSearch.Text = "PRODUCTO";
            this.txtDescripcionSearch.WordWrap = false;
            this.txtDescripcionSearch.DoubleClick += new System.EventHandler(this.lblDescripcionSearch_DoubleClick);
            this.txtDescripcionSearch.Enter += new System.EventHandler(this.txtCodigoInterno_Enter);
            this.txtDescripcionSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarras_KeyUp);
            this.txtDescripcionSearch.Leave += new System.EventHandler(this.txtDescripcionSearch_Leave);
            // 
            // chkPideCantidad
            // 
            this.chkPideCantidad.AutoSize = true;
            this.chkPideCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPideCantidad.ForeColor = System.Drawing.Color.Blue;
            this.chkPideCantidad.Location = new System.Drawing.Point(117, 127);
            this.chkPideCantidad.Name = "chkPideCantidad";
            this.chkPideCantidad.Size = new System.Drawing.Size(115, 21);
            this.chkPideCantidad.TabIndex = 11;
            this.chkPideCantidad.Text = "Pide Cantidad";
            this.chkPideCantidad.UseVisualStyleBackColor = true;
            this.chkPideCantidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarras_KeyUp);
            // 
            // txtCodigoInterno
            // 
            this.txtCodigoInterno.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCodigoInterno.Border.Class = "TextBoxBorder";
            this.txtCodigoInterno.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCodigoInterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoInterno.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodigoInterno.FocusHighlightEnabled = true;
            this.txtCodigoInterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoInterno.ForeColor = System.Drawing.Color.Black;
            this.txtCodigoInterno.Location = new System.Drawing.Point(74, 4);
            this.txtCodigoInterno.Name = "txtCodigoInterno";
            this.txtCodigoInterno.PreventEnterBeep = true;
            this.txtCodigoInterno.ReadOnly = true;
            this.txtCodigoInterno.Size = new System.Drawing.Size(131, 26);
            this.txtCodigoInterno.TabIndex = 0;
            this.txtCodigoInterno.Tag = "0";
            this.txtCodigoInterno.Text = "000000000000";
            this.txtCodigoInterno.WordWrap = false;
            this.txtCodigoInterno.DoubleClick += new System.EventHandler(this.lblDescripcionSearch_DoubleClick);
            this.txtCodigoInterno.Enter += new System.EventHandler(this.txtCodigoInterno_Enter);
            this.txtCodigoInterno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarras_KeyUp);
            this.txtCodigoInterno.Leave += new System.EventHandler(this.txtCodigoBarras_Leave);
            // 
            // txtCodEmpaque
            // 
            this.txtCodEmpaque.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCodEmpaque.Border.Class = "TextBoxBorder";
            this.txtCodEmpaque.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCodEmpaque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodEmpaque.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodEmpaque.FocusHighlightEnabled = true;
            this.txtCodEmpaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodEmpaque.ForeColor = System.Drawing.Color.Black;
            this.txtCodEmpaque.Location = new System.Drawing.Point(538, 4);
            this.txtCodEmpaque.Name = "txtCodEmpaque";
            this.txtCodEmpaque.PreventEnterBeep = true;
            this.txtCodEmpaque.ReadOnly = true;
            this.txtCodEmpaque.Size = new System.Drawing.Size(131, 26);
            this.txtCodEmpaque.TabIndex = 2;
            this.txtCodEmpaque.Tag = "0";
            this.txtCodEmpaque.Text = "000000000000";
            this.txtCodEmpaque.WordWrap = false;
            this.txtCodEmpaque.DoubleClick += new System.EventHandler(this.lblDescripcionSearch_DoubleClick);
            this.txtCodEmpaque.Enter += new System.EventHandler(this.txtCodigoInterno_Enter);
            this.txtCodEmpaque.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarras_KeyUp);
            this.txtCodEmpaque.Leave += new System.EventHandler(this.txtCodigoBarras_Leave_1);
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCodigoBarras.Border.Class = "TextBoxBorder";
            this.txtCodigoBarras.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCodigoBarras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoBarras.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodigoBarras.FocusHighlightEnabled = true;
            this.txtCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarras.ForeColor = System.Drawing.Color.Black;
            this.txtCodigoBarras.Location = new System.Drawing.Point(295, 4);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.PreventEnterBeep = true;
            this.txtCodigoBarras.ReadOnly = true;
            this.txtCodigoBarras.Size = new System.Drawing.Size(131, 26);
            this.txtCodigoBarras.TabIndex = 1;
            this.txtCodigoBarras.Tag = "0";
            this.txtCodigoBarras.Text = "000000000000";
            this.txtCodigoBarras.WordWrap = false;
            this.txtCodigoBarras.DoubleClick += new System.EventHandler(this.lblDescripcionSearch_DoubleClick);
            this.txtCodigoBarras.Enter += new System.EventHandler(this.txtCodigoInterno_Enter);
            this.txtCodigoBarras.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarras_KeyUp);
            this.txtCodigoBarras.Leave += new System.EventHandler(this.txtCodigoBarras_Leave_1);
            // 
            // chkLeeBalanza
            // 
            this.chkLeeBalanza.AutoSize = true;
            this.chkLeeBalanza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLeeBalanza.ForeColor = System.Drawing.Color.Blue;
            this.chkLeeBalanza.Location = new System.Drawing.Point(355, 127);
            this.chkLeeBalanza.Name = "chkLeeBalanza";
            this.chkLeeBalanza.Size = new System.Drawing.Size(111, 21);
            this.chkLeeBalanza.TabIndex = 13;
            this.chkLeeBalanza.Text = "Leer Balanza";
            this.chkLeeBalanza.UseVisualStyleBackColor = true;
            this.chkLeeBalanza.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarras_KeyUp);
            // 
            // labelX25
            // 
            this.labelX25.AutoSize = true;
            this.labelX25.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX25.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX25.ForeColor = System.Drawing.Color.Blue;
            this.labelX25.Location = new System.Drawing.Point(254, 70);
            this.labelX25.Name = "labelX25";
            this.labelX25.Size = new System.Drawing.Size(132, 18);
            this.labelX25.TabIndex = 8;
            this.labelX25.Text = "Unidades X Empaque";
            // 
            // labelX18
            // 
            this.labelX18.AutoSize = true;
            this.labelX18.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX18.ForeColor = System.Drawing.Color.Blue;
            this.labelX18.Location = new System.Drawing.Point(10, 70);
            this.labelX18.Name = "labelX18";
            this.labelX18.Size = new System.Drawing.Size(132, 18);
            this.labelX18.TabIndex = 8;
            this.labelX18.Text = "Unidades X Empaque";
            // 
            // chkPidePrecio
            // 
            this.chkPidePrecio.AutoSize = true;
            this.chkPidePrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPidePrecio.ForeColor = System.Drawing.Color.Blue;
            this.chkPidePrecio.Location = new System.Drawing.Point(10, 127);
            this.chkPidePrecio.Name = "chkPidePrecio";
            this.chkPidePrecio.Size = new System.Drawing.Size(99, 21);
            this.chkPidePrecio.TabIndex = 10;
            this.chkPidePrecio.Text = "Pide Precio";
            this.chkPidePrecio.UseVisualStyleBackColor = true;
            this.chkPidePrecio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarras_KeyUp);
            // 
            // lblDpto
            // 
            this.lblDpto.AutoSize = true;
            this.lblDpto.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblDpto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDpto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDpto.ForeColor = System.Drawing.Color.Blue;
            this.lblDpto.Location = new System.Drawing.Point(399, 71);
            this.lblDpto.Name = "lblDpto";
            this.lblDpto.Size = new System.Drawing.Size(87, 18);
            this.lblDpto.TabIndex = 8;
            this.lblDpto.Text = "Departamento";
            // 
            // txtUndEmpaque
            // 
            this.txtUndEmpaque.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUndEmpaque.Border.Class = "TextBoxBorder";
            this.txtUndEmpaque.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUndEmpaque.DisabledBackColor = System.Drawing.Color.White;
            this.txtUndEmpaque.FocusHighlightEnabled = true;
            this.txtUndEmpaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUndEmpaque.ForeColor = System.Drawing.Color.Black;
            this.txtUndEmpaque.Location = new System.Drawing.Point(10, 91);
            this.txtUndEmpaque.MaxLength = 10;
            this.txtUndEmpaque.Name = "txtUndEmpaque";
            this.txtUndEmpaque.PreventEnterBeep = true;
            this.txtUndEmpaque.Size = new System.Drawing.Size(45, 26);
            this.txtUndEmpaque.TabIndex = 5;
            this.txtUndEmpaque.Tag = "und";
            this.txtUndEmpaque.Text = "999";
            this.txtUndEmpaque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUndEmpaque.TextChanged += new System.EventHandler(this.txtUndEmpaque_TextChanged);
            this.txtUndEmpaque.Enter += new System.EventHandler(this.txtSrchPrecio_Enter);
            this.txtUndEmpaque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSrchPrecio_KeyPress);
            this.txtUndEmpaque.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSrchPrecio_KeyUp);
            this.txtUndEmpaque.Leave += new System.EventHandler(this.txtSrchPrecio_Leave);
            // 
            // txtUndVenta
            // 
            this.txtUndVenta.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUndVenta.Border.Class = "TextBoxBorder";
            this.txtUndVenta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUndVenta.DisabledBackColor = System.Drawing.Color.White;
            this.txtUndVenta.FocusHighlightEnabled = true;
            this.txtUndVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUndVenta.ForeColor = System.Drawing.Color.Black;
            this.txtUndVenta.Location = new System.Drawing.Point(205, 91);
            this.txtUndVenta.MaxLength = 10;
            this.txtUndVenta.Name = "txtUndVenta";
            this.txtUndVenta.PreventEnterBeep = true;
            this.txtUndVenta.Size = new System.Drawing.Size(45, 26);
            this.txtUndVenta.TabIndex = 7;
            this.txtUndVenta.Tag = "und";
            this.txtUndVenta.Text = "999";
            this.txtUndVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUndVenta.Enter += new System.EventHandler(this.txtSrchPrecio_Enter);
            this.txtUndVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSrchPrecio_KeyPress);
            this.txtUndVenta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSrchPrecio_KeyUp);
            this.txtUndVenta.Leave += new System.EventHandler(this.txtSrchPrecio_Leave);
            // 
            // panelProductoPrecios
            // 
            this.panelProductoPrecios.Controls.Add(this.buttonX6);
            this.panelProductoPrecios.Controls.Add(this.txtTasaDivisaProveedor);
            this.panelProductoPrecios.Controls.Add(this.chkPrecioFijo);
            this.panelProductoPrecios.Controls.Add(this.chkRedondeo);
            this.panelProductoPrecios.Controls.Add(this.lblAvisoPerdida);
            this.panelProductoPrecios.Controls.Add(this.labelX8);
            this.panelProductoPrecios.Controls.Add(this.txtsrchOldDivisaFactor);
            this.panelProductoPrecios.Controls.Add(this.txtDivisaMargenM);
            this.panelProductoPrecios.Controls.Add(this.txtSrchOldMargen);
            this.panelProductoPrecios.Controls.Add(this.lblUltimoCosto);
            this.panelProductoPrecios.Controls.Add(this.txtDivisaM);
            this.panelProductoPrecios.Controls.Add(this.txtSrchOldDivisa);
            this.panelProductoPrecios.Controls.Add(this.txtDivisaCostoM);
            this.panelProductoPrecios.Controls.Add(this.txtSrchOldCosto);
            this.panelProductoPrecios.Controls.Add(this.labelX4);
            this.panelProductoPrecios.Controls.Add(this.txtSrchDivisa);
            this.panelProductoPrecios.Controls.Add(this.labelX10);
            this.panelProductoPrecios.Controls.Add(this.labelX13);
            this.panelProductoPrecios.Controls.Add(this.txtPrecioM);
            this.panelProductoPrecios.Controls.Add(this.txtSrchMargen);
            this.panelProductoPrecios.Controls.Add(this.txtSrchOldPrecio);
            this.panelProductoPrecios.Controls.Add(this.labelX7);
            this.panelProductoPrecios.Controls.Add(this.txtSrchPrecio);
            this.panelProductoPrecios.Controls.Add(this.txtSrchCosto);
            this.panelProductoPrecios.Controls.Add(this.labelX11);
            this.panelProductoPrecios.Controls.Add(this.labelX26);
            this.panelProductoPrecios.Controls.Add(this.labelX19);
            this.panelProductoPrecios.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelProductoPrecios.Location = new System.Drawing.Point(7, 371);
            this.panelProductoPrecios.Name = "panelProductoPrecios";
            this.panelProductoPrecios.Size = new System.Drawing.Size(676, 202);
            this.panelProductoPrecios.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelProductoPrecios.Style.BorderColor.Color = System.Drawing.Color.Gray;
            this.panelProductoPrecios.TabIndex = 1;
            // 
            // buttonX6
            // 
            this.buttonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX6.AutoExpandOnClick = true;
            this.buttonX6.BackColor = System.Drawing.Color.Gold;
            this.buttonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.buttonX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX6.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX6.Location = new System.Drawing.Point(525, 30);
            this.buttonX6.Margin = new System.Windows.Forms.Padding(0);
            this.buttonX6.Name = "buttonX6";
            this.buttonX6.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
            this.buttonX6.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlM);
            this.buttonX6.ShowSubItems = false;
            this.buttonX6.Size = new System.Drawing.Size(35, 35);
            this.buttonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX6.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer15});
            this.buttonX6.Symbol = "";
            this.buttonX6.SymbolSize = 20F;
            this.buttonX6.TabIndex = 3;
            this.buttonX6.TabStop = false;
            this.buttonX6.Tag = "";
            this.buttonX6.PopupShowing += new System.EventHandler(this.buttonX6_PopupShowing);
            this.buttonX6.Click += new System.EventHandler(this.buttonX6_Click);
            // 
            // itemContainer15
            // 
            this.itemContainer15.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
            // 
            // 
            // 
            this.itemContainer15.BackgroundStyle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.itemContainer15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer15.BackgroundStyle.PaddingLeft = 5;
            this.itemContainer15.BackgroundStyle.PaddingRight = 5;
            this.itemContainer15.FixedSize = new System.Drawing.Size(300, 200);
            this.itemContainer15.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer15.Name = "itemContainer15";
            this.itemContainer15.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer18,
            this.itemContainer17,
            this.itemContainer20,
            this.itemContainer22,
            this.itemContainer21,
            this.itemContainer19});
            // 
            // 
            // 
            this.itemContainer15.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer15.TitleStyle.BackColor = System.Drawing.Color.SteelBlue;
            this.itemContainer15.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer15.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemContainer15.TitleStyle.PaddingBottom = 5;
            this.itemContainer15.TitleStyle.PaddingLeft = 5;
            this.itemContainer15.TitleStyle.PaddingRight = 5;
            this.itemContainer15.TitleStyle.PaddingTop = 5;
            this.itemContainer15.TitleStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.itemContainer15.TitleStyle.TextColor = System.Drawing.Color.White;
            this.itemContainer15.TitleText = "Calcular Precio Unidad";
            // 
            // itemContainer18
            // 
            // 
            // 
            // 
            this.itemContainer18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer18.BackgroundStyle.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemContainer18.FixedSize = new System.Drawing.Size(250, 30);
            this.itemContainer18.Name = "itemContainer18";
            this.itemContainer18.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem10,
            this.cmbICalcTasa});
            // 
            // 
            // 
            this.itemContainer18.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer18.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer18.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // labelItem10
            // 
            this.labelItem10.AutoCollapseOnClick = false;
            this.labelItem10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItem10.Name = "labelItem10";
            this.labelItem10.Text = "Impuesto %:";
            this.labelItem10.Width = 100;
            // 
            // cmbICalcTasa
            // 
            this.cmbICalcTasa.AutoCollapseOnClick = false;
            this.cmbICalcTasa.ComboWidth = 170;
            this.cmbICalcTasa.DropDownHeight = 106;
            this.cmbICalcTasa.ItemHeight = 24;
            this.cmbICalcTasa.Name = "cmbICalcTasa";
            this.cmbICalcTasa.Text = "comboBoxItem1";
            this.cmbICalcTasa.SelectedIndexChanged += new System.EventHandler(this.cmbICalcTasa_SelectedIndexChanged);
            // 
            // itemContainer17
            // 
            // 
            // 
            // 
            this.itemContainer17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer17.BackgroundStyle.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemContainer17.FixedSize = new System.Drawing.Size(300, 30);
            this.itemContainer17.Name = "itemContainer17";
            this.itemContainer17.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem15,
            this.txtICalcMontoTotal,
            this.labelItem8,
            this.txtICalcCantidad});
            // 
            // 
            // 
            this.itemContainer17.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer17.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer17.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // labelItem15
            // 
            this.labelItem15.AutoCollapseOnClick = false;
            this.labelItem15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItem15.Name = "labelItem15";
            this.labelItem15.Text = "Total Bs.:";
            this.labelItem15.Width = 70;
            // 
            // txtICalcMontoTotal
            // 
            this.txtICalcMontoTotal.AutoCollapseOnClick = false;
            this.txtICalcMontoTotal.FocusHighlightEnabled = true;
            this.txtICalcMontoTotal.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.txtICalcMontoTotal.MaxLength = 16;
            this.txtICalcMontoTotal.Name = "txtICalcMontoTotal";
            this.txtICalcMontoTotal.Text = "99.999.999,99";
            this.txtICalcMontoTotal.TextBoxHeight = 21;
            this.txtICalcMontoTotal.TextBoxWidth = 80;
            this.txtICalcMontoTotal.WatermarkColor = System.Drawing.SystemColors.GrayText;
            this.txtICalcMontoTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSrchPrecio_KeyPress);
            this.txtICalcMontoTotal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSrchPrecio_KeyUp);
            this.txtICalcMontoTotal.LostFocus += new System.EventHandler(this.txtICalcMontoTotal_LostFocus);
            this.txtICalcMontoTotal.GotFocus += new System.EventHandler(this.txtSrchPrecio_Enter);
            // 
            // labelItem8
            // 
            this.labelItem8.AutoCollapseOnClick = false;
            this.labelItem8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItem8.Name = "labelItem8";
            this.labelItem8.Text = "/ cant.:";
            this.labelItem8.Width = 50;
            // 
            // txtICalcCantidad
            // 
            this.txtICalcCantidad.FocusHighlightEnabled = true;
            this.txtICalcCantidad.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.txtICalcCantidad.MaxLength = 8;
            this.txtICalcCantidad.Name = "txtICalcCantidad";
            this.txtICalcCantidad.TextBoxHeight = 21;
            this.txtICalcCantidad.TextBoxWidth = 40;
            this.txtICalcCantidad.WatermarkColor = System.Drawing.SystemColors.GrayText;
            this.txtICalcCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSrchPrecio_KeyPress);
            this.txtICalcCantidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSrchPrecio_KeyUp);
            this.txtICalcCantidad.LostFocus += new System.EventHandler(this.txtICalcMontoTotal_LostFocus);
            this.txtICalcCantidad.GotFocus += new System.EventHandler(this.txtSrchPrecio_Enter);
            // 
            // itemContainer20
            // 
            // 
            // 
            // 
            this.itemContainer20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer20.FixedSize = new System.Drawing.Size(250, 30);
            this.itemContainer20.Name = "itemContainer20";
            this.itemContainer20.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lbl1,
            this.lblICalcCostoUndBs});
            // 
            // 
            // 
            this.itemContainer20.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer20.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer20.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // lbl1
            // 
            this.lbl1.AutoCollapseOnClick = false;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Name = "lbl1";
            this.lbl1.Text = "Costo Und/Bs.: ";
            this.lbl1.Width = 120;
            // 
            // lblICalcCostoUndBs
            // 
            this.lblICalcCostoUndBs.AutoCollapseOnClick = false;
            this.lblICalcCostoUndBs.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblICalcCostoUndBs.ForeColor = System.Drawing.Color.Red;
            this.lblICalcCostoUndBs.Name = "lblICalcCostoUndBs";
            this.lblICalcCostoUndBs.Text = "0,00";
            this.lblICalcCostoUndBs.TextAlignment = System.Drawing.StringAlignment.Far;
            this.lblICalcCostoUndBs.Width = 170;
            // 
            // itemContainer22
            // 
            // 
            // 
            // 
            this.itemContainer22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer22.BackgroundStyle.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemContainer22.FixedSize = new System.Drawing.Size(250, 30);
            this.itemContainer22.Name = "itemContainer22";
            this.itemContainer22.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem11,
            this.txtICalcTasaDivisaProveedor,
            this.labelItem16});
            // 
            // 
            // 
            this.itemContainer22.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer22.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer22.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // labelItem11
            // 
            this.labelItem11.AutoCollapseOnClick = false;
            this.labelItem11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItem11.Name = "labelItem11";
            this.labelItem11.Text = "Tasa $ Prove.:";
            this.labelItem11.Width = 120;
            // 
            // txtICalcTasaDivisaProveedor
            // 
            this.txtICalcTasaDivisaProveedor.FocusHighlightEnabled = true;
            this.txtICalcTasaDivisaProveedor.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.txtICalcTasaDivisaProveedor.MaxLength = 18;
            this.txtICalcTasaDivisaProveedor.Name = "txtICalcTasaDivisaProveedor";
            this.txtICalcTasaDivisaProveedor.Text = "99.999.999,99";
            this.txtICalcTasaDivisaProveedor.TextBoxHeight = 21;
            this.txtICalcTasaDivisaProveedor.TextBoxWidth = 150;
            this.txtICalcTasaDivisaProveedor.WatermarkColor = System.Drawing.SystemColors.GrayText;
            this.txtICalcTasaDivisaProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSrchPrecio_KeyPress);
            this.txtICalcTasaDivisaProveedor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSrchPrecio_KeyUp);
            this.txtICalcTasaDivisaProveedor.LostFocus += new System.EventHandler(this.txtICalcMontoTotal_LostFocus);
            // 
            // labelItem16
            // 
            this.labelItem16.Name = "labelItem16";
            this.labelItem16.Visible = false;
            this.labelItem16.Width = 100;
            // 
            // itemContainer21
            // 
            // 
            // 
            // 
            this.itemContainer21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer21.BackgroundStyle.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemContainer21.FixedSize = new System.Drawing.Size(250, 30);
            this.itemContainer21.Name = "itemContainer21";
            this.itemContainer21.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem17,
            this.txtICalcMontoUnidadDivisa,
            this.labelItem18});
            // 
            // 
            // 
            this.itemContainer21.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer21.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer21.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // labelItem17
            // 
            this.labelItem17.AutoCollapseOnClick = false;
            this.labelItem17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItem17.Name = "labelItem17";
            this.labelItem17.Text = "Costo Und/$:";
            this.labelItem17.Width = 120;
            // 
            // txtICalcMontoUnidadDivisa
            // 
            this.txtICalcMontoUnidadDivisa.FocusHighlightEnabled = true;
            this.txtICalcMontoUnidadDivisa.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.txtICalcMontoUnidadDivisa.MaxLength = 18;
            this.txtICalcMontoUnidadDivisa.Name = "txtICalcMontoUnidadDivisa";
            this.txtICalcMontoUnidadDivisa.Text = "99.999.999,99";
            this.txtICalcMontoUnidadDivisa.TextBoxHeight = 21;
            this.txtICalcMontoUnidadDivisa.TextBoxWidth = 150;
            this.txtICalcMontoUnidadDivisa.WatermarkColor = System.Drawing.SystemColors.GrayText;
            this.txtICalcMontoUnidadDivisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSrchPrecio_KeyPress);
            this.txtICalcMontoUnidadDivisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSrchPrecio_KeyUp);
            this.txtICalcMontoUnidadDivisa.GotFocus += new System.EventHandler(this.txtSrchPrecio_Enter);
            // 
            // labelItem18
            // 
            this.labelItem18.Name = "labelItem18";
            this.labelItem18.Visible = false;
            this.labelItem18.Width = 100;
            // 
            // itemContainer19
            // 
            // 
            // 
            // 
            this.itemContainer19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer19.FixedSize = new System.Drawing.Size(250, 40);
            this.itemContainer19.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainer19.Name = "itemContainer19";
            this.itemContainer19.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnICalcOK});
            // 
            // 
            // 
            this.itemContainer19.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer19.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer19.TitleVisible = false;
            this.itemContainer19.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // btnICalcOK
            // 
            this.btnICalcOK.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnICalcOK.EnableImageAnimation = true;
            this.btnICalcOK.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnICalcOK.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center;
            this.btnICalcOK.Name = "btnICalcOK";
            this.btnICalcOK.PopupWidth = 300;
            this.btnICalcOK.ShowSubItems = false;
            this.btnICalcOK.Stretch = true;
            this.btnICalcOK.Symbol = "";
            this.btnICalcOK.Text = "OK";
            this.btnICalcOK.Click += new System.EventHandler(this.btnIOK_Click);
            // 
            // txtTasaDivisaProveedor
            // 
            this.txtTasaDivisaProveedor.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTasaDivisaProveedor.Border.Class = "TextBoxBorder";
            this.txtTasaDivisaProveedor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTasaDivisaProveedor.DisabledBackColor = System.Drawing.Color.White;
            this.txtTasaDivisaProveedor.FocusHighlightEnabled = true;
            this.txtTasaDivisaProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTasaDivisaProveedor.ForeColor = System.Drawing.Color.Black;
            this.txtTasaDivisaProveedor.Location = new System.Drawing.Point(389, 68);
            this.txtTasaDivisaProveedor.MaxLength = 10;
            this.txtTasaDivisaProveedor.Name = "txtTasaDivisaProveedor";
            this.txtTasaDivisaProveedor.PreventEnterBeep = true;
            this.txtTasaDivisaProveedor.Size = new System.Drawing.Size(173, 23);
            this.txtTasaDivisaProveedor.TabIndex = 2;
            this.txtTasaDivisaProveedor.TabStop = false;
            this.txtTasaDivisaProveedor.Tag = "4";
            this.txtTasaDivisaProveedor.Text = "99.999.999,99";
            this.txtTasaDivisaProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTasaDivisaProveedor.Enter += new System.EventHandler(this.txtSrchPrecio_Enter);
            this.txtTasaDivisaProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSrchPrecio_KeyPress);
            this.txtTasaDivisaProveedor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSrchPrecio_KeyUp);
            this.txtTasaDivisaProveedor.Leave += new System.EventHandler(this.txtSrchPrecio_Leave);
            // 
            // chkPrecioFijo
            // 
            this.chkPrecioFijo.AutoSize = true;
            this.chkPrecioFijo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.chkPrecioFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrecioFijo.ForeColor = System.Drawing.Color.Blue;
            this.chkPrecioFijo.Location = new System.Drawing.Point(64, 8);
            this.chkPrecioFijo.Name = "chkPrecioFijo";
            this.chkPrecioFijo.Size = new System.Drawing.Size(49, 21);
            this.chkPrecioFijo.TabIndex = 26;
            this.chkPrecioFijo.Text = "Fijo";
            this.chkPrecioFijo.UseVisualStyleBackColor = false;
            // 
            // chkRedondeo
            // 
            this.chkRedondeo.AutoSize = true;
            this.chkRedondeo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.chkRedondeo.Checked = true;
            this.chkRedondeo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRedondeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRedondeo.ForeColor = System.Drawing.Color.Red;
            this.chkRedondeo.Location = new System.Drawing.Point(141, 8);
            this.chkRedondeo.Name = "chkRedondeo";
            this.chkRedondeo.Size = new System.Drawing.Size(93, 21);
            this.chkRedondeo.TabIndex = 26;
            this.chkRedondeo.Text = "Redondeo";
            this.chkRedondeo.UseVisualStyleBackColor = false;
            // 
            // lblAvisoPerdida
            // 
            this.lblAvisoPerdida.BackColor = System.Drawing.Color.Yellow;
            // 
            // 
            // 
            this.lblAvisoPerdida.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblAvisoPerdida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoPerdida.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoPerdida.Location = new System.Drawing.Point(506, 2);
            this.lblAvisoPerdida.Name = "lblAvisoPerdida";
            this.lblAvisoPerdida.Size = new System.Drawing.Size(167, 21);
            this.lblAvisoPerdida.TabIndex = 8;
            this.lblAvisoPerdida.Text = "PRECIO A PERDIDA!";
            this.lblAvisoPerdida.Visible = false;
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.LightSteelBlue;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.ForeColor = System.Drawing.Color.Black;
            this.labelX8.Location = new System.Drawing.Point(8, 8);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(226, 21);
            this.labelX8.TabIndex = 8;
            this.labelX8.Text = "Precio";
            // 
            // txtsrchOldDivisaFactor
            // 
            this.txtsrchOldDivisaFactor.BackColor = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            this.txtsrchOldDivisaFactor.Border.Class = "TextBoxBorder";
            this.txtsrchOldDivisaFactor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsrchOldDivisaFactor.DisabledBackColor = System.Drawing.Color.LightGray;
            this.txtsrchOldDivisaFactor.Enabled = false;
            this.txtsrchOldDivisaFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsrchOldDivisaFactor.ForeColor = System.Drawing.Color.Black;
            this.txtsrchOldDivisaFactor.Location = new System.Drawing.Point(549, 171);
            this.txtsrchOldDivisaFactor.Name = "txtsrchOldDivisaFactor";
            this.txtsrchOldDivisaFactor.PreventEnterBeep = true;
            this.txtsrchOldDivisaFactor.Size = new System.Drawing.Size(120, 26);
            this.txtsrchOldDivisaFactor.TabIndex = 2;
            this.txtsrchOldDivisaFactor.TabStop = false;
            this.txtsrchOldDivisaFactor.Tag = "0";
            this.txtsrchOldDivisaFactor.Text = "1.000.000,00";
            this.txtsrchOldDivisaFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtsrchOldDivisaFactor.Enter += new System.EventHandler(this.txtSrchPrecio_Enter);
            // 
            // txtDivisaMargenM
            // 
            this.txtDivisaMargenM.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDivisaMargenM.Border.Class = "TextBoxBorder";
            this.txtDivisaMargenM.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDivisaMargenM.DisabledBackColor = System.Drawing.Color.LightGray;
            this.txtDivisaMargenM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivisaMargenM.ForeColor = System.Drawing.Color.Black;
            this.txtDivisaMargenM.Location = new System.Drawing.Point(567, 110);
            this.txtDivisaMargenM.MaxLength = 10;
            this.txtDivisaMargenM.Name = "txtDivisaMargenM";
            this.txtDivisaMargenM.PreventEnterBeep = true;
            this.txtDivisaMargenM.Size = new System.Drawing.Size(102, 32);
            this.txtDivisaMargenM.TabIndex = 8;
            this.txtDivisaMargenM.Tag = "8";
            this.txtDivisaMargenM.Text = "9.999,00";
            this.txtDivisaMargenM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDivisaMargenM.Enter += new System.EventHandler(this.txtSrchPrecio_Enter);
            this.txtDivisaMargenM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSrchPrecio_KeyPress);
            this.txtDivisaMargenM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSrchPrecio_KeyUp);
            this.txtDivisaMargenM.Leave += new System.EventHandler(this.txtSrchPrecio_Leave);
            // 
            // txtSrchOldMargen
            // 
            this.txtSrchOldMargen.BackColor = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            this.txtSrchOldMargen.Border.Class = "TextBoxBorder";
            this.txtSrchOldMargen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSrchOldMargen.DisabledBackColor = System.Drawing.Color.LightGray;
            this.txtSrchOldMargen.Enabled = false;
            this.txtSrchOldMargen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSrchOldMargen.ForeColor = System.Drawing.Color.Black;
            this.txtSrchOldMargen.Location = new System.Drawing.Point(369, 171);
            this.txtSrchOldMargen.MaxLength = 10;
            this.txtSrchOldMargen.Name = "txtSrchOldMargen";
            this.txtSrchOldMargen.PreventEnterBeep = true;
            this.txtSrchOldMargen.Size = new System.Drawing.Size(81, 26);
            this.txtSrchOldMargen.TabIndex = 5;
            this.txtSrchOldMargen.TabStop = false;
            this.txtSrchOldMargen.Tag = "3";
            this.txtSrchOldMargen.Text = "9.999,00";
            this.txtSrchOldMargen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblUltimoCosto
            // 
            this.lblUltimoCosto.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblUltimoCosto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblUltimoCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoCosto.ForeColor = System.Drawing.Color.Red;
            this.lblUltimoCosto.Location = new System.Drawing.Point(490, 90);
            this.lblUltimoCosto.Name = "lblUltimoCosto";
            this.lblUltimoCosto.Size = new System.Drawing.Size(70, 18);
            this.lblUltimoCosto.TabIndex = 41;
            this.lblUltimoCosto.Text = "21/12/2020";
            this.lblUltimoCosto.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtDivisaM
            // 
            this.txtDivisaM.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDivisaM.Border.Class = "TextBoxBorder";
            this.txtDivisaM.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDivisaM.DisabledBackColor = System.Drawing.Color.LightGray;
            this.txtDivisaM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivisaM.ForeColor = System.Drawing.Color.Black;
            this.txtDivisaM.Location = new System.Drawing.Point(241, 110);
            this.txtDivisaM.MaxLength = 10;
            this.txtDivisaM.Name = "txtDivisaM";
            this.txtDivisaM.PreventEnterBeep = true;
            this.txtDivisaM.Size = new System.Drawing.Size(136, 32);
            this.txtDivisaM.TabIndex = 6;
            this.txtDivisaM.Tag = "6";
            this.txtDivisaM.Text = "9.999,00";
            this.txtDivisaM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDivisaM.Enter += new System.EventHandler(this.txtSrchPrecio_Enter);
            this.txtDivisaM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSrchPrecio_KeyPress);
            this.txtDivisaM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSrchPrecio_KeyUp);
            this.txtDivisaM.Leave += new System.EventHandler(this.txtSrchPrecio_Leave);
            // 
            // txtSrchOldDivisa
            // 
            this.txtSrchOldDivisa.BackColor = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            this.txtSrchOldDivisa.Border.Class = "TextBoxBorder";
            this.txtSrchOldDivisa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSrchOldDivisa.DisabledBackColor = System.Drawing.Color.LightGray;
            this.txtSrchOldDivisa.Enabled = false;
            this.txtSrchOldDivisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSrchOldDivisa.ForeColor = System.Drawing.Color.Black;
            this.txtSrchOldDivisa.Location = new System.Drawing.Point(185, 171);
            this.txtSrchOldDivisa.MaxLength = 10;
            this.txtSrchOldDivisa.Name = "txtSrchOldDivisa";
            this.txtSrchOldDivisa.PreventEnterBeep = true;
            this.txtSrchOldDivisa.Size = new System.Drawing.Size(81, 26);
            this.txtSrchOldDivisa.TabIndex = 3;
            this.txtSrchOldDivisa.TabStop = false;
            this.txtSrchOldDivisa.Tag = "1";
            this.txtSrchOldDivisa.Text = "9.999,00";
            this.txtSrchOldDivisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDivisaCostoM
            // 
            this.txtDivisaCostoM.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDivisaCostoM.Border.Class = "TextBoxBorder";
            this.txtDivisaCostoM.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDivisaCostoM.DisabledBackColor = System.Drawing.Color.LightGray;
            this.txtDivisaCostoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivisaCostoM.ForeColor = System.Drawing.Color.Black;
            this.txtDivisaCostoM.Location = new System.Drawing.Point(387, 110);
            this.txtDivisaCostoM.MaxLength = 10;
            this.txtDivisaCostoM.Name = "txtDivisaCostoM";
            this.txtDivisaCostoM.PreventEnterBeep = true;
            this.txtDivisaCostoM.Size = new System.Drawing.Size(173, 32);
            this.txtDivisaCostoM.TabIndex = 7;
            this.txtDivisaCostoM.Tag = "7";
            this.txtDivisaCostoM.Text = "9.999,00";
            this.txtDivisaCostoM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDivisaCostoM.Enter += new System.EventHandler(this.txtSrchPrecio_Enter);
            this.txtDivisaCostoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSrchPrecio_KeyPress);
            this.txtDivisaCostoM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSrchPrecio_KeyUp);
            this.txtDivisaCostoM.Leave += new System.EventHandler(this.txtSrchPrecio_Leave);
            // 
            // txtSrchOldCosto
            // 
            this.txtSrchOldCosto.BackColor = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            this.txtSrchOldCosto.Border.Class = "TextBoxBorder";
            this.txtSrchOldCosto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSrchOldCosto.DisabledBackColor = System.Drawing.Color.LightGray;
            this.txtSrchOldCosto.Enabled = false;
            this.txtSrchOldCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSrchOldCosto.ForeColor = System.Drawing.Color.Black;
            this.txtSrchOldCosto.Location = new System.Drawing.Point(277, 171);
            this.txtSrchOldCosto.MaxLength = 10;
            this.txtSrchOldCosto.Name = "txtSrchOldCosto";
            this.txtSrchOldCosto.PreventEnterBeep = true;
            this.txtSrchOldCosto.Size = new System.Drawing.Size(81, 26);
            this.txtSrchOldCosto.TabIndex = 4;
            this.txtSrchOldCosto.TabStop = false;
            this.txtSrchOldCosto.Tag = "2";
            this.txtSrchOldCosto.Text = "9.999,00";
            this.txtSrchOldCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.LightSteelBlue;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(243, 8);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(136, 21);
            this.labelX4.TabIndex = 8;
            this.labelX4.Text = "Divisa";
            // 
            // txtSrchDivisa
            // 
            this.txtSrchDivisa.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSrchDivisa.Border.Class = "TextBoxBorder";
            this.txtSrchDivisa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSrchDivisa.DisabledBackColor = System.Drawing.Color.White;
            this.txtSrchDivisa.FocusHighlightEnabled = true;
            this.txtSrchDivisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSrchDivisa.ForeColor = System.Drawing.Color.Black;
            this.txtSrchDivisa.Location = new System.Drawing.Point(243, 30);
            this.txtSrchDivisa.MaxLength = 10;
            this.txtSrchDivisa.Name = "txtSrchDivisa";
            this.txtSrchDivisa.PreventEnterBeep = true;
            this.txtSrchDivisa.Size = new System.Drawing.Size(136, 35);
            this.txtSrchDivisa.TabIndex = 1;
            this.txtSrchDivisa.Tag = "1";
            this.txtSrchDivisa.Text = "9.999,00";
            this.txtSrchDivisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSrchDivisa.Enter += new System.EventHandler(this.txtSrchPrecio_Enter);
            this.txtSrchDivisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSrchPrecio_KeyPress);
            this.txtSrchDivisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSrchPrecio_KeyUp);
            this.txtSrchDivisa.Leave += new System.EventHandler(this.txtSrchPrecio_Leave);
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.LightSteelBlue;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.ForeColor = System.Drawing.Color.Black;
            this.labelX10.Location = new System.Drawing.Point(389, 8);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(173, 21);
            this.labelX10.TabIndex = 8;
            this.labelX10.Text = "Costo $";
            // 
            // labelX13
            // 
            this.labelX13.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX13.ForeColor = System.Drawing.Color.Gray;
            this.labelX13.Location = new System.Drawing.Point(8, 146);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(224, 21);
            this.labelX13.TabIndex = 8;
            this.labelX13.Text = "Precio Anterior:";
            this.labelX13.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtPrecioM
            // 
            this.txtPrecioM.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPrecioM.Border.Class = "TextBoxBorder";
            this.txtPrecioM.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPrecioM.DisabledBackColor = System.Drawing.Color.LightGray;
            this.txtPrecioM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioM.ForeColor = System.Drawing.Color.Black;
            this.txtPrecioM.Location = new System.Drawing.Point(6, 110);
            this.txtPrecioM.Name = "txtPrecioM";
            this.txtPrecioM.PreventEnterBeep = true;
            this.txtPrecioM.Size = new System.Drawing.Size(226, 32);
            this.txtPrecioM.TabIndex = 5;
            this.txtPrecioM.Tag = "5";
            this.txtPrecioM.Text = "999.999.999,99";
            this.txtPrecioM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioM.TextChanged += new System.EventHandler(this.txtPrecioM_TextChanged);
            this.txtPrecioM.Enter += new System.EventHandler(this.txtSrchPrecio_Enter);
            this.txtPrecioM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSrchPrecio_KeyPress);
            this.txtPrecioM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSrchPrecio_KeyUp);
            this.txtPrecioM.Leave += new System.EventHandler(this.txtSrchPrecio_Leave);
            // 
            // txtSrchMargen
            // 
            this.txtSrchMargen.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSrchMargen.Border.Class = "TextBoxBorder";
            this.txtSrchMargen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSrchMargen.DisabledBackColor = System.Drawing.Color.White;
            this.txtSrchMargen.FocusHighlightEnabled = true;
            this.txtSrchMargen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSrchMargen.ForeColor = System.Drawing.Color.Black;
            this.txtSrchMargen.Location = new System.Drawing.Point(569, 30);
            this.txtSrchMargen.MaxLength = 10;
            this.txtSrchMargen.Name = "txtSrchMargen";
            this.txtSrchMargen.PreventEnterBeep = true;
            this.txtSrchMargen.Size = new System.Drawing.Size(102, 35);
            this.txtSrchMargen.TabIndex = 4;
            this.txtSrchMargen.Tag = "3";
            this.txtSrchMargen.Text = "9.999,00";
            this.txtSrchMargen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSrchMargen.Enter += new System.EventHandler(this.txtSrchPrecio_Enter);
            this.txtSrchMargen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSrchPrecio_KeyPress);
            this.txtSrchMargen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSrchPrecio_KeyUp);
            this.txtSrchMargen.Leave += new System.EventHandler(this.txtSrchPrecio_Leave);
            // 
            // txtSrchOldPrecio
            // 
            this.txtSrchOldPrecio.BackColor = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            this.txtSrchOldPrecio.Border.Class = "TextBoxBorder";
            this.txtSrchOldPrecio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSrchOldPrecio.DisabledBackColor = System.Drawing.Color.LightGray;
            this.txtSrchOldPrecio.Enabled = false;
            this.txtSrchOldPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSrchOldPrecio.ForeColor = System.Drawing.Color.Black;
            this.txtSrchOldPrecio.Location = new System.Drawing.Point(8, 171);
            this.txtSrchOldPrecio.Name = "txtSrchOldPrecio";
            this.txtSrchOldPrecio.PreventEnterBeep = true;
            this.txtSrchOldPrecio.Size = new System.Drawing.Size(166, 26);
            this.txtSrchOldPrecio.TabIndex = 2;
            this.txtSrchOldPrecio.TabStop = false;
            this.txtSrchOldPrecio.Tag = "0";
            this.txtSrchOldPrecio.Text = "999.999.999,99";
            this.txtSrchOldPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSrchOldPrecio.Enter += new System.EventHandler(this.txtSrchPrecio_Enter);
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.LightSteelBlue;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.ForeColor = System.Drawing.Color.Black;
            this.labelX7.Location = new System.Drawing.Point(569, 8);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(102, 21);
            this.labelX7.TabIndex = 8;
            this.labelX7.Text = "Márgen";
            // 
            // txtSrchPrecio
            // 
            this.txtSrchPrecio.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSrchPrecio.Border.Class = "TextBoxBorder";
            this.txtSrchPrecio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSrchPrecio.DisabledBackColor = System.Drawing.Color.White;
            this.txtSrchPrecio.FocusHighlightEnabled = true;
            this.txtSrchPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSrchPrecio.ForeColor = System.Drawing.Color.Black;
            this.txtSrchPrecio.Location = new System.Drawing.Point(8, 30);
            this.txtSrchPrecio.Name = "txtSrchPrecio";
            this.txtSrchPrecio.PreventEnterBeep = true;
            this.txtSrchPrecio.Size = new System.Drawing.Size(226, 35);
            this.txtSrchPrecio.TabIndex = 0;
            this.txtSrchPrecio.Tag = "0";
            this.txtSrchPrecio.Text = "999.999.999,99";
            this.txtSrchPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSrchPrecio.Enter += new System.EventHandler(this.txtSrchPrecio_Enter);
            this.txtSrchPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSrchPrecio_KeyPress);
            this.txtSrchPrecio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSrchPrecio_KeyUp);
            this.txtSrchPrecio.Leave += new System.EventHandler(this.txtSrchPrecio_Leave);
            // 
            // txtSrchCosto
            // 
            this.txtSrchCosto.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSrchCosto.Border.Class = "TextBoxBorder";
            this.txtSrchCosto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSrchCosto.ButtonCustom.Symbol = "";
            this.txtSrchCosto.DisabledBackColor = System.Drawing.Color.White;
            this.txtSrchCosto.FocusHighlightEnabled = true;
            this.txtSrchCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSrchCosto.ForeColor = System.Drawing.Color.Black;
            this.txtSrchCosto.Location = new System.Drawing.Point(389, 30);
            this.txtSrchCosto.MaxLength = 10;
            this.txtSrchCosto.Name = "txtSrchCosto";
            this.txtSrchCosto.PreventEnterBeep = true;
            this.txtSrchCosto.Size = new System.Drawing.Size(136, 35);
            this.txtSrchCosto.TabIndex = 2;
            this.txtSrchCosto.Tag = "2";
            this.txtSrchCosto.Text = "999,00";
            this.txtSrchCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSrchCosto.Enter += new System.EventHandler(this.txtSrchPrecio_Enter);
            this.txtSrchCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSrchPrecio_KeyPress);
            this.txtSrchCosto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSrchPrecio_KeyUp);
            this.txtSrchCosto.Leave += new System.EventHandler(this.txtSrchPrecio_Leave);
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.LightGreen;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX11.ForeColor = System.Drawing.Color.Black;
            this.labelX11.Location = new System.Drawing.Point(10, 87);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(223, 21);
            this.labelX11.TabIndex = 8;
            this.labelX11.Text = "Precios al Mayor";
            // 
            // labelX26
            // 
            this.labelX26.AutoSize = true;
            this.labelX26.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX26.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX26.ForeColor = System.Drawing.Color.Blue;
            this.labelX26.Location = new System.Drawing.Point(265, 69);
            this.labelX26.Name = "labelX26";
            this.labelX26.Size = new System.Drawing.Size(112, 18);
            this.labelX26.TabIndex = 8;
            this.labelX26.Text = "Tasa $ Proveedor:";
            // 
            // labelX19
            // 
            this.labelX19.AutoSize = true;
            this.labelX19.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX19.ForeColor = System.Drawing.Color.Black;
            this.labelX19.Location = new System.Drawing.Point(456, 175);
            this.labelX19.Name = "labelX19";
            this.labelX19.Size = new System.Drawing.Size(94, 18);
            this.labelX19.TabIndex = 8;
            this.labelX19.Text = "Factor Anterior:";
            // 
            // panelMoveSearch
            // 
            this.panelMoveSearch.BackColor = System.Drawing.Color.LightGreen;
            this.panelMoveSearch.Controls.Add(this.labelX9);
            this.panelMoveSearch.Controls.Add(this.labelX2);
            this.panelMoveSearch.Controls.Add(this.lblSrchEncontrados);
            this.panelMoveSearch.Controls.Add(this.btnSrchPrev);
            this.panelMoveSearch.Controls.Add(this.btnSrchNext);
            this.panelMoveSearch.Location = new System.Drawing.Point(483, 119);
            this.panelMoveSearch.Name = "panelMoveSearch";
            this.panelMoveSearch.Padding = new System.Windows.Forms.Padding(5);
            this.panelMoveSearch.Size = new System.Drawing.Size(203, 38);
            this.panelMoveSearch.TabIndex = 15;
            // 
            // labelX9
            // 
            this.labelX9.AutoSize = true;
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.ForeColor = System.Drawing.Color.Black;
            this.labelX9.Location = new System.Drawing.Point(186, 0);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(14, 13);
            this.labelX9.TabIndex = 8;
            this.labelX9.Text = "<font size=\"-5\" color=\"#ED1C24\"><b>F7 </b></font>";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(0, 0);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(14, 13);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "<font size=\"-5\" color=\"#ED1C24\"><b>F6 </b></font>";
            // 
            // lblSrchEncontrados
            // 
            this.lblSrchEncontrados.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblSrchEncontrados.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSrchEncontrados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSrchEncontrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSrchEncontrados.ForeColor = System.Drawing.Color.Black;
            this.lblSrchEncontrados.Location = new System.Drawing.Point(49, 5);
            this.lblSrchEncontrados.Name = "lblSrchEncontrados";
            this.lblSrchEncontrados.Size = new System.Drawing.Size(106, 28);
            this.lblSrchEncontrados.TabIndex = 0;
            this.lblSrchEncontrados.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnSrchPrev
            // 
            this.btnSrchPrev.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.btnSrchPrev.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnSrchPrev.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSrchPrev.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSrchPrev.Location = new System.Drawing.Point(5, 5);
            this.btnSrchPrev.Name = "btnSrchPrev";
            this.btnSrchPrev.Size = new System.Drawing.Size(44, 28);
            this.btnSrchPrev.Symbol = "";
            this.btnSrchPrev.TabIndex = 14;
            this.btnSrchPrev.Tag = "1";
            this.btnSrchPrev.Click += new System.EventHandler(this.btnSrchPrev_Click);
            // 
            // btnSrchNext
            // 
            this.btnSrchNext.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.btnSrchNext.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnSrchNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSrchNext.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSrchNext.Location = new System.Drawing.Point(155, 5);
            this.btnSrchNext.Name = "btnSrchNext";
            this.btnSrchNext.Size = new System.Drawing.Size(43, 28);
            this.btnSrchNext.Symbol = "";
            this.btnSrchNext.TabIndex = 1;
            this.btnSrchNext.Tag = "2";
            this.btnSrchNext.Text = "symbolBox2";
            this.btnSrchNext.Click += new System.EventHandler(this.btnSrchPrev_Click);
            // 
            // btnsrchTransmitirDatosEstaciones
            // 
            this.btnsrchTransmitirDatosEstaciones.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsrchTransmitirDatosEstaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsrchTransmitirDatosEstaciones.BackColor = System.Drawing.Color.LightGray;
            this.btnsrchTransmitirDatosEstaciones.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnsrchTransmitirDatosEstaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrchTransmitirDatosEstaciones.Location = new System.Drawing.Point(401, 579);
            this.btnsrchTransmitirDatosEstaciones.Name = "btnsrchTransmitirDatosEstaciones";
            this.btnsrchTransmitirDatosEstaciones.Size = new System.Drawing.Size(148, 32);
            this.btnsrchTransmitirDatosEstaciones.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsrchTransmitirDatosEstaciones.TabIndex = 4;
            this.btnsrchTransmitirDatosEstaciones.Tag = "3";
            this.btnsrchTransmitirDatosEstaciones.Text = "<font size=\"-5\" color=\"#ED1C24\"><b>F11 </b></font>Transmitir Datos";
            this.btnsrchTransmitirDatosEstaciones.Click += new System.EventHandler(this.btnsrchTransmitirDatosEstaciones_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.LightYellow;
            this.btnEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(125, 579);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 32);
            this.btnEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Tag = "3";
            this.btnEliminar.Text = "<font size=\"-5\" color=\"#ED1C24\"><b>F9 </b></font>Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnsrchProductoNuevo
            // 
            this.btnsrchProductoNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsrchProductoNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsrchProductoNuevo.BackColor = System.Drawing.Color.LightYellow;
            this.btnsrchProductoNuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnsrchProductoNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrchProductoNuevo.Location = new System.Drawing.Point(9, 579);
            this.btnsrchProductoNuevo.Name = "btnsrchProductoNuevo";
            this.btnsrchProductoNuevo.Size = new System.Drawing.Size(103, 32);
            this.btnsrchProductoNuevo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsrchProductoNuevo.TabIndex = 6;
            this.btnsrchProductoNuevo.Tag = "3";
            this.btnsrchProductoNuevo.Text = "<font size=\"-5\" color=\"#ED1C24\"><b>F8 </b></font>Nuevo";
            this.btnsrchProductoNuevo.Click += new System.EventHandler(this.btnsrchProductoNuevo_Click);
            // 
            // btnsrchCancelCambio
            // 
            this.btnsrchCancelCambio.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsrchCancelCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsrchCancelCambio.BackColor = System.Drawing.Color.LightGray;
            this.btnsrchCancelCambio.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnsrchCancelCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrchCancelCambio.Location = new System.Drawing.Point(277, 579);
            this.btnsrchCancelCambio.Name = "btnsrchCancelCambio";
            this.btnsrchCancelCambio.Size = new System.Drawing.Size(121, 32);
            this.btnsrchCancelCambio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsrchCancelCambio.TabIndex = 7;
            this.btnsrchCancelCambio.Tag = "3";
            this.btnsrchCancelCambio.Text = "<font size=\"-5\" color=\"#ED1C24\"><b>F4 </b></font>Deshacer";
            this.btnsrchCancelCambio.Click += new System.EventHandler(this.btnSrchPrev_Click);
            // 
            // btnSrchAct
            // 
            this.btnSrchAct.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSrchAct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSrchAct.BackColor = System.Drawing.Color.LightGreen;
            this.btnSrchAct.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnSrchAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSrchAct.Location = new System.Drawing.Point(556, 579);
            this.btnSrchAct.Name = "btnSrchAct";
            this.btnSrchAct.Size = new System.Drawing.Size(128, 32);
            this.btnSrchAct.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSrchAct.TabIndex = 2;
            this.btnSrchAct.Text = "<font size=\"-5\" color=\"#ED1C24\"><b>F5 </b></font>ACTUALIZAR";
            this.btnSrchAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // btnSrchClose
            // 
            this.btnSrchClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSrchClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSrchClose.BackColor = System.Drawing.Color.Red;
            this.btnSrchClose.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnSrchClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSrchClose.Location = new System.Drawing.Point(659, 1);
            this.btnSrchClose.Name = "btnSrchClose";
            this.btnSrchClose.Size = new System.Drawing.Size(27, 32);
            this.btnSrchClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSrchClose.TabIndex = 5;
            this.btnSrchClose.Text = "X";
            this.btnSrchClose.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // lblSrchFactorDivisa
            // 
            this.lblSrchFactorDivisa.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblSrchFactorDivisa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSrchFactorDivisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSrchFactorDivisa.ForeColor = System.Drawing.Color.Black;
            this.lblSrchFactorDivisa.Location = new System.Drawing.Point(144, 127);
            this.lblSrchFactorDivisa.Name = "lblSrchFactorDivisa";
            this.lblSrchFactorDivisa.Size = new System.Drawing.Size(172, 21);
            this.lblSrchFactorDivisa.TabIndex = 8;
            this.lblSrchFactorDivisa.Text = "0,00";
            this.lblSrchFactorDivisa.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblTipoRedondeo
            // 
            this.lblTipoRedondeo.AutoSize = true;
            this.lblTipoRedondeo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblTipoRedondeo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTipoRedondeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoRedondeo.ForeColor = System.Drawing.Color.Black;
            this.lblTipoRedondeo.Location = new System.Drawing.Point(7, 160);
            this.lblTipoRedondeo.Name = "lblTipoRedondeo";
            this.lblTipoRedondeo.Size = new System.Drawing.Size(58, 21);
            this.lblTipoRedondeo.TabIndex = 8;
            this.lblTipoRedondeo.Text = "Código:";
            // 
            // labelX12
            // 
            this.labelX12.AutoSize = true;
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX12.ForeColor = System.Drawing.Color.Black;
            this.labelX12.Location = new System.Drawing.Point(16, 119);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(128, 35);
            this.labelX12.TabIndex = 8;
            this.labelX12.Text = "Divisa Bs.:";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnSrch);
            this.panelEx1.Controls.Add(this.txtSearch);
            this.panelEx1.Controls.Add(this.labelX5);
            this.panelEx1.Controls.Add(this.labelX15);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(7, 41);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Padding = new System.Windows.Forms.Padding(5);
            this.panelEx1.Size = new System.Drawing.Size(679, 72);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.LightGreen;
            this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.LightGreen;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // btnSrch
            // 
            this.btnSrch.BackColor = System.Drawing.Color.Gold;
            // 
            // 
            // 
            this.btnSrch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnSrch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSrch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSrch.Location = new System.Drawing.Point(612, 18);
            this.btnSrch.Name = "btnSrch";
            this.btnSrch.Size = new System.Drawing.Size(62, 49);
            this.btnSrch.Symbol = "";
            this.btnSrch.SymbolSize = 30F;
            this.btnSrch.TabIndex = 1;
            this.btnSrch.Text = "symbolBox1";
            this.btnSrch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSearch.Border.Class = "TextBoxBorder";
            this.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearch.DisabledBackColor = System.Drawing.Color.White;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSearch.FocusHighlightEnabled = true;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(113, 18);
            this.txtSearch.MinimumSize = new System.Drawing.Size(0, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PreventEnterBeep = true;
            this.txtSearch.Size = new System.Drawing.Size(488, 45);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(5, 18);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(108, 49);
            this.labelX5.TabIndex = 2;
            this.labelX5.Text = "<font size=\"-5\" color=\"#ED1C24\"> <b>F3 </b></font>Buscar:";
            // 
            // labelX15
            // 
            this.labelX15.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX15.ForeColor = System.Drawing.Color.Black;
            this.labelX15.Location = new System.Drawing.Point(5, 5);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(669, 13);
            this.labelX15.TabIndex = 2;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.LightSteelBlue;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelX3.Location = new System.Drawing.Point(7, 7);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(679, 26);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Buscar Producto";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // bindingSourcePromocion
            // 
            this.bindingSourcePromocion.DataMember = "promo";
            this.bindingSourcePromocion.DataSource = this.dsPpal;
            // 
            // panelFiltro
            // 
            this.panelFiltro.BackColor = System.Drawing.Color.LightGreen;
            this.panelFiltro.Controls.Add(this.chkFilSoloTroquelados);
            this.panelFiltro.Controls.Add(this.flowGrupoItems);
            this.panelFiltro.Controls.Add(this.btnFiltrarTodos);
            this.panelFiltro.Controls.Add(this.btnOKFiltrar);
            this.panelFiltro.Controls.Add(this.labelX14);
            this.panelFiltro.Location = new System.Drawing.Point(113, 303);
            this.panelFiltro.Name = "panelFiltro";
            this.panelFiltro.Padding = new System.Windows.Forms.Padding(7);
            this.panelFiltro.Size = new System.Drawing.Size(484, 274);
            this.panelFiltro.TabIndex = 13;
            this.panelFiltro.Visible = false;
            this.panelFiltro.VisibleChanged += new System.EventHandler(this.panelFiltro_VisibleChanged);
            // 
            // chkFilSoloTroquelados
            // 
            this.chkFilSoloTroquelados.AutoSize = true;
            this.chkFilSoloTroquelados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFilSoloTroquelados.ForeColor = System.Drawing.Color.Blue;
            this.chkFilSoloTroquelados.Location = new System.Drawing.Point(7, 242);
            this.chkFilSoloTroquelados.Name = "chkFilSoloTroquelados";
            this.chkFilSoloTroquelados.Size = new System.Drawing.Size(139, 21);
            this.chkFilSoloTroquelados.TabIndex = 21;
            this.chkFilSoloTroquelados.Text = "Solo Troquelados";
            this.chkFilSoloTroquelados.UseVisualStyleBackColor = true;
            // 
            // flowGrupoItems
            // 
            this.flowGrupoItems.AutoScroll = true;
            this.flowGrupoItems.BackColor = System.Drawing.Color.LightGray;
            this.flowGrupoItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowGrupoItems.Location = new System.Drawing.Point(7, 33);
            this.flowGrupoItems.Name = "flowGrupoItems";
            this.flowGrupoItems.Padding = new System.Windows.Forms.Padding(5);
            this.flowGrupoItems.Size = new System.Drawing.Size(470, 195);
            this.flowGrupoItems.TabIndex = 20;
            // 
            // btnFiltrarTodos
            // 
            this.btnFiltrarTodos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFiltrarTodos.BackColor = System.Drawing.Color.White;
            this.btnFiltrarTodos.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnFiltrarTodos.Location = new System.Drawing.Point(313, 234);
            this.btnFiltrarTodos.Name = "btnFiltrarTodos";
            this.btnFiltrarTodos.Size = new System.Drawing.Size(78, 32);
            this.btnFiltrarTodos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFiltrarTodos.TabIndex = 10;
            this.btnFiltrarTodos.Tag = "0";
            this.btnFiltrarTodos.Text = "Todos";
            this.btnFiltrarTodos.Click += new System.EventHandler(this.btnFiltrarTodos_Click);
            // 
            // btnOKFiltrar
            // 
            this.btnOKFiltrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOKFiltrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOKFiltrar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnOKFiltrar.Location = new System.Drawing.Point(397, 234);
            this.btnOKFiltrar.Name = "btnOKFiltrar";
            this.btnOKFiltrar.Size = new System.Drawing.Size(78, 32);
            this.btnOKFiltrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOKFiltrar.TabIndex = 10;
            this.btnOKFiltrar.Tag = "1";
            this.btnOKFiltrar.Text = "Filtrar";
            this.btnOKFiltrar.Click += new System.EventHandler(this.btnOKFiltrar_Click);
            // 
            // labelX14
            // 
            this.labelX14.BackColor = System.Drawing.Color.LightSteelBlue;
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX14.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelX14.Location = new System.Drawing.Point(7, 7);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(470, 26);
            this.labelX14.TabIndex = 1;
            this.labelX14.Text = "Seleccionar Grupo";
            this.labelX14.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // invenTableAdapter
            // 
            this.invenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dpto_cajasTableAdapter = null;
            this.tableAdapterManager.grupoTableAdapter = null;
            this.tableAdapterManager.inven_usaTableAdapter = this.inven_usaTableAdapter;
            this.tableAdapterManager.invenTableAdapter = this.invenTableAdapter;
            this.tableAdapterManager.monedasTableAdapter = null;
            this.tableAdapterManager.promoTableAdapter = null;
            this.tableAdapterManager.taxTableAdapter = null;
            this.tableAdapterManager.tipo_empaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RetailTrump.dsPpalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // inven_usaTableAdapter
            // 
            this.inven_usaTableAdapter.ClearBeforeFill = true;
            // 
            // taxTableAdapter
            // 
            this.taxTableAdapter.ClearBeforeFill = true;
            // 
            // monedasTableAdapter1
            // 
            this.monedasTableAdapter1.ClearBeforeFill = true;
            // 
            // estacionesTableAdapter1
            // 
            this.estacionesTableAdapter1.ClearBeforeFill = true;
            // 
            // gruinvTableAdapter
            // 
            this.gruinvTableAdapter.ClearBeforeFill = true;
            // 
            // timTransmitir
            // 
            this.timTransmitir.Interval = 500;
            this.timTransmitir.Tick += new System.EventHandler(this.timTransmitir_Tick);
            // 
            // lblDEMO
            // 
            this.lblDEMO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDEMO.BackColor = System.Drawing.Color.Red;
            // 
            // 
            // 
            this.lblDEMO.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDEMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDEMO.ForeColor = System.Drawing.Color.White;
            this.lblDEMO.Location = new System.Drawing.Point(1079, 0);
            this.lblDEMO.Name = "lblDEMO";
            this.lblDEMO.Size = new System.Drawing.Size(225, 19);
            this.lblDEMO.TabIndex = 14;
            this.lblDEMO.Text = "VERSIÓN PRUEBA";
            this.lblDEMO.TextAlignment = System.Drawing.StringAlignment.Center;
            this.lblDEMO.Visible = false;
            this.lblDEMO.Click += new System.EventHandler(this.lblDEMO_Click);
            // 
            // tipo_empaTableAdapter
            // 
            this.tipo_empaTableAdapter.ClearBeforeFill = true;
            // 
            // promoTableAdapter
            // 
            this.promoTableAdapter.ClearBeforeFill = true;
            // 
            // itemContainer6
            // 
            // 
            // 
            // 
            this.itemContainer6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer6.FixedSize = new System.Drawing.Size(300, 30);
            this.itemContainer6.Name = "itemContainer6";
            this.itemContainer6.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem3});
            // 
            // 
            // 
            this.itemContainer6.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer6.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // labelItem3
            // 
            this.labelItem3.Name = "labelItem3";
            this.labelItem3.Text = "Abreviatura:";
            this.labelItem3.Width = 100;
            // 
            // labelItem12
            // 
            this.labelItem12.Name = "labelItem12";
            this.labelItem12.Text = "Descripción:";
            this.labelItem12.Width = 100;
            // 
            // textBoxItem3
            // 
            this.textBoxItem3.FocusHighlightEnabled = true;
            this.textBoxItem3.MaxLength = 10;
            this.textBoxItem3.Name = "textBoxItem3";
            this.textBoxItem3.TextBoxWidth = 40;
            this.textBoxItem3.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // labelItem13
            // 
            this.labelItem13.Name = "labelItem13";
            this.labelItem13.Text = "Abreviatura:";
            this.labelItem13.Width = 100;
            // 
            // textBoxItem4
            // 
            this.textBoxItem4.FocusHighlightEnabled = true;
            this.textBoxItem4.MaxLength = 4;
            this.textBoxItem4.Name = "textBoxItem4";
            this.textBoxItem4.TextBoxWidth = 40;
            this.textBoxItem4.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // labelItem14
            // 
            this.labelItem14.Name = "labelItem14";
            this.labelItem14.Visible = false;
            this.labelItem14.Width = 100;
            // 
            // buttonItem2
            // 
            this.buttonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem2.EnableImageAnimation = true;
            this.buttonItem2.ForeColor = System.Drawing.Color.Red;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.ShowSubItems = false;
            this.buttonItem2.Stretch = true;
            this.buttonItem2.Symbol = "";
            this.buttonItem2.Text = "Guardar";
            // 
            // dpto_cajasTableAdapter1
            // 
            this.dpto_cajasTableAdapter1.ClearBeforeFill = true;
            // 
            // panAumentoRebaja
            // 
            this.panAumentoRebaja.BackColor = System.Drawing.Color.DarkMagenta;
            this.panAumentoRebaja.Controls.Add(this.panelEx4);
            this.panAumentoRebaja.Controls.Add(this.buttonX2);
            this.panAumentoRebaja.Controls.Add(this.labelX1);
            this.panAumentoRebaja.Location = new System.Drawing.Point(25, 161);
            this.panAumentoRebaja.Name = "panAumentoRebaja";
            this.panAumentoRebaja.Padding = new System.Windows.Forms.Padding(7);
            this.panAumentoRebaja.Size = new System.Drawing.Size(484, 238);
            this.panAumentoRebaja.TabIndex = 15;
            this.panAumentoRebaja.Visible = false;
            this.panAumentoRebaja.VisibleChanged += new System.EventHandler(this.panAumentoRebaja_VisibleChanged);
            // 
            // panelEx4
            // 
            this.panelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx4.Controls.Add(this.gAplicarA);
            this.panelEx4.Controls.Add(this.gTipoAumento);
            this.panelEx4.Controls.Add(this.gTipo);
            this.panelEx4.Controls.Add(this.labelX27);
            this.panelEx4.Controls.Add(this.txtAumValor);
            this.panelEx4.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx4.Location = new System.Drawing.Point(7, 33);
            this.panelEx4.Name = "panelEx4";
            this.panelEx4.Size = new System.Drawing.Size(470, 160);
            this.panelEx4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx4.Style.BackColor1.Color = System.Drawing.Color.WhiteSmoke;
            this.panelEx4.Style.BackColor2.Color = System.Drawing.Color.WhiteSmoke;
            this.panelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx4.Style.GradientAngle = 90;
            this.panelEx4.TabIndex = 22;
            // 
            // gAplicarA
            // 
            this.gAplicarA.CanvasColor = System.Drawing.SystemColors.Control;
            this.gAplicarA.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.gAplicarA.Controls.Add(this.rAplicaPrecio);
            this.gAplicarA.Controls.Add(this.rAplicaDivisa);
            this.gAplicarA.Controls.Add(this.rAplicaCosto);
            this.gAplicarA.DisabledBackColor = System.Drawing.Color.Empty;
            this.gAplicarA.Location = new System.Drawing.Point(7, 82);
            this.gAplicarA.Name = "gAplicarA";
            this.gAplicarA.Size = new System.Drawing.Size(226, 67);
            // 
            // 
            // 
            this.gAplicarA.Style.BackColor = System.Drawing.Color.White;
            this.gAplicarA.Style.BackColor2 = System.Drawing.Color.White;
            this.gAplicarA.Style.BackColorGradientAngle = 90;
            this.gAplicarA.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gAplicarA.Style.BorderBottomWidth = 1;
            this.gAplicarA.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gAplicarA.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gAplicarA.Style.BorderLeftWidth = 1;
            this.gAplicarA.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gAplicarA.Style.BorderRightWidth = 1;
            this.gAplicarA.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gAplicarA.Style.BorderTopWidth = 1;
            this.gAplicarA.Style.CornerDiameter = 4;
            this.gAplicarA.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gAplicarA.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gAplicarA.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gAplicarA.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gAplicarA.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gAplicarA.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gAplicarA.TabIndex = 31;
            this.gAplicarA.Text = "Aplicar A";
            // 
            // rAplicaPrecio
            // 
            this.rAplicaPrecio.AutoSize = true;
            this.rAplicaPrecio.ForeColor = System.Drawing.Color.DarkBlue;
            this.rAplicaPrecio.Location = new System.Drawing.Point(144, 18);
            this.rAplicaPrecio.Name = "rAplicaPrecio";
            this.rAplicaPrecio.Size = new System.Drawing.Size(73, 17);
            this.rAplicaPrecio.TabIndex = 0;
            this.rAplicaPrecio.Text = "Precio Bs.";
            this.rAplicaPrecio.UseVisualStyleBackColor = true;
            // 
            // rAplicaDivisa
            // 
            this.rAplicaDivisa.AutoSize = true;
            this.rAplicaDivisa.ForeColor = System.Drawing.Color.DarkBlue;
            this.rAplicaDivisa.Location = new System.Drawing.Point(71, 18);
            this.rAplicaDivisa.Name = "rAplicaDivisa";
            this.rAplicaDivisa.Size = new System.Drawing.Size(67, 17);
            this.rAplicaDivisa.TabIndex = 0;
            this.rAplicaDivisa.Text = "P. Divisa";
            this.rAplicaDivisa.UseVisualStyleBackColor = true;
            // 
            // rAplicaCosto
            // 
            this.rAplicaCosto.AutoSize = true;
            this.rAplicaCosto.Checked = true;
            this.rAplicaCosto.ForeColor = System.Drawing.Color.DarkBlue;
            this.rAplicaCosto.Location = new System.Drawing.Point(13, 18);
            this.rAplicaCosto.Name = "rAplicaCosto";
            this.rAplicaCosto.Size = new System.Drawing.Size(52, 17);
            this.rAplicaCosto.TabIndex = 0;
            this.rAplicaCosto.TabStop = true;
            this.rAplicaCosto.Text = "Costo";
            this.rAplicaCosto.UseVisualStyleBackColor = true;
            // 
            // gTipoAumento
            // 
            this.gTipoAumento.CanvasColor = System.Drawing.SystemColors.Control;
            this.gTipoAumento.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.gTipoAumento.Controls.Add(this.cmbAumMoneda);
            this.gTipoAumento.Controls.Add(this.rMonto);
            this.gTipoAumento.Controls.Add(this.rPorcentaje);
            this.gTipoAumento.DisabledBackColor = System.Drawing.Color.Empty;
            this.gTipoAumento.Location = new System.Drawing.Point(236, 9);
            this.gTipoAumento.Name = "gTipoAumento";
            this.gTipoAumento.Size = new System.Drawing.Size(226, 67);
            // 
            // 
            // 
            this.gTipoAumento.Style.BackColor = System.Drawing.Color.White;
            this.gTipoAumento.Style.BackColor2 = System.Drawing.Color.White;
            this.gTipoAumento.Style.BackColorGradientAngle = 90;
            this.gTipoAumento.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gTipoAumento.Style.BorderBottomWidth = 1;
            this.gTipoAumento.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gTipoAumento.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gTipoAumento.Style.BorderLeftWidth = 1;
            this.gTipoAumento.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gTipoAumento.Style.BorderRightWidth = 1;
            this.gTipoAumento.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gTipoAumento.Style.BorderTopWidth = 1;
            this.gTipoAumento.Style.CornerDiameter = 4;
            this.gTipoAumento.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gTipoAumento.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gTipoAumento.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gTipoAumento.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gTipoAumento.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gTipoAumento.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gTipoAumento.TabIndex = 31;
            this.gTipoAumento.Text = "Tipo {0}";
            // 
            // cmbAumMoneda
            // 
            this.cmbAumMoneda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAumMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAumMoneda.DropDownWidth = 200;
            this.cmbAumMoneda.Enabled = false;
            this.cmbAumMoneda.FocusHighlightEnabled = true;
            this.cmbAumMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAumMoneda.ForeColor = System.Drawing.Color.DarkBlue;
            this.cmbAumMoneda.FormattingEnabled = true;
            this.cmbAumMoneda.ItemHeight = 22;
            this.cmbAumMoneda.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.cmbAumMoneda.Location = new System.Drawing.Point(148, 12);
            this.cmbAumMoneda.Name = "cmbAumMoneda";
            this.cmbAumMoneda.Size = new System.Drawing.Size(71, 28);
            this.cmbAumMoneda.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbAumMoneda.TabIndex = 11;
            this.cmbAumMoneda.Tag = "";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Divisa";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Bs.";
            // 
            // rMonto
            // 
            this.rMonto.AutoSize = true;
            this.rMonto.ForeColor = System.Drawing.Color.DarkBlue;
            this.rMonto.Location = new System.Drawing.Point(88, 18);
            this.rMonto.Name = "rMonto";
            this.rMonto.Size = new System.Drawing.Size(55, 17);
            this.rMonto.TabIndex = 0;
            this.rMonto.Text = "Monto";
            this.rMonto.UseVisualStyleBackColor = true;
            // 
            // rPorcentaje
            // 
            this.rPorcentaje.AutoSize = true;
            this.rPorcentaje.Checked = true;
            this.rPorcentaje.ForeColor = System.Drawing.Color.DarkBlue;
            this.rPorcentaje.Location = new System.Drawing.Point(7, 18);
            this.rPorcentaje.Name = "rPorcentaje";
            this.rPorcentaje.Size = new System.Drawing.Size(76, 17);
            this.rPorcentaje.TabIndex = 0;
            this.rPorcentaje.TabStop = true;
            this.rPorcentaje.Text = "Porcentaje";
            this.rPorcentaje.UseVisualStyleBackColor = true;
            this.rPorcentaje.CheckedChanged += new System.EventHandler(this.rPorcentaje_CheckedChanged);
            // 
            // gTipo
            // 
            this.gTipo.CanvasColor = System.Drawing.SystemColors.Control;
            this.gTipo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.gTipo.Controls.Add(this.rRebaja);
            this.gTipo.Controls.Add(this.rAumento);
            this.gTipo.DisabledBackColor = System.Drawing.Color.Empty;
            this.gTipo.Location = new System.Drawing.Point(7, 9);
            this.gTipo.Name = "gTipo";
            this.gTipo.Size = new System.Drawing.Size(226, 67);
            // 
            // 
            // 
            this.gTipo.Style.BackColor = System.Drawing.Color.White;
            this.gTipo.Style.BackColor2 = System.Drawing.Color.White;
            this.gTipo.Style.BackColorGradientAngle = 90;
            this.gTipo.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gTipo.Style.BorderBottomWidth = 1;
            this.gTipo.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gTipo.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gTipo.Style.BorderLeftWidth = 1;
            this.gTipo.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gTipo.Style.BorderRightWidth = 1;
            this.gTipo.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gTipo.Style.BorderTopWidth = 1;
            this.gTipo.Style.CornerDiameter = 4;
            this.gTipo.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gTipo.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gTipo.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gTipo.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gTipo.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gTipo.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gTipo.TabIndex = 31;
            this.gTipo.Text = "Tipo";
            this.gTipo.TitleImagePosition = DevComponents.DotNetBar.eTitleImagePosition.Right;
            // 
            // rRebaja
            // 
            this.rRebaja.AutoSize = true;
            this.rRebaja.ForeColor = System.Drawing.Color.DarkBlue;
            this.rRebaja.Location = new System.Drawing.Point(100, 16);
            this.rRebaja.Name = "rRebaja";
            this.rRebaja.Size = new System.Drawing.Size(59, 17);
            this.rRebaja.TabIndex = 0;
            this.rRebaja.Text = "Rebaja";
            this.rRebaja.UseVisualStyleBackColor = true;
            // 
            // rAumento
            // 
            this.rAumento.AutoSize = true;
            this.rAumento.Checked = true;
            this.rAumento.ForeColor = System.Drawing.Color.DarkBlue;
            this.rAumento.Location = new System.Drawing.Point(9, 16);
            this.rAumento.Name = "rAumento";
            this.rAumento.Size = new System.Drawing.Size(67, 17);
            this.rAumento.TabIndex = 0;
            this.rAumento.TabStop = true;
            this.rAumento.Text = "Aumento";
            this.rAumento.UseVisualStyleBackColor = true;
            this.rAumento.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // labelX27
            // 
            this.labelX27.BackColor = System.Drawing.Color.LightSteelBlue;
            // 
            // 
            // 
            this.labelX27.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX27.ForeColor = System.Drawing.Color.Black;
            this.labelX27.Location = new System.Drawing.Point(236, 90);
            this.labelX27.Name = "labelX27";
            this.labelX27.Size = new System.Drawing.Size(226, 21);
            this.labelX27.TabIndex = 28;
            this.labelX27.Text = "Valor";
            // 
            // txtAumValor
            // 
            this.txtAumValor.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtAumValor.Border.Class = "TextBoxBorder";
            this.txtAumValor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAumValor.DisabledBackColor = System.Drawing.Color.White;
            this.txtAumValor.FocusHighlightEnabled = true;
            this.txtAumValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAumValor.ForeColor = System.Drawing.Color.Black;
            this.txtAumValor.Location = new System.Drawing.Point(236, 112);
            this.txtAumValor.Name = "txtAumValor";
            this.txtAumValor.PreventEnterBeep = true;
            this.txtAumValor.Size = new System.Drawing.Size(226, 35);
            this.txtAumValor.TabIndex = 27;
            this.txtAumValor.Tag = "0";
            this.txtAumValor.Text = "0";
            this.txtAumValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAumValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSrchPrecio_KeyPress);
            this.txtAumValor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSrchPrecio_KeyUp);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.buttonX2.Location = new System.Drawing.Point(397, 198);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(78, 32);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 10;
            this.buttonX2.Tag = "1";
            this.buttonX2.Text = "Aplicar";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click_1);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.LightSteelBlue;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelX1.Location = new System.Drawing.Point(7, 7);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(470, 26);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Seleccionar Aumento Rebaja";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.ForeColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(1070, 0);
            this.panel3.MaximumSize = new System.Drawing.Size(230, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 24);
            this.panel3.TabIndex = 16;
            // 
            // linkLabel1
            // 
            this.linkLabel1.BackColor = System.Drawing.Color.Black;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Gold;
            this.linkLabel1.Location = new System.Drawing.Point(67, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(164, 24);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.dpana.com.ve";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Gold;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Visitanos en:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1300, 725);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panAumentoRebaja);
            this.Controls.Add(this.lblDEMO);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelFiltro);
            this.Controls.Add(this.panelProgressBar);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RetailTRUMP 2020";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelEx3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPpal)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invenUsaBindingSource)).EndInit();
            this.panelProgressBar.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelProductoDescr.ResumeLayout(false);
            this.panelProductoDescr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmpaque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUnidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceDptos_Caja)).EndInit();
            this.panelProductoPrecios.ResumeLayout(false);
            this.panelProductoPrecios.PerformLayout();
            this.panelMoveSearch.ResumeLayout(false);
            this.panelMoveSearch.PerformLayout();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePromocion)).EndInit();
            this.panelFiltro.ResumeLayout(false);
            this.panelFiltro.PerformLayout();
            this.panAumentoRebaja.ResumeLayout(false);
            this.panelEx4.ResumeLayout(false);
            this.gAplicarA.ResumeLayout(false);
            this.gAplicarA.PerformLayout();
            this.gTipoAumento.ResumeLayout(false);
            this.gTipoAumento.PerformLayout();
            this.gTipo.ResumeLayout(false);
            this.gTipo.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX btnProbar;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDirDatos;
        private DevComponents.DotNetBar.ButtonX btnSalir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevComponents.DotNetBar.ButtonX btnSimular;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevComponents.DotNetBar.ButtonX btnActualizar;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl gridFinal;
        private dsPpal dsPpal;
        private System.Windows.Forms.BindingSource invenBindingSource;
        private dsPpalTableAdapters.invenTableAdapter invenTableAdapter;
        private dsPpalTableAdapters.TableAdapterManager tableAdapterManager;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl gridOriginal;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gcDescr;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gcPrecio;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gcDivisa;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn16;
        private dsPpalTableAdapters.inven_usaTableAdapter inven_usaTableAdapter;
        private System.Windows.Forms.BindingSource invenUsaBindingSource;
        private dsPpalTableAdapters.taxTableAdapter taxTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gcCosto;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn18;
        private System.Windows.Forms.Panel panelProgressBar;
        private DevComponents.DotNetBar.LabelX lblbarAccion;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX1;
        private DevComponents.DotNetBar.LabelX lblbarStatusAccion;
        private DevComponents.DotNetBar.ButtonX btnPrecioManual;
        private System.Windows.Forms.Panel panelSearch;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.SymbolBox btnSrch;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.ButtonX btnSrchClose;
        private System.Windows.Forms.Panel panelMoveSearch;
        private DevComponents.DotNetBar.LabelX lblSrchEncontrados;
        private DevComponents.DotNetBar.Controls.SymbolBox btnSrchPrev;
        private DevComponents.DotNetBar.Controls.SymbolBox btnSrchNext;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSrchDivisa;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSrchPrecio;
        private DevComponents.DotNetBar.ButtonX btnSrchAct;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX btnFiltrar;
        private System.Windows.Forms.Panel panelFiltro;
        private System.Windows.Forms.FlowLayoutPanel flowGrupoItems;
        private DevComponents.DotNetBar.ButtonX btnFiltrarTodos;
        private DevComponents.DotNetBar.ButtonX btnOKFiltrar;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSrchMargen;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSrchCosto;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX4;
        private dsPpalTableAdapters.monedasTableAdapter monedasTableAdapter1;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSrchOldDivisa;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSrchOldMargen;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSrchOldCosto;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSrchOldPrecio;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.ButtonX btnsrchCancelCambio;
        private DevComponents.DotNetBar.LabelX lblSrchFactorDivisa;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsrchOldDivisaFactor;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX lblAvisoPerdida;
        private System.Windows.Forms.Timer timer1;
        private PanelEx  panelProductoPrecios;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.LabelX lblProductoNoExiste;
        private DevComponents.DotNetBar.ButtonX btnsrchTransmitirDatosEstaciones;
        private dsPpalTableAdapters.estacionesTableAdapter estacionesTableAdapter1;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gcGrupo;
        private System.Windows.Forms.BindingSource bindingSourceGrupos;
        private dsPpalTableAdapters.gruinvTableAdapter gruinvTableAdapter;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbSrchGrupo;
        private DevComponents.DotNetBar.ButtonX btnTransmitir;
        private System.Windows.Forms.Timer timTransmitir;
        private DevComponents.DotNetBar.ButtonX btnMinimize;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDivisa;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFilterGridOriginal;
        private DevComponents.DotNetBar.LabelX labelX16;
        private ItemContainer itemContainer1;
        private ButtonItem btniTransmitir;
        private ButtonItem btniLimpiar;
        private ButtonItem btniVerTransmitir;
        private ButtonItem btniLimpiarGrid;
        private LabelX lblDEMO;
        private System.Windows.Forms.CheckBox chkRedondeo;
        private System.Windows.Forms.CheckBox chkPrecioFijo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTasaDivisaProveedor;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDescripcionSearch;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbTipoIVA;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCodigoBarras;
        private LabelX lblTipoRedondeo;
        private System.Windows.Forms.CheckBox chkPideObservacion;
        private System.Windows.Forms.CheckBox chkPideCantidad;
        private System.Windows.Forms.CheckBox chkLeeBalanza;
        private System.Windows.Forms.CheckBox chkPidePrecio;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbTipoEmpaque;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUndEmpaque;
        private LabelX labelX18;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbTipoUnidad;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUndVenta;
        private LabelX labelX20;
        private LabelX labelX19;
        private LabelX labelX21;
        private System.Windows.Forms.Panel panelProductoDescr;
        private LabelX labelX22;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCodigoInterno;
        private LabelX lblDpto;
        private LabelX labelX24;
        private ButtonX btnsrchProductoNuevo;
        private System.Windows.Forms.BindingSource bindingSourceTax;
        private System.Windows.Forms.BindingSource bindingSourceEmpaque;
        private System.Windows.Forms.BindingSource bindingSourceUnidades;
        private dsPpalTableAdapters.tipo_empaTableAdapter tipo_empaTableAdapter;
        private LabelX lblUltimaActu;
        private System.Windows.Forms.BindingSource bindingSourcePromocion;
        private dsPpalTableAdapters.promoTableAdapter promoTableAdapter;
        private ButtonX btnEliminar;
        private dsPpalSqlServer dsPpalSQLServer;
        private System.Windows.Forms.CheckBox chkTroquelado;
        private System.Windows.Forms.CheckBox chkRegulado;
        private ButtonX btnAddUnidades;
        private ItemContainer itemContainer11;
        private ItemContainer itemContainer12;
        private LabelItem labelItem6;
        private TextBoxItem txtIDescrUnidades;
        private ItemContainer itemContainer13;
        private LabelItem labelItem7;
        private TextBoxItem txtIAbreviaturaUnidades;
        private ItemContainer itemContainer14;
        private ButtonItem btnSaveUnidad;
        private ButtonX btnAddGrupos;
        private ItemContainer itemContainer7;
        private ItemContainer itemContainer16;
        private LabelItem labelItem9;
        private TextBoxItem txtICodigoGrupo;
        private ItemContainer itemContainer8;
        private LabelItem labelItem4;
        private TextBoxItem txtIDescrGrupo;
        private ItemContainer itemContainer9;
        private LabelItem labelItem5;
        private TextBoxItem txtIGastoGrupo;
        private ItemContainer itemContainer10;
        private ButtonItem btnSaveGrupo;
        private ButtonX btnAddEmpaques;
        private ItemContainer itemContainer2;
        private ItemContainer itemContainer3;
        private LabelItem labelItem1;
        private TextBoxItem txtIDescrEmpaque;
        private ItemContainer itemContainer4;
        private LabelItem labelItem2;
        private TextBoxItem txtIAbreviaturaEmpaque;
        private ItemContainer itemContainer5;
        private ButtonItem btnSaveEmpaque;
        private ItemContainer itemContainer6;
        private LabelItem labelItem3;
        private LabelItem lbliCodigoUnidad;
        private LabelItem lblICodigoEmpaque;
        private System.Windows.Forms.CheckBox chkFilSoloTroquelados;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDivisaMargenM;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDivisaM;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDivisaCostoM;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPrecioM;
        private LabelX labelX17;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCodEmpaque;
        private LabelX labelX25;
        private LabelX labelX26;
        private ButtonX buttonX6;
        private ItemContainer itemContainer15;
        private ItemContainer itemContainer18;
        private LabelItem labelItem10;
        private ItemContainer itemContainer19;
        private ItemContainer itemContainer17;
        private LabelItem labelItem8;
        private TextBoxItem txtICalcCantidad;
        private ItemContainer itemContainer20;
        private LabelItem labelItem15;
        private TextBoxItem txtICalcMontoTotal;
        private LabelItem lbl1;
        private ItemContainer itemContainer21;
        private LabelItem labelItem17;
        private TextBoxItem txtICalcMontoUnidadDivisa;
        private LabelItem labelItem18;
        private LabelItem labelItem12;
        private TextBoxItem textBoxItem3;
        private LabelItem labelItem13;
        private TextBoxItem textBoxItem4;
        private LabelItem labelItem14;
        private ButtonItem buttonItem2;
        private ComboBoxItem cmbICalcTasa;
        private ItemContainer itemContainer22;
        private LabelItem labelItem11;
        private TextBoxItem txtICalcTasaDivisaProveedor;
        private LabelItem labelItem16;
        private ButtonItem btnICalcOK;
        private LabelItem lblICalcCostoUndBs;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbDptoCajas;
        private ButtonX btnAddDptosCaja;
        private ItemContainer itemContainer23;
        private ItemContainer itemContainer24;
        private LabelItem labelItem19;
        private ItemContainer itemContainer25;
        private LabelItem labelItem20;
        private ItemContainer itemContainer26;
        private ButtonItem btnISaveDptos_Caja;
        private ComboBoxItem cmbIImpuestosDptosCaja;
        private dsPpalTableAdapters.dpto_cajasTableAdapter dpto_cajasTableAdapter1;
        private System.Windows.Forms.BindingSource BindingSourceDptos_Caja;
        private TextBoxItem txtIDptosCaja;
        private LabelX lblNumRegistros;
        private PanelEx panelEx2;
        DevComponents.DotNetBar.Controls.TextBoxX txtDivisaCajas;
        private PanelEx panelEx3;
        private ButtonItem btniTransmitirTodo;
        private LabelX lblUltimoCosto;
        private System.Windows.Forms.Panel panAumentoRebaja;
        private PanelEx panelEx4;
        private DevComponents.DotNetBar.Controls.GroupPanel gAplicarA;
        private System.Windows.Forms.RadioButton rAplicaPrecio;
        private System.Windows.Forms.RadioButton rAplicaDivisa;
        private System.Windows.Forms.RadioButton rAplicaCosto;
        private DevComponents.DotNetBar.Controls.GroupPanel gTipoAumento;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbAumMoneda;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private System.Windows.Forms.RadioButton rMonto;
        private System.Windows.Forms.RadioButton rPorcentaje;
        private DevComponents.DotNetBar.Controls.GroupPanel gTipo;
        private System.Windows.Forms.RadioButton rRebaja;
        private System.Windows.Forms.RadioButton rAumento;
        private LabelX labelX27;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAumValor;
        private ButtonX buttonX2;
        private LabelX labelX1;
        private ButtonX buttonX1;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}

