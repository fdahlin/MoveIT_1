using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoveIT_1.Startup))]
namespace MoveIT_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
