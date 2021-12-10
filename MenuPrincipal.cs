using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Bankomex
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormInPanel(Object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void subMenuCliente_Alta_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormAltaCliente());
        }

        private void subMenuCliente_Busqueda_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormBusquedaCliente());
        }

        private void subMenuCuenta_Alta_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormAltaCuenta());
        }

        private void subMenuCuenta_Busqueda_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormBusquedaCuenta());
        }

        private void subMenuOperaciones_Depositos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormOperacionDeposito());
        }

        private void subMenuOperaciones_Retiro_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormOperacionRetiro());
        }

        private void subMenuOperaciones_Corte_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormOperacionCorte());
        }

        private void menuPrincipal_AcercaDe_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormAcercaDe());
        }

        private void menuPrincipal_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void goToMenuPrincipal_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormBienvenida());
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormBienvenida());
        }
    }
}
