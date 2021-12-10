using SQLiteDb;
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
    public partial class FormAltaCuenta : Form
    {
        // Establecemos la conexion a la base de datos 
        private SQLiteConn conn = new SQLiteConn("bankomex.db", true);

        public FormAltaCuenta()
        {
            InitializeComponent();
        }

        private void FormAltaCuenta_Load(object sender, EventArgs e)
        {
            lblInfoMessage.Text = "";
            lblInfoMessage.ForeColor = Color.Red;

            // Cargamos los datos de id de clientes
            List<int> clientsIds = conn.getClientsIds();
            foreach(int id in clientsIds)
            {
                cmbClientID.Items.Add(id);
            }
            cmbClientID.SelectedIndex = 0;

            // Cargamos los datos de tipos de cuentas 
            List<string> accountTypes = conn.getAccountTypes();
            foreach(string accountName in accountTypes)
            {
                cmbAccountType.Items.Add(accountName);
            }
            cmbAccountType.SelectedIndex = 0;
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            lblInfoMessage.ForeColor = Color.Red;

            // Verificamos que el cliente no tiene una cuenta de ese tipo asignada
            int clientId = int.Parse(cmbClientID.SelectedItem.ToString());
            string accountType = cmbAccountType.SelectedItem.ToString();
            int accountTypeId = conn.getAccountTypeIdByName(accountType);

            // Si el cliente ya tiene el tipo de cuenta designada
            if (conn.accountTypeAssigned(clientId, accountTypeId))
            {
                lblInfoMessage.Text = $"El cliente seleccionado con ID: {clientId} ya tiene una cuenta {accountType}";
            } else
            {
                // Agregamos la cuenta
                Account newAccount = new Account(clientId, accountTypeId, 0);
                conn.addAccount(newAccount);
                lblInfoMessage.Text = $"La cuenta {accountType} fue asignada con éxito al cliente con ID: {clientId}";
                lblInfoMessage.ForeColor = Color.Green;
            }
        }
    }
}
