namespace Aufgabe.AudioPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            FLACFile f1 = new FLACFile("test1");
            FLACFile f2 = new FLACFile("test2");
            FLACFile f3 = new FLACFile("test3");
            FLACFile f4 = new FLACFile("test4");
            FLACFile f5 = new FLACFile("test5");
            WAVFile w1 = new WAVFile("test6");
            WAVFile w2 = new WAVFile("test7");
            WAVFile w3 = new WAVFile("test8");
            WAVFile w4 = new WAVFile("test9");
            MP3File m1 = new MP3File("test10");
            MP3File m2 = new MP3File("test11");
            MP3File m3 = new MP3File("test12");
            MP3File m4 = new MP3File("test13");
            MP3File m5 = new MP3File("test14");
            AudioFile[] music = {f1,f2,f3,f4,f5,w1,w2,w3,w4,m1,m2,m3,m4,m5};

            AudioPlayer ap = new AudioPlayer();

            foreach(AudioFile file in music)
            {
                ap.AddFile(file);
            }

            //ap.Play(4);
            //ap.Play(18); //test 
            //ap.PlayAll();
            //ap.PlayAll(true);

            ap.RemoveFile(10);
            ap.RemoveFile(-2);  //test
            ap.RemoveFile(20);  //test
            ap.PlayAll(true); 
            ap.PlayAll();
        }
    }
}