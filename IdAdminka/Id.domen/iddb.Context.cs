﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Id.domen
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class iddata : DbContext
    {
        public iddata()
            : base("name=iddata")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Banks> Banks { get; set; }
        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<Curencies> Curencies { get; set; }
        public virtual DbSet<Currencies> Currencies { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Details> Details { get; set; }
        public virtual DbSet<GoodsImages> GoodsImages { get; set; }
        public virtual DbSet<Menus> Menus { get; set; }
        public virtual DbSet<MesureUnits> MesureUnits { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Prices> Prices { get; set; }
        public virtual DbSet<ProdMenuImages> ProdMenuImages { get; set; }
        public virtual DbSet<ProductMenuItems> ProductMenuItems { get; set; }
        public virtual DbSet<ProductMenus> ProductMenus { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Telephones> Telephones { get; set; }
        public virtual DbSet<UserPhotoes> UserPhotoes { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsrRoles> UsrRoles { get; set; }
        public virtual DbSet<Vendors> Vendors { get; set; }
    }
}