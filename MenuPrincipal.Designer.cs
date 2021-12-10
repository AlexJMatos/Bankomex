
namespace ProyectoFinal_Bankomex
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToMenuPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal_AcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.SubmenuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuCliente_Alta = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuCliente_Busqueda = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuCuentas_Alta = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuCuenta_Busqueda = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuOperaciones_Depositos = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuOperaciones_Retiro = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuOperaciones_Corte = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.SubmenuClientes,
            this.cuentasToolStripMenuItem,
            this.operacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToMenuPrincipal,
            this.menuPrincipal_AcercaDe,
            this.menuPrincipal_Salir});
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.menuPrincipalToolStripMenuItem.Text = "Menu principal";
            // 
            // goToMenuPrincipal
            // 
            this.goToMenuPrincipal.Name = "goToMenuPrincipal";
            this.goToMenuPrincipal.Size = new System.Drawing.Size(220, 26);
            this.goToMenuPrincipal.Text = "Ir al menu principal";
            this.goToMenuPrincipal.Click += new System.EventHandler(this.goToMenuPrincipal_Click);
            // 
            // menuPrincipal_AcercaDe
            // 
            this.menuPrincipal_AcercaDe.Name = "menuPrincipal_AcercaDe";
            this.menuPrincipal_AcercaDe.Size = new System.Drawing.Size(220, 26);
            this.menuPrincipal_AcercaDe.Text = "Acerca de";
            this.menuPrincipal_AcercaDe.Click += new System.EventHandler(this.menuPrincipal_AcercaDe_Click);
            // 
            // menuPrincipal_Salir
            // 
            this.menuPrincipal_Salir.Name = "menuPrincipal_Salir";
            this.menuPrincipal_Salir.Size = new System.Drawing.Size(220, 26);
            this.menuPrincipal_Salir.Text = "Salir";
            this.menuPrincipal_Salir.Click += new System.EventHandler(this.menuPrincipal_Salir_Click);
            // 
            // SubmenuClientes
            // 
            this.SubmenuClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuCliente_Alta,
            this.subMenuCliente_Busqueda});
            this.SubmenuClientes.Name = "SubmenuClientes";
            this.SubmenuClientes.Size = new System.Drawing.Size(75, 24);
            this.SubmenuClientes.Text = "Clientes";
            // 
            // subMenuCliente_Alta
            // 
            this.subMenuCliente_Alta.Name = "subMenuCliente_Alta";
            this.subMenuCliente_Alta.Size = new System.Drawing.Size(157, 26);
            this.subMenuCliente_Alta.Text = "Alta";
            this.subMenuCliente_Alta.Click += new System.EventHandler(this.subMenuCliente_Alta_Click);
            // 
            // subMenuCliente_Busqueda
            // 
            this.subMenuCliente_Busqueda.Name = "subMenuCliente_Busqueda";
            this.subMenuCliente_Busqueda.Size = new System.Drawing.Size(157, 26);
            this.subMenuCliente_Busqueda.Text = "Busqueda";
            this.subMenuCliente_Busqueda.Click += new System.EventHandler(this.subMenuCliente_Busqueda_Click);
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuCuentas_Alta,
            this.subMenuCuenta_Busqueda});
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.cuentasToolStripMenuItem.Text = "Cuentas";
            // 
            // subMenuCuentas_Alta
            // 
            this.subMenuCuentas_Alta.Name = "subMenuCuentas_Alta";
            this.subMenuCuentas_Alta.Size = new System.Drawing.Size(157, 26);
            this.subMenuCuentas_Alta.Text = "Alta";
            this.subMenuCuentas_Alta.Click += new System.EventHandler(this.subMenuCuenta_Alta_Click);
            // 
            // subMenuCuenta_Busqueda
            // 
            this.subMenuCuenta_Busqueda.Name = "subMenuCuenta_Busqueda";
            this.subMenuCuenta_Busqueda.Size = new System.Drawing.Size(157, 26);
            this.subMenuCuenta_Busqueda.Text = "Busqueda";
            this.subMenuCuenta_Busqueda.Click += new System.EventHandler(this.subMenuCuenta_Busqueda_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuOperaciones_Depositos,
            this.subMenuOperaciones_Retiro,
            this.subMenuOperaciones_Corte});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // subMenuOperaciones_Depositos
            // 
            this.subMenuOperaciones_Depositos.Name = "subMenuOperaciones_Depositos";
            this.subMenuOperaciones_Depositos.Size = new System.Drawing.Size(159, 26);
            this.subMenuOperaciones_Depositos.Text = "Depositos";
            this.subMenuOperaciones_Depositos.Click += new System.EventHandler(this.subMenuOperaciones_Depositos_Click);
            // 
            // subMenuOperaciones_Retiro
            // 
            this.subMenuOperaciones_Retiro.Name = "subMenuOperaciones_Retiro";
            this.subMenuOperaciones_Retiro.Size = new System.Drawing.Size(159, 26);
            this.subMenuOperaciones_Retiro.Text = "Retiros";
            this.subMenuOperaciones_Retiro.Click += new System.EventHandler(this.subMenuOperaciones_Retiro_Click);
            // 
            // subMenuOperaciones_Corte
            // 
            this.subMenuOperaciones_Corte.Name = "subMenuOperaciones_Corte";
            this.subMenuOperaciones_Corte.Size = new System.Drawing.Size(159, 26);
            this.subMenuOperaciones_Corte.Text = "Corte";
            this.subMenuOperaciones_Corte.Click += new System.EventHandler(this.subMenuOperaciones_Corte_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(0, 31);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(582, 521);
            this.panelContenedor.TabIndex = 1;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.Name = "MenuPrincipal";
            this.Text = "Bankomex";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipal_AcercaDe;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipal_Salir;
        private System.Windows.Forms.ToolStripMenuItem SubmenuClientes;
        private System.Windows.Forms.ToolStripMenuItem subMenuCliente_Alta;
        private System.Windows.Forms.ToolStripMenuItem subMenuCliente_Busqueda;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subMenuCuentas_Alta;
        private System.Windows.Forms.ToolStripMenuItem subMenuCuenta_Busqueda;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subMenuOperaciones_Depositos;
        private System.Windows.Forms.ToolStripMenuItem subMenuOperaciones_Retiro;
        private System.Windows.Forms.ToolStripMenuItem subMenuOperaciones_Corte;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.ToolStripMenuItem goToMenuPrincipal;
    }
}

