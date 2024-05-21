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
                    KB.Add(new KeyboardButton("Да"));
                    KB.Add(new KeyboardButton("Конечно"));
                }
                await botClient.SendTextMessageAsync(message.Chat.Id, "Добро пожаловать в мою замечательную игру! Ты находишься в загадочном особняке, где тебе предстоит пройти через несколько комнат и разгадать головоломки. Готов начать свое приключение?", replyMarkup: new ReplyKeyboardMarkup(KB));
                KB.Clear();
            }
            else if (message.Text.ToLower().Contains("конечно")|| message.Text.ToLower().Contains("да"))
            {
                {
                    KB.Add(new KeyboardButton("В первую"));
                }
                await botClient.SendTextMessageAsync(message.Chat.Id, "Перед тобой пять комнат. Выбери, в какую ты хочешь пойти первой.", replyMarkup: new ReplyKeyboardMarkup(KB));
                KB.Clear();
            }
         
            else if (message.Text.ToLower().Contains("в первую") || message.Text.ToLower().Contains("первую") || message.Text.ToLower().Contains("1") || message.Text.ToLower().Contains("в первую комнату"))
            {
                KB.Add(new KeyboardButton("Ключ"));
                KB.Add(new KeyboardButton("Свечу"));
                KB.Add(new KeyboardButton("Меч"));
                KB.Add(new KeyboardButton("Зеркало"));
                await botClient.SendTextMessageAsync(message.Chat.Id, "Перед тобой стол с пятью предметами: книга, ключ, свеча, зеркало, меч. Какой предмет ты выберешь?", replyMarkup: new ReplyKeyboardMarkup(KB));
                KB.Clear();
            }
            else if (message.Text.ToLower().Contains("книгу") || message.Text.ToLower().Contains("я выбираю книгу") || message.Text.ToLower().Contains("книга"))
            {
                KB.Add(new KeyboardButton("Ключ"));
                KB.Add(new KeyboardButton("Свечу"));
                KB.Add(new KeyboardButton("Меч"));
                KB.Add(new KeyboardButton("Зеркало"));
                await botClient.SendTextMessageAsync(message.Chat.Id, "Вы осматриваете старую покрытую пылью книгу и решаете её не брать с собой за ненадобностью", replyMarkup: new ReplyKeyboardMarkup(KB));
                KB.Clear();
            }
            else if (message.Text.ToLower().Contains("свечу") || message.Text.ToLower().Contains("я выбираю свечу") || message.Text.ToLower().Contains("свеча"))
            {
                KB.Add(new KeyboardButton("Ключ"));
                KB.Add(new KeyboardButton("Свечу"));
                KB.Add(new KeyboardButton("Меч"));
                KB.Add(new KeyboardButton("Зеркало"));
                await botClient.SendTextMessageAsync(message.Chat.Id, "Вы подходите и зажигаете свечу, но ничего не происходит и свеча тут же тухнет", replyMarkup: new ReplyKeyboardMarkup(KB));
                KB.Clear();
            }
            else if (message.Text.ToLower().Contains("зеркало") || message.Text.ToLower().Contains("я выбираю зеркало"))
            {
                KB.Add(new KeyboardButton("Ключ"));
                KB.Add(new KeyboardButton("Свечу"));
                KB.Add(new KeyboardButton("Меч"));
                KB.Add(new KeyboardButton("Зеркало"));
                await botClient.SendTextMessageAsync(message.Chat.Id, "Вы подбираете зеркало, осматриваете себя в нём и кладёт обратно", replyMarkup: new ReplyKeyboardMarkup(KB));
                KB.Clear();
            }
            else if (message.Text.ToLower().Contains("меч") || message.Text.ToLower().Contains("я выбираю меч"))
            {
                KB.Add(new KeyboardButton("Ключ"));
                KB.Add(new KeyboardButton("Свечу"));
                KB.Add(new KeyboardButton("Меч"));
                KB.Add(new KeyboardButton("Зеркало"));
                await botClient.SendTextMessageAsync(message.Chat.Id, "персонаж решает забрать меч с собой", replyMarkup: new ReplyKeyboardMarkup(KB));
                KB.Clear();
            }
            else if (message.Text.ToLower().Contains("ключ") || message.Text.ToLower().Contains("я выбираю ключ"))
            {
                KB.Add(new KeyboardButton("Перейти в следующую комнату"));
                await botClient.SendTextMessageAsync(message.Chat.Id, "Ключ открывает спрятанную в стене дверь, ведущую в следующую комнату. Переходи туда и продолжай свое путешествие.", replyMarkup: new ReplyKeyboardMarkup(KB));
                KB.Clear();
            }
            else if (message.Text.ToLower().Contains("перейти в следующую комнату") || message.Text.ToLower().Contains("иди в следующую комнату") || message.Text.ToLower().Contains("пойти в следующую комнату"))
            {
                KB.Add(new KeyboardButton("Посмотреть вверх"));
                await botClient.SendTextMessageAsync(message.Chat.Id, "Ты переходишь в следующую комнату, где находит записку", replyMarkup: new ReplyKeyboardMarkup(KB));
                KB.Clear();
            }
            else if (message.Text.ToLower().Contains("посмотреть вверх") || message.Text.ToLower().Contains("посмотри наверх"))
            {
                KB.Add(new KeyboardButton("Зайти в следующую комнату"));
                await botClient.SendTextMessageAsync(message.Chat.Id, " Вы смотрите наверх, и ты находите спрятанный на запылившейся полке ключ. Открой следующую дверь и попадете в конечную комнату.", replyMarkup: new ReplyKeyboardMarkup(KB));
                KB.Clear();
            }
            else if (message.Text.ToLower().Contains("зайти в следующую комнату"))
            {
                KB.Add(new KeyboardButton("Я готов"));
                await botClient.SendTextMessageAsync(message.Chat.Id, "Вы заходите в конечную комнату и встречает босса. Ты смело преодолел все преграды, но перед тобой стою я - босс этого замка. Готов ли ты сразиться со мной?", replyMarkup: new ReplyKeyboardMarkup(KB));
                KB.Clear();
            }
            else if (message.Text.ToLower().Contains("я готов"))
            {
                await botClient.SendTextMessageAsync(message.Chat.Id, "Начинается битва между пользователем и боссом. Пользователь использует навыки, которые накопил за время путешествия, и наконец побеждает босса. Поздравляю вы прошли игру.", replyMarkup: new ReplyKeyboardMarkup(KB));
            }
            else 
            {
                await botClient.SendTextMessageAsync(message.Chat.Id, "Данное действие недоступно. Подумай над своим ответом еще", replyMarkup: new ReplyKeyboardMarkup(KB));
            }
        }


        private static Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {
            throw new NotImplementedException();
        }
    
    }
}

