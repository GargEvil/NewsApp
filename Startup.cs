using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using NewsApp.Models;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewsApp.Startup))]
namespace NewsApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            
        }

       
    }
}
