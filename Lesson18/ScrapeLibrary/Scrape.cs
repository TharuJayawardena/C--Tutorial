using System;
using System.Net;

namespace ScrapeLibrary
{
    public class Scrape
    {
        private string reply;

        public object File { get; private set; }

        public string ScrapeWebpage(string url)
        {
            return GetWebpage(url);
        }
        public string ScrapeWebPage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }
        public string ScrapeWebPage(string url, string filepath)

        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }
        private string GetWebpage(string url)
        {
            WebClient client = new WebClient();
            string content = client.DownloadString(url);
            content += "Thats All";
            
            return content;

        }                                              
    }
}
