﻿using System;
using System.Collections.Generic;

namespace GuidoComba_DesafioAccesoADatos
{
    public partial class ProductoVendido
    {
        public int Id { get; set; }
        public int Stock { get; set; }
        public int IdProducto { get; set; }
        public int IdVenta { get; set; }

        public virtual Producto IdProductoNavigation { get; set; } = null!;
        public virtual Venta IdVentaNavigation { get; set; } = null!;
    }
}
