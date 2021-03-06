using Newtonsoft.Json.Linq;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Xml;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBot
{
    class Program
    {
        /// <summary>  
        /// Declare Telegrambot object  
        /// </summary>  
        private static readonly TelegramBotClient bot = new TelegramBotClient("2074885427:AAF95o1RKiLtD64WaTOxFCYYOYKrJe29GRg");
        public static string answer = "";
        public static string s1 = "";
        public static string s2 = "";
        public static string s3 = "";
        public static string s4 = "";

        /// <summary>  
        /// csharp corner chat bot web hook  
        /// </summary>  
        /// <param name="args"></param>  
        static void Main(string[] args)
        {
            bot.OnMessage += Csharpcornerbotmessage;
            bot.StartReceiving();

            //Console.WriteLine("     ");
            //Console.WriteLine("    (\\____/)");
            //Console.WriteLine("     (_oo_)");
            //Console.WriteLine("       (O)");
            //Console.WriteLine("     __||__    \\)");
            //Console.WriteLine("  []/______\\[] /");
            //Console.WriteLine("  / \\______/ \\/");
            //Console.WriteLine(" /    /__\\");
            //Console.WriteLine("(\\   /____\\");

            //Console.WriteLine("                                         |");
            //Console.WriteLine("                                         |");
            //Console.WriteLine("                                         |");
            //Console.WriteLine("                                         |");
            //Console.WriteLine("   _______                   ________    |");
            //Console.WriteLine("  |ooooooo|      ____       | __  __ |   |");
            //Console.WriteLine("  |[]+++[]|     [____]      |/  \\/  \\|   |");
            //Console.WriteLine("  |+ ___ +|     ]()()[      |\\__/\\__/|   |");
            //Console.WriteLine("  |:|   |:|   ___\\__/___    |[][][][]|   |");
            //Console.WriteLine("  |:|___|:|  |__|    |__|   |++++++++|   |");
            //Console.WriteLine("  |[]===[]|   |_|_/\\_|_|    | ______ |   |");
            //Console.WriteLine("_ ||||||||| _ | | __ | | __ ||______|| __|");
            //Console.WriteLine("  |_______|   |_|[::]|_|    |________|   \\");
            //Console.WriteLine("              \\_|_||_|_/                  \\");
            //Console.WriteLine("                |_||_|                     \\");
            //Console.WriteLine("               _|_||_|_                     \\");
            //Console.WriteLine("      ____    |___||___|                     \\");
            //Console.WriteLine("     /  __\\          ____                     \\");
            //Console.WriteLine("     \\( oo          (___ \\                     \\");
            //Console.WriteLine("     _\\_o/           oo~)/");
            //Console.WriteLine("    / \\|/ \\         _\\-_/_");
            //Console.WriteLine("   / / __\\ \\___    / \\|/  \\");
            //Console.WriteLine("   \\ \\|   |__/_)  / /  - \\ \\");
            //Console.WriteLine("    \\/_)  |       \\ \\    /_/");
            //Console.WriteLine("     ||___|        \\/___(_/");
            //Console.WriteLine("     | | |          | |  |");
            //Console.WriteLine("     | | |          | |  |");
            //Console.WriteLine("     |_|_|          |_|__|");
            //Console.WriteLine("     [__)_)        (_(___]");
            //Console.WriteLine("                           ");

            Console.WriteLine("                  ' -, __");
            Console.WriteLine("                 `      `   ,");
            Console.WriteLine("               --'    _,'' - ' ` ");
            Console.WriteLine("                   '         `'");
            Console.WriteLine("             `    /          ,'");
            Console.WriteLine("               `  '--    ,-''");
            Console.WriteLine("                `'`   |   \\");
            Console.WriteLine("                   -  \\, |");
            Console.WriteLine("                    `--Y '      ___ ");
            Console.WriteLine("                         \\     L _, \\");
            Console.WriteLine("               _ ,        `    <  <\\                _");
            Console.WriteLine("             ,' '           `, `    | \\            ( `");
            Console.WriteLine("            /, `             `  |     \\`            \\ \\_");
            Console.WriteLine("         ,' ,                _ ,'    ||\\l            )  '' ");
            Console.WriteLine("        , ,'   \\           ,' - `- _,'  |              _ _` ");
            Console.WriteLine("      ,' /      \\ \\        `' ' `--/   | \\          / /     \\");
            Console.WriteLine("     '  /        \\           |\\__ - _ ,'` `        / /     ` ` ");
            Console.WriteLine("    |  '                     `-   -'   |   `-'      / /          ` ");
            Console.WriteLine("    | /           |L__           |    |          / /          `  ` ");
            Console.WriteLine("   , /                           |    |         / /             ` `");
            Console.WriteLine("  / /          ,  ,` _ `-_       |    |  _   ,-' /               ` \\");
            Console.WriteLine(" /             \\'`_/  `-_ \\_,   ,'    ");
            Console.WriteLine("   '          -f    ,'   `    '        \\__ ---'     _    '   '     \\ \\");
            Console.WriteLine("' /          ` '    l      ' /          \\        ,_|/   `   ,'`     L`");
            Console.WriteLine("|'      _ -''` `     \\ _,'  `            \\ ` ___` ''`-   , |    |      | \\");
            Console.WriteLine("||    ,'      `  `    '       _,    _        `  |    `/ '  |   '      |");
            Console.WriteLine("||  ,'          `  ; , ---' ,'       `    `   `-'   -' /_  '    ;_   ||");
            Console.WriteLine("|| '              V      / /           `   | `   ,'   ,' '     !  `  ||");
            Console.WriteLine("||/            _,-------7 '                |  `-'    l         /    `||");
            Console.WriteLine("  |          ,'  -   ,' ||               |  -         `        '     ||");
            Console.WriteLine(" `'        ,'    `' '    |               |    `         '  - '       `'");
            Console.WriteLine("          /      ,'      |               |,'    \\-  _, '/'");
            Console.WriteLine("                /                                \\     ''");
            Console.WriteLine("         `     |         `              /         :_,' '");
            Console.WriteLine("          \\ `   \\   _     ,'-          '         /_ -'");
            Console.WriteLine("           `- __ `,  `'      _ >----''   _  __  /");
            Console.WriteLine("                 '        /''          |  ''   '_");
            Console.WriteLine("               /_| -'\\ ,'              ' '`__'-( \\");
            Console.WriteLine("                 / ,'''\\,'               `/   `- | ' ");

            Console.WriteLine("InfyBot is currently running...");
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

                var buttonItem = new[] { answer, s1, s2, s3 };
                var rnd = new Random();
                string[] MyRandomArray = buttonItem.OrderBy(x => rnd.Next()).ToArray();

                var keyboardMarkup = new ReplyKeyboardMarkup(GetInlineKeyboard(MyRandomArray));

                bot.SendTextMessageAsync(e.Message.Chat.Id, "Choose", replyMarkup: keyboardMarkup);
            }
            else if (e.Message.Text.ToLower() == "/a")
            {
                bot.SendTextMessageAsync(e.Message.Chat.Id, answer);
                answer = "";
            }
            else if (e.Message.Text.ToLower() == "/ip")
            {
                bot.SendTextMessageAsync(e.Message.Chat.Id, e.Message.From.Username + ", \n" + getIP());
                answer = "";
            }
            else if (e.Message.Text.ToLower() == "/help")
            {
                bot.SendTextMessageAsync(e.Message.Chat.Id, "1. /q = Get Question \n2. /a = Get Answer \n3. /ip = Get Server Info");
                answer = "";
            }
            else if (e.Message.Text.ToLower() == "/start")
            {
                bot.SendTextMessageAsync(e.Message.Chat.Id, "Hello " + e.Message.From.Username + "! 😎");
                answer = "";
            }
            else if (e.Message.Text.ToLower() == "/test")
            {
                var buttonItem = new[] { "Test" };
                var keyboardMarkup = new ReplyKeyboardMarkup(GetInlineKeyboard2(buttonItem));

                bot.SendTextMessageAsync(e.Message.Chat.Id, "Test", replyMarkup: keyboardMarkup);
                answer = "";
            }
            else if (e.Message.Text.ToLower() == "/stop")
            {
                ReplyKeyboardRemove remove = new ReplyKeyboardRemove();
                bot.SendTextMessageAsync(e.Message.Chat.Id, "Thank you for playing! 🤪", replyMarkup: remove);
                answer = "";
            }
            else
            {
                if (answer != "")
                {
                    if (e.Message.Text.ToLower() == answer.ToLower())
                    {
                        ReplyKeyboardRemove remove = new ReplyKeyboardRemove();
                        bot.SendTextMessageAsync(e.Message.Chat.Id, "🤩🦾 Correct!");
                        answer = "";

                        var buttonItem = new[] { "/q", "/stop" };
                        var keyboardMarkup = new ReplyKeyboardMarkup(GetInlineKeyboard(buttonItem));
                        bot.SendTextMessageAsync(e.Message.Chat.Id, "Click /q for another question.", replyMarkup: keyboardMarkup);
                    }
                    else
                        bot.SendTextMessageAsync(e.Message.Chat.Id, "🐖 Wrong, Noob!");
                }
                else
                {
                    string reply = sendChat(e.Message.Text);
                    bot.SendTextMessageAsync(e.Message.Chat.Id, reply, replyToMessageId:e.Message.MessageId);
                    answer = "";
                }
            }
        }

        public static string getQuestion()
        {
            //var url = $"https://opentdb.com/api.php?amount=1&category=18&difficulty=easy&type=multiple";
            var url = $"https://opentdb.com/api.php?amount=1&type=multiple";
            var webClient = new WebClient();
            string jsonData = "";

            jsonData = webClient.DownloadString(url);

            var jo = JObject.Parse(jsonData);
            var question = jo["results"][0]["question"].ToString();
            answer = jo["results"][0]["correct_answer"].ToString();
            s1 = jo["results"][0]["incorrect_answers"][0].ToString();
            s2 = jo["results"][0]["incorrect_answers"][1].ToString();
            s3 = jo["results"][0]["incorrect_answers"][2].ToString();

            return question;
        }

        private static KeyboardButton[][] GetInlineKeyboard(string[] stringArray)
        {
            var keyboardInline = new KeyboardButton[1][];
            var keyboardButtons = new KeyboardButton[stringArray.Length];
            for (var i = 0; i < stringArray.Length; i++)
            {
                keyboardButtons[i] = new KeyboardButton
                {
                    Text = stringArray[i]
                };
            }
            keyboardInline[0] = keyboardButtons;
            return keyboardInline;
        }

        private static KeyboardButton[][] GetInlineKeyboard2(string[] stringArray)
        {
            var keyboardInline = new KeyboardButton[1][];
            var keyboardButtons = new KeyboardButton[stringArray.Length];
            for (var i = 0; i < stringArray.Length; i++)
            {
                keyboardButtons[i] = new KeyboardButton
                {
                    Text = stringArray[i],
                    RequestContact = true
                };
            }
            keyboardInline[0] = keyboardButtons;
            return keyboardInline;
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

        public static string sendChat(string chat)
        {
            string res = checkBadWord(chat);
            if (res.Contains("*"))
                return "🙄";

            //Get new application id from https://www.botlibre.com/api-test.jsp
            var url = $"https://www.botlibre.com/rest/api/form-chat?&application=4289096168448888538&instance=165&message=" + chat;
            var webClient = new WebClient();
            string jsonData = "";
            string reply = "";

            try
            {
                jsonData = webClient.DownloadString(url);
            }
            catch (Exception ex)
            {
                return "🙄";
            }

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(jsonData);
            XmlNode node = doc.DocumentElement.SelectSingleNode("/response");
            reply = node.InnerText;

            return reply;
        }

        public static string checkBadWord(string chat)
        {
            var url = $"https://www.purgomalum.com/service/xml?text=" + chat;
            var webClient = new WebClient();
            string jsonData = "";
            string response = "";

            jsonData = webClient.DownloadString(url);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(jsonData);
            response = doc.InnerText;

            return response;
        }

    }
}
