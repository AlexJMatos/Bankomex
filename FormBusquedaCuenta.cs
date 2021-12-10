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
    public partial class FormBusquedaCuenta : Form
    {
        private SQLiteConn conn = new SQLiteConn("bankomex.db", true);

        public FormBusquedaCuenta()
        {
            InitializeComponent();
        }

        private void btnSearchAccount_Click(object sender, EventArgs e)
        {
            datagridAccounts.Rows.Clear();
            String search = txtSearch.Text.Trim();
            int id;
            List<ClientAccount> accountsForClients = new List<ClientAccount>();

            // Mostramos todo si el parametro de busqueda esta vacio
            if (search.Length == 0)
            {
                accountsForClients = conn.GetClientAccounts();
                if (accountsForClients.Count != 0)
                {
                    foreach(ClientAccount clientAccount in accountsForClients)
                    {
                        // Nuevo renglon 
                        int row = datagridAccounts.Rows.Add();
                        // Colocamos la informacion
                        datagridAccounts.Rows[row].Cells[0].Value = clientAccount.ClientId;
                        datagridAccounts.Rows[row].Cells[1].Value = clientAccount.LastName;
                        datagridAccounts.Rows[row].Cells[2].Value = clientAccount.FirstName;
                        datagridAccounts.Rows[row].Cells[3].Value = clientAccount.AccountId;
                        datagridAccounts.Rows[row].Cells[4].Value = clientAccount.AccountTypeName;
                        datagridAccounts.Rows[row].Cells[5].Value = clientAccount.Balance;
                    }
                }
                else
                {
                    MessageBox.Show("Base de datos vacia", "Registro no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (radiobtnIdAccount.Checked)
            {
                // Verificamos que el parametro de busqueda sea un entero
                if (int.TryParse(search, out id))
                {
                    accountsForClients = conn.GetClientAccountsByAccountId(id);
                    if (accountsForClients.Count != 0)
                    {
                        foreach(ClientAccount clientAccount in accountsForClients)
                        {
                            // Nuevo renglon 
                            int row = datagridAccounts.Rows.Add();
                            // Colocamos la informacion
                            datagridAccounts.Rows[row].Cells[0].Value = clientAccount.ClientId;
                            datagridAccounts.Rows[row].Cells[1].Value = clientAccount.LastName;
                            datagridAccounts.Rows[row].Cells[2].Value = clientAccount.FirstName;
                            datagridAccounts.Rows[row].Cells[3].Value = clientAccount.AccountId;
                            datagridAccounts.Rows[row].Cells[4].Value = clientAccount.AccountTypeName;
                            datagridAccounts.Rows[row].Cells[5].Value = clientAccount.Balance;

                        }
                    } else
                    {
                        MessageBox.Show("No se encontro ninguna cuenta con el ID introducido", "Registro no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("ID debe ser un numero o valor fuera de rango", "Argumento no valido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (radiobtnIdClient.Checked)
            {
                // Verificamos que el parametro de busqueda sea un entero
                if (int.TryParse(search, out id))
                {
                    accountsForClients = conn.GetClientAccountsByClientId(id);
                    if (accountsForClients.Count != 0)
                    {
                        foreach (ClientAccount clientAccount in accountsForClients)
                        {
                            // Nuevo renglon 
                            int row = datagridAccounts.Rows.Add();
                            // Colocamos la informacion
                            datagridAccounts.Rows[row].Cells[0].Value = clientAccount.ClientId;
                            datagridAccounts.Rows[row].Cells[1].Value = clientAccount.LastName;
                            datagridAccounts.Rows[row].Cells[2].Value = clientAccount.FirstName;
                            datagridAccounts.Rows[row].Cells[3].Value = clientAccount.AccountId;
                            datagridAccounts.Rows[row].Cells[4].Value = clientAccount.AccountTypeName;
                            datagridAccounts.Rows[row].Cells[5].Value = clientAccount.Balance;

                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontro ningun cliente con el ID introducido", "Registro no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("ID debe ser un numero o valor fuera de rango", "Argumento no valido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (radiobtnName.Checked)
            {
                accountsForClients = conn.GetClientAccountsByClientFirstNameOrLastName(search);
                if (accountsForClients.Count != 0)
                {
                    foreach (ClientAccount clientAccount in accountsForClients)
                    {
                        // Nuevo renglon 
                        int row = datagridAccounts.Rows.Add();
                        // Colocamos la informacion
                        datagridAccounts.Rows[row].Cells[0].Value = clientAccount.ClientId;
                        datagridAccounts.Rows[row].Cells[1].Value = clientAccount.LastName;
                        datagridAccounts.Rows[row].Cells[2].Value = clientAccount.FirstName;
                        datagridAccounts.Rows[row].Cells[3].Value = clientAccount.AccountId;
                        datagridAccounts.Rows[row].Cells[4].Value = clientAccount.AccountTypeName;
                        datagridAccounts.Rows[row].Cells[5].Value = clientAccount.Balance;

                    }
                }
                else
                {
                    MessageBox.Show("No se encontro ninguna registro con el parametro de busqueda", "Registro no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void FormBusquedaCuenta_Load(object sender, EventArgs e)
        {
            radiobtnIdAccount.Checked = true;
        }
    }
}
