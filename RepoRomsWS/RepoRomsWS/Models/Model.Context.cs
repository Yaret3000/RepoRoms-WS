﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RepoRomsWS.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RomsContext : DbContext
    {
        public RomsContext()
            : base("name=RomsContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Consola> Consolas { get; set; }
        public virtual DbSet<Emu> Emus { get; set; }
        public virtual DbSet<Plataforma> Plataformas { get; set; }
        public virtual DbSet<Rom> Roms { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
