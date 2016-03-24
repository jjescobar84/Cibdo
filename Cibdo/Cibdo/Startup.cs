using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cibdo.Startup))]
namespace Cibdo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
