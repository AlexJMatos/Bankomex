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
    public partial class FormOperacionDeposito : Form
    {
        private SQLiteConn conn = new SQLiteConn("bankomex.db", true);

        public FormOperacionDeposito()
        {
            InitializeComponent();
        }

        private void FormOperacionDeposito_Load(object sender, EventArgs e)
        {
            // Cargar los numeros de cuenta al combo box
            List<int> accountsId = conn.GetAccountsIDs();
            foreach (int accountId in accountsId)
            {
                cmbAccountID.Items.Add(accountId);
            }
            cmbAccountID.SelectedIndex = 0;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            string amount = txtDepositAmount.Text;
            int accountId = int.Parse(cmbAccountID.SelectedItem.ToString());
            double deposit;
            if (double.TryParse(amount, out deposit))
            {
                // Verificamos que tipo de cuenta es
                Account account = conn.GetAccountById(accountId);
                if (conn.isCredit(account.AccountType))
                {
                    // Un deposito en una cuenta de credito disminuye el saldo
                    // Verificamos que el deposito no provoce un saldo negativo 
                    if (account.Balance - deposit > 0)
                    {
                        conn.depositInCreditAccount(accountId, deposit);
                        account = conn.GetAccountById(accountId);
                        MessageBox.Show($"Deposito de ${deposit} realizado con exito\nID de la cuenta: {accountId}\nNuevo balance de cuenta: ${account.Balance}", "Deposito exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"No es posible depositar la cantidad de ${deposit}", "Error: saldo negativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Un deposito en una cuenta de ahorro aumenta el saldo
                    // Realizamos el deposito sin ningun tipo de restriccion
                    conn.depositInDebitAccount(accountId, deposit);
                    account = conn.GetAccountById(accountId);
                    MessageBox.Show($"Deposito de ${deposit} realizado con exito\nID de la cuenta: {accountId}\nNuevo balance de cuenta: ${account.Balance}", "Deposito exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Cantidad de deposito con formato erroneo", "Formato no valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDepositAmount.Text = "";
            }
        }

        private void txtDepositAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
