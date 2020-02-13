﻿// <auto-generated />
using System;
using CvMaker.DataAccess.Concrete.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CvMaker.DataAccess.Migrations
{
    [DbContext(typeof(CvMakerContext))]
    partial class CvMakerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CvMaker.Entities.Concrete.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int>("PostaCode")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AddressId");

                    b.HasIndex("CountryId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.Certificate", b =>
                {
                    b.Property<int>("CertificateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CertificateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CertificateName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Organization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CertificateId");

                    b.HasIndex("UserId");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.HasKey("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.Contact", b =>
                {
                    b.Property<int>("ContatctId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CellPhone")
                        .HasColumnType("int");

                    b.Property<string>("EPostaAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HomePhone")
                        .HasColumnType("int");

                    b.Property<string>("LinkedinAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("WebAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContatctId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Contatcts");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentId");

                    b.HasIndex("FacultyId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.District", b =>
                {
                    b.Property<int>("DistrictId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("DistrictName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DistrictId");

                    b.HasIndex("CityId");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.DriverLisance", b =>
                {
                    b.Property<int>("DriverLisanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DriverLisanceClass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DriverLisanceDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("DriverLisanceId");

                    b.HasIndex("UserId");

                    b.ToTable("DriverLisances");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.EducationLanguage", b =>
                {
                    b.Property<int>("EducationLanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LanguageName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EducationLanguageId");

                    b.ToTable("EducationLanguages");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.Exam", b =>
                {
                    b.Property<int>("ExamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExamDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExamDegree")
                        .HasColumnType("int");

                    b.Property<string>("ExamName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrganizationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ExamId");

                    b.HasIndex("UserId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.Faculty", b =>
                {
                    b.Property<int>("FacultyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FakultyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FacultyId");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.FirmSector", b =>
                {
                    b.Property<int>("FirmSectorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirmSectorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FirmSectorId");

                    b.ToTable("FirmSectors");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.Language", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LanguageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LanguageId");

                    b.HasIndex("UserId");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.Nationality", b =>
                {
                    b.Property<int>("NationalityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserInformationId")
                        .HasColumnType("int");

                    b.HasKey("NationalityId");

                    b.HasIndex("UserInformationId");

                    b.ToTable("Nationalities");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.OtherInformation", b =>
                {
                    b.Property<int>("OtherInformationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BloodGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hobbies")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalaryExpectation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Smoking")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OtherInformationId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("OtherInformations");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.Personel", b =>
                {
                    b.Property<int>("PersonelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PersonelName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonelId");

                    b.ToTable("Personels");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.Reference", b =>
                {
                    b.Property<int>("ReferenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EPosta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("Pozition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferenceNameSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferenceType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("WorkOrganization")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReferenceId");

                    b.HasIndex("UserId");

                    b.ToTable("References");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.University", b =>
                {
                    b.Property<int>("UniversityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UniversityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UniversityId");

                    b.ToTable("Universities");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.UniversityFaculty", b =>
                {
                    b.Property<int>("UniversityId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int?>("FacultyId")
                        .HasColumnType("int");

                    b.HasKey("UniversityId", "DepartmentId");

                    b.HasIndex("FacultyId");

                    b.ToTable("UniversityFaculties");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.UniversityType", b =>
                {
                    b.Property<int>("UniversityTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UniversityTypeName")
                        .HasColumnType("int");

                    b.HasKey("UniversityTypeId");

                    b.ToTable("UniversityTypes");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.UserHighschool", b =>
                {
                    b.Property<int>("UserHighschoolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("HighschoolDegree")
                        .HasColumnType("float");

                    b.Property<string>("HighschoolDepartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HighschoolName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HighschoolType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserHighschoolId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserHighschools");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.UserInformation", b =>
                {
                    b.Property<int>("UserInformationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BirthPlace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisabilitySituation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DischargeDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdentificationNumber")
                        .HasColumnType("int");

                    b.Property<string>("MaritalStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MilitaryStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalExperience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkState")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserInformationId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserInformations");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.UserLanguage", b =>
                {
                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<int>("UserLanguageStatusId")
                        .HasColumnType("int");

                    b.HasKey("LanguageId", "UserLanguageStatusId");

                    b.HasIndex("UserLanguageStatusId");

                    b.ToTable("UserLanguages");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.UserLanguageStatus", b =>
                {
                    b.Property<int>("UserLanguageStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Reading")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Speaking")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Writing")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserLanguageStatusId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserLanguageStatus");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.UserUniversity", b =>
                {
                    b.Property<int>("UserUniversityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EducationLanguageId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("LisanceDegree")
                        .HasColumnType("float");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UniversityId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserUniversityId");

                    b.HasIndex("EducationLanguageId");

                    b.HasIndex("UniversityId");

                    b.HasIndex("UserId");

                    b.ToTable("UserUniversities");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.WorkArea", b =>
                {
                    b.Property<int>("WorkAreaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("WorkAreaName")
                        .HasColumnType("int");

                    b.HasKey("WorkAreaId");

                    b.ToTable("WorkAreas");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.WorkHistory", b =>
                {
                    b.Property<int>("WorkHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirmName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MannerOfWork")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("WorkHistoryId");

                    b.ToTable("WorkHistories");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.Address", b =>
                {
                    b.HasOne("CvMaker.Entities.Concrete.Country", "Country")
                        .WithMany("Addresses")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CvMaker.Entities.Concrete.User", "User")
                        .WithOne("Address")
                        .HasForeignKey("CvMaker.Entities.Concrete.Address", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.Certificate", b =>
                {
                    b.HasOne("CvMaker.Entities.Concrete.User", "User")
                        .WithMany("Certificates")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.City", b =>
                {
                    b.HasOne("CvMaker.Entities.Concrete.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.Contact", b =>
                {
                    b.HasOne("CvMaker.Entities.Concrete.User", "User")
                        .WithOne("Contact")
                        .HasForeignKey("CvMaker.Entities.Concrete.Contact", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.Department", b =>
                {
                    b.HasOne("CvMaker.Entities.Concrete.Faculty", "Faculty")
                        .WithMany("Departments")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.District", b =>
                {
                    b.HasOne("CvMaker.Entities.Concrete.City", "City")
                        .WithMany("Districts")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.DriverLisance", b =>
                {
                    b.HasOne("CvMaker.Entities.Concrete.User", "User")
                        .WithMany("DriverLisances")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.Exam", b =>
                {
                    b.HasOne("CvMaker.Entities.Concrete.User", "User")
                        .WithMany("Exams")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.Language", b =>
                {
                    b.HasOne("CvMaker.Entities.Concrete.User", null)
                        .WithMany("Languages")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.Nationality", b =>
                {
                    b.HasOne("CvMaker.Entities.Concrete.UserInformation", "UserInformation")
                        .WithMany("Nationalities")
                        .HasForeignKey("UserInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.OtherInformation", b =>
                {
                    b.HasOne("CvMaker.Entities.Concrete.User", "User")
                        .WithOne("OtherInformation")
                        .HasForeignKey("CvMaker.Entities.Concrete.OtherInformation", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.Reference", b =>
                {
                    b.HasOne("CvMaker.Entities.Concrete.User", "User")
                        .WithMany("References")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.UniversityFaculty", b =>
                {
                    b.HasOne("CvMaker.Entities.Concrete.Faculty", "Faculty")
                        .WithMany("UniversityFaculties")
                        .HasForeignKey("FacultyId");

                    b.HasOne("CvMaker.Entities.Concrete.University", "University")
                        .WithMany("UniversityFaculties")
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.UserHighschool", b =>
                {
                    b.HasOne("CvMaker.Entities.Concrete.User", "User")
                        .WithOne("UserHighschool")
                        .HasForeignKey("CvMaker.Entities.Concrete.UserHighschool", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.UserInformation", b =>
                {
                    b.HasOne("CvMaker.Entities.Concrete.User", "User")
                        .WithOne("UserInformation")
                        .HasForeignKey("CvMaker.Entities.Concrete.UserInformation", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.UserLanguage", b =>
                {
                    b.HasOne("CvMaker.Entities.Concrete.Language", "Language")
                        .WithMany("UserLanguages")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CvMaker.Entities.Concrete.UserLanguageStatus", "UserLanguageStatus")
                        .WithMany("UserLanguages")
                        .HasForeignKey("UserLanguageStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.UserLanguageStatus", b =>
                {
                    b.HasOne("CvMaker.Entities.Concrete.User", "User")
                        .WithOne("LanguageStatus")
                        .HasForeignKey("CvMaker.Entities.Concrete.UserLanguageStatus", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CvMaker.Entities.Concrete.UserUniversity", b =>
                {
                    b.HasOne("CvMaker.Entities.Concrete.EducationLanguage", "EducationLanguage")
                        .WithMany("UserUniversities")
                        .HasForeignKey("EducationLanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CvMaker.Entities.Concrete.University", "University")
                        .WithMany("UserUniversities")
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CvMaker.Entities.Concrete.User", "User")
                        .WithMany("UserUniversities")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
