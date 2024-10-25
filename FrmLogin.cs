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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            FrmIniciarSesion iniciarSesion = new FrmIniciarSesion();
            iniciarSesion.ShowDialog();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            FrmCrearUsuario crearUsuario = new FrmCrearUsuario();
            crearUsuario.ShowDialog();
        }

        private void btnConsultarUsuario_Click(object sender, EventArgs e)
        {
            FrmConsultarUsuario consultarUsuario = new FrmConsultarUsuario();
            consultarUsuario.ShowDialog();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            FrmModificarUsuario modificarUsuario = new FrmModificarUsuario();
            modificarUsuario.ShowDialog();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            FrmEliminarUsuario eliminarUsuario = new FrmEliminarUsuario();
            eliminarUsuario.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
