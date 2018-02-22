using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureDemo.Startup))]
namespace AzureDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
