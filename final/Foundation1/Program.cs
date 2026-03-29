using System;

class Program
{
    static void Main(string[] args)
    {
    List<Video> videoList = new List<Video>();

    Video video1 = new Video("Burger King is Overrated", "AndyBean123", 450);
    Comment comment11 = new Comment("XXXTheLion420XXX","Burger King is a national treasure. People like you don't deserve to live");
    video1._commentList.Add(comment11);
    Comment comment12 = new Comment("CrayonEater1","yeh");
    video1._commentList.Add(comment12);
    Comment comment13 = new Comment("Schmlorf","hi");
    video1._commentList.Add(comment13);
    videoList.Add(video1);

    Video video2 = new Video("This can NOT be Tolerated", "XXXTheLion420XXX", 2437);
    Comment comment21 = new Comment("Benjamin","Is this satire?");
    video2._commentList.Add(comment21);
    Comment comment22 = new Comment("ConcreteEeter7","The Burger King Slander Has gone to far, We must take AndyBean DOWN!");
    video2._commentList.Add(comment22);
    Comment comment23 = new Comment("ManStabber666","Someone Get Andy's Address, there is work to be done");
    video2._commentList.Add(comment23);
    videoList.Add(video2);

    Video video3 = new Video("Fight filmed at Burger King ", "Schmlorf", 153);
    Comment comment31 = new Comment("143InanimateIdiot","Waht could possibly be the context???");
    video3._commentList.Add(comment31);
    Comment comment32 = new Comment("IEATD0G5","Is That AndyBean??? the other guy never stood a chance, Andy's built like a tank");
    video3._commentList.Add(comment32);
    Comment comment33 = new Comment("qoggle985","Average Burger King Experience, that place serves deepfried dirt!");
    video3._commentList.Add(comment33);
    videoList.Add(video3);


    Console.Clear();
    foreach(Video video in videoList)
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine(video.GetVideoInfo());
            Console.WriteLine();
            Console.WriteLine($"COMMENTS: {video.GetCommentCount()}");
            foreach(Comment comment in video._commentList)
            {
                Console.WriteLine(comment.GetCompiledComment());
            }
            
        }

    }
}