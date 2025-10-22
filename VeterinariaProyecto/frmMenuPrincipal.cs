using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinariaProyecto
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos frmProduct = new frmProductos();
            this.Hide();
            frmProduct.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmClientes frmcliente = new frmClientes();
            this.Hide();
            frmcliente.Show();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            frmCitas frmCitas=new frmCitas();
            this.Hide();
            frmCitas.Show();
        }
    }
}
