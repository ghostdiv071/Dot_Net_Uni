using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Solutions.Task_8
{
    public class Factory
    {
        public List<BlastFurnace> Furnaces { get; } = new List<BlastFurnace>();

        public ILoader BeltLoader = new BeltLoader();
        public ILoader BucketLoader = new BucketLoader();
        public ILoader Excavator = new Excavator();
        public Worker Worker { get; } = new Worker();
        
        public delegate void UpdateHandler();
        public event UpdateHandler Update;

        public async void StartFurnace(BlastFurnace furnace)
        {
            furnace.Overheat += HandleOverheat;
            furnace.OutOfFuel += HandleLoading;
            await Task.Run(furnace.Work);
        }
        
        private void HandleOverheat(BlastFurnace caller)
        {
            while (Worker.Busy)
            {
                Thread.Sleep(1000);
            }
            Worker.CoolDown(caller);
            Update?.Invoke();
        }
        
        private void HandleLoading(BlastFurnace caller)
        {
            if (!BeltLoader.Busy)
            {
                BeltLoader.LoadFuel(caller);
                Update?.Invoke();
            }
            else if (!BucketLoader.Busy)
            {
                BucketLoader.LoadFuel(caller);
                Update?.Invoke();
            }
            else if (!Excavator.Busy)
            {
                Excavator.LoadFuel(caller);
                Update?.Invoke();
            }
            else
            {
                Thread.Sleep(1000);
            }
        }
        
    }
}