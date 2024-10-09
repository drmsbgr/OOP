using VideoLib;

var video = new Video(1, "OOP nedir?", 27.8);
video.AddKeywords(["oop", "c#", "java", "abstraction", "inheritance", "polymorphism", "encapsulation"]);

var playlist = new PlayList("Courses")
{
    video,
    new(2, "Inheritance nedir?", 12.5),
    new(3, "Polymorphism nedir?", 20.8)
};

var playlistMusic = new PlayList("Songs"){
    new (1, "Lovebite", 3.49),
    new (2, "Heavy Blanket", 4.49),
    new (3, "The Summoning", 6.36),
};

Console.WriteLine(playlist.PlayListTitle);
foreach (var item in playlist)
    Console.WriteLine($"Title: {item.Title}");

Console.WriteLine(playlistMusic.PlayListTitle);
foreach (var item in playlistMusic)
    Console.WriteLine($"Title: {item.Title}");
