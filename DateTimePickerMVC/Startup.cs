using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DateTimePickerMVC.Startup))]
namespace DateTimePickerMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
