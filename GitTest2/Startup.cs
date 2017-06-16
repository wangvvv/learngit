using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitTest2.Startup))]
namespace GitTest2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
