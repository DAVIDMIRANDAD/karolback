using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RestauranteKarol.Models
{
    public partial class ProyectoRestKarolContext : DbContext
    {
        public ProyectoRestKarolContext()
        {
        }

        public ProyectoRestKarolContext(DbContextOptions<ProyectoRestKarolContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Compra> Compras { get; set; } = null!;
        public virtual DbSet<Egreso> Egresos { get; set; } = null!;
        public virtual DbSet<Factura> Facturas { get; set; } = null!;
        public virtual DbSet<Inventario> Inventarios { get; set; } = null!;
        public virtual DbSet<InventarioPlatillo> InventarioPlatillos { get; set; } = null!;
        public virtual DbSet<Pedido> Pedidos { get; set; } = null!;
        public virtual DbSet<Persona> Personas { get; set; } = null!;
        public virtual DbSet<Platillo> Platillos { get; set; } = null!;
        public virtual DbSet<PlatilloXfactura> PlatilloXfacturas { get; set; } = null!;
        public virtual DbSet<Producto> Productos { get; set; } = null!;
        public virtual DbSet<Proveedor> Proveedors { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=David\\SQLEXPRESS; Database=ProyectoRestKarol; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Compra>(entity =>
            {
                entity.HasKey(e => e.IdCompras);

                entity.Property(e => e.IdCompras).HasColumnName("idCompras");

                entity.Property(e => e.FechaCompra)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Compra");

                entity.Property(e => e.FechaDespacho)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Despacho");

                entity.Property(e => e.TipoCompra)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Compra");

            });

            modelBuilder.Entity<Egreso>(entity =>
            {
                entity.HasKey(e => e.IdEgreso);

                entity.Property(e => e.IdEgreso).HasColumnName("idEgreso");

                entity.Property(e => e.DescripEgreso)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("Descrip_Egreso");

                entity.Property(e => e.FechaPago)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Pago");

                entity.Property(e => e.TipoEgreso)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Egreso");

              
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.IdFactura);

                entity.ToTable("Factura");

                entity.Property(e => e.IdFactura).HasColumnName("idFactura");

                entity.Property(e => e.EstadoFactura)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("Estado_Factura");

                entity.Property(e => e.FechaFactura)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Factura");

                entity.Property(e => e.FormaPago)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("Forma_Pago");
            });

            modelBuilder.Entity<Inventario>(entity =>
            {
                entity.HasKey(e => e.IdInventario);

                entity.ToTable("Inventario");

                entity.Property(e => e.IdInventario).HasColumnName("idInventario");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Ingreso");

            });

            modelBuilder.Entity<InventarioPlatillo>(entity =>
            {
                entity.HasKey(e => e.IdInventarioPlatillo);

                entity.ToTable("InventarioPlatillo");

                entity.Property(e => e.IdInventarioPlatillo).HasColumnName("idInventarioPlatillo");

                entity.Property(e => e.IdPlatillo).HasColumnName("idPlatillo");

                entity.Property(e => e.IdProducto).HasColumnName("idProducto");

                
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(e => e.IdPedido)
                    .HasName("PK_Pedidos");

                entity.ToTable("Pedido");

                entity.Property(e => e.IdPedido).HasColumnName("idPedido");

                entity.Property(e => e.FechaDespacho)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Despacho");

                entity.Property(e => e.FechaPedido)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Pedido");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.TipoEntrega)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Entrega");

                entity.Property(e => e.TipoPedido)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Pedido");

                entity.Property(e => e.ValorEntrega).HasColumnName("Valor_Entrega");

              
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona);

                entity.ToTable("Persona");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.ApePersona)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("Ape_Persona");

                entity.Property(e => e.CorreoPersona)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("Correo_Persona");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.NomPersona)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("Nom_Persona");

                entity.Property(e => e.NumDoc).HasColumnName("Num_Doc");

                entity.Property(e => e.TelPersona).HasColumnName("Tel_Persona");
            });

            modelBuilder.Entity<Platillo>(entity =>
            {
                entity.HasKey(e => e.IdPlatillo);

                entity.ToTable("Platillo");

                entity.Property(e => e.IdPlatillo).HasColumnName("idPlatillo");

                entity.Property(e => e.DescripPlat)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("Descrip_Plat");

                entity.Property(e => e.NomPlatillo)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("Nom_Platillo");

                entity.Property(e => e.TipoPlatillo)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Platillo");
            });

            modelBuilder.Entity<PlatilloXfactura>(entity =>
            {
                entity.HasKey(e => e.IdPlatilloFactura);

                entity.ToTable("PlatilloXFactura");

                entity.Property(e => e.IdPlatilloFactura).HasColumnName("idPlatilloFactura");

                entity.Property(e => e.IdFactura).HasColumnName("idFactura");

                entity.Property(e => e.IdPlatillo).HasColumnName("idPlatillo");

            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto);

                entity.ToTable("Producto");

                entity.Property(e => e.IdProducto).HasColumnName("idProducto");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFabricacion)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Fabricacion");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Vencimiento");

                entity.Property(e => e.NomProducto)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("Nom_Producto");
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.HasKey(e => e.IdProveedor);

                entity.ToTable("Proveedor");

                entity.Property(e => e.IdProveedor).HasColumnName("idProveedor");

                entity.Property(e => e.CorreoProveedor)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("Correo_Proveedor");

                entity.Property(e => e.DirProveedor)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("Dir_Proveedor");

                entity.Property(e => e.IdProducto).HasColumnName("idProducto");

                entity.Property(e => e.Nit)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("NIT");

                entity.Property(e => e.NomProveedor)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("Nom_Proveedor");

                entity.Property(e => e.TelProveedor)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("Tel_Proveedor");

            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.ToTable("Usuario");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.EstadoUsu)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("Estado_Usu");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.NomUsuario)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("Nom_Usuario");

                entity.Property(e => e.Password)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.RolUsu)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("Rol_Usu");

             
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
