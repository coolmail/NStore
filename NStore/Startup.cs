using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NStore.Startup))]
namespace NStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
