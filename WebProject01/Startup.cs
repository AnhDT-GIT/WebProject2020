using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebProject01.Startup))]
namespace WebProject01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
