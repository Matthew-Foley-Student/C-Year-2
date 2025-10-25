/*
 * Matthew Foley
 * CST-250
 * 10/20/2025
 * Activity 2
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMaker.Models
{
    public class PizzaModel
    {
        public string ClientName {  get; set; }
        public List<string> Ingrediants { get; set; }
        public List <string> StrangeAddOns { get; set; }
        public string Crust {  get; set; }
        public int SauceQty { get; set; }
        public int CheeseQty { get; set; }
        public DateTime DeliveryTime { get; set; }
        public Color PizzaBox {  get; set; }
        public decimal Price { get; set; }

        public PizzaModel()
        {
            ClientName = "Unknown";
            Ingrediants = new List<string>();
            StrangeAddOns= new List<string>();
            Crust = "Unkown";
            SauceQty = 0;
            CheeseQty = 0;
            DeliveryTime = DateTime.Now;
            PizzaBox = Color.White;
            Price = 15m;
        }
    }
}
