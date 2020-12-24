namespace Solutions.Task_3
{
    public class Door
    {
        public bool IsClosed { get; set; }
        public string Material { get; set; }

        public Door(bool isClosed, string material)
        {
            IsClosed = isClosed;
            Material = material;
        }

        public string Close()
        {
            IsClosed = true;
            return "Door is closed";
        }

        public string Open()
        {
            IsClosed = false;
            return "Door is opened";
        }

        public string GetInfo()
        {
            return "Is closed: " + IsClosed +
                   ", material: " + Material;
        }
    }
}