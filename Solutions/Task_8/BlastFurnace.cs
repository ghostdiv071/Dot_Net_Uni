using System;

namespace Solutions.Task_8
{
    public class BlastFurnace
    {
        private delegate void LoadHandler();
        private event LoadHandler LoadFuel;
        
        private delegate void CoolingHandler();
        private event CoolingHandler CoolDown;
        
        private delegate void UpdateHandler(FurnaceState state);
        private event UpdateHandler Update;
        
        public FurnaceState State { get; set; }
        private Random _random { get; } = new Random();
        private double OverheatChance { get; } = 0.25;
        private bool CanWork { get; set; } = false;

        public void UpdateState(FurnaceState state)
        {
            State = state;
            Update?.Invoke(state);
        }
    }
}