using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RestauranteKarol.Models;

namespace Restaurante_Karol.Models
{
    public partial class RESTAURANTE_KAROLContext : DbContext
    {
        public RESTAURANTE_KAROLContext()
        {
        }

        public RESTAURANTE_KAROLContext(DbContextOptions<RESTAURANTE_KAROLContext> options)
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
                optionsBuilder.UseSqlServer("Server=CARLOS\\SQLEXPRESS; Database=RESTAURANTE_KAROL; Trusted_Connection=True;");
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
                    .HasMaxLength(10)
                    .HasColumnName("Tipo_Compra")
                    .IsFixedLength();

            });

            modelBuilder.Entity<Egreso>(entity =>
            {
                entity.HasKey(e => e.IdEgreso);

                entity.Property(e => e.IdEgreso).HasColumnName("idEgreso");

                entity.Property(e => e.DescripEgreso)
                    .HasMaxLength(10)
                    .HasColumnName("Descrip_Egreso")
                    .IsFixedLength();

                entity.Property(e => e.FechaPago)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Pago");

                entity.Property(e => e.TipoEgreso)
                    .HasMaxLength(10)
                    .HasColumnName("Tipo_Egreso")
                    .IsFixedLength();
            
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.IdFactura);

                entity.ToTable("Factura");

                entity.Property(e => e.IdFactura).HasColumnName("idFactura");

                entity.Property(e => e.EstadoFactura)
                    .HasMaxLength(10)
                    .HasColumnName("Estado_Factura")
                    .IsFixedLength();

                entity.Property(e => e.FechaFactura)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Factura");

                entity.Property(e => e.FormaPago)
                    .HasMaxLength(10)
                    .HasColumnName("Forma_Pago")
                    .IsFixedLength();
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
                    .HasMaxLength(10)
                    .HasColumnName("Tipo_Entrega")
                    .IsFixedLength();

                entity.Property(e => e.TipoPedido)
                    .HasMaxLength(10)
                    .HasColumnName("Tipo_Pedido")
                    .IsFixedLength();

                entity.Property(e => e.ValorEntrega).HasColumnName("Valor_Entrega");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona);

                entity.ToTable("Persona");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.ApePersona)
                    .HasMaxLength(10)
                    .HasColumnName("Ape_Persona")
                    .IsFixedLength();

                entity.Property(e => e.CorreoPersona)
                    .HasMaxLength(10)
                    .HasColumnName("Correo_Persona")
                    .IsFixedLength();

                entity.Property(e => e.Direccion)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NomPersona)
                    .HasMaxLength(10)
                    .HasColumnName("Nom_Persona")
                    .IsFixedLength();

                entity.Property(e => e.NumDoc).HasColumnName("Num_Doc");

                entity.Property(e => e.TelPersona).HasColumnName("Tel_Persona");
            });

            modelBuilder.Entity<Platillo>(entity =>
            {
                entity.HasKey(e => e.IdPlatillo);

                entity.ToTable("Platillo");

                entity.Property(e => e.IdPlatillo).HasColumnName("idPlatillo");

                entity.Property(e => e.DescripPlat)
                    .HasMaxLength(10)
                    .HasColumnName("Descrip_Plat")
                    .IsFixedLength();

                entity.Property(e => e.NomPlatillo)
                    .HasMaxLength(10)
                    .HasColumnName("Nom_Platillo")
                    .IsFixedLength();

                entity.Property(e => e.TipoPlatillo)
                    .HasMaxLength(10)
                    .HasColumnName("Tipo_Platillo")
                    .IsFixedLength();
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
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FechaFabricacion)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Fabricacion");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Vencimiento");

                entity.Property(e => e.NomProducto)
                    .HasMaxLength(10)
                    .HasColumnName("Nom_Producto")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.HasKey(e => e.IdProveedor);

                entity.ToTable("Proveedor");

                entity.Property(e => e.IdProveedor).HasColumnName("idProveedor");

                entity.Property(e => e.CorreoProveedor)
                    .HasMaxLength(10)
                    .HasColumnName("Correo_Proveedor")
                    .IsFixedLength();

                entity.Property(e => e.DirProveedor)
                    .HasMaxLength(10)
                    .HasColumnName("Dir_Proveedor")
                    .IsFixedLength();

                entity.Property(e => e.IdProducto).HasColumnName("idProducto");

                entity.Property(e => e.Nit)
                    .HasMaxLength(10)
                    .HasColumnName("NIT")
                    .IsFixedLength();

                entity.Property(e => e.NomProveedor)
                    .HasMaxLength(10)
                    .HasColumnName("Nom_Proveedor")
                    .IsFixedLength();

                entity.Property(e => e.TelProveedor)
                    .HasMaxLength(10)
                    .HasColumnName("Tel_Proveedor")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.ToTable("Usuario");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.EstadoUsu)
                    .HasMaxLength(10)
                    .HasColumnName("Estado_Usu")
                    .IsFixedLength();

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.NomUsuario)
                    .HasMaxLength(10)
                    .HasColumnName("Nom_Usuario")
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RolUsu)
                    .HasMaxLength(10)
                    .HasColumnName("Rol_Usu")
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
