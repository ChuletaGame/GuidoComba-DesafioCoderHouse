using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidoComba_DesafioCoderHouse
{
    internal class Producto
    {

        private int _id;
        private string _descripcion;
        private double _costo;
        private double _precioVenta;
        private int _stock;
        private int _idUsuario;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        public double Costo
        {
            get { return _costo; }
            set { _costo = value; }
        }
        public double PrecioVenta
        {
            get { return _precioVenta; }
            set { _precioVenta = value; }
        }
        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }


        public Producto()
        {
            _id = 0;
            _descripcion = string.Empty;
            _costo = 0;
            _precioVenta = 0;
            _stock = 0;
            _idUsuario = 0;
        }
        public Producto(int Id, string Descripcion, double Costo,
            double PrecioVenta, int Stock, int IdUsuario)
        {
            this._id = Id;
            this._descripcion = Descripcion;
            this._costo = Costo;
            this._precioVenta = PrecioVenta;
            this._stock = Stock;
            this._idUsuario = IdUsuario;
        }
    }

}
