using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Employee.Test.Git.Merge.Startup))]
namespace Employee.Test.Git.Merge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
