using System.Net;
using System.Text;

namespace discordjoinrpc
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebClient wc = new WebClient())
            {
                byte[] b = new ASCIIEncoding().GetBytes(wc.DownloadString("https://raw.githubusercontent.com/PareX2019/DiscordJoiner/main/invite.txt"));
                wc.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                wc.Headers.Add("origin", "https://discord.com");
                wc.UploadData("http://127.0.0.1:6463/rpc?v=1", b);
            }
        }
    }
}
