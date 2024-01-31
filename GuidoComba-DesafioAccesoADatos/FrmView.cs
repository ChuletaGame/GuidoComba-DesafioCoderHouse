using GuidoComba_DesafioAccesoADatos.Database;
using GuidoComba_DesafioAccesoADatos.Models;

namespace GuidoComba_DesafioAccesoADatos
{
    public partial class FrmView : Form
    {
        public FrmView()
        {
            InitializeComponent();
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            using(CoderContext database = new CoderContext())
            {
                List<Usuario> usuarios = database.Usuarios.ToList(); 
                
                this.dgvListado.DataSource = usuarios;
            }
        }
    }
}
