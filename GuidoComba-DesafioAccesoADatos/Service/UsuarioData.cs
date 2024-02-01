using GuidoComba_DesafioAccesoADatos.Database;
using GuidoComba_DesafioAccesoADatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidoComba_DesafioAccesoADatos.Service
{
    public static class UsuarioData
    {
        public static Usuario ObtenerUsuario(int id)
        {
            using (CoderContext context = new CoderContext())
            {
                Usuario usuarioBuscado = context.Usuarios.Where(u => u.Id == id).FirstOrDefault();

                return usuarioBuscado;
            }


        }

        public static List<Usuario> ListarUsuarios()
        {
            using (CoderContext context = new CoderContext())
            {
                List<Usuario> usuarios = context.Usuarios.ToList();

                return usuarios;
            }
        }

        public static bool CrearUsuario(Usuario usuario)
        {
            using (CoderContext context = new CoderContext())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();

                return true;
            }
        }

    }
}
