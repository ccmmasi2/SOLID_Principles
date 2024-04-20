using Microsoft.Extensions.DependencyInjection;

using _2_Solid_O_Solution.Solution.API.Services;
using _2_Solid_O_Solution.Solution.Data.Repository.Interface;
using _2_Solid_O_Solution.Utils.Notification;
using _2_Solid_O_Solution.Utils.Notification.Base;

public class program
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<ApiNotification>();
        services.AddScoped<HotmailNotification>();

        services.AddScoped<IGeneralNotification>(serviceProvider => serviceProvider.GetService<ApiNotification>());

        services.AddScoped<OrderService>(serviceProvider =>
        {
            var orderRepo = serviceProvider.GetRequiredService<IOrderRepository>();
            var hotmailNotification = serviceProvider.GetRequiredService<HotmailNotification>();
            return new OrderService(orderRepo, new NotificationService(hotmailNotification));
        });

        services.AddScoped<InvoiceService>(serviceProvider =>
        {
            var invoiceRepo = serviceProvider.GetRequiredService<IInvoiceRepository>();
            var apiNotification = serviceProvider.GetRequiredService<ApiNotification>();
            return new InvoiceService(invoiceRepo, new NotificationService(apiNotification));
        });
    }
}
