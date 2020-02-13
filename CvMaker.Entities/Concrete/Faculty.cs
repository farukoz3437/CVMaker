using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class Faculty:IEntity
    {
        [Key]
        public int FacultyId { get; set; }
        public string FakultyName { get; set; }

        public virtual ICollection<Department> Departments { get; set; }

        public virtual IList<UniversityFaculty> UniversityFaculties { get; set; }

    }
}
