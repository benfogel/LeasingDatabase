﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeasingDatabase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class auleaseApps2Entities1 : DbContext
    {
        public auleaseApps2Entities1()
            : base("name=auleaseApps2Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BackupComponent> BackupComponents { get; set; }
        public DbSet<BackupMake> BackupMakes { get; set; }
        public DbSet<BackupModel> BackupModels { get; set; }
    }
}
