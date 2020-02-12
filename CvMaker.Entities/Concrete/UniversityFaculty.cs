using System;
using System.Collections.Generic;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class UniversityFaculty
    {
        public int UniversityId { get; set; }
        public University University { get; set; }
        public int DepartmentId { get; set; }
        public Faculty Faculty { get; set; }
    }
}
