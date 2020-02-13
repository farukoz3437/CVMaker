using CvMaker.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class Personel:IEntity
    {
        public int PersonelId { get; set; }
        public string PersonelName { get; set; }
    }
}
