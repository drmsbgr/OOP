namespace VideoLib;

public class Video(int id, string? title, double duration)
{
    public int Id { get; set; } = id;
    public string? Title { get; set; } = title;
    public double Duration { get; set; } = duration;
    public List<string>? Keywords { get; set; }

    public void AddKeywords(ICollection<string> collection)
    {
        Keywords ??= [];
        this.Keywords.AddRange(collection);
    }
}
