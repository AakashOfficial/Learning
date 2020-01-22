using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Demo_App.Startup))]
namespace MVC_Demo_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
