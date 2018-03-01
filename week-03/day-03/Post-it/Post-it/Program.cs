using System;

namespace Post_it
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a PostIt a struct that has
            //    a BackgroundColor
            //    a Text on it
            //    a TextColor
            //Create a few example post-it objects:
            //    an orange with blue text: "Idea 1"
            //    a pink with black text: "Awesome"
            //    a yellow with green text: "Superb!"

            PostIt postIt1 = new PostIt("orange", "Idea 1", "blue");
            PostIt postIt2 = new PostIt("pink", "Awesome", "black");
            PostIt postIt3 = new PostIt("yellow", "Superb!", "green");
            
            Console.WriteLine(postIt1.BackgroundColor + ", " + postIt1.Text + ", " + postIt1.TextColor);
            Console.WriteLine(postIt2.BackgroundColor + ", " + postIt2.Text + ", " + postIt2.TextColor);
            Console.WriteLine(postIt3.BackgroundColor + ", " + postIt3.Text + ", " + postIt3.TextColor);
            Console.ReadLine();
        }
    }
}
