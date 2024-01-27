using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(csCommerce.Startup))]
namespace csCommerce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
