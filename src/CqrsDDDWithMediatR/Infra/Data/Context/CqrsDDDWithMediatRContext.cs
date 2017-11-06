using CqrsDDDWithMediatR.Domain.Models;
using CqrsDDDWithMediatR.Infra.CrossCutting.Util;
using CqrsDDDWithMediatR.Infra.Data.Context.Mappings;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CqrsDDDWithMediatR.Infra.Data.Context
{
    public sealed class CqrsDDDWithMediatRContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            RemoveConventions(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserMap());

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(Configuration.GetDefaultConnectionString());

        private void RemoveConventions(ModelBuilder modelBuilder)
        {
            #region Remove convention cascade delete

            var cascadeFKs = modelBuilder.Model
                .GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;

            #endregion
        }
    }
}
