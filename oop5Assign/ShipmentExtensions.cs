using System;
using System.Collections.Generic;
using System.Text;

namespace oop5Assign
{
    internal static class ShipmentExtensions
    {
        #region part02 Q8 Extension Methods
        public static string GetSummary(this Shipment shipment)
        {
            ITrackable trackable = (ITrackable)shipment;
            return $"{shipment.TrackingCode} | {shipment.GetType().Name} | {shipment.Weight} | {trackable.GetTrackingStatus()}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            ITrackable trackable = (ITrackable)shipment;
            return trackable.GetTrackingStatus() == "Delivered";

        } 
        #endregion
    }
}
