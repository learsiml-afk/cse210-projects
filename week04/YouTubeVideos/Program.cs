using System;
using System.Collections.Generic;
class Program
{

    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Astronaut Chris Hadfield Breaks Down Space Movies", "Vanity Fair", 2156);
        Video video2 = new Video("Artemis II reentry, splashdown & recovery", "CNN", 550);
        Video video3 = new Video("SpaceX Makes History Catching Rocket on Landing", "Bloomberg Tech", 51);
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        video1.AddComment(new Comment("ariestheram5693", "\"I surfed the northern lights\" is probably the hardest flex in human history"));
        video1.AddComment(new Comment("dhaniluvkakashi", "Chris is the perfect example of \"Space for Dummies\". The way he can \"dumb it down\" for people that knows nothing on space stuff is amazing. Not a lot of people can do that even lecturers on universities."));
        video1.AddComment(new Comment("danwellsanddangmtb2302", "Imagine watching a space film in the cinema and you see Chris hadfield angrily leave the cinema"));

        video2.AddComment(new Comment("chombabwalya8921", "The feeling of being back home must be surreal."));
        video2.AddComment(new Comment("TheBbod156", "I don't think this mission could've possibly went any smoother. That's some incredible engineering"));
        video2.AddComment(new Comment("user-kx1lz8xz1m", "\"What did you do last week?\" \"I flew around the moon\""));

        video3.AddComment(new Comment("Kyle-cw2in", "This is something straight out of science fiction, congratulations to the engineers and everyone involved, truly one of the biggest leaps in space travel recently"));
        video3.AddComment(new Comment("itsyo42", "That's what happen when a company is not bloated by paperwork and allows their engineers do their jobs"));
        video3.AddComment(new Comment("IzabellaCoimbra-o5m", "I'm 64 years old. I actually watched when Neil Armstrong landed on the moon. As a 9 year-old, I fell in love with the space program and became a huge sci-fi fan. I haven't felt this emotional about a space program since that day in 1969."));
        video3.AddComment(new Comment("SuperSkandale", "literally chills down my spine. I would never have thought they would be able to do this"));

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}\nAuthor: {video._author}\nSeconds: {video._seconds} s\nNumber of Comments: {video.NumComments()}\nComments...\n{video.TheComment()}");
        }

    }

}