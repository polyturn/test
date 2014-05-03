using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ravenDB_3U2.Startup))]
namespace ravenDB_3U2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
