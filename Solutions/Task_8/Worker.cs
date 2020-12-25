using System.Drawing;
using System.Threading;

namespace Solutions.Task_8
{
    public class Worker
    {
        public bool Busy { get; set; }
        public string Path { get; } = Paths.Worker;
        public Point Position { set; get; }
        
        public void CoolDown(BlastFurnace furnace)
        {
            Busy = true;
            Position = new Point(furnace.Position.X-100, furnace.Position.Y);
            Thread.Sleep(3000);
            furnace.State = FurnaceState.Working;
            Busy = false;
        }
    }
}