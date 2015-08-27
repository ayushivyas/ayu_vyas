using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Phone1App.Startup))]
namespace Phone1App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
