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

namespace PruebaProyecto
{
    public partial class FrmConsultarUsuario : Form
    {
        public FrmConsultarUsuario()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=boletos_aereos;uid=root;pwd=tu_contraseña"))
            {
                conn.Open();
                string query = "SELECT * FROM Usuarios WHERE Nombre_Usuario=@nombre";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", txtBuscarUsuario.Text);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblNombreUsuario.Text = "Nombre de Usuario: " + reader["Nombre_Usuario"].ToString();
                    lblContraseña.Text = "Contraseña: " + reader["Contraseña"].ToString();
                    lblRol.Text = "Rol: " + reader["Rol"].ToString();
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado.");
                    lblNombreUsuario.Text = "Nombre de Usuario: ";
                    lblContraseña.Text = "Contraseña: ";
                    lblRol.Text = "Rol: ";
                }
                reader.Close();
            }
    }
}
