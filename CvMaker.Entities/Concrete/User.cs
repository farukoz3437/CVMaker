using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class User:IEntity
    {
        [Key]
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

       
        public virtual MilitaryState MilitaryState { get; set; }
        public virtual UserInformation UserInformation { get; set; }
        public virtual ICollection<DriverLisance> DriverLisances { get; set; }
    }
}
