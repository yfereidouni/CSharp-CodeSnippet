using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.Fundamentals.DAL
{
    public class PersonDb : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ///Connection String Examples
            ///<seealso cref="https://www.connectionstrings.com/sql-server/"/>
            ///<example>
            ///Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;
            ///Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;
            ///Server=myServerName\myInstanceName;Database=myDataBase;User Id=myUsername;Password=myPassword;
            ///Server=myServerName,myPortNumber;Database=myDataBase;User Id=myUsername;Password=myPassword;
            ///</example>
            
            optionsBuilder.UseSqlServer("Server=.;Database=PersonDb;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
