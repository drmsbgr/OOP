namespace VideoLib;

public class Video
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public float Duration { get; set; }
    public List<string>? Keywords { get; set; }
}
