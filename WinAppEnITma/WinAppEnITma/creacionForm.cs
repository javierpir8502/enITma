using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEnITma
{
    public partial class creacionForm : Form
    {
        public creacionForm()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            CatalogoProductosService.CatalogoProductoServiceClient client = new CatalogoProductosService.CatalogoProductoServiceClient();
            client.AgregarCatalogoProducto(txt_descripcion.Text);
            this.Close();
        }
    }
}
