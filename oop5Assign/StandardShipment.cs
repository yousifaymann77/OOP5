using System;
using System.Collections.Generic;
using System.Text;

namespace oop5Assign
{
    internal class StandardShipment :Shipment, ITrackable , IInsurable
    {
        public StandardShipment(string trackingCode, string description, decimal deliveryFee, decimal weight)
       : base(trackingCode, description, deliveryFee, weight)
        {
        }

        public override decimal EstimatedCost
        {
            get
            {
                return (Weight * 5) + DeliveryFee;
            }
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }
        

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is out for Delivery ";
        }

        public override void PrintShipment()
        {
            Console.WriteLine("---Standard Shipment---");
            Console.WriteLine();
            Console.WriteLine($"Tracking Code: {TrackingCode},\n" +
                              $" Description: {Description},\n" +
                              $" Estimated Cost: ${EstimatedCost} EGP");
        }

        #region Part02 Q1 Object Copying
        public override Shipment CopyShipment()
        {
            return new StandardShipment(
                this.TrackingCode,
                this.Description,
                this.Weight,
                this.DeliveryFee
            );
        } 
        #endregion
    }
}
