using ObsLib;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TelegramBot.Services;

namespace TelegramBot
{
    public class Program
    {
        //private static ITelegramBotClient _botClient;

        //private static ReceiverOptions _receiverOptions;

        public static async Task Main(string[] args)
        {
            var token = "7199513694:AAFovy21eXWzbeIfSFkyahQO8QG41Wjm6KQ";

            var host = new Host(token);
            host.Start();

            host.Message += NewMessage;

            Console.ReadLine();

            //var test = new ObsApi();

            //test.SayHello();

        }
         
        private static async void NewMessage(ITelegramBotClient client, Update update)
        {
            await client.SendTextMessageAsync(update.Message.Chat.Id, "иди нахуй");
        }
    }
}