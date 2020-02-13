using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class Contact:IEntity
    {
        [Key]
        public int ContatctId { get; set; }
        public int CellPhone { get; set; }
        public int HomePhone { get; set; }
        public string WebAddress { get; set; }
        public string LinkedinAddress { get; set; }
        public string EPostaAddress { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
