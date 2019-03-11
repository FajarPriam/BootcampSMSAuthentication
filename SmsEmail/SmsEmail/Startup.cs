using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmsEmail.Startup))]
namespace SmsEmail
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
