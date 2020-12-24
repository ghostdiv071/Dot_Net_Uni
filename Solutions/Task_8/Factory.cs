using System.Threading;
using System.Threading.Tasks;

namespace Solutions.Task_8
{
    public class Factory
    {
        private BlastFurnace[] _furnaces = {new BlastFurnace(), new BlastFurnace()};
        private Worker Worker { get; } = new Worker();
        private ILoader BeltLoader { get; } = new BeltLoader();
        private ILoader BucketLoader { get; } = new BucketLoader();
        private ILoader Excavator { get; } = new Excavator();

        public async void StartFurnace(int index)
        {
            _furnaces[index].Overheat += HandleOverheat;
            _furnaces[index].OutOfFuel += HandleLoading;
            await Task.Run((() => _furnaces[index].Work()));
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