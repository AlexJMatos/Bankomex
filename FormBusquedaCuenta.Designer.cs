
namespace ProyectoFinal_Bankomex
{
    partial class FormBusquedaCuenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchAccount = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiobtnName = new System.Windows.Forms.RadioButton();
            this.radiobtnIdAccount = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datagridAccounts = new System.Windows.Forms.DataGridView();
            this.radiobtnIdClient = new System.Windows.Forms.RadioButton();
            this.IDClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busqueda de cuenta";
            // 
            // btnSearchAccount
            // 
            this.btnSearchAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAccount.Location = new System.Drawing.Point(133, 118);
            this.btnSearchAccount.Name = "btnSearchAccount";
            this.btnSearchAccount.Size = new System.Drawing.Size(102, 34);
            this.btnSearchAccount.TabIndex = 8;
            this.btnSearchAccount.Text = "Buscar";
            this.btnSearchAccount.UseVisualStyleBackColor = true;
            this.btnSearchAccount.Click += new System.EventHandler(this.btnSearchAccount_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobtnIdClient);
            this.groupBox1.Controls.Add(this.radiobtnName);
            this.groupBox1.Controls.Add(this.radiobtnIdAccount);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(327, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 113);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterio";
            // 
            // radiobtnName
            // 
            this.radiobtnName.AutoSize = true;
            this.radiobtnName.Location = new System.Drawing.Point(6, 83);
            this.radiobtnName.Name = "radiobtnName";
            this.radiobtnName.Size = new System.Drawing.Size(165, 24);
            this.radiobtnName.TabIndex = 1;
            this.radiobtnName.TabStop = true;
            this.radiobtnName.Text = "Nombre o apellido";
            this.radiobtnName.UseVisualStyleBackColor = true;
            // 
            // radiobtnIdAccount
            // 
            this.radiobtnIdAccount.AutoSize = true;
            this.radiobtnIdAccount.Location = new System.Drawing.Point(6, 25);
            this.radiobtnIdAccount.Name = "radiobtnIdAccount";
            this.radiobtnIdAccount.Size = new System.Drawing.Size(143, 24);
            this.radiobtnIdAccount.TabIndex = 0;
            this.radiobtnIdAccount.TabStop = true;
            this.radiobtnIdAccount.Text = "ID de la cuenta";
            this.radiobtnIdAccount.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(133, 73);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(175, 30);
            this.txtSearch.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Busqueda: ";
            // 
            // datagridAccounts
            // 
            this.datagridAccounts.AllowUserToAddRows = false;
            this.datagridAccounts.AllowUserToDeleteRows = false;
            this.datagridAccounts.AllowUserToResizeColumns = false;
            this.datagridAccounts.AllowUserToResizeRows = false;
            this.datagridAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDClient,
            this.FirstName,
            this.LastName,
            this.AccountID,
            this.AccountType,
            this.Balance});
            this.datagridAccounts.Location = new System.Drawing.Point(20, 199);
            this.datagridAccounts.Name = "datagridAccounts";
            this.datagridAccounts.RowHeadersWidth = 51;
            this.datagridAccounts.RowTemplate.Height = 24;
            this.datagridAccounts.Size = new System.Drawing.Size(518, 317);
            this.datagridAccounts.TabIndex = 9;
            // 
            // radiobtnIdClient
            // 
            this.radiobtnIdClient.AutoSize = true;
            this.radiobtnIdClient.Location = new System.Drawing.Point(6, 53);
            this.radiobtnIdClient.Name = "radiobtnIdClient";
            this.radiobtnIdClient.Size = new System.Drawing.Size(128, 24);
            this.radiobtnIdClient.TabIndex = 2;
            this.radiobtnIdClient.TabStop = true;
            this.radiobtnIdClient.Text = "ID del cliente";
            this.radiobtnIdClient.UseVisualStyleBackColor = true;
            // 
            // IDClient
            // 
            this.IDClient.HeaderText = "ID del cliente";
            this.IDClient.MinimumWidth = 6;
            this.IDClient.Name = "IDClient";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Nombre";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Apellido";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // AccountID
            // 
            this.AccountID.HeaderText = "ID de la cuenta";
            this.AccountID.MinimumWidth = 6;
            this.AccountID.Name = "AccountID";
            this.AccountID.ReadOnly = true;
            // 
            // AccountType
            // 
            this.AccountType.HeaderText = "Tipo de cuenta";
            this.AccountType.MinimumWidth = 6;
            this.AccountType.Name = "AccountType";
            this.AccountType.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Balance";
            this.Balance.MinimumWidth = 6;
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // FormBusquedaCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 550);
            this.Controls.Add(this.datagridAccounts);
            this.Controls.Add(this.btnSearchAccount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBusquedaCuenta";
            this.Text = "FormBusquedaCuenta";
            this.Load += new System.EventHandler(this.FormBusquedaCuenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchAccount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiobtnName;
        private System.Windows.Forms.RadioButton radiobtnIdAccount;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView datagridAccounts;
        private System.Windows.Forms.RadioButton radiobtnIdClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
    }
}