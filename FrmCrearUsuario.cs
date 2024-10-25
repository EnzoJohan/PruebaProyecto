using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaProyecto
{
    public partial class FrmCrearUsuario : Form
    {
        public FrmCrearUsuario()
        {
            InitializeComponent();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            string tipo = cmbTipoUsuario.SelectedItem.ToString();

            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=boletos_aereos;uid=root;pwd=tu_contraseña"))
            {
                conn.Open();
                string query = "INSERT INTO Usuarios (nombre_usuario, contraseña, tipo) VALUES (@usuario, @contraseña, @tipo)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);
                cmd.Parameters.AddWithValue("@tipo", tipo);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario creado exitosamente.");
            }
    }
}
