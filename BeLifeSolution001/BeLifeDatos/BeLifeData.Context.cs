﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeLifeDatos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BeLifeEntities : DbContext
    {
        public BeLifeEntities()
            : base("name=BeLifeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Comuna> Comuna { get; set; }
        public DbSet<Contrato> Contrato { get; set; }
        public DbSet<EstadoCivil> EstadoCivil { get; set; }
        public DbSet<MarcaModeloVehiculo> MarcaModeloVehiculo { get; set; }
        public DbSet<MarcaVehiculo> MarcaVehiculo { get; set; }
        public DbSet<ModeloVehiculo> ModeloVehiculo { get; set; }
        public DbSet<Plan> Plan { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<RegionComuna> RegionComuna { get; set; }
        public DbSet<Sexo> Sexo { get; set; }
        public DbSet<TipoContrato> TipoContrato { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }
        public DbSet<Vivienda> Vivienda { get; set; }
    }
}