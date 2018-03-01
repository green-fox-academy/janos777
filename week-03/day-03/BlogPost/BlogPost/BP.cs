using System;
using System.Collections.Generic;
using System.Text;

namespace BlogPost
{
    public class BP
    {
        public string AuthorName;
        public string Title;
        public string Text;
        public string PublicationDate;

        public BP(string AuthorName, string Title, string Text, string PublicationDate)
        {
            this.AuthorName = AuthorName;
            this.Title = Title;
            this.Text = Text;
            this.PublicationDate = PublicationDate;
        }

        public string CompleteBlogPost()
        {
            return $"Author: {AuthorName}\nTitle: {Title}\nText: {Text}\nPublicationDate: {PublicationDate}\n";
        }
    }
}
