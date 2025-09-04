using System;
using RentCar.Entities;
using RentCar.Services;

namespace RentCar.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PicePerDay { get; private set; }

        public RentalService(double pricePerHour, double picePerDay)
        {
            PricePerHour = pricePerHour;
            PicePerDay = picePerDay;
        }

        public void ProcessInvoide(CarRental carRental)
        {

        }
    }
}
