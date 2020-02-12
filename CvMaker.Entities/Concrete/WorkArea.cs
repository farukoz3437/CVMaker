using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class WorkArea:IEntity //İş alanı
    {
        [Key]
        public int WorkAreaId{ get; set; }
        public int WorkAreaName{ get; set; }
    }
}
