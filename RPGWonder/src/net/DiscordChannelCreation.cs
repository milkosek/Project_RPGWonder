using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using Discord.WebSocket;
using Discord;
using System.Threading;

namespace RPGWonder.src.net
{
    internal class DiscordChannelConnection
    {
        private static string token = "Bot MTA2MTYyMTgxMjUwNjY2NTAyMQ.GVilXh.6M7BsjlSL_R8mcNG-lHItfPo2Lzj4Xi9kn0Tqk";
        private static string tokenForClientVariable = "MTA2MTYyMTgxMjUwNjY2NTAyMQ.GVilXh.6M7BsjlSL_R8mcNG-lHItfPo2Lzj4Xi9kn0Tqk";
        private static DiscordSocketClient _client;
        private static string invite_link = "";
        private static Discord.ITextChannel textChannel;
        
        public static async void LogIntoTextChannel(string message){
            await textChannel.SendMessageAsync(message);
        }

        private static void SetInviteLink(string link) { 
            invite_link = link;
        }

        public static string GetInviteLink() {
            return invite_link;
        }

        private static void SetTextChannelId(string id){
            Thread.Sleep(3000);
            var textChannelId = ulong.Parse(id);
            textChannel = _client.GetChannel(textChannelId) as ITextChannel;
            var w = textChannel;
        }
        public async static void CreateGuildThenChannelThenInviteAndOpen()
        {
            _client = new DiscordSocketClient();
            await _client.LoginAsync(TokenType.Bot, tokenForClientVariable);
            await _client.StartAsync();

            string guild_id = GetGuild();
            var voice_channel_id = GetVoiceChannelId(guild_id);
            CreateChatChannel(guild_id);
            GetAndOpenInvite(voice_channel_id);
        }

        private static string GetGuild()
        {
            HttpWebRequest webRequest1 = (HttpWebRequest)WebRequest.Create("https://discordapp.com/api/guilds");
            webRequest1.Method = "POST";
            webRequest1.Headers.Add("Authorization", token);
            webRequest1.ContentType = "application/json";

            Stream postStream = webRequest1.GetRequestStream();
            var data = Encoding.ASCII.GetBytes("{\"name\": \"RPG_WONDER\"}");
            postStream.Write(data, 0, data.Length);
            postStream.Close();

            string apiResponse1;
            using (HttpWebResponse response1 = webRequest1.GetResponse() as HttpWebResponse)
            {
                StreamReader reader1 = new StreamReader(response1.GetResponseStream());
                apiResponse1 = reader1.ReadToEnd();
            }
            JObject x = JObject.Parse(apiResponse1);

            string guild_id = "";
            foreach (var VARIABLE in x)
            {
                if (VARIABLE.ToString().Substring(1, 2) != "id")
                    continue;
                guild_id = VARIABLE.ToString().TrimEnd(new char[] { '"', ']' }).Substring(5);
                break;
            }
            return (guild_id);
        }

        private static void CreateChatChannel(string guild_id) {
            HttpWebRequest webRequest1 = (HttpWebRequest)WebRequest.Create("https://discordapp.com/api/guilds/" + guild_id.ToString() + "/channels");
            webRequest1.Method = "POST";
            webRequest1.Headers.Add("Authorization", token);
            webRequest1.ContentType = "application/json";

            Stream postStream = webRequest1.GetRequestStream();
            var data = Encoding.ASCII.GetBytes("{\"name\": \"Chatting\"}");
            postStream.Write(data, 0, data.Length);
            postStream.Close();

            string apiResponse1;
            using (HttpWebResponse response1 = webRequest1.GetResponse() as HttpWebResponse)
            {
                StreamReader reader1 = new StreamReader(response1.GetResponseStream());
                apiResponse1 = reader1.ReadToEnd();
            }
            JObject x = JObject.Parse(apiResponse1);
        }

        private static void GetAndOpenInvite(string channel_id)
        {
            HttpWebRequest webRequest1 = (HttpWebRequest)WebRequest.Create("https://discordapp.com/api/channels/" + channel_id + "/invites");
            webRequest1.Method = "POST";
            webRequest1.Headers.Add("Authorization", token);
            webRequest1.ContentType = "application/json";

            Stream postStream = webRequest1.GetRequestStream();
            var data = Encoding.ASCII.GetBytes("{}");
            postStream.Write(data, 0, data.Length);
            postStream.Close();

            string apiResponse1;
            using (HttpWebResponse response1 = webRequest1.GetResponse() as HttpWebResponse)
            {
                StreamReader reader1 = new StreamReader(response1.GetResponseStream());
                apiResponse1 = reader1.ReadToEnd();
            }

            JObject x = JObject.Parse(apiResponse1);
            var code = x.First.ToString().Substring(9, 8);

            SetInviteLink("https://discord.gg/" + code);

            Thread openLinkThread = new Thread(new ThreadStart(() => DiscordChannelConnection.OpenInviteLink(invite_link)));
            openLinkThread.Start();
        }

        private static string GetVoiceChannelId(string guild_id)
        {
            HttpWebRequest webRequest1 =
                (HttpWebRequest)WebRequest.Create("https://discordapp.com/api/guilds/" + guild_id + "/channels");
            webRequest1.Method = "Get";
            webRequest1.ContentLength = 0;
            webRequest1.Headers.Add("Authorization", token);
            webRequest1.ContentType = "application/json";

            string apiResponse1;
            using (HttpWebResponse response1 = webRequest1.GetResponse() as HttpWebResponse)
            {
                StreamReader reader1 = new StreamReader(response1.GetResponseStream());
                apiResponse1 = reader1.ReadToEnd();
            }

            JArray jsonArray = JArray.Parse(apiResponse1);
            string voiceChannelid = "";
            foreach (var jToken in jsonArray)
            {
                foreach (var x in jToken)
                {
                    if (!x.ToString().Substring(1, 4).Equals("type")) continue;
                    if (x.ToString().Substring(8).Equals("2")){
                        voiceChannelid = jToken["id"].ToString();
                    }
                    else if (x.ToString().Substring(8).Equals("0"))
                    {
                        SetTextChannelId(jToken["id"].ToString());
                    }
                }
            }

            return voiceChannelid;
        }

        public static void OpenInviteLink(string link) {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = link,
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }
    }
}