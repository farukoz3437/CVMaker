using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class WorkInformation:IEntity
    {
        [Key]
        public int WorkInformationId { get; set; }
        public string TotalExperience { get; set; } //Toplam deneyim
        public string WorkStatus { get; set; } //Çalışma durumu
        public string MannerOfWork { get; set; } //Çalışma şekli
    }
}
