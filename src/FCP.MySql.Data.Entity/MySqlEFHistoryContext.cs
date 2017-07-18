using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Migrations.History;

namespace FCP.MySql.Data.Entity
{
    public class MySqlEFHistoryContext : HistoryContext
    {
        internal const int MigrationIdMaxLength = 100;
        internal const int ContextKeyMaxLength = 200;

        public MySqlEFHistoryContext(DbConnection existingConnection, string defaultSchema)
            : base(existingConnection, defaultSchema)
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<HistoryRow>().Property((HistoryRow h) => h.MigrationId).HasMaxLength(MigrationIdMaxLength).IsRequired();
            modelBuilder.Entity<HistoryRow>().Property((HistoryRow h) => h.ContextKey).HasMaxLength(ContextKeyMaxLength).IsRequired();
        }
    }
}
