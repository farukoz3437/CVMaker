using CvMaker.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;


namespace CvMaker.DataAccess.Concrete.EntityFramework.Contexts
{
    public class CvMakerContext:DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Data Source=LAPTOP-5KN4USMR;Initial Catalog=CvMaker;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UniversityFaculty>().HasKey(x => new { x.UniversityId, x.FacultyId});
            modelBuilder.Entity<NationalityUser>().HasOne(x => x.User).WithMany(u => u.NationalityUsers).HasForeignKey(u => u.UserId);
            modelBuilder.Entity<NationalityUser>().HasOne(x => x.Nationality).WithMany(n => n.NationalityUsers).HasForeignKey(n => n.NationalityId);
            modelBuilder.Entity<FirmSectorWorkArea>().HasKey(x => new { x.FirmSectorId, x.WorkAreaId });

           
        }

        public DbSet<Personel> Personels { get; set; } //Deneme amaçlı

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Contact> Contatcts { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DriverLisance> DriverLisances { get; set; }
        public DbSet<UserHighschool> UserHighschools { get; set; }
        public DbSet<UserUniversity> UserUniversities { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<FirmSector> FirmSectors { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<OtherInformation> OtherInformations { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserInformation> UserInformations { get; set; }
        public DbSet<UserLanguageStatus> UserLanguageStatus { get; set; }
        public DbSet<WorkArea> WorkAreas { get; set; }
        public DbSet<WorkHistory> WorkHistories { get; set; }
        public DbSet<UniversityType> UniversityTypes { get; set; }
        public DbSet<District>  Districts { get; set; }



        public DbSet<UniversityFaculty> UniversityFaculties { get; set; }
        public DbSet<NationalityUser> NationalityUsers { get; set; }
        public DbSet<FirmSectorWorkArea> FirmSectorWorkAreas { get; set; }
   
     
    }
}
