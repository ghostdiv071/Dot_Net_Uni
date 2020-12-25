using System.Drawing;

namespace Solutions.Task_8
{
    public interface ILoader
    {
        int FuelVolume { get; }
        bool Busy { get; set; }
        Point Position { set; get; }
        void LoadFuel(BlastFurnace furnace);
    }
}