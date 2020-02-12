using CvMaker.Core.EntityFramework;
using CvMaker.DataAccess.Abstract;
using CvMaker.DataAccess.Concrete.EntityFramework.Contexts;
using CvMaker.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CvMaker.DataAccess.Concrete.EntityFramework
{
    public class EfPersonelDal: EfEntityRepositoryBase<Personel, CvMakerContext>, IPersonelDal
    {
    }
}
