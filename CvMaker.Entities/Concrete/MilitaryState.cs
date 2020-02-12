using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class MilitaryState:IEntity
    {
        [Key]
        public int MilitaryStateId { get; set; }
        public string MilitaryStatus { get; set; }
        public DateTime DischargeDate { get; set; }
        public string Description { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
