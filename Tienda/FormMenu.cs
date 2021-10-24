﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var formlogin = new FormLogin();
            formlogin.ShowDialog();
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ropaParaDamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formproductos = new FormProductos();
            formproductos.MdiParent = this;
            formproductos.Show();
        }


        private void ropaParaCaballeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formproductos_hombre = new FormProductoC();
            formproductos_hombre.MdiParent = this;
            formproductos_hombre.Show();
        }

        private void ropaParaNiñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formproductos_nino = new FormProductoN();
            formproductos_nino.MdiParent = this;
            formproductos_nino.Show();
        }

        private void reporteDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formreporinventario = new FormReportInv();
            formreporinventario.MdiParent = this;
            formreporinventario.Show();
        }

        private void reporteDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formreporcliente = new FormReportClte();
            formreporcliente.MdiParent = this;
            formreporcliente.Show();
        }

        private void reporteDeErroresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formreporterror = new FormTBLTipoProd();
            formreporterror.MdiParent = this;
            formreporterror.Show();
        }

        private void administrarBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formadmbase = new FormAdminBD();
            formadmbase.MdiParent = this;
            formadmbase.Show();

        }

        private void formmenu_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void cerrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void reporteDeErroresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formreporterror = new FormTBLTipoProd();
            formreporterror.MdiParent = this;
            formreporterror.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

