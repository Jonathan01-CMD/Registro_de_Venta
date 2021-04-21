using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Reguistro_de_Venta.Entidades
{
    class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string NombreProducto { get; set; }
        public string MarcaProducto { get; set; }
        public int PrecioProducto { get; set; }
        public int CantidadProducto { get; set; }
    }
}
