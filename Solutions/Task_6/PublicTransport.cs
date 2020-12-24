using System;

namespace Solutions.Task_6
{
    public abstract class PublicTransport : IVehicle
    { 
        public bool IsBroken { get; set; }
        public string RouteName { get; set; }
        public int Seats { get; set; }
        public int Passengers { get; set; }
        
        public string Broke()
        {
            if (!IsBroken)
            {
                IsBroken = false;
                return "Transport has broken.";
            }

            return "Transport is already broken.";
        }

        public string Move()
        {
            return "The transport is set on the " + RouteName;
        }
        
        public string TakePassenger()
        {
            return Passengers < Seats 
                ? "Passengers number: " + (++Passengers) 
                : "The transport is full";
        }
        
        public virtual string GetInfo()
        {
            return "seats:" + Seats +
                   ", route name:" + RouteName +
                   ", passengers:" + Passengers +
                   ", broken or not:" + IsBroken;
        }
        
    }
}