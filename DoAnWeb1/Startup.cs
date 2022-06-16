using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DoAnWeb1.Startup))]
namespace DoAnWeb1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
