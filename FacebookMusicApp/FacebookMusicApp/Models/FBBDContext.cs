using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FacebookMusicApp.Models
{
    public class FBBDContext : DbContext
    {
        public FBBDContext()
            : base()
        {

        }
        public DbSet<User> User { get; set; }
        //public DbSet<Rate> Rate { get; set; }
        //public DbSet<Demo> Demo { get; set; }
        //public DbSet<Advert> Advert { get; set; }
        //public DbSet<Comment> Comment { get; set; }
        //public DbSet<Messages> Messages { get; set; }
        //public DbSet<Callendar> Callendar { get; set; }
    }
}