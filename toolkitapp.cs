using System;

namespace toolKitApp
{
    class Entry
    {
        public string url;
        public string name;
        public string key;

        public Entry(string newUrl, string newName, string newKey)
        {
            url = newUrl;
            name = newName;
            key = newKey;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Entry[] Entries = new Entry[]
            {
                new Entry("www.Facebook.com", "facebook", "f" ),
                new Entry("www.Google.com", "google", "g"),
                new Entry("www.Youtube.com", "youtube", "y")
            };
            



                
            Console.WriteLine("type the key you want and press enter!");
            Console.WriteLine("\b");
            Console.WriteLine("options:");

            foreach(Entry entry in Entries)
            {
                Console.WriteLine("\t" + entry.key + "-" + entry.name);
            }

            Console.WriteLine("\n your option...");



            string userInput = Console.ReadLine();

            foreach (Entry entry in Entries)
            {
                if(userInput == entry.key || userInput == entry.name)
                {
                    System.Diagnostics.Process.Start(entry.url);
                }
            }
            

                Console.Read();



        }
    }
}
