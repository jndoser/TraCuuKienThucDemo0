using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TraCuuKienThucDemo0.Models
{
    public partial class ContentDB : DbContext
    {
        public ContentDB()
            : base("name=ContentDB1")
        {
        }

        public virtual DbSet<DataAI> DataAIs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
