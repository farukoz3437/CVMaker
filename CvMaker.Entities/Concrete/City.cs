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
    }
}
