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
    public partial class FormOperacionRetiro : Form
    {
        private SQLiteConn conn = new SQLiteConn("bankomex.db", true);

        public FormOperacionRetiro()
        {
            InitializeComponent();
        }

        private void FormOperacionRetiro_Load(object sender, EventArgs e)
        {
            // Cargar los numeros de cuenta al combo box
            List<int> accountsId = conn.GetAccountsIDs();
            foreach (int accountId in accountsId)
            {
                cmbAccountID.Items.Add(accountId);
            }
            cmbAccountID.SelectedIndex = 0;
        }

        private void txtWithdrawAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            string amount = txtWithdrawAmount.Text;
            int accountId = int.Parse(cmbAccountID.SelectedItem.ToString());
            double withdraw;
            if (double.TryParse(amount, out withdraw))
            {
                // Verificamos que tipo de cuenta es
                Account account = conn.GetAccountById(accountId);
                if (conn.isCredit(account.AccountType))
                {
                    // Un retiro en una cuenta de credito aumenta el saldo
                    AccountType currentAccountType = conn.GetAccountTypeById(account.AccountType);

                    // Verificamos la propiedad limited
                    if (conn.isLimited(account.AccountType))
                    {
                        // Verificamos que el retiro no sobrepase el credito maximo
                        if (account.Balance + withdraw < currentAccountType.MaxCredit)
                        {
                            // Realizamos el retiro sin problemas
                            conn.withdrawInCreditAccount(accountId, withdraw);
                            account = conn.GetAccountById(accountId);
                            // Notificamos al usuario
                            MessageBox.Show($"Retiro de ${withdraw} realizado con exito\nID de la cuenta: {accountId}\nNuevo balance de cuenta: ${account.Balance}", "Retiro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } else
                        {
                            // Se le agrega la penalizacion (retiro)
                            if (account.Balance + currentAccountType.OverDraftFee <= currentAccountType.MaxCredit)
                            {
                                conn.applyOverDraftFee(account.Id, currentAccountType.OverDraftFee);
                            }
                            account = conn.GetAccountById(accountId);
                            // Notificamos al usuario que no es posible realizar el retiro 
                            MessageBox.Show($"Retiro de ${withdraw} no efectuado\nID de la cuenta: {accountId}\nPenalizacion de : ${currentAccountType.OverDraftFee}\nNuevo balance: ${account.Balance}", "Intento de sobregiro de cuenta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (account.Balance >= currentAccountType.MaxCredit)
                            {
                                MessageBox.Show($"Penalizacion no aplicada, se ha alcanzado el crédito maximo", "Cuenta bloqueada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    } else
                    {
                        /* Realizamos el retiro */
                        conn.withdrawInCreditAccount(accountId, withdraw);
                        account = conn.GetAccountById(accountId);

                        /* Verificamos si no se ha sobregirado la cuenta */
                        if (account.Balance > currentAccountType.MaxCredit)
                        {
                            // Aplicamos la penalizacion 
                            conn.applyOverDraftFee(account.Id, currentAccountType.OverDraftFee);
                            account = conn.GetAccountById(accountId);

                            // Notificamos que se ha realizado el retiro, pero se ha penalizado
                            MessageBox.Show($"Retiro de ${withdraw} realizado con exito\nID de la cuenta: {accountId}\nPenalizacion: ${currentAccountType.OverDraftFee} \nNuevo balance de cuenta: ${account.Balance}", "Retiro exitoso con sobregiro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            // Si no ocurre sobregiro, simplemente se notifica que el retiro ha sido exitoso
                            MessageBox.Show($"Retiro de ${withdraw} realizado con exito\nID de la cuenta: {accountId}\nNuevo balance de cuenta: ${account.Balance}", "Retiro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    // Un retiro en una cuenta de ahorro disminuye el saldo
                    // Verificamos que el retiro no provoque un saldo negativo
                    if (account.Balance > withdraw)
                    {
                        conn.withdrawInDebitAccount(accountId, withdraw);
                        account = conn.GetAccountById(accountId);
                        MessageBox.Show($"Retiro de ${withdraw} realizado con exito\nID de la cuenta: {accountId}\nNuevo balance de cuenta: ${account.Balance}", "Retiro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Saldo insuficiente para el retiro de ${withdraw}", "Saldo negativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Cantidad de deposito con formato erroneo", "Formato no valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWithdrawAmount.Text = "";
            }
        }

        private void txtWithdrawAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
