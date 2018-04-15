using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AtAspNet2.Startup))]
namespace AtAspNet2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
