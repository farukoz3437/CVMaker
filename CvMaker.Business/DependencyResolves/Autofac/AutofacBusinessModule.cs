using Autofac;
using CvMaker.Business.Abstract;
using CvMaker.Business.Concrete;
using CvMaker.DataAccess.Abstract;
using CvMaker.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CvMaker.Business.DependencyResolves.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PersonelManager>().As<IPersonelService>();
            builder.RegisterType<EfPersonelDal>().As<IPersonelDal>();
        }


    }
}
