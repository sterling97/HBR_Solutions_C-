using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_service.Startup))]
namespace Web_service
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
