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
        public int LisanceDegree { get; set; }
    }
}
