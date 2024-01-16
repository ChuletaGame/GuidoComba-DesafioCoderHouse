using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidoComba_DesafioCoderHouse
{
    internal class Venta
    {
        private int _id;
        private string _Comentario;
        private int _idUsuario;

        public int Id {
            get { return _id; }
            set { _id = value; }
        }
        public string Comentario
        {
            get { return _Comentario; }
            set { _Comentario = value; }
        }
        public int IdUsuario
        {
            get { return _idUsuario;}
            set { _idUsuario = value;}
        }

        public Venta()
        {
            _id = 0;
            _Comentario = string.Empty;
            _idUsuario = 0;
           
        }
        public Venta(int Id, string Comentario, int IdUsuario)
        {
            this._id = Id;
            this._Comentario = Comentario;
            this._idUsuario = IdUsuario;
        }


    }
}
