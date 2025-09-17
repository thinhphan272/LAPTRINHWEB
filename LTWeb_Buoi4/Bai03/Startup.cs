using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bai03.Startup))]
namespace Bai03
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
