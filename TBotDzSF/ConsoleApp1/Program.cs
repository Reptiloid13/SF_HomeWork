using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text;
using Telegram.Bot;
using System.Threading.Tasks;
using System;

namespace TBotDZ;

public class Program
{
    public static async Task Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        //Объект отвечаю за постоянный железный цикл приложения 

        var host = new HostBuilder().ConfigureServices((hostContext, services) => ConfigureServices(services))
            .UseConsoleLifetime()
            .Build();

        Console.WriteLine("Starting service");

        await host.RunAsync();

        Console.WriteLine("Service stopped");
    }

    static void ConfigureServices(IServiceCollection services)
    {
        // Регистрируем объект TelegramClient с токеном подключения

        services.AddSingleton<ITelegramBotClient>(provide => new TelegramBotClient("8102144811:AAF9-nUWAENxJlPU0DtIcYssMREce3kePws"));
        //Регистрируем постоянно активный сервис бота 
        services.AddHostedService<Bot>();

    }
}
