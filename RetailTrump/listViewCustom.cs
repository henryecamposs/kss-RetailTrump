using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailTrump
{

    public partial class listViewCustom : UserControl
    {
        public listViewCustom(Image image, string texto)
        {
            InitializeComponent();

            pictureBox1.Image = image;
            label1.Text = texto;
        }

        private void listViewCustom_Load(object sender, EventArgs e)
        {
            
        }
    }
}
