using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class Personel : IEntity
    {
        [Key]
        public int PersonelId { get; set; }
        public string PersonelName { get; set; }
        public string PersonelSurname { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }

        public int EducationId { get; set; }
        public int CertificateId { get; set; }
        public int ExperienceId { get; set; }

    }
}
