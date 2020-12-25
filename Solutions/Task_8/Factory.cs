using System.Threading;
using System.Threading.Tasks;

namespace Solutions.Task_8
{
    public class Factory
    {
        public BlastFurnace[] Furnaces { get; } =
        {
            new BlastFurnace(), 
            new BlastFurnace()
        };

        public ILoader BeltLoader = new BeltLoader();
        public ILoader BucketLoader = new BucketLoader();
        public ILoader Excavator = new Excavator();
        public Worker Worker { get; } = new Worker();
        
        public delegate void UpdateHandler();
        public event UpdateHandler Update;

        public async void StartFurnace()
        {
            foreach (var furnace in Furnaces)
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