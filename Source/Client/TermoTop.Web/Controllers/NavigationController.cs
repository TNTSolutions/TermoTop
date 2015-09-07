namespace TermoTop.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

    using AutoMapper.QueryableExtensions;

    using TermoTop.Data.UnitOfWork;
    using TermoTop.Web.Controllers.Base;

    using DbModel = TermoTop.Data.Models.NavigationItem;
    using IndexViewModel = TermoTop.Web.ViewModels.NavigationItems.NavigationItemViewModel;

    public class NavigationController : BaseEntityController
    {

        public NavigationController(ITermoTopData data)
            : base(data)
        {

        }

        public ActionResult PopulateNavigation()
        {
            var data = GetData<IndexViewModel>().Where(x => x.ParentItemId == null).ToList();

            return PartialView("_MainNavigationPartial", data);
        }

        public ActionResult PopulateNavigationSubItems(IEnumerable<DbModel> collection)
        {
            return PartialView("_MainNavigationSubItemPartial", collection);
        }

        protected override IQueryable<TViewModel> GetData<TViewModel>()
        {
            return this.Data.NavigationItems.All().Project().To<TViewModel>();
        }

        protected override T GetById<T>(object id)
        {
            return this.Data.NavigationItems.GetById(id) as T;
        }
    }
}