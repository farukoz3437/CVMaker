using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class University:IEntity
    {
        [Key]
        public int UniversityId { get; set; }
        public string UniversityName { get; set; }

        public ICollection<UserUniversity> UserUniversities { get; set; }

        public virtual IList<UniversityFaculty> UniversityFaculties { get; set; }

       
    }
}
