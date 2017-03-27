using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyWebPage.Startup))]
namespace MyWebPage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
