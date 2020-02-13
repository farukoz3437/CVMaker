using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class UserHighschool:IEntity
    {
        [Key]
        public int UserHighschoolId { get; set; }
        public string HighschoolName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double HighschoolDegree { get; set; }
        public string HighschoolDepartment { get; set; }
        public string HighschoolType { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
