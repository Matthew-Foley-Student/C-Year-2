namespace VehicleStoreGUIApp
{
    partial class FrmVehicleStore
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            lblWheelError = new Label();
            lblPriceError = new Label();
            lblYearError = new Label();
            lblModelError = new Label();
            lblMakeError = new Label();
            lblVehicleError = new Label();
            btnCreate = new Button();
            txtWheels = new TextBox();
            label5 = new Label();
            txtPrice = new TextBox();
            rdoVehicle = new RadioButton();
            txtYear = new TextBox();
            label4 = new Label();
            txtModel = new TextBox();
            rdoCar = new RadioButton();
            txtMake = new TextBox();
            label3 = new Label();
            rdoPickup = new RadioButton();
            label2 = new Label();
            rdoMotorCycle = new RadioButton();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblDecimalError = new Label();
            lblSpecialBooleanError = new Label();
            txtSpecialDecimal = new TextBox();
            lblSpecialDecimal = new Label();
            rdoSpecialNo = new RadioButton();
            lblSpecialBoolean = new Label();
            rdoSpcialYes = new RadioButton();
            groupBox3 = new GroupBox();
            lstInventory = new ListBox();
            btnAddToCart = new Button();
            groupBox4 = new GroupBox();
            lstShoppingCart = new ListBox();
            btnCheckout = new Button();
            label8 = new Label();
            lblTotal = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblWheelError);
            groupBox1.Controls.Add(lblPriceError);
            groupBox1.Controls.Add(lblYearError);
            groupBox1.Controls.Add(lblModelError);
            groupBox1.Controls.Add(lblMakeError);
            groupBox1.Controls.Add(lblVehicleError);
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Controls.Add(txtWheels);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(rdoVehicle);
            groupBox1.Controls.Add(txtYear);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtModel);
            groupBox1.Controls.Add(rdoCar);
            groupBox1.Controls.Add(txtMake);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(rdoPickup);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(rdoMotorCycle);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(243, 388);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create A Vehicle";
            // 
            // lblWheelError
            // 
            lblWheelError.AutoSize = true;
            lblWheelError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWheelError.ForeColor = Color.Red;
            lblWheelError.Location = new Point(45, 337);
            lblWheelError.Name = "lblWheelError";
            lblWheelError.Size = new Size(190, 15);
            lblWheelError.TabIndex = 10;
            lblWheelError.Text = "Please Enter A Valid Wheel Count";
            // 
            // lblPriceError
            // 
            lblPriceError.AutoSize = true;
            lblPriceError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriceError.ForeColor = Color.Red;
            lblPriceError.Location = new Point(47, 293);
            lblPriceError.Name = "lblPriceError";
            lblPriceError.Size = new Size(146, 15);
            lblPriceError.TabIndex = 10;
            lblPriceError.Text = "Please Enter A Valid Price";
            // 
            // lblYearError
            // 
            lblYearError.AutoSize = true;
            lblYearError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYearError.ForeColor = Color.Red;
            lblYearError.Location = new Point(45, 242);
            lblYearError.Name = "lblYearError";
            lblYearError.Size = new Size(142, 15);
            lblYearError.TabIndex = 11;
            lblYearError.Text = "Please Enter A Valid Year";
            // 
            // lblModelError
            // 
            lblModelError.AutoSize = true;
            lblModelError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModelError.ForeColor = Color.Red;
            lblModelError.Location = new Point(45, 198);
            lblModelError.Name = "lblModelError";
            lblModelError.Size = new Size(124, 15);
            lblModelError.TabIndex = 10;
            lblModelError.Text = "Please Enter A Model";
            // 
            // lblMakeError
            // 
            lblMakeError.AutoSize = true;
            lblMakeError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMakeError.ForeColor = Color.Red;
            lblMakeError.Location = new Point(45, 153);
            lblMakeError.Name = "lblMakeError";
            lblMakeError.Size = new Size(120, 15);
            lblMakeError.TabIndex = 9;
            lblMakeError.Text = "Please Enter A Make";
            // 
            // lblVehicleError
            // 
            lblVehicleError.AutoSize = true;
            lblVehicleError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVehicleError.ForeColor = Color.Red;
            lblVehicleError.Location = new Point(35, 95);
            lblVehicleError.Name = "lblVehicleError";
            lblVehicleError.Size = new Size(132, 15);
            lblVehicleError.TabIndex = 8;
            lblVehicleError.Text = "Please Chose A Vehicle";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.White;
            btnCreate.BackgroundImageLayout = ImageLayout.None;
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.Location = new Point(57, 350);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(108, 32);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtWheels
            // 
            txtWheels.Location = new Point(45, 311);
            txtWheels.Name = "txtWheels";
            txtWheels.Size = new Size(136, 23);
            txtWheels.TabIndex = 5;
            txtWheels.Leave += txtWheelsLeave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 314);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 5;
            label5.Text = "Wheels:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(45, 267);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(136, 23);
            txtPrice.TabIndex = 4;
            txtPrice.Leave += txtPriceLeave;
            // 
            // rdoVehicle
            // 
            rdoVehicle.AutoSize = true;
            rdoVehicle.Location = new Point(94, 73);
            rdoVehicle.Name = "rdoVehicle";
            rdoVehicle.Size = new Size(109, 19);
            rdoVehicle.TabIndex = 4;
            rdoVehicle.TabStop = true;
            rdoVehicle.Text = "Unmodified Car";
            rdoVehicle.UseVisualStyleBackColor = true;
            rdoVehicle.Click += rdoVehicleClick;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(45, 216);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(136, 23);
            txtYear.TabIndex = 3;
            txtYear.Leave += txtYearLeave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 270);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 4;
            label4.Text = "Price:";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(45, 171);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(136, 23);
            txtModel.TabIndex = 2;
            txtModel.Leave += txtModelLeave;
            // 
            // rdoCar
            // 
            rdoCar.AutoSize = true;
            rdoCar.Location = new Point(0, 39);
            rdoCar.Name = "rdoCar";
            rdoCar.Size = new Size(43, 19);
            rdoCar.TabIndex = 1;
            rdoCar.TabStop = true;
            rdoCar.Text = "Car";
            rdoCar.UseVisualStyleBackColor = true;
            rdoCar.CheckedChanged += rdoCarClick;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(45, 127);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(136, 23);
            txtMake.TabIndex = 1;
            txtMake.Leave += txtMakeLeave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 219);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 3;
            label3.Text = "Year:";
            // 
            // rdoPickup
            // 
            rdoPickup.AutoSize = true;
            rdoPickup.Location = new Point(0, 73);
            rdoPickup.Name = "rdoPickup";
            rdoPickup.Size = new Size(94, 19);
            rdoPickup.TabIndex = 3;
            rdoPickup.TabStop = true;
            rdoPickup.Text = "Pickup-Truck";
            rdoPickup.UseVisualStyleBackColor = true;
            rdoPickup.Click += rdoPickupClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 171);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Model:";
            // 
            // rdoMotorCycle
            // 
            rdoMotorCycle.AutoSize = true;
            rdoMotorCycle.Location = new Point(94, 39);
            rdoMotorCycle.Name = "rdoMotorCycle";
            rdoMotorCycle.Size = new Size(87, 19);
            rdoMotorCycle.TabIndex = 2;
            rdoMotorCycle.TabStop = true;
            rdoMotorCycle.Text = "MotorCycle";
            rdoMotorCycle.UseVisualStyleBackColor = true;
            rdoMotorCycle.Click += rdoMotorcycleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 127);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Make:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblDecimalError);
            groupBox2.Controls.Add(lblSpecialBooleanError);
            groupBox2.Controls.Add(txtSpecialDecimal);
            groupBox2.Controls.Add(lblSpecialDecimal);
            groupBox2.Controls.Add(rdoSpecialNo);
            groupBox2.Controls.Add(lblSpecialBoolean);
            groupBox2.Controls.Add(rdoSpcialYes);
            groupBox2.Location = new Point(13, 417);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(242, 196);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Specialty Properites";
            // 
            // lblDecimalError
            // 
            lblDecimalError.AutoSize = true;
            lblDecimalError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDecimalError.ForeColor = Color.Red;
            lblDecimalError.Location = new Point(34, 158);
            lblDecimalError.Name = "lblDecimalError";
            lblDecimalError.Size = new Size(164, 15);
            lblDecimalError.TabIndex = 10;
            lblDecimalError.Text = "Please Enter A Valid Number";
            // 
            // lblSpecialBooleanError
            // 
            lblSpecialBooleanError.AutoSize = true;
            lblSpecialBooleanError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpecialBooleanError.ForeColor = Color.Red;
            lblSpecialBooleanError.Location = new Point(34, 85);
            lblSpecialBooleanError.Name = "lblSpecialBooleanError";
            lblSpecialBooleanError.Size = new Size(137, 15);
            lblSpecialBooleanError.TabIndex = 10;
            lblSpecialBooleanError.Text = "Please Select Yes Or No";
            // 
            // txtSpecialDecimal
            // 
            txtSpecialDecimal.Location = new Point(22, 132);
            txtSpecialDecimal.Name = "txtSpecialDecimal";
            txtSpecialDecimal.Size = new Size(148, 23);
            txtSpecialDecimal.TabIndex = 2;
            txtSpecialDecimal.Leave += txtSpecialLeave;
            // 
            // lblSpecialDecimal
            // 
            lblSpecialDecimal.AutoSize = true;
            lblSpecialDecimal.Location = new Point(44, 114);
            lblSpecialDecimal.Name = "lblSpecialDecimal";
            lblSpecialDecimal.Size = new Size(103, 15);
            lblSpecialDecimal.TabIndex = 3;
            lblSpecialDecimal.Text = "Specialty Decimal:";
            // 
            // rdoSpecialNo
            // 
            rdoSpecialNo.AutoSize = true;
            rdoSpecialNo.Location = new Point(111, 63);
            rdoSpecialNo.Name = "rdoSpecialNo";
            rdoSpecialNo.Size = new Size(41, 19);
            rdoSpecialNo.TabIndex = 3;
            rdoSpecialNo.TabStop = true;
            rdoSpecialNo.Text = "No";
            rdoSpecialNo.UseVisualStyleBackColor = true;
            rdoSpecialNo.Click += SpecialtyBoolNo;
            // 
            // lblSpecialBoolean
            // 
            lblSpecialBoolean.AutoSize = true;
            lblSpecialBoolean.Location = new Point(44, 32);
            lblSpecialBoolean.Name = "lblSpecialBoolean";
            lblSpecialBoolean.Size = new Size(93, 15);
            lblSpecialBoolean.TabIndex = 2;
            lblSpecialBoolean.Text = "Special Boolean:";
            // 
            // rdoSpcialYes
            // 
            rdoSpcialYes.AutoSize = true;
            rdoSpcialYes.Location = new Point(34, 63);
            rdoSpcialYes.Name = "rdoSpcialYes";
            rdoSpcialYes.Size = new Size(42, 19);
            rdoSpcialYes.TabIndex = 2;
            rdoSpcialYes.TabStop = true;
            rdoSpcialYes.Text = "Yes";
            rdoSpcialYes.UseVisualStyleBackColor = true;
            rdoSpcialYes.Click += SpecialtyBoolYes;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lstInventory);
            groupBox3.Location = new Point(278, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(230, 487);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "StoreInventory";
            // 
            // lstInventory
            // 
            lstInventory.FormattingEnabled = true;
            lstInventory.Location = new Point(6, 22);
            lstInventory.Name = "lstInventory";
            lstInventory.Size = new Size(218, 439);
            lstInventory.TabIndex = 3;
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.White;
            btnAddToCart.Location = new Point(514, 231);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(130, 82);
            btnAddToCart.TabIndex = 3;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += BtnAddToCartEH;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lstShoppingCart);
            groupBox4.Location = new Point(650, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(230, 487);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "StoreInventory";
            // 
            // lstShoppingCart
            // 
            lstShoppingCart.FormattingEnabled = true;
            lstShoppingCart.Location = new Point(6, 22);
            lstShoppingCart.Name = "lstShoppingCart";
            lstShoppingCart.Size = new Size(218, 439);
            lstShoppingCart.TabIndex = 3;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.White;
            btnCheckout.Location = new Point(713, 505);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(100, 41);
            btnCheckout.TabIndex = 5;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += BtnCheckoutClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(676, 549);
            label8.Name = "label8";
            label8.Size = new Size(56, 25);
            label8.TabIndex = 6;
            label8.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(729, 549);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(32, 25);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "$0";
            // 
            // FrmVehicleStore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 628);
            Controls.Add(lblTotal);
            Controls.Add(label8);
            Controls.Add(btnCheckout);
            Controls.Add(groupBox4);
            Controls.Add(btnAddToCart);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmVehicleStore";
            Text = "Vehicle Store";
            Load += FrmVehicleStore_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdoVehicle;
        private RadioButton rdoCar;
        private RadioButton rdoPickup;
        private RadioButton rdoMotorCycle;
        private Button btnCreate;
        private TextBox txtWheels;
        private Label label5;
        private TextBox txtPrice;
        private TextBox txtYear;
        private Label label4;
        private TextBox txtModel;
        private TextBox txtMake;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton rdoSpcialYes;
        private RadioButton rdoSpecialNo;
        private Label lblSpecialDecimal;
        private Label lblSpecialBoolean;
        private TextBox txtSpecialDecimal;
        private GroupBox groupBox3;
        private ListBox lstInventory;
        private Button btnAddToCart;
        private GroupBox groupBox4;
        private ListBox lstShoppingCart;
        private Label lblVehicleError;
        private Button btnCheckout;
        private Label label8;
        private Label lblTotal;
        private Label lblMakeError;
        private Label lblWheelError;
        private Label lblPriceError;
        private Label lblYearError;
        private Label lblModelError;
        private Label lblDecimalError;
        private Label lblSpecialBooleanError;
    }
}
