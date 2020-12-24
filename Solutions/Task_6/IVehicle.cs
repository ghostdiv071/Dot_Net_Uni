namespace Solutions.Task_6
{
    public interface IVehicle
    {
        bool IsBroken { get; set; }

        string Broke();

        string Move();
    }
}