using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectsDatabase.Startup))]
namespace ProjectsDatabase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
