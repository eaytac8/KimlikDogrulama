using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KimlikDogrulama.Startup))]
namespace KimlikDogrulama
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
