/*
 * Matthew Foley
 * CST-250
 * 10/20/2025
 * Activity 2
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzaMaker.Models;
using PizzaMakereClass.Sereivices.BuisnessLogic;

namespace PizzaMaker
{
    public partial class frmOrderDetails : Form
    {
        private List<PizzaModel> _pizzaOrder;
        private PizzaLogic _pizzaLogic;

        public frmOrderDetails(List<PizzaModel> pizzaOrderList, PizzaLogic pizzaBuisnessLogic)
        {
            InitializeComponent();
            _pizzaOrder = pizzaOrderList;
            _pizzaLogic = pizzaBuisnessLogic;
        }

        public void DisplayPizzas()
        {
            lblOrderDetails.Text = "";
            foreach (PizzaModel pizza in _pizzaOrder)
            {
                lblOrderDetails.Text +=
                    $"Name: {pizza.ClientName}\n" +
                    $"Ingrediants: {string.Join(", ", pizza.Ingrediants)}\n" +
                    $"Strange AddOns: {string.Join(", ", pizza.StrangeAddOns)}\n" +
                    $"Crust: {pizza.Crust}\n" +
                    $"Sauce: {pizza.SauceQty}\n" +
                    $"Cheese: {pizza.CheeseQty}\n" +
                    $"Delivery Time: {pizza.DeliveryTime}\n" +
                    $"Box Color: {pizza.PizzaBox}\n" +
                    $"Price: {pizza.Price}\n\n";
            }
        }

        private void SaveOrder(object sender, EventArgs e)
        {
            bool isSaveSuccesfull = false;
            isSaveSuccesfull = _pizzaLogic.WriteOrderToFile();
            if (isSaveSuccesfull)
            {
                MessageBox.Show("The Pizza Order Is Saved");
            }
            else
            {
                MessageBox.Show("An Unexpeted Error Showed,Check the Order Then Try Again");
            }
        }
    }
}
