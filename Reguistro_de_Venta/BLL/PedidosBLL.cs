using Microsoft.EntityFrameworkCore;
using Reguistro_de_Venta.DAL;
using Reguistro_de_Venta.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Reguistro_de_Venta.BLL
{
    class PedidosBLL
    {
        public static bool Guardar(Pedidos pedidos)
        {
            if (!Existe(pedidos.PedidoId))
                return Insertar(pedidos);
            else
                return Modificar(pedidos);
        }

        private static bool Insertar(Pedidos pedidos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Pedidos.Add(pedidos);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Modificar(Pedidos pedidos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(pedidos).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var pedidos = contexto.Pedidos.Find(id);
                if (pedidos != null)
                {
                    contexto.Pedidos.Remove(pedidos);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static Pedidos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Pedidos pedidos;
            try
            {
                pedidos = contexto.Pedidos.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return pedidos;
        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = contexto.Pedidos.Any(e => e.PedidoId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }

        public static List<Pedidos> GetList(Expression<Func<Pedidos, bool>> criterio)
        {
            List<Pedidos> lista = new List<Pedidos>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Pedidos.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }
    }
}
