using System;
using System.Collections.Generic;
using System.Text;

namespace oop5Assign
{
    internal class Driver
    {
        public Driver(int driverId, string fullName, string phoneNumber)
        {
            DriverId = driverId;
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }
        public int DriverId { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

    }
}
