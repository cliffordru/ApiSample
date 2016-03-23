using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ApiSample.Startup))]

namespace ApiSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
