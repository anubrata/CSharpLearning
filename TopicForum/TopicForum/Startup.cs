using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TopicForum.Startup))]
namespace TopicForum
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
