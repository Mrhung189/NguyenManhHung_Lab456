using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenManhHung_Lab456.Startup))]
namespace NguyenManhHung_Lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
