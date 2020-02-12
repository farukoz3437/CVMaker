using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class OtherInformation:IEntity
    {
        [Key]
        public int OtherInformationId { get; set; }
        public string Hobbies { get; set; }
        public string BloodGroup { get; set; }
        public string Smoking { get; set; }
        public string SalaryExpectation { get; set; } //Maaş beklentisi
    }
}
