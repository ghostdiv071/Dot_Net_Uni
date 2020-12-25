using System.Drawing;
using System.Threading;

namespace Solutions.Task_8
{
    public class Excavator : ILoader
    {
        public int FuelVolume { get; } = 5000;
        public bool Busy { get; set; }
        public string Path { get; } = Paths.Excavator;
        public Point Position { get; set; }
        
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