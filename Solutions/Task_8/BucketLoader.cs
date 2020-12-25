using System.Drawing;
using System.Threading;

namespace Solutions.Task_8
{
    public class BucketLoader : ILoader
    {
        public int FuelVolume { get; } = 3500;
        public bool Busy { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public string Path { get; } = Paths.Bucket;
        
        public void LoadFuel(BlastFurnace furnace)
        {
            Busy = true;
            X = furnace.X + 100;
            Y = furnace.Y;
            Thread.Sleep(FuelVolume);
            furnace.FuelVolume = FuelVolume;
            furnace.State = FurnaceState.Working;
            Busy = false;
        }
    }
}