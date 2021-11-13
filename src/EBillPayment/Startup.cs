using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EBillPayment.Startup))]
namespace EBillPayment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
