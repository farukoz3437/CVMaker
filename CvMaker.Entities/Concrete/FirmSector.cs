using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class FirmSector:IEntity
    {
        [Key]
        public int FirmSectorId { get; set; }
        public string FirmSectorName { get; set; }

        public int UserFirmId { get; set; }

        public UserFirm UserFirm { get; set; }
        public virtual ICollection<WorkAreaFirmSector> WorkAreaFirmSectors { get; set; }
    }
}
