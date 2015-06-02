using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BITS.Startup))]
namespace BITS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
