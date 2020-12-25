using System.Drawing;

namespace Solutions.Task_8
{
    public interface ILoader
    {
        int FuelVolume { get; }
        bool Busy { get; set; }
        int X { get; set; }
        int Y { get; set; }
        void LoadFuel(BlastFurnace furnace);
    }
}