﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HostalWeb.Datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HostalEntities : DbContext
    {
        public HostalEntities()
            : base("name=HostalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EMPLEADO> EMPLEADO { get; set; }
        public virtual DbSet<EMPRESA> EMPRESA { get; set; }
        public virtual DbSet<ESTADO_EMPLEADO> ESTADO_EMPLEADO { get; set; }
        public virtual DbSet<ESTADO_ORDEN> ESTADO_ORDEN { get; set; }
        public virtual DbSet<FAMILIA_PRODUCTO> FAMILIA_PRODUCTO { get; set; }
        public virtual DbSet<ORDEN_PEDIDO> ORDEN_PEDIDO { get; set; }
        public virtual DbSet<PRODUCTO> PRODUCTO { get; set; }
        public virtual DbSet<PROVEEDOR> PROVEEDOR { get; set; }
        public virtual DbSet<RUBRO> RUBRO { get; set; }
        public virtual DbSet<TIPO_PRODUCTO> TIPO_PRODUCTO { get; set; }
        public virtual DbSet<TIPO_USUARIO> TIPO_USUARIO { get; set; }
        public virtual DbSet<TRABAJADOR> TRABAJADOR { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
        public virtual DbSet<FACTURA> FACTURA { get; set; }
        public virtual DbSet<HABITACION> HABITACION { get; set; }
        public virtual DbSet<HABITACION_FACTURA> HABITACION_FACTURA { get; set; }
        public virtual DbSet<HABITACION_ORDEN_COMPRA> HABITACION_ORDEN_COMPRA { get; set; }
        public virtual DbSet<HUESPED> HUESPED { get; set; }
        public virtual DbSet<MINUTA> MINUTA { get; set; }
        public virtual DbSet<MINUTA_PLATO> MINUTA_PLATO { get; set; }
        public virtual DbSet<ORDEN_COMPRA> ORDEN_COMPRA { get; set; }
        public virtual DbSet<ORDEN_PEDIDO_PRODUCTO> ORDEN_PEDIDO_PRODUCTO { get; set; }
        public virtual DbSet<PLATO> PLATO { get; set; }
        public virtual DbSet<SERVICIO> SERVICIO { get; set; }
        public virtual DbSet<SERVICIO_FACTURA> SERVICIO_FACTURA { get; set; }
        public virtual DbSet<SERVICIO_ODEN_COMPRA> SERVICIO_ODEN_COMPRA { get; set; }
    }
}
