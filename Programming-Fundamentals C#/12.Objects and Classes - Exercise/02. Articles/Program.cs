using System;
using System.Collections.Generic;

namespace _02._Articles
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public static void Edit (string newContent, Article article)
        {
            article.Content = newContent;
        }
        public static void ChangeAuthor (string newAuthor, Article article)
        {
            article.Author = newAuthor;
        }
        public static void Rename (string newTitle, Article article)
        {
            article.Title = newTitle;
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] articleArgs = Console.ReadLine().Split(", ");
            string title = articleArgs[0];
            string content = articleArgs[1];
            string author = articleArgs[2];

            Article article = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine().Split(": ");
                string typeCommand = commandArgs[0];
                if (typeCommand == "Edit")
                {
                    string newContent = commandArgs[1];
                    Article.Edit(newContent, article);
                }
                else if (typeCommand == "ChangeAuthor")
                {
                    string newAuthor = commandArgs[1];
                    Article.ChangeAuthor(newAuthor, article);
                }
                else if (typeCommand == "Rename")
                {
                    string newTitle = commandArgs[1];
                    Article.Rename(newTitle, article);
                }
            }
            Console.WriteLine(article);
        }
    }
}
