using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(paracosmic.Startup))]
namespace paracosmic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}
