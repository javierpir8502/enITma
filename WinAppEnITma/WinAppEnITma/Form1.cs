using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppEnITma.DTOs;

namespace WinAppEnITma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            actualizarGrid();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            creacionForm frm = new creacionForm();
            frm.ShowDialog();
        }

        public void actualizarGrid()
        {
            CatalogoProductosService.CatalogoProductoServiceClient client = new CatalogoProductosService.CatalogoProductoServiceClient();
            var catalogoProductos = client.ObtenerCatalogoProductos();

            dgv_catalogo.DataSource = catalogoProductos;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            actualizarGrid();
        }
    }
}
