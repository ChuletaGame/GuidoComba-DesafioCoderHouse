namespace GuidoComba_DesafioAccesoADatos
{
    public partial class FrmView : Form
    {
        Usuario usuarioSeleccionado;
        public FrmView()
        {
            InitializeComponent();
        }

        private void btnListarUsuarios_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios = UsuarioData.ListarUsuarios();
            this.ActualizarDgv(usuarios);
        }

        private void ActualizarDgv(object objeto)
        {
            this.dgvListado.DataSource = null;
            this.dgvListado.DataSource = objeto;
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            string idString = this.txtId.Text;

            if (!string.IsNullOrWhiteSpace(idString))
            {
                int id = Convert.ToInt32(idString);

                Usuario usuarioBuscado = UsuarioData.ObtenerUsuario(id);
                List<Usuario> lista = new List<Usuario>();
                lista.Add(usuarioBuscado);

                this.ActualizarDgv(lista);
            }
            else
            {
                MessageBox.Show("Ingrese un ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtId.Focus();
            }
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            AMBUsuario frmAlta = new AMBUsuario();
            frmAlta.ShowDialog();
            this.Hide();

            Usuario usuario = frmAlta.UsuarioCreado;

            this.Show();

            if (UsuarioData.CrearUsuario(usuario))
            {
                MessageBox.Show("Usuario creado con exito", "Alta");
                this.txtId.Focus();
            }


        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            string idString = this.txtId.Text;

            if (!string.IsNullOrWhiteSpace(idString))
            {
                int id = Convert.ToInt32(idString);
                bool resultado = UsuarioData.EliminarUsuario(id);

                if (resultado)
                {
                    MessageBox.Show("Se borro el usuario", "Atencion",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtId.Focus();
                }

            }
            else
            {
                MessageBox.Show("Ingrese un ID", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtId.Focus();
            }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
           
               
             AMBUsuario frm = new AMBUsuario(this.usuarioSeleccionado);
            frm.ShowDialog();

            Usuario usuarioModificado = frm.UsuarioCreado;
            if (UsuarioData.ModificarUsuario(usuarioModificado, this.usuarioSeleccionado.Id))
            {
                MessageBox.Show("Se modifico el usuario", "Atencion",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

                       
        }

        private void dgvListado_SelectionChanged(object sender, EventArgs e)
        {
            var seleccion = this.dgvListado.SelectedRows;
            if (seleccion.Count > 0)
            {
                object dato = seleccion[0].DataBoundItem;

                this.usuarioSeleccionado = dato as Usuario;
            }
        }
    }
}
