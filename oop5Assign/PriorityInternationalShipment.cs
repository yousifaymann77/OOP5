using System;
using System.Collections.Generic;
using System.Text;

namespace oop5Assign
{
    internal class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(string trackingCode, string description, decimal deliveryFee, decimal weight, string destinationCountry, decimal customFee)
           : base(trackingCode, description, deliveryFee, weight, destinationCountry, customFee)
        {
        }

        public sealed override void GenerateCustomReport()
        {
            base.GenerateCustomReport();
        }
    }
}
