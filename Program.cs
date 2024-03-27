using Modul6_1302220105;

class program()
{
    static void Main(string[] args)
    {
        Console.WriteLine("Inputkan Username");
        String nama = Console.ReadLine();
        SayaTubeUser user = new SayaTubeUser(nama);
        Console.WriteLine(" ");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Inputkan Judul Film ke "+(i+1));
            String judul = Console.ReadLine();
            SayaTubeVideo video = new SayaTubeVideo(judul);
            video.PrintVideoDetails();
            video.IncreasePlayCount(5);
            Console.WriteLine(" ");
            Console.WriteLine("Setelah nambah PlayCount");
            video.PrintVideoDetails();
            user.AddVideo(video);
            Console.WriteLine(" ");

        }
        user.PrintAllVideoPlayCount();
    }
}