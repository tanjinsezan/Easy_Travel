﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Easy_TravelEntities : DbContext
    {
        public Easy_TravelEntities()
            : base("name=Easy_TravelEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<HotelBooking> HotelBookings { get; set; }
        public DbSet<Inq> Inqs { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<VehicleBooking> VehicleBookings { get; set; }
    }
}