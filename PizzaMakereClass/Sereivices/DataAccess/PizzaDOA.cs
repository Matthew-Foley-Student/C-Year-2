/*
 * Matthew Foley
 * CST-250
 * 10/20/2025
 * Activity 2
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaMaker.Models;
using PizzaMakereClass.Sereivices.DataAccess;


namespace PizzaMakereClass.Sereivices.DataAccess
{
    public class PizzaDOA
    {
        private List<PizzaModel> _pizzaOrder;

        public PizzaDOA()
        {
            _pizzaOrder = new List<PizzaModel>();
        }

        public int AddPizzaToOrder(PizzaModel newPizza)
        {
            _pizzaOrder.Add(newPizza);
            return _pizzaOrder.Count;
        }

        public List<PizzaModel> GetPizzaOrder()
        {
            return _pizzaOrder;
        }

        public bool WriteOrderToFile()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data");
            string pizzaString = "";
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            try
            {
                using(StreamWriter streamwriter = new StreamWriter(Path.Combine(filePath, "PizzaOrder.txt")))
                {
                    foreach(PizzaModel pizza in _pizzaOrder)
                    {
                        pizzaString=
                    $"Name: {pizza.ClientName}\n" +
                    $"Ingrediants: {string.Join(", ", pizza.Ingrediants)}\n" +
                    $"Strange AddOns: {string.Join(", ", pizza.StrangeAddOns)}\n" +
                    $"Crust: {pizza.Crust}\n" +
                    $"Sauce: {pizza.SauceQty}\n" +
                    $"Cheese: {pizza.CheeseQty}\n" +
                    $"Delivery Time: {pizza.DeliveryTime}\n" +
                    $"Box Color: {pizza.PizzaBox}\n" +
                    $"Price: {pizza.Price}\n\n";
                        streamwriter.WriteLine(pizzaString);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
