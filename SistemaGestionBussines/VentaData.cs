﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuidoComba_DesafioAccesoADatos;

namespace GuidoComba_DesafioAccesoADatos
{
    public static class VentaData
    {
        public static Venta ObtenerVenta(int id)
        {
            using (CoderContext context = new CoderContext())
            {
                Venta ventaBuscado = context.Venta.Where(u => u.Id == id).FirstOrDefault();

                return ventaBuscado;
            }

        }

        public static List<Venta> ListarVenta()
        {
            using (CoderContext context = new CoderContext())
            {
                List<Venta> venta = context.Venta.ToList();

                return venta;
            }
        }

        public static bool CrearVenta(Venta venta)
        {
            using (CoderContext context = new CoderContext())
            {
                context.Venta.Add(venta);
                context.SaveChanges();

                return true;
            }
        }

        public static bool ModificarVenta(Venta venta, int id)
        {
            using (CoderContext context = new CoderContext())
            {
                Venta VentaBuscada = context.Venta.Where(v => v.Id == id).FirstOrDefault();


                VentaBuscada.Comentarios = venta.Comentarios;
                VentaBuscada.IdUsuario = venta.IdUsuario;


                context.Venta.Update(VentaBuscada);
                context.SaveChanges();

                return true;
            }
        }

        public static bool EliminarVenta(int id)
        {
            using (CoderContext context = new CoderContext())
            {
                Venta ventaABorrado = context.Venta.Include(p => p.ProductoVendidos).Where(v => v.Id == id).FirstOrDefault();

                if (ventaABorrado is not null)
                {
                    context.Venta.Remove(ventaABorrado);
                    context.SaveChanges();
                    return true;
                }

                return false;
            }

        }
    }
}

