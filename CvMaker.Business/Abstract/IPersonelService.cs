using CvMaker.Core.Utilities.Result;
using CvMaker.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CvMaker.Business.Abstract
{
    public interface IPersonelService
    {
        IDataResult<Personel> GetById(int personelId);
        IDataResult<List<Personel>> GetList();
        IDataResult<List<Personel>> GetListByPersonelName(string personelName);
        IResult Add(Personel personel);
        IResult Delete(Personel personel);
        IResult Update(Personel personel);
    }
}
