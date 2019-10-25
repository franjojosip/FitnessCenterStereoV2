using FitnessCenterStereo.DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FitnessCenterStereo.DAL.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        #region Constructors

        public ApplicationDbContext() : base()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        #endregion Constructors

        #region Properties

        public virtual DbSet<BodyPartType> BodyPartType { get; set; }
        public virtual DbSet<Card> Card { get; set; }
        public virtual DbSet<ComplexityLevelType> ComplexityLevelType { get; set; }
        public virtual DbSet<DietType> DietType { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<ExerciseEquipment> ExerciseEquipment { get; set; }
        public virtual DbSet<Exercises> Exercises { get; set; }
        public virtual DbSet<ExerciseSchedule> ExerciseSchedule { get; set; }
        public virtual DbSet<Membership> Membership { get; set; }
        public virtual DbSet<Plan> Plan { get; set; }
        public virtual DbSet<PlanTrainer> PlanTrainer { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<Step> Step { get; set; }
        public virtual DbSet<Trainer> Trainer { get; set; }

        #endregion Properties

        #region Methods

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasPostgresExtension("pg_buffercache")
                .HasPostgresExtension("pg_stat_statements")
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<BodyPartType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");
            });

            modelBuilder.Entity<Card>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");
            });

            modelBuilder.Entity<PlanTrainer>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("Id_pkey");

                entity.Property(e => e.TrainerId).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");

                ///////FRESH ADDED
                entity.HasKey(sc => new { sc.PlanId, sc.TrainerId });
                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanTrainers)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("PlanTrainer_PlanId_fkey");

                entity.HasOne(d => d.Trainer)
                    .WithMany(p => p.PlanTrainers)
                    .HasForeignKey(d => d.TrainerId)
                    .HasConstraintName("PlanTrainer_TrainerId_fkey");
            });

            modelBuilder.Entity<ComplexityLevelType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");
            });

            modelBuilder.Entity<DietType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");
            });

            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");
            });

            modelBuilder.Entity<ExerciseEquipment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");

                entity.HasKey(sc => new { sc.ExercisesId, sc.EquipmentId });
                ///////FRESH ADDED
                entity.HasOne(d => d.Exercises)
                    .WithMany(p => p.ExerciseEquipment)
                    .HasForeignKey(d => d.ExercisesId)
                    .HasConstraintName("ExerciseEquipment_ExercisesId_fkey");

                entity.HasOne(d => d.Equipment)
                    .WithMany(p => p.ExerciseEquipment)
                    .HasForeignKey(d => d.EquipmentId)
                    .HasConstraintName("ExerciseEquipment_EquipmentId_fkey");
            });

            modelBuilder.Entity<ExerciseSchedule>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");

                entity.HasKey(sc => new { sc.ExercisesId, sc.ScheduleId });
                //FRESH ADDED
                entity.HasOne(d => d.Exercises)
                    .WithMany(p => p.ExerciseSchedule)
                    .HasForeignKey(d => d.ExercisesId)
                    .HasConstraintName("ExerciseSchedule_ExercisesId_fkey");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.ExerciseSchedule)
                    .HasForeignKey(d => d.ScheduleId)
                    .HasConstraintName("ExerciseSchedule_ScheduleId_fkey");
            });

            modelBuilder.Entity<Exercises>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");

                entity.HasOne(d => d.BodyPart)
                    .WithMany(p => p.Exercises)
                    .HasForeignKey(d => d.BodyPartId)
                    .HasConstraintName("Exercises_BodyPartId_fkey");

                entity.HasOne(d => d.ComplexityLeveTypel)
                    .WithMany(p => p.Exercises)
                    .HasForeignKey(d => d.ComplexityLeveTypelId)
                    .HasConstraintName("Exercises_ComplexityLeveTypelId_fkey");
            });

            modelBuilder.Entity<Membership>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");

                entity.Property(e => e.Price).HasColumnType("numeric(5,2)");
            });

            modelBuilder.Entity<Plan>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");

                entity.HasOne(d => d.DietType)
                    .WithMany(p => p.Plan)
                    .HasForeignKey(d => d.DietTypeId)
                    .HasConstraintName("Plan_DietTypeId_fkey");
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("Schedule_PlanId_fkey");
            });

            modelBuilder.Entity<Step>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");

                entity.HasOne(d => d.Exercises)
                    .WithMany(p => p.Step)
                    .HasForeignKey(d => d.ExercisesId)
                    .HasConstraintName("Step_ExercisesId_fkey");
            });

            modelBuilder.Entity<Trainer>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateUpdated).HasColumnType("date");

                entity.Property(e => e.HiredAt).HasColumnType("date");
            });
        }

        #endregion Methods
    }
}