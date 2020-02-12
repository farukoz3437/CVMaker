using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class Nationality:IEntity
    {
        [Key]
        public int NationalityId { get; set; }
        public string CountryName { get; set; }

        public int UserInformationId { get; set; }
        public virtual UserInformation UserInformation { get; set; }
    }
}
