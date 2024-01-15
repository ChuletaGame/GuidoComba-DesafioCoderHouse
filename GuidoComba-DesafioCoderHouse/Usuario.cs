using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidoComba_DesafioCoderHouse
{
    internal class Usuario
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _nombreUsuario;
        private string _contraseña;
        private string _mail;


        public int Id {
            get { return _id; }
            set { _id = value; } 
        }
        public string Nombre {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public string NombreUsuario
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }
        public string Contraseña
        {
            get { return _contraseña; }
            set { _contraseña = value; }
        }
        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }


        public Usuario()
        {
            _id = 0;
            _nombre = string.Empty;
            _apellido = string.Empty;
            _nombreUsuario = string.Empty;
            _contraseña = string.Empty;
            _mail = string.Empty;
        }    
            
        public Usuario(int Id, string Nombre, string Apellido, string NombreUsuario, string Contraseña, string Mail)
        {
            this._id = Id;
            this._nombre = Nombre;
            this._apellido = Apellido;
            this._nombreUsuario = NombreUsuario;
            this._contraseña = Contraseña;
            this._mail = Mail;
                
        }


    }
}
