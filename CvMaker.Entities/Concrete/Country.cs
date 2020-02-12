using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class Country:IEntity
    {
        [Key]
        public int CountryId { get; set; }
        public string CountryName { get; set; }
    }
}
