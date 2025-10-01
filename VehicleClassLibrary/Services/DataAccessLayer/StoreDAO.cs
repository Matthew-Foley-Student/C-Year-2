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
using VehicleClassLibrary.Models;

namespace VehicleClassLibrary.Services.DataAccessLayer
{
    public class StoreDAO
    {
        //CarModel list for the stores inventory
        private List<VehicleModel> _inventory;
        //chapping cart list
        private List<VehicleModel> _shoppingCart;
        //text file for inventory
        private string _fileDirectory = "Data";
        //specifying name for the inventory file
        private string _textFile = "inventory.txt";
        //path used to reach the inventory file
        private string _filePath;

        /// <summary>
        /// Default constructor
        /// </summary>
        public StoreDAO()
        {
            //Initiate the model list
            _inventory = new List<VehicleModel>();
            _shoppingCart = new List<VehicleModel>();
            //set up the file for the inventory
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _fileDirectory, _textFile);
        }

        /// <summary>
        /// Get summery of the inventory
        /// </summary>
        /// <returns></returns>
        public List<VehicleModel> GetInventory()
        {
            return _inventory;
        }

        /// <summary>
        /// Get summery of the shopping cart
        /// </summary>
        /// <returns></returns>
        public List<VehicleModel> GetShoppingCart()
        {
            return _shoppingCart;
        }

        /// <summary>
        /// Add vehicles to the inventory
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        public int AddVehicleToInventory(VehicleModel vehicle)
        {
            //set the Id's
            vehicle.Id = _inventory.Count + 1;
            //add the vehicle to the list for inventory
            _inventory.Add(vehicle);
            //return the id for the new vehicle
            return vehicle.Id;
        }

        /// <summary>
        /// Add vehicles to the shopping cart using their Id's
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        public int AddVehicleToCart(int vehicleId)
        {
            //loop the inventory to find the needed vehicle
            for (int i = 0; i < _inventory.Count; i++)
            {
                if (_inventory[i].Id == vehicleId)
                {
                    _shoppingCart.Add(_inventory[i]);
                }
            }
            return _shoppingCart.Count;
        }

        /// <summary>
        /// Write the inventory to a text file
        /// </summary>
        public bool WriteInventory()
        {
            //Check If the File Exists
            if (!Directory.Exists(_fileDirectory))
            {
                Directory.CreateDirectory(_fileDirectory);
            }

            //create the stream writer to write into the file
            try
            {
                using(StreamWriter writer = new StreamWriter(_filePath))
                {
                    foreach (VehicleModel vehicle in _inventory)
                    {
                        Type vehicleType = vehicle.GetType();
                        switch (vehicleType.Name)
                        {
                            case "CarModel":
                                //cast the vehicle
                                CarModel car = (CarModel)vehicle;
                                //write to file
                                writer.WriteLine($"Car, {car.Make}, {car.Model}, {car.Year}, {car.Price},{car.NumWheels}, {car.IsConvertible}, {car.TrunkSize}");
                                break;
                            case "MotorcycleModel":
                                //Cast the motorcycle
                                MotorCycleModel motorcycle = (MotorCycleModel)vehicle;
                                //Write the motorcycle
                                writer.WriteLine($"Motorcycle, {motorcycle.Make}, {motorcycle.Model}, {motorcycle.Year}, {motorcycle.Price}, {motorcycle.NumWheels}, {motorcycle.HasSideCar}, {motorcycle.SeatHeight}");
                                break;
                            case "PickupModel":
                                //Cast the pickup
                                PickupModel pickup = (PickupModel)vehicle;
                                //Write the pickup
                                writer.WriteLine($"Pickup, {pickup.Make}, {pickup.Model}, {pickup.Year}, {pickup.Price}, {pickup.NumWheels}, {pickup.HasBedCover}, {pickup.BedSize}");
                                break;
                            default:
                                writer.WriteLine($"Vehicle, {vehicle.Make}, {vehicle.Model}, {vehicle.Year}, {vehicle.Price}, {vehicle.NumWheels} ");
                                break;
                        }

                    }

                }return true;
            }
            catch (Exception)
            {
                return false;
            }

         }//End of the writing method

        public List<VehicleModel> ReadInventory() 
        {
            //Declare and initilize
            string? line = "";
            string[] parts = [];
            string make = "", model = "";
            int year = 0, numWheels = 0;
            decimal price = 0m;
            //specialty vehicle variables
            bool isConvertible = false, hasSideCar = false, hasBedCover = false;
            decimal trunkSize = 0m, seatHeight = 0m, bedSize = 0m;

            try
            {
                //make sure file exists
                if (File.Exists(_filePath))
                {
                    //creat the streamreader
                    using (StreamReader reader = new StreamReader(_filePath))
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            //split the line's by commas plus a space creating an array of sperate parts
                            parts = line.Split(", ");

                            //use the newly made array to make the car data
                            make = parts[1];
                            model = parts[2];
                            //remember to parse the next varibales to ensure there are no errors converting from string to their respective points
                            year = ParseInteger(parts[3]);
                            price = ParseDecimal(parts[4]);
                            numWheels = ParseInteger(parts[5]);

                            //Use the first piece of data to create a switch for a spacific model
                            switch (parts[0])
                            {
                                case "Car":
                                    //remember to parse the data points
                                    isConvertible = ParseBoolean(parts[6]);
                                    trunkSize = ParseDecimal(parts[7]);
                                    CarModel car = new CarModel(0, make, model, year, price, numWheels, isConvertible, trunkSize);
                                    AddVehicleToInventory(car);
                                    break;

                                case "Motorcycle":
                                    //remember to parse the data points
                                    hasSideCar = ParseBoolean(parts[6]);
                                    seatHeight = ParseDecimal(parts[7]);
                                    MotorCycleModel motorcycle = new MotorCycleModel(0, make, model, year, price, numWheels, hasSideCar, seatHeight);
                                    AddVehicleToInventory(motorcycle);
                                    break;

                                case "Pickup":
                                    //remember to parse the data points
                                    hasBedCover = ParseBoolean(parts[6]);
                                    bedSize = ParseDecimal(parts[7]);
                                    PickupModel pickup = new PickupModel(0, make, model, year, price, numWheels, hasBedCover, bedSize);
                                    AddVehicleToInventory(pickup);
                                    break;

                                default:
                                    //make a standard vehicle with no added data points
                                    VehicleModel vehicle = new VehicleModel(0, make, model, year, price, numWheels);
                                    AddVehicleToInventory(vehicle);
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //return the inventory list
                return _inventory;
            }
            //return the inventory list
            return _inventory;
            }//End of the Inventory reader

/// <summary>
/// Method that sfely parses int's
/// </summary>
/// <param name="input"></param>
/// <returns></returns>
private int ParseInteger(string input)
        {
            try
            {
                //parse the input
                return int.Parse(input);
            }
            catch(Exception ex)
            {
                //return 0
                return 0;
                //return 0;
            }
        }

        /// <summary>
        /// Method to safely parse decimals
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private decimal ParseDecimal(string input)
        {
            try
            {
                //Parse in the input
                return decimal.Parse(input);
            }
            catch(Exception ex)
            {
                //return 0
                return 0m;
            }
        }

        /// <summary>
        /// Method to safely parse a boolean
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private bool ParseBoolean(string input)
        {
            try
            {
                //Parse the input
                return bool.Parse(input);
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public decimal Checkout()
        {
            decimal total = 0m;
            foreach(VehicleModel vehicle in _shoppingCart)
            {
                total += vehicle.Price;
            }
            _shoppingCart.Clear();
            return total;
        }
            
        }
}





