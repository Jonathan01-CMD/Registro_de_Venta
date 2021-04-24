using Microsoft.EntityFrameworkCore;
using Reguistro_de_Venta.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reguistro_de_Venta.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data/datosProductos.Db");
        }
    }
}
