using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class EducationUniversity:IEntity
    {
        [Key]
        public int EducationUniversityId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double LisanceDegree { get; set; }

        public int UniversityTypeId { get; set; }
        public int UniversityId { get; set; }
        public int UserId { get; set; }

        public UniversityType UniversityType { get; set; }
        public University University { get; set; }
        public User User { get; set; }
    }
}


