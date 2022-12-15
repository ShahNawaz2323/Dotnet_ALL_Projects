using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyV4.Startup))]
namespace VidlyV4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
