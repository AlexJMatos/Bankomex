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
    public partial class FormOperacionCorte : Form
    {
        private SQLiteConn conn = new SQLiteConn("bankomex.db", true);

        public FormOperacionCorte()
        {
            InitializeComponent();
        }

        private void FormOperacionCorte_Load(object sender, EventArgs e)
        {
            rdbtnMonthFee.Checked = true;
        }

        private void btnCorte_Click(object sender, EventArgs e)
        {
            if (rdbtnMonthFee.Checked)
            {
                // Aplicamos el corte mensual
                conn.applyMonthlyFee();
                conn.applyInteresPct();
                MessageBox.Show($"Comisión por fin de mes aplicada correctamente", "Fin de mes exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (rdbtnMonthAnnualFee.Checked)
            {
                // Aplicamos el corte mensual
                conn.applyMonthlyFee();
                conn.applyInteresPct();

                // Aplicamos el corte anual 
                conn.applyAnnualFee();
                
                MessageBox.Show($"Comisión por fin de año aplicada correctamente", "Fin de año exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
