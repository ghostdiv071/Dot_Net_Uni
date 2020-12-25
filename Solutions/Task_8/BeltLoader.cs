using System.Drawing;
using System.Threading;

namespace Solutions.Task_8
{
    public class BeltLoader : ILoader
    {
        public int FuelVolume { get; } = 2000;
        public bool Busy { get; set; }
        public Point Position { set; get; }
        
        public string Path { get; } = Paths.Belt;
        
        public void LoadFuel(BlastFurnace furnace)
        {
            Busy = true;
            Position = new Point(furnace.Position.X+100, furnace.Position.Y);
            Thread.Sleep(FuelVolume);
            furnace.FuelVolume = FuelVolume; 
            furnace.State = FurnaceState.Working;
            Busy = false;
        }
    }
}