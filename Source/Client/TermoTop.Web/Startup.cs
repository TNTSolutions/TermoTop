using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TermoTop.Web.Startup))]
namespace TermoTop.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
