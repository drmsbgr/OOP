using System.Collections;

namespace VideoLib;

public class PlayList(string title) : IEnumerable<Video>
{
    public string? PlayListTitle { get; set; } = title;
    public int Count => _videos.Count;
    private readonly List<Video> _videos = [];

    public void Add(Video item)
    {
        _videos.Add(item);
    }

    public void Clear()
    {
        _videos.Clear();
    }

    public bool Remove(Video item)
    {
        return _videos.Remove(item);
    }

    public IEnumerator<Video> GetEnumerator()
    {
        return _videos.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}