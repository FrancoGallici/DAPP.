using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using DB.Data.Entities;

namespace DB.Data
{
    public partial class DAPPContext : DbContext
    {
        private readonly IConfiguration configuration;

        #region DBSET
        public virtual DbSet<Spells> Spells { get; set; }
        #endregion
    

        #region CONSTRUCTOR
    public DAPPContext()
    {
    }

    public DAPPContext(DbContextOptions<DAPPContext> options, IConfiguration configuration) : base(options)
    {
        this.configuration = configuration;
    }
        #endregion

        #region METODOS
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
                //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=RN77;Trusted_Connection=True;MultipleActiveResultSets=true;");
                optionsBuilder.UseSqlServer(this.configuration.GetConnectionString("DAPPConnection"));

            }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

        var cascadeFKs = modelBuilder.Model
                            .G­etEntityTypes()
                            .SelectMany(t => t.GetForeignKeys())
                            .Where(fk => !fk.IsOwnership
                                         && (fk.DeleteBehavior == DeleteBehavior.Casca­de
                                         || fk.DeleteBehavior == DeleteBehavior.SetNull));

            #region Spells
            modelBuilder.Entity<Spells>(entity =>
            {


                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false);


                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Casting_Time)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Components)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(d => d.Duration)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Level)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Range)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.School)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
            #endregion

            foreach (var fk in cascadeFKs)
        {
            fk.DeleteBehavior = DeleteBehavior.Restr­ict;
        }

        base.OnModelCreating(modelBuilder);

        //OnModelCreatingExtension.Seed(modelBuilder); //uses the extension class to seed the db
    }
    #endregion

}
}