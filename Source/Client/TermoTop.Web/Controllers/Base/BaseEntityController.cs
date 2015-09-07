namespace TermoTop.Web.Controllers.Base
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using AutoMapper;

    using TermoTop.Data.UnitOfWork;

    public abstract class BaseEntityController : BaseController
    {
        public BaseEntityController(ITermoTopData Data)
            : base(Data)
        {

        }

        protected abstract IQueryable<TViewModel> GetData<TViewModel>() where TViewModel : class;

        protected abstract T GetById<T>(object id) where T : class;

        protected virtual TViewModel GetViewModel<TModel, TViewModel>(object id)
            where TModel : class
            where TViewModel : class
        {
            if (id == null)
            {
                return null;
            }

            var dbModel = this.GetById<TModel>(id);

            if (dbModel == null)
            {
                return null;
            }

            var model = Mapper.Map<TViewModel>(dbModel);

            return model;
        }
    }
}