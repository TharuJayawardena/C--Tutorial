using System;
using System.IO;
using System.Net;

namespace MyCodeLibrary
{
    public class Scrape
    {
        private string reply;

        public string ScrapeWebpage(string url)
        {
            return GetWebpage(url);
        }
        public string ScrapeWebPage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }
        public string ScrapeWebPage(string url,string filepath)

        {
            WebClient client = new WebClient();
            return client.DownloadString(url);

            File.WriteAllText(filepath, reply);
            return reply;
        }
        private string GetWebpage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);

        }
            }
}
