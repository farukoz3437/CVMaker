using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class Exam:IEntity
    {
        [Key]
        public int ExamId { get; set; }
        public string ExamName { get; set; }
        public string OrganizationName { get; set; } //Sınavı yapan kurum
        public DateTime ExamDate { get; set; } 
        public int ExamDegree { get; set; } 
        public string Description { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
