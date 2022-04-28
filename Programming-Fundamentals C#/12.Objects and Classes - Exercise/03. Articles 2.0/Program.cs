using System;
using System.Collections.Generic;

namespace _03._Articles_2._0
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

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> allArticles = new List<Article>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] articleArgs = Console.ReadLine().Split(", ");
                string title = articleArgs[0];
                string content = articleArgs[1];
                string author = articleArgs[2];

                Article newArticle = new Article(title, content, author);
                allArticles.Add(newArticle);
            }

            string str = Console.ReadLine();
            foreach (Article article in allArticles)
            {
                Console.WriteLine(article);
            }
        }
    }
}
