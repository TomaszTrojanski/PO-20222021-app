using Microsoft.Extensions.Hosting;
using System.Windows;

namespace PO_20222021_app
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost _host;

        public App()
        {
            _host = Host.CreateDefaultBuilder()
                .AddViewModels()
                //.ConfigureServices((hostContext, services) =>
                //{
                //    string connectionString = hostContext.Configuration.GetConnectionString("Default");
                //    //services.AddSingleton<IPromocjeProvider, DatabasePromocjeProvider>();
                //    //services.AddSingleton<IPromocjeCreator, DatabasePromocjeCreator>();
                //    //services.AddSingleton<IPromocjeConflictValidators, DatabasePromocjeConflictValidator>();

                //    services.AddTransient<PromocjaBook>();

                //    string halaName = hostContext.Configuration.GetValue<string>("HalaName");
                //    services.AddSingleton((s) => new Hala(halaName, s.GetRequiredService<Wspolprace>()));

                //    services.AddSingleton<HalaStore>();

                //    services.AddSingleton(s => new MainWindow()
                //    {
                //        DataContext = s.GetRequiredService<MainViewModel>()
                //    });
                //})
                .Build();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            //_host.Dispose();

            base.OnExit(e);
        }
    }
}