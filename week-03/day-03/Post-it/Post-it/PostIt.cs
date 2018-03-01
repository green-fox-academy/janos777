using System;
using System.Collections.Generic;
using System.Text;

namespace Post_it
{
    public struct PostIt
    {
        public string BackgroundColor;
        public string Text;
        public string TextColor;

        public PostIt(string BackgroundColor, string Text, string TextColor)
        {
            this.BackgroundColor = BackgroundColor;
            this.Text = Text;
            this.TextColor = TextColor;
        }
    }
}
