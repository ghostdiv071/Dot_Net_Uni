using System.Drawing;
using System.Threading;

namespace Solutions.Task_8
{
    public class Excavator : ILoader
    {
        public int FuelVolume { get; } = 5000;
        public bool Busy { get; set; }
        public Point Position { get; set; }
        public Point BeginPosition { get; set; }
        
        private object Locker { get; } = new object();
        
        public void LoadFuel(BlastFurnace furnace)
        {
            Busy = true;
            lock (Locker)
            {
                Thread.Sleep(FuelVolume);
                if (furnace.State == FurnaceState.Overheat)
                {
                    furnace.State = FurnaceState.Working;
                }
                Busy = false;
                Position = BeginPosition;
            }
        }
    }
}