using System.Diagnostics;

namespace Solutions.Task_8
{
    public class BlastFurnace
    {
        public FurnaceState State { get; set; } = FurnaceState.Working;
        private double OverheatChance { get; } = 0.1;
        public long FuelVolume { get; set; } = 10000;
        public int X { get; set; }
        public int Y { get; set; }
        public string Path { get; } = Paths.Furnace;
        
        public delegate void OverheatHandler(BlastFurnace furnace);
        public event OverheatHandler Overheat;
        
        public delegate void OutOfFuelHandler(BlastFurnace furnace);
        public event OutOfFuelHandler OutOfFuel;
        
        public BlastFurnace(int x, int y)
        {
            X = x;
            Y = y;
        }

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

                if (FuelVolume <= 0)
                {
                    FuelVolume = 0;
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