using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2A1IDEJAMR
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void medicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
          
        }

        


        private void btnAltaMedicos_Click(object sender, EventArgs e)
        {
            FrmMedicosJAMR forma = new FrmMedicosJAMR();
            forma.ShowDialog();

        }

        private void btnModificarEliminarMedicos_Click(object sender, EventArgs e)
        {
            FrmMedicosAdmJAMR forma = new FrmMedicosAdmJAMR();
            forma.ShowDialog();

        }

        private void btnAltaPacientes_Click(object sender, EventArgs e)
        {
            Form1 forma = new Form1();
            forma.ShowDialog();

        }

        private void btnModificarEliminarPacientes_Click(object sender, EventArgs e)
        {
            FrmPacientesJAMR forma = new FrmPacientesJAMR();
            forma.ShowDialog();
        }

        private void btnBuscarPacientes_Click(object sender, EventArgs e)
        {
            FrmBuscarJAMR forma = new FrmBuscarJAMR();
            forma.ShowDialog();

        }

     
    }
}
