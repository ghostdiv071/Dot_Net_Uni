using System.Drawing;
using System.Threading;

namespace Solutions.Task_8
{
    public class Worker
    {
        public bool Busy { get; set; }
        public string Path { get; } = Paths.Worker;
        public int X { get; set; }
        public int Y { get; set; }
        
        public void CoolDown(BlastFurnace furnace)
        {
            Busy = true;
            X = furnace.X - 100;
            Y = furnace.Y;
            Thread.Sleep(3000);
            furnace.State = FurnaceState.Working;
            Busy = false;
        }
    }
}