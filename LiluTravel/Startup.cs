using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LiluTravel.Startup))]
namespace LiluTravel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
