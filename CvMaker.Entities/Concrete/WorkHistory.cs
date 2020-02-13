using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class WorkHistory:IEntity
    {
        [Key]
        public int WorkHistoryId { get; set; }
        public string FirmName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Position { get; set; }
        public string MannerOfWork { get; set; } //Çalışma şekli
        public string Description { get; set; }

        public int FirmSectorId { get; set; }
        public virtual FirmSector FirmSector { get; set; }
    }
}
