using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RelatoriosTags.Startup))]
namespace RelatoriosTags
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
