using System;
using System.Collections.Generic;
using System.Text;

namespace CvMaker.Entities.Concrete
{
    public class NationalityUser
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int NationalityId { get; set; }
        public Nationality Nationality { get; set; }

    }
}
