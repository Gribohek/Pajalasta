using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Aspose.Cells;
using Aspose.Cells.Rendering;
using System.IO;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {
            var client = new TelegramBotClient("6416658489:AAGeYQiBlN9M7RMtrUQlbmjtC6F1CoAm59E");
            client.StartReceiving(Update, Error);
            Console.ReadLine();

        }
        async static Task Update(ITelegramBotClient botClient, Update update, CancellationToken arg3)
        {
            var message = update.Message;
            var KB = new List<KeyboardButton>();

            if (message.Text.ToLower().Contains("start"))
            {
                {
                    KB.Add(new KeyboardButton("Гойда"));
                    KB.Add(new KeyboardButton("Пиво пить :D"));
                }
                await botClient.SendTextMessageAsync(message.Chat.Id, "Добро пожаловать в игру Лабиринт проклятых душ, для начала игры напишите гойда", replyMarkup: new ReplyKeyboardMarkup(KB));
                KB.Clear();
            }
            else if (message.Text.ToLower().Contains("гойда"))
            {
                {
                    KB.Add(new KeyboardButton("ЗА ПУТИНА!!!!!!!!!!!!!!!!"));
                    KB.Add(new KeyboardButton("Я ХОЧУ, НА СВО"));
                }
                await botClient.SendTextMessageAsync(message.Chat.Id, "Ты просыпаешся в темном и запутанном лабиринте, ощущая сильное беспокойство и страх. У тебя нет никаких воспоминаний о том, кто ты такой и как зддесь оказался. Вокруг тебя стены лабиринта, выглядящие совершенно непроницаемыми, но на них видны странные символы и вырезанные пазлы.", replyMarkup: new ReplyKeyboardMarkup(KB));

            }
            else
            {
                await botClient.SendTextMessageAsync(message.Chat.Id,"Ебанько?", replyMarkup: new ReplyKeyboardMarkup(KB));

            }

        }


        private static Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {
            throw new NotImplementedException();
        }
    
    }
}

