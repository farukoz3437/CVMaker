using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class Reference:IEntity
    {
        [Key]
        public int ReferenceId { get; set; }
        public string ReferenceType { get; set; }
        public string ReferenceNameSurname { get; set; }
        public string WorkOrganization { get; set; } //Çalıştığı kurum
        public string Pozition { get; set; }
        public string EPosta { get; set; }
        public int PhoneNumber { get; set; }
    }
}
