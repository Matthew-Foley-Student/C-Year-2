/*
 * Matthew Foley
 * CST-250
 * 10/20/2025
 * Activity 2
 */
using PizzaMaker.Models;
using PizzaMakereClass.Sereivices.BuisnessLogic;

namespace PizzaMaker
{
    public partial class FrmPizzaMaker : Form
    {
        private PizzaModel _pizza;
        private PizzaLogic _pizzaLogic;
        public FrmPizzaMaker()
        {
            InitializeComponent();
            _pizza = new PizzaModel();
            _pizzaLogic = new PizzaLogic();
            btnFinishOrder.Enabled = false;
            btnFormReset.Enabled = false;
            btnOrderList.Enabled = false;
            UpdatePrice();
            hsbSauce.Maximum = 100 + hsbSauce.LargeChange - 1;
            hsbCheese.Maximum = 100 + hsbCheese.LargeChange - 1;
        }

        public void EnablePizza()
        {
            btnFinishOrder.Enabled = true;
            btnFormReset.Enabled = true;
        }

        private void TxtNameLeaeve(object sender, EventArgs e)
        {
            _pizza.ClientName = txtName.Text;
        }

        public void UpdatePrice()
        {
            decimal price = 15;
            price += (_pizza.Ingrediants.Count * .5m);

            if (_pizza.Crust == "Gluten Free")
            {
                price += 1;
            }
            _pizza.Price = price;
            lblPizzaPrice.Text = $"{price:C2}";
        }

        private void ChbIngrediantCheckedChange(object sender, EventArgs e)
        {
            CheckBox checkbox = sender as CheckBox;
            if (checkbox != null)
            {
                if (checkbox.Checked)
                {
                    _pizza.Ingrediants.Add(checkbox.Text);
                }
                else
                {
                    _pizza.Ingrediants.Remove(checkbox.Text);
                }
            }
            UpdatePrice();
        }

        private void LsbStrangeAddOnsChange(object sender, EventArgs e)
        {
            _pizza.StrangeAddOns = lsbStrangeAddOns.SelectedItems.Cast<string>().ToList();
            UpdatePrice();
        }

        private void RdoCrustChange(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                _pizza.Crust = radioButton.Text;
            }
            UpdatePrice();
        }

        private void HsbExtraValueChange(object sender, EventArgs e)
        {
            HScrollBar scrollBar = sender as HScrollBar;
            if (scrollBar != null)
            {
                if (scrollBar == hsbSauce)
                {
                    _pizza.SauceQty = scrollBar.Value;
                    lblSauce.Text = scrollBar.Value.ToString();
                }
                else if (scrollBar == hsbCheese)
                {
                    _pizza.CheeseQty = scrollBar.Value;
                    lblCheese.Text = scrollBar.Value.ToString();
                }
            }
        }

        private void DtpDelivereytimeChange(object sender, EventArgs e)
        {
            _pizza.DeliveryTime = dtpDeliverey.Value;
        }

        private void PicPizzaBoxClick(object sender, EventArgs e)
        {
            ColorDialog pizzaBoxColorPick = new ColorDialog();
            DialogResult result = pizzaBoxColorPick.ShowDialog();
            if (result == DialogResult.OK)
            {
                _pizza.PizzaBox = pizzaBoxColorPick.Color;
                picPizzaBox.BackColor = pizzaBoxColorPick.Color;
                EnablePizza();
            }
        }

        private void ResetFormClick(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            _pizza = new PizzaModel();
            ResetControls(this);
            UpdatePrice();
        }

        private void ResetControls(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                Type controlType = control.GetType();
                string type = controlType.Name.ToString();
                switch (type)
                {
                    case "TextBox":
                        TextBox textbox = (TextBox)control;
                        textbox.Clear();
                        break;
                    case "CheckBox":
                        CheckBox checkBox = (CheckBox)control;
                        checkBox.Checked = false;
                        break;
                    case "ListBox":
                        ListBox listBox = (ListBox)control;
                        listBox.ClearSelected();
                        break;
                    case "RadioButton":
                        RadioButton radioButton = (RadioButton)control;
                        radioButton.Checked = false;
                        break;
                    case "HScrollBar":
                        HScrollBar hScrollBar = (HScrollBar)control;
                        hScrollBar.Value = 0;
                        break;
                    case "DateTimePicker":
                        DateTimePicker dateTimePicker = (DateTimePicker)control;
                        dateTimePicker.Value = new DateTime(2025, 1, 1, 0, 0, 0);
                        break;
                    case "PictureBox":
                        PictureBox pictureBox = (PictureBox)control;
                        pictureBox.BackColor = SystemColors.Control;
                        break;
                }
                if (control.HasChildren)
                {
                    ResetControls(control);
                }
            }
        }//end of reset controls

        private void CreatePizza(object sender, EventArgs e)
        {
            bool isValidPizza = false;
            int pizzaOrder = -1;
            (isValidPizza, pizzaOrder) = _pizzaLogic.AddPizzaToOrder(_pizza);
            if (isValidPizza)
            {                
                btnOrderList.Enabled = true;
                ResetForm();
            }
            else
            {
                MessageBox.Show("Your Order Is Incmoplete.");
            }
        }

        private void SeeOrderList(object sender, EventArgs e)
        {
            List<PizzaModel> pizzaList;
            pizzaList = _pizzaLogic.GetPizzaOrdere();
            frmOrderDetails frmOrderDetails = new frmOrderDetails(pizzaList, _pizzaLogic);
            frmOrderDetails.DisplayPizzas();
            frmOrderDetails.ShowDialog();
        }
    }
}
