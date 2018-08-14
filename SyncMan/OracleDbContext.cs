using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 


namespace SyncMan
{
    public class OracleDbContext : DbContext
    {
        public OracleDbContext()
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("HR");
            Database.SetInitializer<OracleDbContext>(null);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PTMS_SUBJECT>().ToTable("PTMS_SUBJECT");
            modelBuilder.Entity<PIX_SUBJECT>().ToTable("PIX_SUBJECT");
        }

        public DbSet<PTMS_SUBJECT> PTMS_SUBJECTS { get; set; }
        public DbSet<PIX_SUBJECT> PIX_SUBJECTS { get; set; }

    }

    public class PTMS_SUBJECT
    {
        public int ID { get; set; }
        public string NAME { get; set; }
    }

    public class PIX_SUBJECT
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public DateTime CREATE_DT { get; set; }
        public DateTime UPDATE_DT { get; set; }
    }

    public class WEAPON
    {
        public int ID { get; set; }
        public string TYPE { get; set; }
        public int SUBJECT_ID { get; set; }
    }
}
