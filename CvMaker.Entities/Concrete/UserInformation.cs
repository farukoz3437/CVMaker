using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class UserInformation:IEntity
    {
        [Key]
        public int UserInformationId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public int IdentificationNumber { get; set; }
        public string Title { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public string BirthPlace { get; set; }
        public DateTime BirthDate { get; set; }
        public string DisabilitySituation { get; set; }
        public string MilitaryStatus { get; set; }
        public string DischargeDate { get; set; }
        public string TotalExperience { get; set; }
        public string WorkState { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

 

    }
}
