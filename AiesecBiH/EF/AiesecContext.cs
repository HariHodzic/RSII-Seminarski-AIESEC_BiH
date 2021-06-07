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
        public DbSet<City> Cities { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventAttendance> EventAttendances { get; set; }
        public DbSet<FileModel> FileModels { get; set; }
        public DbSet<FunctionalField> FunctionalFields { get; set; }
        public DbSet<LocalCommittee> LocalCommittees { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<MemberAccount> MemberAccount { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Task>() <======== Za koristenje Enum-a
            //    .Property(x => x.Priority)
            //    .HasConversion<int>(); 
            //LocalCommittee
            modelBuilder.Entity<LocalCommittee>()
                .HasOne<City>(c => c.City)
                .WithOne()
                .OnDelete(DeleteBehavior.ClientSetNull);
            //Office
            modelBuilder.Entity<Office>()
                .HasOne<LocalCommittee>(l => l.LocalCommittee)
                .WithMany(l => l.Offices)
                .OnDelete(DeleteBehavior.ClientSetNull);

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
            modelBuilder.Entity<Task>()
                .HasOne<Member>(l => l.MemberExecutor)
                .WithMany(x => x.ExecutedTasks)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.FunctionalFieldsSeed();
            modelBuilder.CitySeed();
            modelBuilder.LocalCommitteeSeed();
            modelBuilder.OfficeSeed();
            modelBuilder.RoleSeed();
        }
    }
}
