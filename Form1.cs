using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace U2A1IDEJAMR
{
    public partial class Form1 : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server = 127.0.0.1; database = DBU3JAMR; Uid = root; pwd = root;" +
            "");
        public Form1()
        {
            InitializeComponent();
            poblarMedicos();
            poblarEstadoCivil();
           
        }

       

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Se ha conectado exitosamente");
                conexion.Close();

            }
            catch (Exception)
            {
                throw;
            }
        }

       
        public void poblarMedicos()
        {
            DataRow datarow1;
            try
            {
                conexion.Open();
                


                MySqlCommand comando = new MySqlCommand("select * from TbMedicos", conexion);
                MySqlDataAdapter sda = new MySqlDataAdapter(comando);
                DataTable datatable1 = new DataTable();
                sda.Fill(datatable1);

                datarow1 = datatable1.NewRow();
                datarow1.ItemArray = new object[] { 0, "Elegir" };
                datatable1.Rows.InsertAt(datarow1, 0);

                CbxMedicos.ValueMember = "IdMedico";

                CbxMedicos.DisplayMember = "NombreCompleto";
                CbxMedicos.DataSource = datatable1;

                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void limpiarForma()
        {
            TxtNombreC.Text = " ";
            TxtEdad.Text = " ";
            TxtEmail.Text = " ";
            TxtDireccion.Text = " ";
            TxtCelular.Text = " ";
            TxtTelefonoFijo.Text = " ";
            //CbxEdoCivil.SelectedIndex = 0;
            CbxEdoCivil.Text = " ";
            CbxMedicos.Text = " ";
            //CbxMedicos.SelectedIndex = 0;
            RbdSexoF.Checked = true;
            RbdSexoM.Checked = true;
        }
        public void poblarEstadoCivil()
        {
            DataRow datarow1;
            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand("select * from EdoCivil", conexion);
                MySqlDataAdapter sda = new MySqlDataAdapter(comando);
                DataTable datatable1 = new DataTable();
                sda.Fill(datatable1);

                CbxEdoCivil.ValueMember = "IdEdoCivil";

                CbxEdoCivil.DisplayMember = "EdoCivil";
                CbxEdoCivil.DataSource = datatable1;

                conexion.Close();
            }
            catch (Exception e)
            {
                throw;
            }

        }

        //esta opcion asigna el sexo dependiendo de la opcion seleccionada en el radio button
        private char opcionSexo()
        {
            char sexo;
           
            if (RbdSexoF.Checked)
            {
                sexo = 'F';
            }
            else
            {
                sexo = 'M';
            }
            return sexo;

        }

   
        private void Guardar_Click(object sender, EventArgs e)
        {
            
            int idPaciente;
            int idMedico;
            //string insertarConsulta = "INSERT INTO TbPacientes(NombreCompleto, Direccion, TelefonoFijo, Celular, Edad, Sexo, Email, EdoCivil, IdEdoCivil) VALUES ( '" + TxtNombreC.Text + "','" + TxtDireccion.Text + "','" + TxtTelefonoFijo.Text + "','" + TxtCelular.Text + "'," + TxtEdad.Text + ",'" + opcionSexo() + "','" + TxtEmail.Text + "','" + CbxEdoCivil.Text + "','" + CbxEdoCivil.SelectedValue+ "')";
            string insertarConsulta = "INSERT INTO TbPacientes(NombreCompleto, Direccion, TelefonoFijo, Celular, Edad, Sexo, Email, EdoCivil) VALUES ( '" + TxtNombreC.Text + "','" + TxtDireccion.Text + "','" + TxtTelefonoFijo.Text + "','" + TxtCelular.Text + "'," + TxtEdad.Text + ",'" + opcionSexo() + "','" + TxtEmail.Text + "','" + CbxEdoCivil.SelectedValue + "')";
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(insertarConsulta, conexion);
            comando.ExecuteNonQuery();
            
            idPaciente = (Convert.ToInt32(comando.LastInsertedId));
            idMedico = (Convert.ToInt32(CbxMedicos.SelectedValue.ToString()));

            
            string insertarLlForaneas = "INSERT INTO TbPacientesMedico (IdMedico, IdPacientes) VALUES ('" +idMedico + "', '" + idPaciente + "') ";
            MySqlCommand comando2 = new MySqlCommand(insertarLlForaneas, conexion);
            comando2.ExecuteNonQuery();

            MessageBox.Show("El ID del paciente creado es : " + idPaciente);
            return;

            try
            {
                if (comando.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Los Datos han sido insertados");
                }
                else
                {
                    MessageBox.Show("Los datos no fueron insertados");
                }

            }
            catch(Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
            try
            {
                if (comando2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Los Datos han sido insertados");
                }
                else
                {
                    MessageBox.Show("Los datos no fueron insertados");
                }

            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }

            conexion.Close();
            limpiarForma();
        }
        //verifica/valida que solo se escriban numeros y lanza mensaje de error
        //en caso de escribir  letras
        private void TxtEdad_KeyPress(object sender, KeyPressEventArgs e)
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
            else if ((e.KeyChar == '.') && (!TxtEdad.Text.Contains(".")))
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
        private void TxtCelular_KeyPress(object sender, KeyPressEventArgs e)
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
            else if ((e.KeyChar == '.') && (!TxtEdad.Text.Contains(".")))
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

        private void TxtTelefonoFijo_KeyPress(object sender, KeyPressEventArgs e)
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
            else if ((e.KeyChar == '.') && (!TxtEdad.Text.Contains(".")))
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

        private void TxtNombreC_KeyPress(object sender, KeyPressEventArgs e)
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


        private void TxtEmail_Leave(object sender, EventArgs e)
        {
          
            string email = TxtEmail.Text;
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

    }
}
