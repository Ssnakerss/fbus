using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace fbus.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DbConnection")
            {
            }
        public DbSet<AnswerAttachment> AnswerAttachments { get; set; }
        //public DbSet<AnswerEvent> AnswerEvent { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<fbus.Models.AnswerEvent> AnswerEvents { get; set; }
    }
}