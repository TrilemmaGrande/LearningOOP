namespace Aufgabe_TV {
    internal class Program {
        static void Main(string[] args) {
            Tv tv = new Tv();
            tv.TurnOn();
            tv.RaiseVolume();
            tv.GetInfo();
            tv.SetVolumeStep(10);
            tv.LowerVolume();
            tv.GetInfo();
            tv.switchProgram();
            tv.TurnOff();
            tv.GetInfo();
            tv.TurnOn();
            tv.switchProgram();
            tv.RaiseVolume();
            tv.RaiseVolume();
            tv.GetInfo();
            tv.TurnOff();
            tv.GetInfo();
        }
    }
}