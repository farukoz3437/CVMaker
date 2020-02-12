using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class Address:IEntity
    {
        [Key]
        public int AddressId { get; set; }
        public string AddressName { get; set; }
        public int PostaCode { get; set; }
    }
}
