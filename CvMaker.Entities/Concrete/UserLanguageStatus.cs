using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class UserLanguageStatus:IEntity
    {
        [Key]
        public int UserLanguageStatusId { get; set; }
        public string Speaking { get; set; }
        public string Reading { get; set; }
        public string Writing { get; set; }

        public int UserId { get; set; }
        public int LanguageId { get; set; }

        public User User { get; set; }
        public Language Language { get; set; }
    }
}
