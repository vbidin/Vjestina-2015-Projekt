using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperSubtitles.Startup))]
namespace SuperSubtitles
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
