using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class City:IEntity
    {
        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }

        public virtual ICollection<District> Districts { get; set; }

    

    }
}
