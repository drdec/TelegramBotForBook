using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBot.Services
{
    public class Host
    {
        private readonly TelegramBotClient _botClient;
        public Action<ITelegramBotClient, Update> Message;

        public Host(string token)
        {
            _botClient = new TelegramBotClient(token);
        }

        public void Start()
        {
            _botClient.StartReceiving(UpdateHandler, ErrorHandler);
        }

        private async Task UpdateHandler(ITelegramBotClient client, Update update, CancellationToken token)
        {
            Console.WriteLine(update.Message.Text);

            Message.Invoke(client, update);
            await Task.CompletedTask;
        }

        private async Task ErrorHandler(ITelegramBotClient client, Exception error, CancellationToken token)
        {
            Console.WriteLine("Ошибка :" + error.Message);
            await Task.CompletedTask; 
        }
    }
}
