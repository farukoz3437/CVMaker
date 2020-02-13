using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class Certificate:IEntity
    {
        [Key]
        public int CertificateId { get; set; }
        public string CertificateName { get; set; }
        public DateTime CertificateDate { get; set; }
        public string Organization { get; set; } //Alındığı kurum
        public string Description { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
