/*
 * Matthew Foley
 * CST - 250
 * 9/29/2025
 * Vehicle Class Library
 * Activity 1
 */
using VehicleClassLibrary.Models;
using VehicleClassLibrary.Services.BuisnessLogicLayer;

namespace VehicleStoreGUIApp
{
    public partial class FrmVehicleStore : Form
    {
        string currentVehicleType;
        bool isVehicleTypeValid = false, isMakeValid = false, isModelValid = false, isYearValid = false;
        bool isPriceValid = false, isWheelsValid = false, isSpecialtyBoolean = false, isSpecialtyDecimal = false;
        private StoreLogic _storeLogic;
        private BindingSource _inventoryBindingSource;
        private BindingSource _shoppingCartBindingSource;


        public FrmVehicleStore()
        {
            InitializeComponent();
            currentVehicleType = "";
            //make all appropriate labels visible
            lblSpecialBoolean.Visible = false;
            rdoSpcialYes.Visible = false;
            rdoSpecialNo.Visible = false;
            lblSpecialDecimal.Visible = false;
            txtSpecialDecimal.Visible = false;
            lblVehicleError.Visible = false;
            lblMakeError.Visible = false;
            lblModelError.Visible = false;
            lblYearError.Visible = false;
            lblPriceError.Visible = false;
            lblWheelError.Visible = false;
            lblSpecialBooleanError.Visible = false;
            lblDecimalError.Visible = false;
            _storeLogic = new StoreLogic();

            //Bind the data lists as sources and then display them to the approperiate ListBoxes
            _inventoryBindingSource = new BindingSource();
            _shoppingCartBindingSource = new BindingSource();
            _inventoryBindingSource.DataSource = _storeLogic.GetInventory();
            _shoppingCartBindingSource.DataSource = _storeLogic.GetShoppingCart();
            lstInventory.DataSource = _inventoryBindingSource;
            lstShoppingCart.DataSource = _shoppingCartBindingSource;


        }

        /// <summary>
        /// Click Event for Car's
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoCarClick(object sender, EventArgs e)
        {
            currentVehicleType = "Car";
            //change the label texts for specialties
            lblSpecialBoolean.Text = "Is the Car a Convertible?:";
            lblSpecialDecimal.Text = "What is the Trunk Size (in cubic feet)?: ";
            //make all appropriate labels visible
            lblSpecialBoolean.Visible = true;
            rdoSpcialYes.Visible = true;
            rdoSpecialNo.Visible = true;
            lblSpecialDecimal.Visible = true;
            txtSpecialDecimal.Visible = true;
            ValidateVehicalType();
        }

        /// <summary>
        /// Click Event for the Motorcycles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoMotorcycleClick(object sender, EventArgs e)
        {
            currentVehicleType = "MotorCycle";
            //change the label texts for specialties
            lblSpecialBoolean.Text = "Does the Motorcycle have a Side Car?:";
            lblSpecialDecimal.Text = "How tall is the Mototcycle (in feet)?: ";
            //make all appropriate labels visible
            lblSpecialBoolean.Visible = true;
            rdoSpcialYes.Visible = true;
            rdoSpecialNo.Visible = true;
            lblSpecialDecimal.Visible = true;
            txtSpecialDecimal.Visible = true;
            ValidateVehicalType();
        }

        /// <summary>
        /// Click Event for the Pickup Trucks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoPickupClick(object sender, EventArgs e)
        {
            currentVehicleType = "Pickup";
            //change the label texts for specialties
            lblSpecialBoolean.Text = "Does the Pickup-Truck have a BedCover ?:";
            lblSpecialDecimal.Text = "What is the Bed Size (in cubic feet)?: ";
            //make all appropriate labels visible
            lblSpecialBoolean.Visible = true;
            rdoSpcialYes.Visible = true;
            rdoSpecialNo.Visible = true;
            lblSpecialDecimal.Visible = true;
            txtSpecialDecimal.Visible = true;
            ValidateVehicalType();
        }

