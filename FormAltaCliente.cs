using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLiteDb;
using ProyectoFinal_Bankomex;
using System.Windows.Forms;

namespace ProyectoFinal_Bankomex
{
    public partial class FormAltaCliente : Form
    {
        // Establecemos la conexion a la base de datos 
        private SQLiteConn conn = new SQLiteConn("bankomex.db", true);

        public FormAltaCliente()
        {
            InitializeComponent();
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            lblInfoMessage.ForeColor = Color.Red;

            // Verificamos que el primer nombre y apellido sean validos 
            String firstName = txtFirstName.Text.Trim();
            String lastName = txtLastName.Text.Trim();

            // Verificamos que el usuario no existe en la base de datos
            String username = txtUsername.Text.ToLower();

            // Verificamos que el nip sea un numero de 4 digitos 
            String pin = txtNip.Text;
            
            if (Validation.IsLettersOnly(firstName) && Validation.IsLettersOnly(lastName))
            {
                if(username.Length != 0)
                {
                    if (conn.ClientUsernameUnique(username))
                    {
                        if (pin.Length == 4 && Validation.IsDigitsOnly(pin))
                        {
                            // Si se cumple lo anterior, se agrega a la base de datos 
                            Client newClient = new Client(username, pin, firstName, lastName);
                            conn.AddClient(newClient);
                            lblInfoMessage.Text = "Usuario agregado correctamente!";
                            lblInfoMessage.ForeColor = Color.Green;
                            txtFirstName.Text = "";
                            txtLastName.Text = "";
                            txtUsername.Text = "";
                            txtNip.Text = "";
                        }
                        else
                        {
                            lblInfoMessage.Text = "El nip introducido no es correcto. Debe contener 4 digitos.";
                        }
                    }
                    else
                    {
                        lblInfoMessage.Text = "El usuario introducido no es unico.";
                    }
                }
                else
                {
                    lblInfoMessage.Text = "El usuario no puede estar vacio.";
                }
                
            } else
            {
                lblInfoMessage.Text = "El nombre y apellido no puede contener digitos o estar vacios";
            }
        }

        private void FormAltaCliente_Load(object sender, EventArgs e)
        {
            // Inicializamos el label de mensaje vacio
            lblInfoMessage.Text = "";
            lblInfoMessage.ForeColor = Color.Red;
        }
    }
}
