﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeatLab.Models.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BeatLabDBEntities : DbContext
    {
        public BeatLabDBEntities()
            : base("name=BeatLabDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alboms> Alboms { get; set; }
        public virtual DbSet<Chat> Chat { get; set; }
        public virtual DbSet<Comment_Music> Comment_Music { get; set; }
        public virtual DbSet<Comment_Plugin> Comment_Plugin { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<Format_Plugin> Format_Plugin { get; set; }
        public virtual DbSet<Genere_Of_Music> Genere_Of_Music { get; set; }
        public virtual DbSet<Music> Music { get; set; }
        public virtual DbSet<Order_Music> Order_Music { get; set; }
        public virtual DbSet<Order_Plugin> Order_Plugin { get; set; }
        public virtual DbSet<Plugins> Plugins { get; set; }
        public virtual DbSet<Price_Music> Price_Music { get; set; }
        public virtual DbSet<Price_Plugin> Price_Plugin { get; set; }
        public virtual DbSet<Type_Alboms> Type_Alboms { get; set; }
        public virtual DbSet<Type_Music> Type_Music { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<User_Type> User_Type { get; set; }
    }
}
