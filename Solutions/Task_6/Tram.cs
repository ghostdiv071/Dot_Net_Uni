namespace Solutions.Task_6
{
    public class Tram : PublicTransport
    {
        public string Depot { get; set; }
        public int Voltage  { get; set; }
        
        public Tram(string routeName, int seats, string depot , 
            bool isBroken, int passengers, int voltage)
        {
            Seats = seats;
            Depot = depot;
            RouteName = routeName;
            IsBroken = isBroken;
            Passengers = passengers;
            Voltage = voltage;
        }

        public string SetNewVoltage(int newVoltage)
        {
            Voltage = newVoltage;
            return "New voltage is " + Voltage;
        }

        public string ChangeDepot(string newDepot)
        {
            Depot = newDepot;
            return "Depot is changed. The new one is " + Depot;
        }
        
        public override string GetInfo()
        {
            return base.GetInfo() +
                ", depot name:" + Depot +
                ", voltage:" + Voltage;
        }
    }
}