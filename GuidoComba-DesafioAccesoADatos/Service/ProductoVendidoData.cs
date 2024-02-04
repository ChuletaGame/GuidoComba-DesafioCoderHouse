using GuidoComba_DesafioAccesoADatos.Database;
using GuidoComba_DesafioAccesoADatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidoComba_DesafioAccesoADatos.Service
{
    public static class ProductoVendidoData
    {

        public static ProductoVendido ObtenerProductoVendido (int id)
        {
            using (CoderContext context = new CoderContext())
            {
                ProductoVendido productoBuscadoVendido = context.ProductoVendidos.Where(u => u.Id == id).FirstOrDefault();

                return productoBuscadoVendido;
            }

        }

        public static List<ProductoVendido> ListarProductosVendidos()
        {
            using (CoderContext context = new CoderContext())
            {
                List<ProductoVendido> productoVendido = context.ProductoVendidos.ToList();

                return productoVendido;
            }
        }

        public static bool CrearProductoVendido(ProductoVendido productoVendido)
        {
            using (CoderContext context = new CoderContext())
            {
                context.ProductoVendidos.Add(productoVendido);
                context.SaveChanges();

                return true;
            }
        }

        public static bool ModificarProductoVendido(ProductoVendido productoVendido)
        {
            using (CoderContext context = new CoderContext())
            {
                context.ProductoVendidos.Add(productoVendido);
                context.SaveChanges();

                return true;
            }
        }

        public static bool EliminarProductoVendido(int id)
        {
            using (CoderContext context = new CoderContext())
            {
                ProductoVendido productoBorradoVendido = context.ProductoVendidos.Where(u => u.Id == id).FirstOrDefault();

                if (productoBorradoVendido is not null)
                {
                    context.ProductoVendidos.Remove(productoBorradoVendido);
                    context.SaveChanges();
                    return true;
                }

                return false;
            }

        }
    }
}
