using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class WorkAreaFirmSector : IEntity

    {

        public int WorkAreaId { get; set; }
        public WorkArea WorkArea { get; set; }

        public int FirmSectorId { get; set; }
        public FirmSector FirmSector { get; set; }

    }
}
