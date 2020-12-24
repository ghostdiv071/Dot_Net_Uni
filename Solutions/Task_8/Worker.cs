using System.Drawing;
using System.Threading;

namespace Solutions.Task_8
{
    public class Worker
    {
        public Point Position { private set; get; }
        public bool Busy { get; set; }
        public Point BeginPosition { get; set; }
        private string Path { get; } = Paths.Worker;
        
        private object Locker { get; } = new object();
        
        public void CoolDown(BlastFurnace furnace)
        {
            Busy = true;
            lock (Locker)
            {
                Thread.Sleep(3000);
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