using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
namespace RPGWonder.src.net
{
    internal class DiscordChannelConnection
    {
        private static string token = "Bot MTA2MTYyMTgxMjUwNjY2NTAyMQ.GVilXh.6M7BsjlSL_R8mcNG-lHItfPo2Lzj4Xi9kn0Tqk";

        private static string invite_link = "";
        public static void CreateGuildThenChannelThenInviteAndOpen()
        {
            string guild_id = getGuild();
            var voice_channel_id = getChannel(guild_id);
            get_and_openInvite(voice_channel_id);
        }

        private static string getGuild()
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

            //MessageBox.Show(apiResponse1);
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

        private static void get_and_openInvite(string channel_id)
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

            invite_link = "https://discord.gg/" + code; 
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = invite_link,
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private static string getChannel(string guild_id)
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
            foreach (var jToken in jsonArray)
            {
                foreach (var x in jToken)
                {
                    if (!x.ToString().Substring(1, 4).Equals("type")) continue;
                    if (x.ToString().Substring(8).Equals("2"))
                    {
                        return jToken["id"].ToString();
                    }
                }
            }

            return jsonArray[0]["id"].ToString();
        }
    }
}
