using System.IO;
using System.Net;

namespace WebSockets
{
    // this is working, just create a new web hook endpoint and update the url here.
    public class SendMessageToWebHook
    {
        private string url = "https://webhook.site/63451a4c-0671-4df0-b236-b02ff1a23d27";

        public void SendMessage(string json)
        {
            var wr = WebRequest.Create(url);
            wr.ContentType = "application/json";
            wr.Method = "POST";
            using (var sw = new StreamWriter(wr.GetRequestStream()))
                sw.Write(json);
            wr.GetResponse();
        }
    }
}