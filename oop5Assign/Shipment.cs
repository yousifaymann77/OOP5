using System;
using System.Collections.Generic;
using System.Text;

namespace oop5Assign
{
    internal abstract partial class Shipment 
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        public decimal ExtraPackingWeight { get; set; }

        public DeliveryAddress Address { get; set; }

        #region Part02 Q4 Static Field
        public static int TotalShipmentsCreated ;
        #endregion

        #region Part02 Q5 Static constructor
        static Shipment()
        {
            TotalShipmentsCreated = 0;
            Console.WriteLine("Shipment System Initialized ");
        } 
        #endregion


        public Shipment(string trackingCode)
        {
            this.TrackingCode = trackingCode;
            this.description = "Unknown";
            this.weight = 1;
            this.deliveryFee = 50;
            TotalShipmentsCreated++;

        }

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee)
        {
            this.TrackingCode = trackingCode;
            this.Description = description;
            this.Weight = weight;
            this.DeliveryFee = deliveryFee;
            TotalShipmentsCreated++;


        }
        
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                deliveryFee = newFee;
            }
        }

        //public virtual decimal EstimatedCost
        //{
        //    get
        //    {
        //        return deliveryFee + (weight * 5);
        //    }
        //}

        public abstract decimal EstimatedCost { get; }
        public abstract void PrintShipment();


        //public virtual string PrintShipment()
        //{
        //    return $"Tracking Code: {trackingCode},\n" +
        //        $" Description: {description},\n" +
        //        $" Weight: {weight} kg,\n" +
        //        $" Delivery Fee: ${deliveryFee},\n" +
        //        $" Estimated Cost: ${EstimatedCost}";
        //}

        public void UpdateWeight(decimal weight)
        {
            if (weight > 0)
            {
                this.weight = weight;
            }

        }
        public void UpdateWeight(decimal weight, decimal extraWeight)
        {
            if (extraWeight >= 0)
                this.weight = weight + extraWeight;
        }

        #region Part02 Q1 Object Copying
        public abstract Shipment CopyShipment();
        #endregion

        #region Part02 Q2 Shallow Copy
        public Shipment ShallowCopy()
        {
            return (Shipment)this.MemberwiseClone();
        }
        #endregion

        #region Part02 Q3 Deep Copy 
        public Shipment DeepCopy()
        {
            Shipment copy = (Shipment)this.MemberwiseClone();
            copy.Address = new DeliveryAddress(this.Address.City, this.Address.Street, this.Address.BuildingNumber);
            return copy;
        }
        #endregion

        #region Part02 Q10 Partial Method
        partial void OnTrackingStatusChanged(string status)
        {
            Console.WriteLine($"Tracking status changed to: {status}");
        } 
        #endregion

    }
}
