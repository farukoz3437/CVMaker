using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class DriverLisance:IEntity
    {
        [Key]
        public int DriverLisanceId { get; set; }
        public string DriverLisanceClass { get; set; }
        public DateTime DriverLisanceDate { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
