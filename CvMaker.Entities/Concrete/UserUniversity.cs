using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class UserUniversity:IEntity
    {
        [Key]
        public int UserUniversityId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double LisanceDegree { get; set; }

        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int UniversityId { get; set; }
        public virtual University University { get; set; }

        public int UniversityTypeId { get; set; }
        public virtual UniversityType UniversityType { get; set; }


    }
}