        /// <summary>
        /// Click Event for non-discript vehicles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoVehicleClick(object sender, EventArgs e)
        {
            currentVehicleType = "Vehicle";
            lblSpecialBoolean.Visible = false;
            rdoSpcialYes.Visible = false;
            rdoSpecialNo.Visible = false;
            lblSpecialDecimal.Visible = false;
            txtSpecialDecimal.Visible = false;
            ValidateVehicalType();
        }

        private void FrmVehicleStore_Load(object sender, EventArgs e)
        {
            lblSpecialBoolean.Visible = false;
            rdoSpcialYes.Visible = false;
            rdoSpecialNo.Visible = false;
            lblSpecialDecimal.Visible = false;
            txtSpecialDecimal.Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int id = 0;
            string make = "", model = "";
            int year = -1, wheels = -1;
            decimal price = -1m, specialtyDecimal = -1;
            bool specialtyBoolean = false;
            VehicleModel vehicle;

            //validate eveything
            ValidateVehicalType();
            make = ValidatetxtMake();
            model = ValidatetxtModel();
            year = ValidateTxtYear();
            price = ValidateTxtPrice();
            wheels = ValidateTxtWheels();
            specialtyBoolean = ValidateSpcialBoolean();
            specialtyDecimal = ValidateSpecialDecimal();

            if (isVehicleTypeValid && isMakeValid && isModelValid && isYearValid && isPriceValid && isWheelsValid && isSpecialtyBoolean && isSpecialtyDecimal)
            {
                switch (currentVehicleType)
                {
                    case "Car":
                        vehicle = new CarModel(id, make, model, year, price, wheels, specialtyBoolean, specialtyDecimal);
                        break;
                    case "Motorcycle":
                        vehicle = new MotorCycleModel(id, make, model, year, price, wheels, specialtyBoolean, specialtyDecimal);
                        break;
                    case "Pickup":
                        vehicle = new PickupModel(id, make, model, year, price, wheels, specialtyBoolean, specialtyDecimal);
                        break;
                    default:
                        vehicle = new VehicleModel(id, make, model, year, price, wheels);
                        break;
                }
                _storeLogic.AddVehicleToInventory(vehicle);
                MessageBox.Show($"The Following car has been added to the Inventory:\n{vehicle}");
                rdoCar.Checked = false;
                rdoMotorCycle.Checked = false;
                rdoPickup.Checked = false;
                rdoVehicle.Checked = false;
                txtMake.Clear();
                txtModel.Clear();
                txtYear.Clear();
                txtPrice.Clear();
                txtWheels.Clear();
                rdoSpcialYes.Checked = false;
                rdoSpecialNo.Checked = false;
                txtSpecialDecimal.Clear();

                //refresh the lists for displaying
                _inventoryBindingSource.ResetBindings(false);
            }

        }

        /// <summary>
        /// Validates that the vehicle is selected
        /// </summary>
        private void ValidateVehicalType()
        {
            if (rdoCar.Checked || rdoMotorCycle.Checked || rdoPickup.Checked || rdoVehicle.Checked)
            {
                //Hiding errors and setting flags
                lblVehicleError.Visible = false;
                isVehicleTypeValid = true;
            }
            else
            {
                //Showing error and setting flags
                lblVehicleError.Visible = true;
                isVehicleTypeValid = false;
            }
        }

        private string ValidatetxtMake()
        {
            if (string.IsNullOrEmpty(txtMake.Text))
            {
                lblMakeError.Visible = true;
                isMakeValid = false;
            }
            else
            {
                lblMakeError.Visible = false;
                isMakeValid = true;
            }
            return txtMake.Text;
        }

        private string ValidatetxtModel()
        {
            if (string.IsNullOrEmpty(txtModel.Text))
            {
                lblModelError.Visible = true;
                isModelValid = false;
            }
            else
            {
                lblModelError.Visible = false;
                isModelValid = true;
            }
            return txtModel.Text;
        }

        private int ValidateTxtYear()
        {
            int yearValue = -1;
            if (string.IsNullOrEmpty(txtYear.Text))
            {
                lblYearError.Visible = true;
                isYearValid = false;
            }
            else
            {
                lblYearError.Visible = false;
                isYearValid = int.TryParse(txtYear.Text, out yearValue);
                if (!isYearValid)
                {
                    lblYearError.Visible = true;
                }
            }
            return yearValue;
        }

