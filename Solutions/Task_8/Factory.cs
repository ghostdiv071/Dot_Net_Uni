using System.Threading;
using System.Threading.Tasks;

namespace Solutions.Task_8
{
    public class Factory
    {
        public BlastFurnace[] _furnaces = {new BlastFurnace(), new BlastFurnace()};
        public Worker Worker { get; } = new Worker();
        public ILoader BeltLoader { get; } = new BeltLoader();
        public ILoader BucketLoader { get; } = new BucketLoader();
        public ILoader Excavator { get; } = new Excavator();

        public delegate void UpdateHandler();
        public event UpdateHandler Update;

        public async void StartFurnace()
        {
            foreach (var furnace in _furnaces)
            {
                furnace.Overheat += HandleOverheat;
                furnace.OutOfFuel += HandleLoading;
                await Task.Run((() => furnace.Work()));
            }
        }
        
        private void HandleOverheat(BlastFurnace caller)
        {
            while (Worker.Busy)
            {
                Thread.Sleep(1000);
            }
            Worker.CoolDown(caller);
        }
        
        private void HandleLoading(BlastFurnace caller)
        {
            if (!BeltLoader.Busy)
            {
                BeltLoader.LoadFuel(caller);
            }
            else if (!BucketLoader.Busy)
            {
                BucketLoader.LoadFuel(caller);
            }
            else if (!Excavator.Busy)
            {
                Excavator.LoadFuel(caller);
            }
            else
            {
                Thread.Sleep(1000);
            }
        }
        
    }
}