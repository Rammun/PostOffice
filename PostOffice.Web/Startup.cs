using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PostOffice.Web.Startup))]
namespace PostOffice.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
