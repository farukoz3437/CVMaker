using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class District:IEntity
    {
        [Key]
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }

        public int CityId { get; set; }
        public City  City { get; set; }


    }
}
