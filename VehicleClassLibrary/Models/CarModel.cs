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
    public class CarModel : VehicleModel
    {
        //Class level properties
        public bool IsConvertible { get; set; }
        public decimal TrunkSize { get; set; }//cubic feet

        /// <summary>
        /// Default Constructor for a car model
        /// </summary>
        public CarModel() : base()
        {
            IsConvertible = false;
            TrunkSize = 0m;
        }

        /// <summary>
        /// Parmaerters for the car model
        /// </summary>
        /// <param name="id"></param>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="price"></param>
        /// <param name="numWheels"></param>
        /// <param name="isConvertable"></param>
        /// <param name="trunkSize"></param>
        public CarModel(int id, string make, string model, int year, decimal price, int numWheels, bool isConvertable, decimal trunkSize): 
            base(id, make, model, year, price, numWheels)
        {
            IsConvertible = isConvertable;
            TrunkSize = trunkSize;
        }

        /// <summary>
        /// ToString method for printing a car
        /// </summary>
        /// <returns></returns>
        public override string ToString()
            
        {
            // Use a ternary operator for a true false condition
            string convertible = IsConvertible ? "with" : "Without";
            //Printing format to include the new information
            return $"{Id}: {Year} {Make} {Model} with {NumWheels} wheels and a {TrunkSize} cubic foot trunk {convertible} a convertible top - {Price:C2}";
        }
    }
}
