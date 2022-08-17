using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria
{
    public partial class FrmVeterinaria : Form
    {
        string cadena = @"Data Source=DESKTOP-35K14QB\;Initial Catalog=VeterinariaPatitas4;Integrated Security=True";

        public FrmVeterinaria()
        {
            InitializeComponent();
        }

        private void FrmVeterinaria_Load(object sender, EventArgs e)
        {


            cargarLbxClientes(cadena);
        }

        private void cargarLbxClientes(String cadena)
        {
            //Data Source=DESKTOP-35K14QB\;Initial Catalog=VeterinariaPatitas4;Integrated Security=True

            SqlConnection cnn = new SqlConnection(cadena);

            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "pa_listarClientes";
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tabla = new DataTable();
            tabla.Load(reader);

            lbxClientes.DataSource = tabla;
            lbxClientes.ValueMember = "id_dueno";
            lbxClientes.DisplayMember = "nombre"; //concatenar nombre+apellido en el sp

            cnn.Close();

        }

        private void lbxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            string cadena = @"Data Source=DESKTOP-35K14QB\;Initial Catalog=VeterinariaPatitas4;Integrated Security=True";
            cargarCboMascotas(cadena);

        }

        private void cargarCboMascotas(String cadena)
        {

            SqlConnection cnn = new SqlConnection(cadena);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dueno", lbxClientes.SelectedIndex);
            cmd.CommandText = "PA_selectMascotasxDueno";
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tabla = new DataTable();
            tabla.Load(reader);

            
            cbxMascotas.DataSource = tabla;
            cbxMascotas.ValueMember = "id_mascota";
            cbxMascotas.DisplayMember = "nombre";

            cnn.Close();
        }
    }
}
