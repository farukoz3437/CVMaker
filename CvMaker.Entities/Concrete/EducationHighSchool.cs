using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class EducationHighSchool:IEntity
    {
        [Key]
        public int HighschoolId { get; set; }
        public string HighschoolName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int HighschoolDegree { get; set; }
        public string HighschoolDepartment { get; set; }
        public string HighschoolType { get; set; }
    }
}
