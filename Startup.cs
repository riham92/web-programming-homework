using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Amjad_AWP.Startup))]
namespace Amjad_AWP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