        private decimal ValidateTxtPrice()
        {
            decimal priceValue = -1;
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                lblPriceError.Visible = true;
                isPriceValid = false;
            }
            else
            {
                lblPriceError.Visible = false;
                isPriceValid = decimal.TryParse(txtPrice.Text, out priceValue);
                if (!isPriceValid)
                {
                    lblPriceError.Visible = true;
                }
            }
            return priceValue;
        }

        private int ValidateTxtWheels()
        {
            int wheelsValue = -1;
            if (string.IsNullOrEmpty(txtWheels.Text))
            {
                lblWheelError.Visible = true;
                isWheelsValid = false;
            }
            else
            {
                lblWheelError.Visible = false;
                isWheelsValid = int.TryParse(txtWheels.Text, out wheelsValue);
                if (!isWheelsValid)
                {
                    lblWheelError.Visible = true;
                }
            }
            return wheelsValue;
        }

        private bool ValidateSpcialBoolean()
        {
            if (currentVehicleType != "Vehicle")
            {
                if (rdoSpcialYes.Checked || rdoSpecialNo.Checked)
                {
                    lblSpecialBooleanError.Visible = false;
                    isSpecialtyBoolean = true;
                }
                else
                {
                    lblSpecialBooleanError.Visible = true;
                    isSpecialtyBoolean = false;
                }
            }
            else
            {
                lblSpecialBooleanError.Visible = false;
                isSpecialtyBoolean = true;
            }
            return rdoSpcialYes.Checked;
        }

        private decimal ValidateSpecialDecimal()
        {
            decimal specialDecimalValue = -1;
            if (currentVehicleType != "Vehicle")
            {
                if (string.IsNullOrEmpty(txtSpecialDecimal.Text))
                {
                    lblDecimalError.Visible = true;
                    isSpecialtyDecimal = false;
                }
                else
                {
                    lblDecimalError.Visible = false;
                    isSpecialtyDecimal = decimal.TryParse(txtSpecialDecimal.Text, out specialDecimalValue);

                    if (!isSpecialtyDecimal)
                    {
                        lblDecimalError.Visible = true;
                    }
                }
            }
            else
            {
                lblSpecialDecimal.Visible = false;
                isSpecialtyDecimal = decimal.TryParse(txtSpecialDecimal.Text, out specialDecimalValue);
                if (!isSpecialtyDecimal)
                {
                    lblDecimalError.Visible = true;
                }
            }
            return specialDecimalValue;
        }

        private void txtMakeLeave(object sender, EventArgs e)
        {
            ValidatetxtMake();
        }

        private void txtModelLeave(object sender, EventArgs e)
        {
            ValidatetxtModel();
        }

        private void txtYearLeave(object sender, EventArgs e)
        {
            ValidateTxtYear();
        }

        private void txtPriceLeave(object sender, EventArgs e)
        {
            ValidateTxtPrice();
        }

        private void txtWheelsLeave(object sender, EventArgs e)
        {
            ValidateTxtWheels();
        }

        private void txtSpecialLeave(object sender, EventArgs e)
        {
            ValidateSpecialDecimal();
        }

        private void SpecialtyBoolYes(object sender, EventArgs e)
        {
            ValidateSpcialBoolean();
        }

        private void SpecialtyBoolNo(object sender, EventArgs e)
        {
            ValidateSpcialBoolean();
        }

        private void BtnAddToCartEH(object sender, EventArgs e)
        {
            //select a car from the list and then add that to the shopping cart
            VehicleModel vehicle = (VehicleModel)lstInventory.SelectedItem;
            _storeLogic.AddVehicleToCart(vehicle.Id);
            _shoppingCartBindingSource.ResetBindings(false);
        }

        private void BtnCheckoutClick(object sender, EventArgs e)
        {
            decimal total = _storeLogic.Checkout();
            lblTotal.Text = total.ToString("C");
            _shoppingCartBindingSource.ResetBindings(false);
        }
    }//End of the form

}


