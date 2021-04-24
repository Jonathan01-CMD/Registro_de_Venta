using System;
using System.Collections.Generic;
using System.Text;

namespace Reguistro_de_Venta.Entidades
{
    public class Pedidos
    {
        public int PedidoId { get; set; }
        public string NombreCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public bool Pedido { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaEntrega { get; set; }
        public int PrecioTotal { get; set; }
    }
}
