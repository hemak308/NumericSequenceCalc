using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NumericSequenceCalc.Startup))]
namespace NumericSequenceCalc
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
