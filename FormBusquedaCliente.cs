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
    public partial class FormBusquedaCliente : Form
    {
        private SQLiteConn conn = new SQLiteConn("bankomex.db", true);

        public FormBusquedaCliente()
        {
            InitializeComponent();
        }

        private void FormBusquedaCliente_Load(object sender, EventArgs e)
        {
            radiobtnId.Checked = true;
        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            dataGridClients.Rows.Clear();
            List<Client> foundClients = new List<Client>();
            String search = txtSearch.Text.Trim();
            int id;

            if (search.Length == 0)
            {
                foundClients = conn.GetClients();
                foreach (Client client in foundClients)
                {
                    // Nuevo renglon 
                    int row = dataGridClients.Rows.Add();
                    // Colocamos la informacion
                    dataGridClients.Rows[row].Cells[3].Value = client.Id;
                    dataGridClients.Rows[row].Cells[2].Value = client.UserName;
                    dataGridClients.Rows[row].Cells[1].Value = client.FirstName;
                    dataGridClients.Rows[row].Cells[0].Value = client.LastName;
                }
            }
            else if (radiobtnId.Checked)
            {
                if (int.TryParse(search, out id))
                {
                    Client foundClient = conn.GetClientByID(id);
                    if (foundClient != null)
                    {
                        foundClients.Add(foundClient);
                        foreach(Client client in foundClients)
                        {
                            // Nuevo renglon 
                            int row = dataGridClients.Rows.Add();
                            // Colocamos la informacion
                            dataGridClients.Rows[row].Cells[3].Value = client.Id;
                            dataGridClients.Rows[row].Cells[2].Value = client.UserName;
                            dataGridClients.Rows[row].Cells[1].Value = client.FirstName;
                            dataGridClients.Rows[row].Cells[0].Value = client.LastName;
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID del cliente no encontrado", "Registro no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else
                {
                    MessageBox.Show("ID debe ser un numero o esta fuera de rango", "Argumento no valido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (radiobtnName.Checked)
            {
                foundClients = conn.GetClientsByFirstNameOrLastName(search);
                if (foundClients.Count != 0)
                {
                    foreach (Client client in foundClients)
                    {
                        // Nuevo renglon 
                        int row = dataGridClients.Rows.Add();
                        // Colocamos la informacion
                        dataGridClients.Rows[row].Cells[3].Value = client.Id;
                        dataGridClients.Rows[row].Cells[2].Value = client.UserName;
                        dataGridClients.Rows[row].Cells[1].Value = client.FirstName;
                        dataGridClients.Rows[row].Cells[0].Value = client.LastName;
                    }
                } else
                {
                    MessageBox.Show("No se encontro registro con el parametro de busqueda descrito", "Registro no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
