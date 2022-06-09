using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PO_20222021_app.ViewModels;
using System;

namespace PO_20222021_app
{
    public static class AddViewModelsHostBuilderExtensions
    {
        public static IHostBuilder AddViewModels(this IHostBuilder hostBuilder)
        {
            hostBuilder.ConfigureServices(services =>
            {
                services.AddTransient((s) => CreateReservationListingViewModel(s));
                services.AddSingleton<Func<PromocjeListingViewModel>>((s) => () => s.GetRequiredService<PromocjeListingViewModel>());

                services.AddTransient<MakePromocjeViewModel>();
                services.AddSingleton<Func<MakePromocjeViewModel>>((s) => () => s.GetRequiredService<MakePromocjeViewModel>());

                services.AddSingleton<MainViewModel>();
            });

            return hostBuilder;
        }

        private static PromocjeListingViewModel CreateReservationListingViewModel(IServiceProvider services)
        {
            return PromocjeListingViewModel.LoadViewModel(
                services.GetRequiredService<HalaStore>());
        }
    }
}