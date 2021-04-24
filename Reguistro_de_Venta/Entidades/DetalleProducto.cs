using System;
using System.Collections.Generic;
using System.Text;

namespace Reguistro_de_Venta.Entidades
{
    public class DetalleProducto
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public string NombreProducto { get; set; }
        public int PedidoId { get; set; }
        public bool Pedido { get; set; }

        public DetalleProducto()
        {
            Id = 0;
            ProductoId = 0;
            NombreProducto = string.Empty;
            PedidoId = 0;
            Pedido = false;
        }

        public DetalleProducto(int id, int producto, string nombre, int pedidoid, bool pedido)
        {
            Id = id;
            ProductoId = producto;
            NombreProducto = nombre;
            PedidoId = pedidoid;
            Pedido = pedido;
        }
    }
}
