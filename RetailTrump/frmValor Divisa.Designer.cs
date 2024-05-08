namespace RetailTrump
{
    partial class frmValor_Divisa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnSalir = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDivisa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.monedasTableAdapter1 = new RetailTrump.dsPpalTableAdapters.monedasTableAdapter();
            this.dsPpal = new RetailTrump.dsPpal();
            this.MONEDASTableAdapter_SQL = new RetailTrump.dsPpalSqlServerTableAdapters.MONEDASTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDivisaCajas = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.estacionesTableAdapter1 = new RetailTrump.dsPpalSqlServerTableAdapters.ESTACIONESTableAdapter();
            this.lblEstadoDivisas = new DevComponents.DotNetBar.LabelX();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPpal)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(10, 10);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(134, 50);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "Divisa <b>ADMIN:</b>";
            // 
            // btnSalir
            // 
            this.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSalir.BackColor = System.Drawing.Color.Green;
            this.btnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.Location = new System.Drawing.Point(354, 10);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 50);
            this.btnSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "APLICAR";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.buttonX1.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonX1.Location = new System.Drawing.Point(438, 10);
            this.buttonX1.Margin = new System.Windows.Forms.Padding(5);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(84, 50);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 8;
            this.buttonX1.Text = "CANCELAR";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(0, 0);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(532, 55);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "<div align=\"center\">Por favor indique el valor <b>Actual </b>de la divisa de cálc" +
    "ulo para los nuevos productos.</div>";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.txtDivisa);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Controls.Add(this.buttonX1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 143);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(532, 70);
            this.panel1.TabIndex = 10;
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
            this.txtDivisa.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtDivisa.FocusHighlightEnabled = true;
            this.txtDivisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivisa.Location = new System.Drawing.Point(144, 10);
            this.txtDivisa.MaximumSize = new System.Drawing.Size(180, 40);
            this.txtDivisa.MinimumSize = new System.Drawing.Size(0, 53);
            this.txtDivisa.Name = "txtDivisa";
            this.txtDivisa.Size = new System.Drawing.Size(159, 53);
            this.txtDivisa.TabIndex = 9;
            this.txtDivisa.ButtonCustomClick += new System.EventHandler(this.txtDivisa_ButtonCustomClick);
            this.txtDivisa.ButtonCustom2Click += new System.EventHandler(this.txtDivisa_ButtonCustom2Click);
            this.txtDivisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSrchPrecio_KeyPress);
            this.txtDivisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSrchPrecio_KeyUp);
            this.txtDivisa.Leave += new System.EventHandler(this.txtDivisa_Leave);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.BackColor = System.Drawing.Color.White;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.buttonX2.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonX2.Location = new System.Drawing.Point(438, 10);
            this.buttonX2.Margin = new System.Windows.Forms.Padding(5);
            this.buttonX2.MaximumSize = new System.Drawing.Size(91, 52);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(84, 50);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.TabIndex = 11;
            this.buttonX2.Text = "Consultar";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelX2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 55);
            this.panel2.TabIndex = 12;
            // 
            // monedasTableAdapter1
            // 
            this.monedasTableAdapter1.ClearBeforeFill = true;
            // 
            // dsPpal
            // 
            this.dsPpal.DataSetName = "dsPpal";
            this.dsPpal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MONEDASTableAdapter_SQL
            // 
            this.MONEDASTableAdapter_SQL.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Controls.Add(this.txtDivisaCajas);
            this.panel3.Controls.Add(this.buttonX2);
            this.panel3.Controls.Add(this.labelX3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 73);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(532, 70);
            this.panel3.TabIndex = 13;
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
            this.txtDivisaCajas.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtDivisaCajas.FocusHighlightEnabled = true;
            this.txtDivisaCajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivisaCajas.Location = new System.Drawing.Point(144, 10);
            this.txtDivisaCajas.MaximumSize = new System.Drawing.Size(180, 40);
            this.txtDivisaCajas.MinimumSize = new System.Drawing.Size(270, 53);
            this.txtDivisaCajas.Name = "txtDivisaCajas";
            this.txtDivisaCajas.Size = new System.Drawing.Size(270, 53);
            this.txtDivisaCajas.TabIndex = 9;
            this.txtDivisaCajas.Text = "1";
            this.txtDivisaCajas.ButtonCustomClick += new System.EventHandler(this.txtDivisa_ButtonCustomClick);
            this.txtDivisaCajas.ButtonCustom2Click += new System.EventHandler(this.txtDivisa_ButtonCustom2Click);
            this.txtDivisaCajas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSrchPrecio_KeyPress);
            this.txtDivisaCajas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSrchPrecio_KeyUp);
            this.txtDivisaCajas.Leave += new System.EventHandler(this.txtDivisaCajas_Leave);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Gold;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(10, 10);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(134, 50);
            this.labelX3.TabIndex = 7;
            this.labelX3.Text = "Divisa <b>CAJAS:</b>";
            // 
            // estacionesTableAdapter1
            // 
            this.estacionesTableAdapter1.ClearBeforeFill = true;
            // 
            // lblEstadoDivisas
            // 
            this.lblEstadoDivisas.BackColor = System.Drawing.Color.Lime;
            // 
            // 
            // 
            this.lblEstadoDivisas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEstadoDivisas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblEstadoDivisas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoDivisas.ForeColor = System.Drawing.Color.Black;
            this.lblEstadoDivisas.Location = new System.Drawing.Point(0, 48);
            this.lblEstadoDivisas.Name = "lblEstadoDivisas";
            this.lblEstadoDivisas.Size = new System.Drawing.Size(532, 25);
            this.lblEstadoDivisas.TabIndex = 14;
            this.lblEstadoDivisas.Text = "000";
            this.lblEstadoDivisas.TextAlignment = System.Drawing.StringAlignment.Center;
            this.lblEstadoDivisas.Visible = false;
            // 
            // frmValor_Divisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 213);
            this.Controls.Add(this.lblEstadoDivisas);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmValor_Divisa";
            this.Text = "Monto Inicial DIVISA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmValor_Divisa_FormClosed);
            this.Load += new System.EventHandler(this.frmValor_Divisa_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsPpal)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnSalir;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private System.Windows.Forms.Panel panel2;
        DevComponents.DotNetBar.Controls.TextBoxX txtDivisa;
        private dsPpalTableAdapters.monedasTableAdapter monedasTableAdapter1;
        private dsPpal dsPpal;
        private dsPpalSqlServerTableAdapters.MONEDASTableAdapter MONEDASTableAdapter_SQL;
        private System.Windows.Forms.Panel panel3;
        DevComponents.DotNetBar.Controls.TextBoxX txtDivisaCajas;
        private DevComponents.DotNetBar.LabelX labelX3;
        private dsPpalSqlServerTableAdapters.ESTACIONESTableAdapter estacionesTableAdapter1;
        private DevComponents.DotNetBar.LabelX lblEstadoDivisas;
    }
}