using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmTavsiye.Models.DbModels;

namespace FilmTavsiye.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host = localhost; Database = moviedb; Username = postgres; Password = 123");
        }


        //Initial Data 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>().HasData(
                InitialDataController.GetMemberData()
            );

            modelBuilder.Entity<Constant>().HasData(
                InitialDataController.GetConstantData()
            );

            modelBuilder.Entity<ConstantValue>().HasData(
                InitialDataController.GetConstantValuesData()
            );

            modelBuilder.Entity<MemberRole>().HasData(
                InitialDataController.GetMemberRoleData()
            );
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Constant> Constants { get; set; }
        public DbSet<ConstantValue> ConstantValues { get; set; }
        public DbSet<MemberRole> MemberRoles { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
