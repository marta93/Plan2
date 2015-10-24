using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Plan.Startup))]
namespace Plan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
