using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(devsolution.Startup))]
namespace devsolution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
