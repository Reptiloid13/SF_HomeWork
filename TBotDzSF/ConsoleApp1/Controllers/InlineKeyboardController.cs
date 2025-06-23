using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace TBotDZ.Controllers;

public class InlineKeyboardController
{
    private readonly IStorage _memoryStorage;
    private readonly ITelegramBotClient _telegramClient;


    public InlineKeyboardController(ITelegramBotClient telegramBotClient, IStorage memoryStorage)
    {
        _telegramClient = telegramBotClient;
        _memoryStorage = memoryStorage;
    }

    public async Task Handle(CallbackQuery? callbackQuery, CancellationToken ct)
    {
        Console.WriteLine($"Controller {GetType().Name} detected the button press");

        await _telegramClient.SendMessage(callbackQuery.From.Id, "Detected press button press", cancellationToken: ct);
    }

}
