using System;
using System.Collections.Generic;

class Article
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public void Edit(string newContent)
    {
        Content = newContent;
    }

    public void ChangeAuthor(string newAuthor)
    {
        Author = newAuthor;
    }

    public void Rename(string newTitle)
    {
        Title = newTitle;
    }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}

class ArticlesList
{
    public List<Article> Articles { get; set; }

    public ArticlesList()
    {
        Articles = new List<Article>();
    }

    public void AddArticle(Article article)
    {
        Articles.Add(article);
    }

    public override string ToString()
    {
        string result = "";
        foreach (Article article in Articles)
        {
            result += article.ToString() + "\n";
        }
        return result;
    }
}

class Articles2
{
    static void Main()
    {
        int numArticles = int.Parse(Console.ReadLine());

        ArticlesList articlesList = new ArticlesList();

        for (int i = 0; i < numArticles; i++)
        {
            string[] articleInfo = Console.ReadLine().Split(", ");
            string title = articleInfo[0];
            string content = articleInfo[1];
            string author = articleInfo[2];

            Article article = new Article(title, content, author);
            articlesList.AddArticle(article);
        }

        Console.WriteLine(articlesList);
    }
}
