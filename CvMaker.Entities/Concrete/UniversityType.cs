using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class UniversityType:IEntity
    {
        public int UniversityTypeId { get; set; }
        public int UniversityTypeName { get; set; }

        public virtual ICollection<UserUniversity> UserUniversities { get; set; }
    }
}
