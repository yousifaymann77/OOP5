using System;
using System.Collections.Generic;
using System.Text;

namespace oop5Assign
{
    internal class DeliveryReport
    {
        public void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine($"Tracking Status : {shipment.GetTrackingStatus()}");
        }
        public void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine($"Shipment Insurance : {shipment.CalculateInsurance()}");
        }
    
    }
}
