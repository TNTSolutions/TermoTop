namespace TermoTop.Web.Controllers.Base
{
    using System.Web.Mvc;

    using TermoTop.Data.UnitOfWork;

    public class BaseController : Controller
    {
        protected ITermoTopData Data { get; private set; }

        public BaseController(ITermoTopData data)
        {
            this.Data = data;
        }
    }
}