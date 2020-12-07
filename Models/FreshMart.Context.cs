﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class SuperMarketEntities : DbContext
    {
        public SuperMarketEntities()
            : base("name=SuperMarketEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Account> Account { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Providers> Providers { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<Invoice_detail> Invoice_detail { get; set; }
        public DbSet<Order_Detail> Order_Detail { get; set; }
    
        public virtual int sp_AddCustomer(string name, string gender, Nullable<System.DateTime> birth, string address, string phone, string mail, string temp)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("gender", gender) :
                new ObjectParameter("gender", typeof(string));
    
            var birthParameter = birth.HasValue ?
                new ObjectParameter("birth", birth) :
                new ObjectParameter("birth", typeof(System.DateTime));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("mail", mail) :
                new ObjectParameter("mail", typeof(string));
    
            var tempParameter = temp != null ?
                new ObjectParameter("temp", temp) :
                new ObjectParameter("temp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AddCustomer", nameParameter, genderParameter, birthParameter, addressParameter, phoneParameter, mailParameter, tempParameter);
        }
    
        public virtual int sp_AddEmployee(string name, string gender, Nullable<System.DateTime> birth, string address, string phone, string pass)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("gender", gender) :
                new ObjectParameter("gender", typeof(string));
    
            var birthParameter = birth.HasValue ?
                new ObjectParameter("birth", birth) :
                new ObjectParameter("birth", typeof(System.DateTime));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AddEmployee", nameParameter, genderParameter, birthParameter, addressParameter, phoneParameter, passParameter);
        }
    
        public virtual int sp_AddProduct(string name, string type, string unit, Nullable<decimal> unitprice, Nullable<System.DateTime> mfg, Nullable<System.DateTime> exp)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var typeParameter = type != null ?
                new ObjectParameter("type", type) :
                new ObjectParameter("type", typeof(string));
    
            var unitParameter = unit != null ?
                new ObjectParameter("unit", unit) :
                new ObjectParameter("unit", typeof(string));
    
            var unitpriceParameter = unitprice.HasValue ?
                new ObjectParameter("unitprice", unitprice) :
                new ObjectParameter("unitprice", typeof(decimal));
    
            var mfgParameter = mfg.HasValue ?
                new ObjectParameter("mfg", mfg) :
                new ObjectParameter("mfg", typeof(System.DateTime));
    
            var expParameter = exp.HasValue ?
                new ObjectParameter("exp", exp) :
                new ObjectParameter("exp", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AddProduct", nameParameter, typeParameter, unitParameter, unitpriceParameter, mfgParameter, expParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_NewOrder(string emID, string proID)
        {
            var emIDParameter = emID != null ?
                new ObjectParameter("EmID", emID) :
                new ObjectParameter("EmID", typeof(string));
    
            var proIDParameter = proID != null ?
                new ObjectParameter("ProID", proID) :
                new ObjectParameter("ProID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_NewOrder", emIDParameter, proIDParameter);
        }
    }
}
