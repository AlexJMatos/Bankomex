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
    public partial class FormAcercaDe : Form
    {
        public FormAcercaDe()
        {
            InitializeComponent();
        }

        private void FormAcercaDe_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "Este programa fue realizado por alumnos del\n" +
                            "4° semestre de Ingeniería Mecatrónica.\n\n" +
                            "       \u2022 Ayuso Vera Paola\n" +
                            "       \u2022 Contreras Montañez Humberto\n" +
                            "       \u2022 Echeverría Blanco Raúl\n" +
                            "       \u2022 Gutierrez Lara Yahdiel\n\n" +
                            "Profesor: Edson Geovanny Estrada Lopez";
        }
    }
}
