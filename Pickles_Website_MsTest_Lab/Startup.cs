using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pickles_Website_MsTest_Lab.Startup))]
namespace Pickles_Website_MsTest_Lab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
