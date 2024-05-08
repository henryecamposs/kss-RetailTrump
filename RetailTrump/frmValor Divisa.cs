using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Net;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace RetailTrump
{
    public partial class frmValor_Divisa : Form
    {
        decimal DivisaBs;
        decimal DivisaCajaBs;
        private decimal codigoMoneda;
        private string descrMoneda = "";
        private bool esSQLServer;
        private frmMain ParentForm;

        public frmValor_Divisa(frmMain parent)
        {
            InitializeComponent();
            ParentForm = parent;
        }

        private void frmValor_Divisa_Load(object sender, EventArgs e)
        {
            DivisaBs = (decimal)Properties.Settings.Default.LastDivisa;
            txtDivisa.Text =  DivisaBs.ToString("N2");
            DivisaCajaBs= (decimal)Properties.Settings.Default.LastDivisaCaja;
            txtDivisaCajas.Text = DivisaCajaBs.ToString("N2");
            Text = "Indique factor cambio";
            codigoMoneda = Properties.Settings.Default.codigoMoneda;
            txtDivisa_ButtonCustom2Click(txtDivisa.ButtonCustom2, null);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Se va a actualizar el precio en divisas del producto a un valor de {txtDivisa.Text} Bs.", "Actualizando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Properties.Settings.Default.LastDivisa = Convert.ToDouble(txtDivisa.Text);
                Properties.Settings.Default.LastDivisaCaja = Convert.ToDouble(txtDivisaCajas.Text);
                DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cancelar la actualización de divisas para nuevos productos?", "Cancelando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        
        private void buttonX2_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Program.ConsultaMonitorve();

            if (Program.dolarBCV > 0)
            {
                if (MessageBox.Show("Desea Usar los datos:\n" + Program.sEstadoMoneda, "Usar Datos Recopilados", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtDivisa.Text =  Program.dolarBCV.ToString();
                    txtDivisaCajas.Text =  Program.dolarBCV.ToString();
                }
            }
            Cursor = Cursors.Default;
        }

        private void txtDivisa_ButtonCustom2Click(object sender, EventArgs e)
        {
            txtDivisaCajas.Text =  ParentForm.loadMoneda().ToString("N2");
        }

        private void txtDivisa_ButtonCustomClick(object sender, EventArgs e)
        {
            ParentForm.modificarMoneda(Convert.ToDecimal(txtDivisaCajas.Text));
        }


        private void txtDivisa_Leave(object sender, EventArgs e)
        {
            returnValues();
        }

        private void txtDivisaCajas_Leave(object sender, EventArgs e)
        {
            returnValues();
        }

        private void frmValor_Divisa_FormClosed(object sender, FormClosedEventArgs e)
        {
            returnValues();
        }
        void returnValues()
        {
            ParentForm.FactorDivisaBs = Convert.ToDecimal( txtDivisa.Text);
            ParentForm.FactorDivisaCaja = Convert.ToDecimal(txtDivisaCajas.Text);
        }
        private void txtSrchPrecio_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                dynamic txt = sender;
                if (e.KeyCode == Keys.Enter)
                {
                    
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
    }
}
