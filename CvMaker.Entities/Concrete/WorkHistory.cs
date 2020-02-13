using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class WorkHistory:IEntity
    {
        public int WorkHistoryId { get; set; }
        public string FirmName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Title { get; set; }
        public string MannerOfWork { get; set; }
        public string Description { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
