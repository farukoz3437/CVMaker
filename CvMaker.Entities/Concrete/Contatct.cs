using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class Contatct:IEntity
    {
        [Key]
        public int ContatctId { get; set; }
        public int PhoneNumber { get; set; }
        public int HomePhoneNumber { get; set; }
        public string WebAddress { get; set; }
        public string LinkedinAddress { get; set; }
        public string EPostaAddress { get; set; }
    }
}
