namespace Solutions.Task_3
{
    public class Window
    {
        public int Leaves { get; set; }  // створки
        public string Type { get; set; }

        public Window(int leaves, string type)
        {
            Leaves = leaves;
            Type = type;
        }

        public string GetInfo()
        {
            return "Leaves amount: " + Leaves +
                   ", type: " + Type;
        }
    }
}