using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IIW.Startup))]
namespace IIW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
