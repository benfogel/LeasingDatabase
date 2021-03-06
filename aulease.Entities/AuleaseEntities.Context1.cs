﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace aulease.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AuleaseEntities : DbContext
    {
        public AuleaseEntities()
            : base("name=AuleaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BillingCoordinator> BillingCoordinators { get; set; }
        public DbSet<Charge> Charges { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Lease> Leases { get; set; }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Overhead> Overheads { get; set; }
        public DbSet<PO> POes { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Repair> Repairs { get; set; }
        public DbSet<Signature> Signatures { get; set; }
        public DbSet<SingleCharge> SingleCharges { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<VendorEmail> VendorEmails { get; set; }
        public DbSet<VendorRate> VendorRates { get; set; }
        public DbSet<StandardComponent> StandardComponents { get; set; }
        public DbSet<Tax> Taxes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<SystemGroup> SystemGroups { get; set; }
        public DbSet<StandardOptionStandardComponent> StandardOptionStandardComponents { get; set; }
        public DbSet<StandardOption> StandardOptions { get; set; }
    }
}
