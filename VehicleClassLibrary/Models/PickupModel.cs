/*
 * Matthew Foley
 * CST - 250
 * 9/29/2025
 * Vehicle Class Library
 * Activity 1
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClassLibrary.Models
{
    public class PickupModel : VehicleModel
    {
        //setting properties
        public bool HasBedCover { get; set; }
        public decimal BedSize { get; set; }

        /// <summary>
        /// Default constructors
        /// </summary>
        public PickupModel(): base()
        {
            HasBedCover = false;
            BedSize = 0m;
        }

        /// <summary>
        /// setting up parameters
        /// </summary>
        /// <param name="id"></param>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="price"></param>
        /// <param name="numWheels"></param>
        /// <param name="hasBedCover"></param>
        /// <param name="bedSize"></param>
        public PickupModel(int id, string make, string model, int year, decimal price, int numWheels, bool hasBedCover, decimal bedSize):
            base(id, make, model, year, price, numWheels)
        {
            HasBedCover = hasBedCover;
            BedSize = bedSize;
        }

        public override string ToString() 
        {
            //Use a ternary operator for the conditions
            string bedCover = HasBedCover ? "with" : "without";
            //set the printed format
            return $"{Id}: {Year} {Make} {Model} with {NumWheels} wheels and a {BedSize} cubic foor bed {bedCover} a bed cover - {Price:C2}";
        }
    }
}
