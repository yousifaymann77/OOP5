using System;
using System.Collections.Generic;
using System.Text;

namespace oop5Assign
{
    internal abstract partial class Shipment
    {
        public string TrackingStatus { get; set; }
        public string TrackingCode
        {
            get
            {
                return trackingCode;
            }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    trackingCode = value;
                }
            }

        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    description = value;
                }
            }
        }

        public decimal Weight
        {
            get
            {
                return weight;

            }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }
        public decimal DeliveryFee
        {
            get
            {
                return deliveryFee;
            }
            private set
            {
                if (value > 0)
                {
                    deliveryFee = value;
                }
            }
        }

        #region part02 Q6 Static Method
        public static int GetTotalShipmensCreated()
        {
            return TotalShipmentsCreated;
        }

        #endregion

        public string GetTrackingStatus()
        {
            return TrackingStatus;
        }

        public string UpdateTrackingStatus(string status)
        {
            TrackingStatus = status;
            OnTrackingStatusChanged(status);
            return TrackingStatus;
        }

        #region part02 Q10 Partial Method
        partial void OnTrackingStatusChanged(string status); 
        #endregion

    }
}
