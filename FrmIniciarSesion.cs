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
    public partial class FrmIniciarSesion : Form
    {
        public FrmIniciarSesion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=boletos_aereos;uid=root;pwd=tu_contraseña"))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Usuarios WHERE nombre_usuario=@usuario AND contraseña=@contraseña";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);

                int result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result > 0)
                {
                    MessageBox.Show("Inicio de sesión exitoso.");
                    // Aquí abrirías el siguiente formulario principal para el usuario.
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
    }
}
