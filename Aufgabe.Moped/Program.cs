namespace Aufgabe.Moped
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Moped m1 = new Moped(1);
            Moped m2 = new Moped(licensePlate: "EN-TE 1");
            Console.WriteLine(m1.GetInfos());
            Console.WriteLine(m2.GetInfos());
            MitAnhaenger ma1 = new MitAnhaenger(20);
            Console.WriteLine(   ma1.Unload(5));
            Console.WriteLine(ma1.GetInfos());
            ma1.Drive(10);
            Console.WriteLine(ma1.GetInfos());
            ma1.Load(20);
            Console.WriteLine(ma1.Load(20) );
            Console.WriteLine(ma1.GetInfos());
            Console.WriteLine(ma1.Unload(40));
        }
    }
}