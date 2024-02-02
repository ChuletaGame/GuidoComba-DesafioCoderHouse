using GuidoComba_DesafioAccesoADatos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuidoComba_DesafioAccesoADatos
{
    public partial class AMBUsuario : Form
    {
        public AMBUsuario()
        {
            InitializeComponent();
        }

        public AMBUsuario(Usuario usuario):this() 
        {
            this.txtNombre.Text = usuario.Nombre;
            this.txtApellido.Text = usuario.Apellido;
            this.txtNombreUsuario.Text = usuario.NombreUsuario;
            this.txtPassword.Text = usuario.Contraseña;
            this.txtMail.Text = usuario.Mail;
        }

        public Usuario UsuarioCreado { get; private set; }

        private void AMBUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario() {Nombre = this.txtNombre.Text,
            Apellido = this.txtApellido.Text, Contraseña = this.txtPassword.Text,
            NombreUsuario = this.txtNombreUsuario.Text, Mail = this.txtMail.Text};

            this.UsuarioCreado = usuario;

            this.Close();
        }
    }
}
