using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MakeYourStory.Startup))]
namespace MakeYourStory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
