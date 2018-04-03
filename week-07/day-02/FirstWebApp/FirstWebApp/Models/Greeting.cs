namespace FirstWebApp.Models
{
    public class Greeting
    {
        public long Id { get; set; }
        public string Content { get; set; }
        static private int counter;

        public Greeting()
        {
            Id = counter++;
        }

        public Greeting(string content)
        {
            Id = counter++;
            Content = content;
        }
    }
}
