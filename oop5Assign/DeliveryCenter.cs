using System;
using System.Collections.Generic;
using System.Text;

namespace oop5Assign
{
    internal class DeliveryCenter
    {
        private Shipment[] shipments;

        public string CenterName { get; set; }

        #region part02 Q5 
        public Driver Driver { get; set; }
        #endregion
        public static int count;

        public DeliveryCenter()
        {
            this.shipments = new Shipment[20];
        }
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                {
                    return shipments[index];
                }
                else return default!;
            }
            set
            {
                if (index >= 0 && index < shipments.Length)
                    shipments[index] = value;
            }
        }
        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i].TrackingCode == trackingCode)
                    {
                        return shipments[i];
                    }
                }
                return default!;
            }
        }

        public bool AddShipment(Shipment shipment)
        {

            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    count++;
                    return true;
                }
            }
            return false;
        }


        public bool RemoveShipment(string delCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i].TrackingCode == delCode)
                {
                    for (int j = i; j < shipments.Length - 1; j++)
                    {
                        shipments[j] = shipments[j + 1];
                    }

                    shipments[shipments.Length - 1] = null!;

                    return true;
                }
            }

            return false;
        }

        public void PrintAllShipments()
        {

            foreach (Shipment shipment in shipments)
            {
                if (shipment != null)
                {
                    shipment.PrintShipment();
                }
            }

        }

        public void PrintTrackingStatueses()
        {
            foreach (ITrackable trackable in shipments)
            {
                trackable.GetTrackingStatus();
                Console.WriteLine("---------");
            }
        }
        public void PrintInsurances()
        {
            foreach (IInsurable insurable in shipments)
            {
                insurable.CalculateInsurance();
                Console.WriteLine("-----------");
            }
        }
    }
}
