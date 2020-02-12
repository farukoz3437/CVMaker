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
        public string PlaceOfBirth { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string DisabilitySituation { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<Nationality> Nationalities { get; set; }

    }
}
