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
using System.Text.RegularExpressions;

namespace U2A1IDEJAMR
{
    public partial class FrmPacientesJAMR : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server = 127.0.0.1; database = DBU3JAMR; Uid = root; pwd = root;" +
         "");
        public FrmPacientesJAMR()
        {
            InitializeComponent();
            poblarPacientesDgv();
         
        }
        public void limpiarForma()
        {
            txtNombreC.Clear();
            txtIdPacientes.Clear();
            txtDireccion.Clear();
            txtTelefonoF.Clear();
            txtCelular.Clear();
            txtEmail.Clear();
            txtEdad.Clear();
            txtSexo.Clear();
            txtEdoC.Clear();

        }
        public void poblarPacientesDgv()
        {
            MySqlCommand comando = new MySqlCommand("Select * from TbPacientes", conexion);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = comando;
            DataTable tabla1 = new DataTable();
            sda.Fill(tabla1);
            dgvPacientes.DataSource = tabla1;

        }
       


        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.Open();


            //MySqlCommand comando = new MySqlCommand("UPDATE TbPacientes SET NombreCompleto = '" + txtNombreC.Text + "', Direccion = '" + txtDireccion.Text + "', TelefonoFijo = '" + txtTelefonoF.Text + "', Celular = '" + txtCelular.Text + "', Edad = '" + txtEdad.Text + "', Sexo = '" + txtSexo.Text + "', Email = '" + txtEmail.Text + "', EdoCivil = '" + txtEdoC.Text + "', IdEdoCivil = '" + txtIdEdoC.Text + "' WHERE IdPacientes = '" + txtIdPacientes.Text + "'", conexion);
            MySqlCommand comando = new MySqlCommand("UPDATE TbPacientes SET NombreCompleto = '" + txtNombreC.Text + "', Direccion = '" + txtDireccion.Text + "', TelefonoFijo = '" + txtTelefonoF.Text + "', Celular = '" + txtCelular.Text + "', Edad = '" + txtEdad.Text + "', Sexo = '" + txtSexo.Text + "', Email = '" + txtEmail.Text + "', EdoCivil = '" + txtEdoC.Text + "' WHERE IdPacientes = '" + txtIdPacientes.Text + "'", conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("El paciente ha sido modificado ");
            poblarPacientesDgv();
            limpiarForma();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            
            MySqlCommand comando = new MySqlCommand("DELETE FROM TbPacientes WHERE IdPacientes = '" + txtIdPacientes.Text + "'", conexion);
            MySqlCommand comando2 = new MySqlCommand("DELETE FROM TbPacientesMedico WHERE IdPacientes = '" + txtIdPacientes.Text + "'", conexion);
         

            comando.ExecuteNonQuery();
            comando2.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("El paciente ha sido eliminado");
            poblarPacientesDgv();
            limpiarForma();
        }



        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdPacientes.Text = dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[0].Value.ToString();
            txtNombreC.Text = dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[1].Value.ToString();
            txtDireccion.Text = dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[2].Value.ToString();
            txtTelefonoF.Text = dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[3].Value.ToString();
            txtCelular.Text = dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[4].Value.ToString();
            txtEdad.Text = dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[5].Value.ToString();
            txtSexo.Text = dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[6].Value.ToString();
            txtEmail.Text = dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[7].Value.ToString();
          
            txtEdoC.Text = dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[8].Value.ToString();
            //txtIdEdoC.Text = dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[9].Value.ToString();
         
        }

        private void txtIdPacientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("No se puede cambiar el campo de ID");

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
        //en caso de escribir  letras u otros caracteres
        private void txtTelefonoF_KeyPress(object sender, KeyPressEventArgs e)
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
            // no se permite ingresar puntos al telefono
            else if ((e.KeyChar == '.') && (!txtTelefonoF.Text.Contains(".")))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permmiten numeros, no decimales", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //verifica/valida que solo se escriban numeros y lanza mensaje de error
        //en caso de escribir  letras u otros caracteres
        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
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
            // no se permite ingresar puntos al telefono
            else if ((e.KeyChar == '.') && (!txtTelefonoF.Text.Contains(".")))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permmiten numeros, no decimales", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            string email = txtEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match1 = regex.Match(email);
            if (match1.Success)
            {

            }

            else
            {
                MessageBox.Show("El formato de email es incorrecto", "introduce  un email valido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        //verifica/valida que solo se escriban numeros y lanza mensaje de error
        //en caso de escribir  letras u otros caracteres
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
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
            // no se permite ingresar puntos al telefono
            else if ((e.KeyChar == '.') && (!txtTelefonoF.Text.Contains(".")))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permmiten numeros, no decimales", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //verifica/valida que solo se escriban letras y lanza mensaje de error
        //en caso de escribir  numeros u otros caracteres
        private void txtSexo_KeyPress(object sender, KeyPressEventArgs e)
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
       

        private void txtEdoC_KeyPress(object sender, KeyPressEventArgs e)
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
            // no se permite ingresar puntos al telefono
            else if ((e.KeyChar == '.') && (!txtTelefonoF.Text.Contains(".")))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permmiten numeros, no decimales", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
