using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LEATS.Startup))]
namespace LEATS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
