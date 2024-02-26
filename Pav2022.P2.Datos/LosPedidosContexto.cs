using Microsoft.EntityFrameworkCore;
using Pav2022.P2.Dominio.Entidades;
using System;

namespace Pav2022.P2.Datos
{
    public class LosPedidosContexto : DbContext, IUnidadDeTrabajoMarco
    {
        public LosPedidosContexto()
        {

        }

        public LosPedidosContexto(DbContextOptions<LosPedidosContexto> options)
        : base(options)
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LosPedidos;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Producto>()
                .ToTable("Productos")
                .Property(p=> p.Descripcion)
                .HasMaxLength(150);

            modelBuilder
                .Entity<Pedido>()
                .ToTable("Pedidos") 
                .Ignore(p => p.Iniciado)  
                .HasMany(p => p.Lineas)
                .WithOne() 
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<LineaPedido>()
                .ToTable("LineasPedido")
                .Ignore(lp => lp.SubTotal)
                .Ignore(lp => lp.TiempoDePreparacion);
        }


        public void Confirmar()
        {
            SaveChanges();
        }

        public DbSet<T> CrearSet<T>() where T : class
        {
            return Set<T>();
        }

        public void Refrescar<T>(T item) where T : class
        {
            if (Entry(item).State != EntityState.Detached)
            {
                Attach(item);
            }
            base.Update(item);
        }

        public void RevertirCambios()
        {
            throw new NotImplementedException();
        }

        public void SetModificado<T>(T item) where T : class
        {
            Entry(item).State = EntityState.Modified;
        }
    }
}
