using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sample_1_Youtube.Startup))]
namespace Sample_1_Youtube
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
