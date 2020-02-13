using System;
using System.Collections.Generic;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class FirmSectorWorkArea
    {
        public int FirmSectorId { get; set; }
        public FirmSector FirmSector { get; set; }

        public int WorkAreaId { get; set; }
        public WorkArea WorkArea { get; set; }
    }
}
