﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DatabaseBuxEntities : DbContext
    {
        public DatabaseBuxEntities()
            : base("name=DatabaseBuxEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__EFMigrationsHistory> C__EFMigrationsHistory { get; set; }
        public virtual DbSet<должностиs> должностиs { get; set; }
        public virtual DbSet<единицаИзмеренияs> единицаИзмеренияs { get; set; }
        public virtual DbSet<классификациятоваровs> классификациятоваровs { get; set; }
        public virtual DbSet<клиентыs> клиентыs { get; set; }
        public virtual DbSet<приходs> приходs { get; set; }
        public virtual DbSet<приходТоварыs> приходТоварыs { get; set; }
        public virtual DbSet<производительs> производительs { get; set; }
        public virtual DbSet<расходs> расходs { get; set; }
        public virtual DbSet<расходТоварыs> расходТоварыs { get; set; }
        public virtual DbSet<сотрудникиs> сотрудникиs { get; set; }
        public virtual DbSet<тараиУпаковкаs> тараиУпаковкаs { get; set; }
        public virtual DbSet<товарыs> товарыs { get; set; }
    }
}