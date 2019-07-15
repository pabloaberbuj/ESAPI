namespace AriaEntities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AriaEntityContext : DbContext
    {
        public AriaEntityContext()
            : base("name=AriaEntityContext")
            
        {
            Database.SetInitializer<AriaEntityContext>(null);
        }

        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PlanSetup> PlanSetups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>()
                .Property(e => e.Transformation)
                .IsFixedLength();

            modelBuilder.Entity<Image>()
                .Property(e => e.VolumeTransformation)
                .IsFixedLength();

            modelBuilder.Entity<Image>()
                .Property(e => e.UserOrigin)
                .IsFixedLength();

            modelBuilder.Entity<Image>()
                .Property(e => e.DisplayTransformation)
                .IsFixedLength();

            modelBuilder.Entity<Image>()
                .Property(e => e.HstryTimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<Image>()
                .HasMany(e => e.Image1)
                .WithOptional(e => e.Image2)
                .HasForeignKey(e => e.GeometricParentSer);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Sex)
                .IsFixedLength();

            modelBuilder.Entity<Patient>()
                .Property(e => e.HstryTimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<PlanSetup>()
                .Property(e => e.HstryTimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<PlanSetup>()
                .Property(e => e.ViewingPlane)
                .IsFixedLength();

            modelBuilder.Entity<PlanSetup>()
                .Property(e => e.ViewingPlaneULCorner)
                .IsFixedLength();

            modelBuilder.Entity<PlanSetup>()
                .Property(e => e.ViewingPlaneLRCorner)
                .IsFixedLength();

            modelBuilder.Entity<PlanSetup>()
                .Property(e => e.TransactionId)
                .IsUnicode(false);
        }
    }
}
