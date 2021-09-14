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
    public partial class FrmBuscarJAMR : Form
    {
       
        MySqlConnection conexion = new MySqlConnection("Server = 127.0.0.1; database = DBU3JAMR; Uid = root; pwd = root;" +
           "");
        public FrmBuscarJAMR()
        {
            InitializeComponent();
            cargarDatosMedico();
           
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (CbxMedicos.SelectedValue.ToString() != null)
            {
                string IdMedico = CbxMedicos.SelectedValue.ToString();
                cargarDatosPaciente(IdMedico);
            }
        }

        // Elimina el problema del pooling que evita se conecte mas de una vez
        public void pooling()
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("i={0}", i);
                MySqlConnection conexion = new MySqlConnection("Server = 127.0.0.1; database = DBU3JAMR; Uid = root; pwd = root; pooling =false");
                MySqlCommand comando = new MySqlCommand("select 1", conexion);
                conexion.Open();
                comando.ExecuteNonQuery();
 
                conexion.Close();
            }
        }

        public void cargarDatosMedico()
        {
            DataRow dataRow1;
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("select IdMedico, NombreCompleto from TbMedicos", conexion);
            MySqlDataAdapter sda = new MySqlDataAdapter(comando);
            DataTable dataTable1 = new DataTable();
            sda.Fill(dataTable1);
            conexion.Close();

            dataRow1 = dataTable1.NewRow();
            dataRow1.ItemArray = new object[] { 0, "Elegir" };
            dataTable1.Rows.InsertAt(dataRow1, 0);

            CbxMedicos.ValueMember = "IdMedico";
            CbxMedicos.DisplayMember = "NombreCompleto";
            CbxMedicos.DataSource = dataTable1;

        }
        public void cargarDatosPaciente(string IdMedico)
        {
            DataRow dataRow1;
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("SELECT  a.NombreCompleto FROM TbPacientes a JOIN TbPacientesMedico b ON a.IdPacientes = b.IdPacientes JOIN TbMedicos c ON b.IdMedico = c.IdMedico WHERE b.IdMedico = @IdMedico ", conexion);
            
            comando.Parameters.AddWithValue("IdMedico", IdMedico);
            MySqlDataAdapter sda = new MySqlDataAdapter(comando);
            DataTable dataTable1 = new DataTable();
            sda.Fill(dataTable1);
            conexion.Close();
            dataRow1 = dataTable1.NewRow();
            dataRow1[0] = "" ;
            dataTable1.Rows.InsertAt(dataRow1, 0);
            DgvPacientes.DataSource = dataTable1;
         
        }
    }
}
