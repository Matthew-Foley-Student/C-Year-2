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
    public class MotorCycleModel : VehicleModel
    {
        //Class level properties
        public bool HasSideCar { get; set; }
        public decimal SeatHeight { get; set; }
    

        /// <summary>
        /// Default constructor for the motercycles
        /// </summary>
    public MotorCycleModel() : base()
        {
            HasSideCar = false;
            SeatHeight = 0m;
        }

        /// <summary>
        /// setting parameters for the motorcycles
        /// </summary>
        /// <param name="id"></param>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="price"></param>
        /// <param name="numWheels"></param>
        /// <param name="hasSideCar"></param>
        /// <param name="seatHeight"></param>
        public MotorCycleModel(int id, string make, string model, int year, decimal price, int numWheels, bool hasSideCar, decimal seatHeight): 
            base(id, make, model, year, price, numWheels)
        {
            HasSideCar = hasSideCar;
            SeatHeight = seatHeight;
        }

        public override string ToString() 
        {
            //use ternary operators to set string condition
            string sideCar = HasSideCar ? "with" : "without";
            //set the printing format for the motorcycles
            return $"{Id}: {Year} {Make} {Model} with {NumWheels} wheels and a {SeatHeight} inch seat {sideCar} a side car - {Price:C2}";
        }
    }
}
