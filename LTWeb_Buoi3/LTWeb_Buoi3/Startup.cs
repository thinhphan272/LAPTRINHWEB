using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LTWeb_Buoi3.Startup))]
namespace LTWeb_Buoi3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
