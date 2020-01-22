using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jg739415MIS4200.Startup))]
namespace jg739415MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
