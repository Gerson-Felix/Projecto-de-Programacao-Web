using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vitty.Startup))]
namespace Vitty
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
