using CvMaker.Business.Abstract;
using CvMaker.Core.Utilities.Result;
using CvMaker.DataAccess.Abstract;
using CvMaker.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CvMaker.Business.Concrete
{
    class PersonelManager : IPersonelService
    {
        private IPersonelDal _personelDal;
        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }
        public IResult Add(Personel personel)
        {
            _personelDal.Add(personel);
            return new SuccessResult(message: "Personel başarıyla eklendi");
        }

        public IResult Delete(Personel personel)
        {
            _personelDal.Delete(personel);
            return new SuccessResult(message: "Personel başarıyla silindi");
        }

        public IResult Update(Personel personel)
        {
            _personelDal.Update(personel);
            return new SuccessResult(message: "Personel başarıyla güncellendi");
        }
        public IDataResult<Personel> GetById(int personelId)
        {
            return new SuccessDataResult<Personel>(_personelDal.Get(filter: p => p.PersonelId == personelId));
        }

        public IDataResult<List<Personel>> GetList()
        {
            return new SuccessDataResult<List<Personel>>(_personelDal.GetList().ToList());
        }

        public IDataResult<List<Personel>> GetListByPersonelName(string personelName)
        {
            return new SuccessDataResult<List<Personel>>(_personelDal.GetList(filter: p => p.PersonelName == personelName).ToList());
        }
    }
}
