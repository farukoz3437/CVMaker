using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class Language:IEntity
    {
        [Key]
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }

        
        public UserLanguageStatus UserLanguageStatus { get; set; }
    }
}
