using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to Code 101", "John Jones", 300);
        Comment comment1 = new Comment("user1", "This is so helpful!");
        Comment comment2 = new Comment("user2", "My teacher explained this better in class...");
        Comment comment3 = new Comment("user3", "I want to join user2's class then!");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        Video video2 = new Video("BYU-I Campus Tour", "Jane Doe", 600);
        Comment comment4 = new Comment("user4", "Such a beautiful campus!");
        Comment comment5 = new Comment("user5", "Tuition is affordable, too.");
        Comment comment6 = new Comment("user6", "I can't wait to attend here!");
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        Video video3 = new Video("My First Job Interview After Graduating", "Charlie Cherry", 420);
        Comment comment7 = new Comment("user7", "Wow! That was intense. I'm glad you were prepared.");
        Comment comment8 = new Comment("user8", "I hear they only hire those with degrees from BYU-I.");
        Comment comment9 = new Comment("user9", "You'll do great at a company like that!");
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3
        };

        Console.Clear();
        foreach (Video v in videos)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~");
            v.DisplayVideoInfo();
            v.DisplayAllComments();
        }
        Console.WriteLine("~~~~~~~~~~~~~~~");
    }
}