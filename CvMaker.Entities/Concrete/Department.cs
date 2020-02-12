using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class Department:IEntity
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public int FacultyId { get; set; }
        public virtual Faculty Faculty { get; set; }
    }
}
