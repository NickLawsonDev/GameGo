using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameGo.Startup))]
namespace GameGo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
