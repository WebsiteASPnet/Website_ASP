using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Website_DienThoai.Startup))]
namespace Website_DienThoai
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
