﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sportiroda_WPF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class sportirodaEntities : DbContext
    {
        public sportirodaEntities()
            : base("name=sportirodaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<nevezes> nevezes { get; set; }
        public virtual DbSet<tipus> tipus { get; set; }
        public virtual DbSet<verseny> verseny { get; set; }
        public virtual DbSet<versenyzo> versenyzo { get; set; }
        public virtual DbSet<OsszesAdat> OsszesAdat { get; set; }
    }
}