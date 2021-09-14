using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace U2A1IDEJAMR
{
    public partial class FrmMedicosAdmJAMR : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server = 127.0.0.1; database = DBU3JAMR; Uid = root; pwd = root;" +
          "");
        public FrmMedicosAdmJAMR()
        {
            InitializeComponent();
            poblarMedicosDgv();
   
        }

        public void limpiarForma()
        {
            txtIdMedico.Clear();
            txtNombreC.Clear();
            txtCedula.Clear();
            txtEspecialidad.Clear();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
          
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("DELETE a.* FROM TbPacientes a INNER JOIN TbPacientesMedico b ON a.IdPacientes = b.IdPacientes WHERE b.IdMedico = '" + txtIdMedico.Text + "'", conexion);
            MySqlCommand comando2 = new MySqlCommand("DELETE FROM TbMedicos WHERE IdMedico = '"+txtIdMedico.Text+ "'", conexion);
           
            MySqlCommand comando3 = new MySqlCommand("DELETE FROM TbPacientesMedico WHERE IdMedico = '" + txtIdMedico.Text + "'", conexion);
        
            comando.ExecuteNonQuery();
            
            comando2.ExecuteNonQuery();
            comando3.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("El medico ha sido eliminado");
            poblarMedicosDgv();
            limpiarForma();
        }

        public void poblarMedicosDgv()
        {
            MySqlCommand comando = new MySqlCommand("Select * from TbMedicos", conexion);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = comando;
            DataTable tabla1 = new DataTable();
            sda.Fill(tabla1);
            dgvMedicos.DataSource = tabla1;

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
         
            MySqlCommand comando = new MySqlCommand("UPDATE TbMedicos SET NombreCompleto = '"+txtNombreC.Text+"', Cedula = '"+txtCedula.Text+"', Especialidad = '"+txtEspecialidad.Text+"' WHERE IdMedico = '"+txtIdMedico.Text+ "'", conexion);
            
            comando.ExecuteNonQuery();

            conexion.Close();
            MessageBox.Show("El medico ha sido modificado ");
            poblarMedicosDgv();
            limpiarForma();
        }

        private void dgvMedicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdMedico.Text = dgvMedicos.Rows[dgvMedicos.CurrentRow.Index].Cells[0].Value.ToString();
            txtNombreC.Text = dgvMedicos.Rows[dgvMedicos.CurrentRow.Index].Cells[1].Value.ToString();
            txtCedula.Text = dgvMedicos.Rows[dgvMedicos.CurrentRow.Index].Cells[2].Value.ToString();
            txtEspecialidad.Text = dgvMedicos.Rows[dgvMedicos.CurrentRow.Index].Cells[3].Value.ToString();
          
        }

        //verifica/valida que solo se escriban numeros y lanza mensaje de error
        //en caso de escribir  letras
        private void txtIdMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permite solo introducir numeros
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            // no se permite ingresar puntos a  la edad
            else if ((e.KeyChar == '.') && (!txtIdMedico.Text.Contains(".")))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permmiten numeros, no decimales", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //si no se cumple lo anterior manda mensaje  de eerror y no pemrite escribir el dato
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //verifica/valida que solo se escriban letras y lanza mensaje de error
        //en caso de escribir  numeros u otros caracteres
        private void txtNombreC_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo admitir letras
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //para backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //para que admita tecla de espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            //si no cumple nada de lo anterior que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //verifica/valida que solo se escriban numeros y lanza mensaje de error
        //en caso de escribir  letras
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permite solo introducir numeros
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            // no se permite ingresar puntos a  la edad
            else if ((e.KeyChar == '.') && (!txtIdMedico.Text.Contains(".")))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permmiten numeros, no decimales", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //si no se cumple lo anterior manda mensaje  de eerror y no pemrite escribir el dato
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //verifica/valida que solo se escriban numeros y lanza mensaje de error
        //en caso de escribir  letras
        private void txtEspecialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permite solo introducir numeros
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            // no se permite ingresar puntos a  la edad
            else if ((e.KeyChar == '.') && (!txtIdMedico.Text.Contains(".")))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permmiten numeros, no decimales", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //si no se cumple lo anterior manda mensaje  de eerror y no pemrite escribir el dato
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

       
    }
}
