using Newtonsoft.Json.Linq;
using System;
using System.Net;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace TelegramBot
{
    class Program
    {
        /// <summary>  
        /// Declare Telegrambot object  
        /// </summary>  
        private static readonly TelegramBotClient bot = new TelegramBotClient("2074885427:AAF95o1RKiLtD64WaTOxFCYYOYKrJe29GRg");
        public static string answer = "";

        /// <summary>  
        /// csharp corner chat bot web hook  
        /// </summary>  
        /// <param name="args"></param>  
        static void Main(string[] args)
        {
            bot.OnMessage += Csharpcornerbotmessage;
            bot.StartReceiving();
            Console.ReadKey();
            bot.StopReceiving();
        }

        /// <summary>  
        /// Handle bot webhook  
        /// </summary>  
        /// <param name="sender"></param>  
        /// <param name="e"></param>  
        private static void Csharpcornerbotmessage(object sender, MessageEventArgs e)
        {
            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
                PrepareQuestionnaires(e);
        }
        public static void PrepareQuestionnaires(MessageEventArgs e)
        {
            if (e.Message.Text.ToLower() == "/q")
            {
                bot.SendTextMessageAsync(e.Message.Chat.Id, getQuestion());
            }
            else if (e.Message.Text.ToLower() == "/a")
                bot.SendTextMessageAsync(e.Message.Chat.Id, answer);
            else if (e.Message.Text.ToLower() == "/ip")
                bot.SendTextMessageAsync(e.Message.Chat.Id, getIP());
            else
            {
                if(e.Message.Text.ToLower() == answer.ToLower())
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "🤩🦾 Correct!");
                else
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "🐖 Wrong, Noob!");
            }
        }

        public static string getQuestion()
        {
            var url = $"https://opentdb.com/api.php?amount=1&category=18&difficulty=easy&type=multiple";
            var webClient = new WebClient();
            string jsonData = "";

            jsonData = webClient.DownloadString(url);

            var jo = JObject.Parse(jsonData);
            var question = jo["results"][0]["question"].ToString();
            answer = jo["results"][0]["correct_answer"].ToString();

            return question;
        }

        public static string getIP()
        {
            var url = $"https://api.myip.com";
            var webClient = new WebClient();
            string jsonData = "";

            jsonData = webClient.DownloadString(url);

            var jo = JObject.Parse(jsonData);
            var ip = jo["ip"].ToString();
            var country = jo["country"].ToString();

            return "🔑 Server IP Address - " + ip + "\n" + "🏠 Country - " + country;
        }

        
    }
}
