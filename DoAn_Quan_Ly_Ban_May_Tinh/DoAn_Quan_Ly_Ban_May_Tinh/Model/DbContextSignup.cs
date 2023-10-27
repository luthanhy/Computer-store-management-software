using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoAn_Quan_Ly_Ban_May_Tinh
{
    public partial class DbContextSignup : DbContext
    {
        public DbContextSignup()
            : base("name=DbContextSignup")
        {
        }

         public virtual DbSet<AcountSignUp> AcountSignUps { get; set; }
         protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
