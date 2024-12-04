namespace GenericExample.Entities;

public class Course(int code, string? title, int credit)
{
    public int Code { get; set; } = code;
    public string? Title { get; set; } = title;
    public int Credit { get; set; } = credit;

    public override string ToString()
    {
        return $"{Code,-5} {Title,-30} {Credit,-5}";
    }
}