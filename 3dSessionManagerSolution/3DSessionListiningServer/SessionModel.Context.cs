﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _3DSessionListiningServer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<instance> instances { get; set; }
        public virtual DbSet<location> locations { get; set; }
        public virtual DbSet<messagelog> messagelogs { get; set; }
        public virtual DbSet<session> sessions { get; set; }
        public virtual DbSet<sessiondata> sessiondatas { get; set; }
        public virtual DbSet<setup> setups { get; set; }
    }
}
