using System;
using System.Collections.Generic;
using System.Text;

namespace oop5Assign
{
    internal class InternationalShipment : Shipment , ITrackable , IInsurable
    {
        private string destinationCountry = default!;
        private decimal customFee;

        public InternationalShipment(string trackingCode, string description, decimal deliveryFee, decimal weight, string destinationCountry, decimal customFee)
            : base(trackingCode, description, deliveryFee, weight)
        {
            this.customFee = customFee;
            this.destinationCountry = destinationCountry;
        }

        public string DestinationCountry
        {
            get { return destinationCountry; }
            set
            {
                if (string.IsNullOrWhiteSpace(destinationCountry))
                {
                    destinationCountry = value;
                }
            }
        }
        public decimal CustomFee
        {
            get { return customFee; }
            set
            {
                if (customFee >= 0)
                {
                    customFee = value;
                }
            }
        }


        public override decimal EstimatedCost => (Weight * 5) + DeliveryFee + customFee;



        public override void PrintShipment()
        {
            Console.WriteLine("---International Shipment---");
            Console.WriteLine();
            Console.WriteLine($"Tracking Code: {TrackingCode},\n" +
                              $" Estimated Cost: ${EstimatedCost} EGP" +
                              $"\n Destination country : {destinationCountry}" +
                              $"\n CustomFee : {customFee}");

        }


        public virtual void GenerateCustomReport()
        {
            Console.WriteLine($"CustomFee : {customFee}");
            Console.WriteLine($"Destination Country : {destinationCountry}");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is ready ";
        }
        public decimal CalculateInsurance()
        {
            return 0.12m * EstimatedCost;

        }

    }
}
