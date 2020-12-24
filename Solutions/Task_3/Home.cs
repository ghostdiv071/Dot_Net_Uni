using System.Collections.Generic;

namespace Solutions.Task_3
{
    public class Home
    {
        private List<Window> Windows { get; set; }
        private List<Door> Doors { get; set; }

        public Home()
        {
            Windows = new List<Window>();
            Doors = new List<Door>();
        }

        public string Close(int doorNumber)
        {
            if (doorNumber > 0 & doorNumber <= Doors.Count)
            {
                return !Doors[doorNumber-1].IsClosed 
                    ? Doors[doorNumber-1].Close() 
                    : "The door is already closed";
            }

            return "There is no door with this number";
        }

        public string Open(int doorNumber)
        {
            if (doorNumber > 0 & doorNumber <= Doors.Count)
            {
                return Doors[doorNumber-1].IsClosed 
                    ? Doors[doorNumber-1].Open() 
                    : "The door is already opened";
            }

            return "There is no door with this number";
        }
        
        public int GetDoorsAmount()
        {
            return Doors.Count;
        }

        public int GetWindowsAmount()
        {
            return Windows.Count;
        }

        public void AddDoor(string material)
        {
            Doors.Add(new Door(false, material));
        }

        public void AddWindow(int leaves, string type)
        {
            Windows.Add(new Window(leaves, type));
        }
    }
}