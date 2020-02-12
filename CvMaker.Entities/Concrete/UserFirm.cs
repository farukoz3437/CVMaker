using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class UserFirm:IEntity
    {
        [Key]
        public int UserFirmId { get; set; }
        public string UserFirmName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Position { get; set; }
    }
}
