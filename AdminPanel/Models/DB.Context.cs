﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminPanel.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AdminPanelDBEntities : DbContext
    {
        public AdminPanelDBEntities()
            : base("name=AdminPanelDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Galeri> tbl_Galeri { get; set; }
        public virtual DbSet<tbl_Icerik> tbl_Icerik { get; set; }
        public virtual DbSet<tbl_Modul> tbl_Modul { get; set; }
        public virtual DbSet<tbl_Dil> tbl_Dil { get; set; }
        public virtual DbSet<tbl_DilCeviri> tbl_DilCeviri { get; set; }
    }
}
