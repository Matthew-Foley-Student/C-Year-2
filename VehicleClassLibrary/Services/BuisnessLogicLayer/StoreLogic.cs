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
using VehicleClassLibrary.Services.DataAccessLayer;

namespace VehicleClassLibrary.Services.BuisnessLogicLayer
{
    public class StoreLogic
    {
        //Declare a local variable
        private StoreDAO _storeDAO;

        /// <summary>
        /// Default constructor
        /// </summary>
        public StoreLogic()
        {
            _storeDAO = new StoreDAO();
        }

        /// <summary>
        /// Get the vehicle list
        /// </summary>
        /// <returns></returns>
        public List<VehicleModel> GetInventory()
        {
            return _storeDAO.GetInventory();
        }
    /// <summary>
    /// Get the vehicles in the shopping cart
    /// </summary>
    /// <returns></returns>
        public List<VehicleModel> GetShoppingCart()
        {
            return _storeDAO.GetShoppingCart();
        }

        /// <summary>
        /// add a new vehicle to the inventory
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        public int AddVehicleToInventory(VehicleModel vehicle)
        {
            return _storeDAO.AddVehicleToInventory(vehicle);
        }

        /// <summary>
        /// Add a new vehicle to the cart
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        public int AddVehicleToCart(int vehicleId)
        {
            return _storeDAO.AddVehicleToCart(vehicleId);
        }

        /// <summary>
        /// Write to a text file
        /// </summary>
        public void WriteInventory()
        {
            _storeDAO.WriteInventory();
        }

        /// <summary>
        /// read from a text file
        /// </summary>
        /// <returns></returns>
        public List<VehicleModel> ReadInventory()
        {
            return _storeDAO.ReadInventory();
        }

        /// <summary>
        /// Calls the checkout command
        /// </summary>
        /// <returns></returns>
        public decimal Checkout()
        {
            return _storeDAO.Checkout();
        }
    }
}
