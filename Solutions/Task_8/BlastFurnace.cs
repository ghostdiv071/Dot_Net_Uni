using System.Diagnostics;
using System.Drawing;

namespace Solutions.Task_8
{
    public class BlastFurnace
    {
        public FurnaceState State { get; set; }
        private double OverheatChance { get; } = 0.25;
        public long FuelVolume { get; set; } = 1000;
        public string Path { get; } = Paths.Furnace;
        
        public delegate void OverheatHandler(BlastFurnace furnace);
        public event OverheatHandler Overheat;
        
        public delegate void OutOfFuelHandler(BlastFurnace furnace);
        public event OutOfFuelHandler OutOfFuel;

        public void Work()
        {
            var stopWatch = new Stopwatch();
            while (State == FurnaceState.Working)
            {
                stopWatch.Start();
                if (Randomizer.IsHappened(OverheatChance))
                {
                    State = FurnaceState.Overheat;
                    Overheat?.Invoke(this);
                    stopWatch.Stop();
                    FuelVolume -= stopWatch.ElapsedMilliseconds * 10;
                }

                if (FuelVolume == 0)
                {
                    State = FurnaceState.Empty;
                    OutOfFuel?.Invoke(this);
                }
                else
                {
                    FuelVolume -= stopWatch.ElapsedMilliseconds * 10;
                }
            }
        }
    }
}