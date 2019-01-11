using Microsoft.Owin;
using Owin;
using WebApiIDependency;

[assembly: OwinStartup(typeof(Startup))]

namespace WebApiIDependency
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}