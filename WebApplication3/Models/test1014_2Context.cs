using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication3.Models
{
    public partial class test1014_2Context : DbContext
    {
        public test1014_2Context()
            : base("name=test1014_2")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        public virtual DbSet<Member> Members { get; set; }
    }
}
