using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SportsStore.Startup))]
namespace SportsStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           
        }
    }
}
