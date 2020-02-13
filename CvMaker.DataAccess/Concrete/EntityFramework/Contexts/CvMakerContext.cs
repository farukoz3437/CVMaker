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
            modelBuilder.Entity<UniversityFaculty>().HasKey(x => new { x.UniversityId, x.DepartmentId });
            modelBuilder.Entity<WorkAreaFirmSector>().HasKey(wf => new { wf.WorkAreaId, wf.FirmSectorId });
        }

        public DbSet<Personel> Personels { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Contatct> Contatcts { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DriverLisance> DriverLisances { get; set; }
        public DbSet<EducationHighSchool> EducationHighSchools { get; set; }
        public DbSet<EducationUniversity> EducationUniversities { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<FirmSector> FirmSectors { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<MilitaryState> MilitaryStates { get; set; }
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
        public DbSet<UniversityFaculty> UniversityDepartments { get; set; }
        public DbSet<WorkAreaFirmSector> WorkAreaFirmSectors { get; set; }
    }
}
