﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AppDb_Entities : DbContext
    {
        public AppDb_Entities()
            : base("name=AppDb_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_AgencyMaster> tbl_AgencyMaster { get; set; }
        public virtual DbSet<tbl_App> tbl_App { get; set; }
        public virtual DbSet<tbl_AppAgency> tbl_AppAgency { get; set; }
        public virtual DbSet<tbl_AppDomain> tbl_AppDomain { get; set; }
        public virtual DbSet<tbl_AppRole> tbl_AppRole { get; set; }
        public virtual DbSet<tbl_AppRoleMaster> tbl_AppRoleMaster { get; set; }
        public virtual DbSet<tbl_AppServer> tbl_AppServer { get; set; }
        public virtual DbSet<tbl_AppTech> tbl_AppTech { get; set; }
        public virtual DbSet<tbl_DomainMaster> tbl_DomainMaster { get; set; }
        public virtual DbSet<tbl_Employee> tbl_Employee { get; set; }
        public virtual DbSet<tbl_Server> tbl_Server { get; set; }
        public virtual DbSet<tbl_ServerTypeMaster> tbl_ServerTypeMaster { get; set; }
        public virtual DbSet<tbl_TechnologyMaster> tbl_TechnologyMaster { get; set; }
    }
}
