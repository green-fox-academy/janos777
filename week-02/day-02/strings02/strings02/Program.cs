using System;

namespace UrlFixer
{
    public class UrlFixer
    {
        public static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";

            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            // Also, the URL is missing a crutial component, find out what it is and insert it too!
            // Try to solve it more than once using different string functions!

            url = url.Replace("https", "https:").Replace("bots", "odds");

            Console.WriteLine(url);


            string url2 = "https//www.reddit.com/r/nevertellmethebots";

            url2 = url2.Insert(5, ":");
            url2 = url2.Remove(url2.Length - 4, 4);

            Console.WriteLine(url2 + "odds");

            Console.ReadLine();
        }
    }
}