using CMCS.DataAccess;
using System.Configuration;
using System.Data;
using System.Windows;

namespace CMCS
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var connectionString = ConfigurationManager.AppSettings["ConnectionStrings:CMCSConnection"];
            var options = new DbContextOptionsBuilder<CMCSContext>()
                          .UseSqlServer(connectionString)
                          .Options;
            var context = new CMCSContext(options);

            var claimsRepository = new ClaimsRepository(context);
            // You can now use claimsRepository in other parts of your application
        }
    }

}
