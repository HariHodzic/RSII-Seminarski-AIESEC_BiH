using System;
using System.Collections.Generic;
using System.Text;
using AiesecBiH.Database;
using Microsoft.EntityFrameworkCore;

namespace AiesecBiH.EF
{
    public class AiesecContext: DbContext
    {
        public AiesecContext(DbContextOptions<AiesecContext> options):base(options)
        {
        }
        //public DbSet<City> Cities { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventAttendance> EventAttendances { get; set; }
        public DbSet<FileModel> FileModels { get; set; }
        public DbSet<FunctionalField> FunctionalFields { get; set; }
        public DbSet<LocalCommittee> LocalCommittees { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Notice> Notices { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Member>(entity => {
                entity.HasIndex(e => e.EmailAddress).IsUnique();
            });

            //Office
            modelBuilder.Entity<Office>()
                .HasOne<LocalCommittee>(l => l.LocalCommittee)
                .WithMany(l => l.Offices)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Member>()
                .HasOne<FunctionalField>(x => x.FunctionalField)
                .WithMany(x =>x.Members)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<FunctionalField>()
              .HasMany<Member>(x => x.Members)
              .WithOne(x => x.FunctionalField)
              .OnDelete(DeleteBehavior.Cascade);


            //Event
            modelBuilder.Entity<Event>()
                .HasOne<LocalCommittee>(l => l.LocalCommittee)
                .WithMany(x => x.Events)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Event>()
                .HasOne<FunctionalField>(l => l.FunctionalField)
                .WithMany(x=>x.Events)
                .OnDelete(DeleteBehavior.NoAction);

            //Task
            modelBuilder.Entity<Task>()
                .HasOne<Member>(l => l.MemberCreator)
                .WithMany(x => x.CreatedTasks)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Member>()
                .HasOne(l => l.FunctionalField)
                .WithMany(x => x.Members)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Member>()
                .HasOne(l => l.LocalCommittee)
                .WithMany(x => x.Members)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.FunctionalFieldsSeed();
            modelBuilder.LocalCommitteeSeed();
            modelBuilder.OfficeSeed();
            modelBuilder.RoleSeed();
            modelBuilder.MembersSeed();
            modelBuilder.NoticeSeed();
            modelBuilder.TasksSeed();
            modelBuilder.EventsSeed();
            modelBuilder.EventAttendanceSeed();

        }

    }
}
