using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class User : IEntity
    {
        [Key]
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual Address Address { get; set; }

        public virtual UserInformation UserInformation { get; set; }

        public virtual OtherInformation OtherInformation { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual UserHighschool UserHighschool { get; set; }

        public virtual ICollection<DriverLisance> DriverLisances { get; set; }

        public virtual ICollection<UserUniversity> UserUniversities { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }

        public virtual ICollection<Certificate> Certificates { get; set; }

        public virtual ICollection<Reference> References { get; set; }

        public virtual ICollection<UserLanguageStatus> UserLanguageStatuses { get; set; }

        public virtual ICollection<NationalityUser> NationalityUsers { get; set; }

        public virtual ICollection<WorkHistory> WorkHistories { get; set; }

    }
}
