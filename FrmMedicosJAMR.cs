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
    public partial class FrmMedicosJAMR : Form
    {
        //MySqlConnection conexion = new MySqlConnection("Server = 127.0.0.1; database = DBU3JAMR; Uid = root; pwd = root;");
        MySqlConnection conexion = new MySqlConnection("Server = 127.0.0.1; database = DBU3JAMR; Uid = root; pwd = root;" +
           "");
        public FrmMedicosJAMR()
        {
            InitializeComponent();
        }


        private void FrmMedicosJAMR_Load(object sender, EventArgs e)
        {

        }
        public void limpiarForma()
        {
            txtNombreC.Clear();
            txtCedula.Clear();
            txtEspecialidad.Clear();
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string insertarConsulta = "INSERT  INTO TbMedicos (NombreCompleto, Cedula, Especialidad) VALUES ('" + txtNombreC.Text + "', '" + txtCedula.Text + "', '" + txtEspecialidad.Text + "' )";
            conexion.Open();

            MySqlCommand comando = new MySqlCommand(insertarConsulta, conexion);
            comando.ExecuteNonQuery();
            try
            {
                if(comando.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Los Datos han sido insertados");
                }
                else
                {
                    MessageBox.Show("Los datos no fueron insertados");
                }
            }
            catch(Exception e3)
            {
                MessageBox.Show(e3.Message);
            }
            conexion.Close();
            limpiarForma();
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
            // no se permite ingresar puntos al telefono
            else if ((e.KeyChar == '.') && (!txtCedula.Text.Contains(".")))
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
            // no se permite ingresar puntos al telefono
            else if ((e.KeyChar == '.') && (!txtCedula.Text.Contains(".")))
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
