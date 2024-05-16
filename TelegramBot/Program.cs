using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

class Program
{
    // Введите сюда ваш токен от BotFather
    private static readonly string BotToken = "7199513694:AAFovy21eXWzbeIfSFkyahQO8QG41Wjm6KQ";
    private static readonly TelegramBotClient BotClient = new TelegramBotClient(BotToken);

    static async Task Main(string[] args)
    {
        using var cts = new CancellationTokenSource();
        var receiverOptions = new ReceiverOptions
        {
            AllowedUpdates = Array.Empty<UpdateType>() // Получать все типы обновлений
        };

        BotClient.StartReceiving(
            HandleUpdateAsync,
            HandleErrorAsync,
            receiverOptions,
            cancellationToken: cts.Token
        );

        var me = await BotClient.GetMeAsync();
        Console.WriteLine($"Начал прослушивание @{me.Username}");
        Console.WriteLine("Нажмите любую клавишу для завершения");
        Console.ReadKey();

        // Остановить бота при завершении работы
        cts.Cancel();
    }

    private static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        // Обработка только сообщений
        if (update.Type != UpdateType.Message)
            return;

        var message = update.Message;
        if (message.Type != MessageType.Text)
            return;

        Console.WriteLine($"Получено сообщение от {message.From.Username}: {message.Text}");

        // Ответ на сообщение
        await botClient.SendTextMessageAsync(
            chatId: message.Chat.Id,
            text: $"Вы сказали: {message.Text}",
            cancellationToken: cancellationToken
        );
    }

    private static Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
    {
        var errorMessage = exception switch
        {
            ApiRequestException apiRequestException
                => $"Ошибка телеграм API:\n{apiRequestException.ErrorCode}\n{apiRequestException.Message}",
            _ => exception.ToString()
        };

        Console.WriteLine(errorMessage);
        return Task.CompletedTask;
    }
}
