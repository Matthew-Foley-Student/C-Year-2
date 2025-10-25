/*
 * Matthew Foley
 * CST-250
 * 10/20/2025
 * Activity 2
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PizzaMaker.Models;
using PizzaMakereClass.Sereivices.DataAccess;

namespace PizzaMakereClass.Sereivices.BuisnessLogic
{
    public class PizzaLogic
    {
        private PizzaDOA _pizzaDOA;
        public PizzaLogic()
        {
            _pizzaDOA = new PizzaDOA();

           
        } 
        public(bool isValidPizza,int pizzaInOrdeer) AddPizzaToOrder(PizzaModel newPizza)
        {
            int pizzas = -1;
            pizzas = _pizzaDOA.AddPizzaToOrder(newPizza);
            return (true, pizzas);
        }
        public List<PizzaModel> GetPizzaOrdere()
        {
            return _pizzaDOA.GetPizzaOrder();
        }
        public bool WriteOrderToFile()
        {
            return _pizzaDOA.WriteOrderToFile();
        }
    }
}
