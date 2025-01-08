namespace BlogApp.Entities;

public class Content
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }

    public Content()
    {
    }

    public Content(int id, string title, string text)
    {
        Id = id;
        Title = title;
        Text = text;
    }

    public override string ToString()
    {
        return $"----{Title}--------------\n{Text}\n-----------------------";
    }
}