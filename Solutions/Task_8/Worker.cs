using System.Drawing;
using System.Threading;

namespace Solutions.Task_8
{
    public class Worker
    {
        public bool Busy { get; set; }
        public string Path { get; } = Paths.Worker;
        
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
            }
        }
    }
}