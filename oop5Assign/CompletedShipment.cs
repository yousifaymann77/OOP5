using System;
using System.Collections.Generic;
using System.Text;

namespace oop5Assign
{
    internal class CompletedShipment : Shipment
    {
        public CompletedShipment(string trackingCode, string description, decimal weight, decimal deliveryFee) : base(trackingCode, description, weight, deliveryFee)
        {
        }

        public override decimal EstimatedCost => throw new NotImplementedException();

        public override Shipment CopyShipment()
        {
            throw new NotImplementedException();
        }

        public override void PrintShipment()
        {
            throw new NotImplementedException();
        }
    }
}
