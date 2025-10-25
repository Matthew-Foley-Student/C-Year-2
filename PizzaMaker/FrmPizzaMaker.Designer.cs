namespace PizzaMaker
{
    partial class FrmPizzaMaker
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
            label1 = new Label();
            txtName = new TextBox();
            grpIngrediants = new GroupBox();
            chbTomatoees = new CheckBox();
            chbPeppers = new CheckBox();
            chbSausage = new CheckBox();
            chbMushrooms = new CheckBox();
            chbPineapple = new CheckBox();
            chbOlives = new CheckBox();
            chbBacon = new CheckBox();
            chbPeperonni = new CheckBox();
            label2 = new Label();
            lsbStrangeAddOns = new ListBox();
            groupBox1 = new GroupBox();
            rdoDeep = new RadioButton();
            rdoStuffed = new RadioButton();
            rdoGluten = new RadioButton();
            rdoThin = new RadioButton();
            groupBox2 = new GroupBox();
            lblSauce = new Label();
            lblCheese = new Label();
            label4 = new Label();
            hsbCheese = new HScrollBar();
            label3 = new Label();
            hsbSauce = new HScrollBar();
            label5 = new Label();
            dtpDeliverey = new DateTimePicker();
            label6 = new Label();
            picPizzaBox = new PictureBox();
            label7 = new Label();
            lblPizzaPrice = new Label();
            btnFormReset = new Button();
            btnFinishOrder = new Button();
            btnOrderList = new Button();
            grpIngrediants.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPizzaBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 18);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(67, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(219, 26);
            txtName.TabIndex = 1;
            txtName.Leave += TxtNameLeaeve;
            // 
            // grpIngrediants
            // 
            grpIngrediants.Controls.Add(chbTomatoees);
            grpIngrediants.Controls.Add(chbPeppers);
            grpIngrediants.Controls.Add(chbSausage);
            grpIngrediants.Controls.Add(chbMushrooms);
            grpIngrediants.Controls.Add(chbPineapple);
            grpIngrediants.Controls.Add(chbOlives);
            grpIngrediants.Controls.Add(chbBacon);
            grpIngrediants.Controls.Add(chbPeperonni);
            grpIngrediants.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpIngrediants.Location = new Point(12, 51);
            grpIngrediants.Name = "grpIngrediants";
            grpIngrediants.Size = new Size(291, 142);
            grpIngrediants.TabIndex = 2;
            grpIngrediants.TabStop = false;
            grpIngrediants.Text = "Ingrediants";
            // 
            // chbTomatoees
            // 
            chbTomatoees.AutoSize = true;
            chbTomatoees.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbTomatoees.Location = new Point(150, 109);
            chbTomatoees.Name = "chbTomatoees";
            chbTomatoees.Size = new Size(97, 22);
            chbTomatoees.TabIndex = 10;
            chbTomatoees.Text = "Tomatoes";
            chbTomatoees.UseVisualStyleBackColor = true;
            chbTomatoees.CheckedChanged += ChbIngrediantCheckedChange;
            // 
            // chbPeppers
            // 
            chbPeppers.AutoSize = true;
            chbPeppers.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbPeppers.Location = new Point(150, 81);
            chbPeppers.Name = "chbPeppers";
            chbPeppers.Size = new Size(141, 22);
            chbPeppers.TabIndex = 9;
            chbPeppers.Text = "Green Pepperes";
            chbPeppers.UseVisualStyleBackColor = true;
            chbPeppers.CheckedChanged += ChbIngrediantCheckedChange;
            // 
            // chbSausage
            // 
            chbSausage.AutoSize = true;
            chbSausage.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbSausage.Location = new Point(150, 53);
            chbSausage.Name = "chbSausage";
            chbSausage.Size = new Size(84, 22);
            chbSausage.TabIndex = 8;
            chbSausage.Text = "Sausage";
            chbSausage.UseVisualStyleBackColor = true;
            chbSausage.CheckedChanged += ChbIngrediantCheckedChange;
            // 
            // chbMushrooms
            // 
            chbMushrooms.AutoSize = true;
            chbMushrooms.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbMushrooms.Location = new Point(6, 109);
            chbMushrooms.Name = "chbMushrooms";
            chbMushrooms.Size = new Size(111, 22);
            chbMushrooms.TabIndex = 7;
            chbMushrooms.Text = "Mushrooms";
            chbMushrooms.UseVisualStyleBackColor = true;
            chbMushrooms.CheckedChanged += ChbIngrediantCheckedChange;
            // 
            // chbPineapple
            // 
            chbPineapple.AutoSize = true;
            chbPineapple.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbPineapple.Location = new Point(150, 25);
            chbPineapple.Name = "chbPineapple";
            chbPineapple.Size = new Size(96, 22);
            chbPineapple.TabIndex = 6;
            chbPineapple.Text = "Pineapple";
            chbPineapple.UseVisualStyleBackColor = true;
            chbPineapple.CheckedChanged += ChbIngrediantCheckedChange;
            // 
            // chbOlives
            // 
            chbOlives.AutoSize = true;
            chbOlives.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbOlives.Location = new Point(6, 81);
            chbOlives.Name = "chbOlives";
            chbOlives.Size = new Size(71, 22);
            chbOlives.TabIndex = 5;
            chbOlives.Text = "Olives";
            chbOlives.UseVisualStyleBackColor = true;
            chbOlives.CheckedChanged += ChbIngrediantCheckedChange;
            // 
            // chbBacon
            // 
            chbBacon.AutoSize = true;
            chbBacon.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbBacon.Location = new Point(6, 53);
            chbBacon.Name = "chbBacon";
            chbBacon.Size = new Size(69, 22);
            chbBacon.TabIndex = 4;
            chbBacon.Text = "Bacon";
            chbBacon.UseVisualStyleBackColor = true;
            chbBacon.CheckedChanged += ChbIngrediantCheckedChange;
            // 
            // chbPeperonni
            // 
            chbPeperonni.AutoSize = true;
            chbPeperonni.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbPeperonni.Location = new Point(6, 25);
            chbPeperonni.Name = "chbPeperonni";
            chbPeperonni.Size = new Size(90, 22);
            chbPeperonni.TabIndex = 3;
            chbPeperonni.Text = "Peperoni";
            chbPeperonni.UseVisualStyleBackColor = true;
            chbPeperonni.CheckedChanged += ChbIngrediantCheckedChange;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 207);
            label2.Name = "label2";
            label2.Size = new Size(175, 18);
            label2.TabIndex = 3;
            label2.Text = "Unusial Ingrediants";
            // 
            // lsbStrangeAddOns
            // 
            lsbStrangeAddOns.FormattingEnabled = true;
            lsbStrangeAddOns.Items.AddRange(new object[] { "HotDog", "EggPlant", "Atichoke", "Eggs", "PeanutButter", "Proscuitto", "Honey", "Chillie", "OliveOil", "Arugula", "GarlicCloves", "Chiken", "Anchovies", "BBQSauce", "GreenOnions", "Carrots" });
            lsbStrangeAddOns.Location = new Point(12, 228);
            lsbStrangeAddOns.Name = "lsbStrangeAddOns";
            lsbStrangeAddOns.SelectionMode = SelectionMode.MultiSimple;
            lsbStrangeAddOns.Size = new Size(202, 166);
            lsbStrangeAddOns.TabIndex = 4;
            lsbStrangeAddOns.SelectedIndexChanged += LsbStrangeAddOnsChange;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoDeep);
            groupBox1.Controls.Add(rdoStuffed);
            groupBox1.Controls.Add(rdoGluten);
            groupBox1.Controls.Add(rdoThin);
            groupBox1.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(220, 228);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(206, 166);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crust";
            // 
            // rdoDeep
            // 
            rdoDeep.AutoSize = true;
            rdoDeep.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoDeep.Location = new Point(6, 53);
            rdoDeep.Name = "rdoDeep";
            rdoDeep.Size = new Size(97, 22);
            rdoDeep.TabIndex = 3;
            rdoDeep.TabStop = true;
            rdoDeep.Text = "Deep Dish";
            rdoDeep.UseVisualStyleBackColor = true;
            rdoDeep.CheckedChanged += RdoCrustChange;
            // 
            // rdoStuffed
            // 
            rdoStuffed.AutoSize = true;
            rdoStuffed.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoStuffed.Location = new Point(6, 81);
            rdoStuffed.Name = "rdoStuffed";
            rdoStuffed.Size = new Size(120, 22);
            rdoStuffed.TabIndex = 2;
            rdoStuffed.TabStop = true;
            rdoStuffed.Text = "Stuffed Crust";
            rdoStuffed.UseVisualStyleBackColor = true;
            rdoStuffed.CheckedChanged += RdoCrustChange;
            // 
            // rdoGluten
            // 
            rdoGluten.AutoSize = true;
            rdoGluten.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoGluten.Location = new Point(6, 109);
            rdoGluten.Name = "rdoGluten";
            rdoGluten.Size = new Size(111, 22);
            rdoGluten.TabIndex = 1;
            rdoGluten.TabStop = true;
            rdoGluten.Text = "Gluten Free";
            rdoGluten.UseVisualStyleBackColor = true;
            rdoGluten.CheckedChanged += RdoCrustChange;
            // 
            // rdoThin
            // 
            rdoThin.AutoSize = true;
            rdoThin.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoThin.Location = new Point(6, 25);
            rdoThin.Name = "rdoThin";
            rdoThin.Size = new Size(102, 22);
            rdoThin.TabIndex = 0;
            rdoThin.TabStop = true;
            rdoThin.Text = "Thin Crust";
            rdoThin.UseVisualStyleBackColor = true;
            rdoThin.CheckedChanged += RdoCrustChange;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblSauce);
            groupBox2.Controls.Add(lblCheese);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(hsbCheese);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(hsbSauce);
            groupBox2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 400);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(414, 137);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Extra Goods";
            // 
            // lblSauce
            // 
            lblSauce.AutoSize = true;
            lblSauce.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSauce.Location = new Point(184, 22);
            lblSauce.Name = "lblSauce";
            lblSauce.Size = new Size(28, 18);
            lblSauce.TabIndex = 7;
            lblSauce.Text = "00";
            lblSauce.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCheese
            // 
            lblCheese.AutoSize = true;
            lblCheese.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCheese.Location = new Point(184, 85);
            lblCheese.Name = "lblCheese";
            lblCheese.Size = new Size(28, 18);
            lblCheese.TabIndex = 8;
            lblCheese.Text = "00";
            lblCheese.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 85);
            label4.Name = "label4";
            label4.Size = new Size(140, 18);
            label4.TabIndex = 8;
            label4.Text = "Amount Of Cheese";
            // 
            // hsbCheese
            // 
            hsbCheese.Location = new Point(7, 103);
            hsbCheese.Name = "hsbCheese";
            hsbCheese.Size = new Size(404, 28);
            hsbCheese.TabIndex = 7;
            hsbCheese.ValueChanged += HsbExtraValueChange;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 22);
            label3.Name = "label3";
            label3.Size = new Size(131, 18);
            label3.TabIndex = 7;
            label3.Text = "Amount Of Sauce";
            // 
            // hsbSauce
            // 
            hsbSauce.Location = new Point(7, 46);
            hsbSauce.Name = "hsbSauce";
            hsbSauce.Size = new Size(404, 23);
            hsbSauce.TabIndex = 7;
            hsbSauce.ValueChanged += HsbExtraValueChange;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(464, 14);
            label5.Name = "label5";
            label5.Size = new Size(129, 18);
            label5.TabIndex = 7;
            label5.Text = "Deilivery Time";
            // 
            // dtpDeliverey
            // 
            dtpDeliverey.CustomFormat = "MM/dd/yyyy   hh:mm";
            dtpDeliverey.Format = DateTimePickerFormat.Custom;
            dtpDeliverey.Location = new Point(439, 35);
            dtpDeliverey.Name = "dtpDeliverey";
            dtpDeliverey.Size = new Size(193, 26);
            dtpDeliverey.TabIndex = 8;
            dtpDeliverey.ValueChanged += DtpDelivereytimeChange;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(464, 64);
            label6.Name = "label6";
            label6.Size = new Size(137, 18);
            label6.TabIndex = 9;
            label6.Text = "Pizza Box Color";
            // 
            // picPizzaBox
            // 
            picPizzaBox.BorderStyle = BorderStyle.FixedSingle;
            picPizzaBox.Location = new Point(439, 85);
            picPizzaBox.Name = "picPizzaBox";
            picPizzaBox.Size = new Size(200, 108);
            picPizzaBox.TabIndex = 10;
            picPizzaBox.TabStop = false;
            picPizzaBox.Click += PicPizzaBoxClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(439, 207);
            label7.Name = "label7";
            label7.Size = new Size(159, 18);
            label7.TabIndex = 11;
            label7.Text = "Price Of The Pizza";
            // 
            // lblPizzaPrice
            // 
            lblPizzaPrice.AutoSize = true;
            lblPizzaPrice.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPizzaPrice.ForeColor = Color.Red;
            lblPizzaPrice.Location = new Point(604, 207);
            lblPizzaPrice.Name = "lblPizzaPrice";
            lblPizzaPrice.Size = new Size(28, 18);
            lblPizzaPrice.TabIndex = 12;
            lblPizzaPrice.Text = "$0";
            // 
            // btnFormReset
            // 
            btnFormReset.Location = new Point(439, 236);
            btnFormReset.Name = "btnFormReset";
            btnFormReset.Size = new Size(109, 42);
            btnFormReset.TabIndex = 13;
            btnFormReset.Text = "Reset Form";
            btnFormReset.UseVisualStyleBackColor = true;
            btnFormReset.Click += ResetFormClick;
            // 
            // btnFinishOrder
            // 
            btnFinishOrder.Location = new Point(554, 236);
            btnFinishOrder.Name = "btnFinishOrder";
            btnFinishOrder.Size = new Size(109, 42);
            btnFinishOrder.TabIndex = 14;
            btnFinishOrder.Text = "Finish Order";
            btnFinishOrder.UseVisualStyleBackColor = true;
            btnFinishOrder.Click += CreatePizza;
            // 
            // btnOrderList
            // 
            btnOrderList.Location = new Point(483, 295);
            btnOrderList.Name = "btnOrderList";
            btnOrderList.Size = new Size(138, 50);
            btnOrderList.TabIndex = 15;
            btnOrderList.Text = "See Order List";
            btnOrderList.UseVisualStyleBackColor = true;
            btnOrderList.Click += SeeOrderList;
            // 
            // FrmPizzaMaker
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 540);
            Controls.Add(btnOrderList);
            Controls.Add(btnFinishOrder);
            Controls.Add(btnFormReset);
            Controls.Add(lblPizzaPrice);
            Controls.Add(label7);
            Controls.Add(picPizzaBox);
            Controls.Add(label6);
            Controls.Add(dtpDeliverey);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lsbStrangeAddOns);
            Controls.Add(label2);
            Controls.Add(grpIngrediants);
            Controls.Add(txtName);
            Controls.Add(label1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmPizzaMaker";
            Text = "Pizza Maker";
            grpIngrediants.ResumeLayout(false);
            grpIngrediants.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPizzaBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private GroupBox grpIngrediants;
        private CheckBox chbTomatoees;
        private CheckBox chbPeppers;
        private CheckBox chbSausage;
        private CheckBox chbMushrooms;
        private CheckBox chbPineapple;
        private CheckBox chbOlives;
        private CheckBox chbBacon;
        private CheckBox chbPeperonni;
        private Label label2;
        private ListBox lsbStrangeAddOns;
        private GroupBox groupBox1;
        private RadioButton rdoThin;
        private RadioButton rdoDeep;
        private RadioButton rdoStuffed;
        private RadioButton rdoGluten;
        private GroupBox groupBox2;
        private HScrollBar hsbCheese;
        private HScrollBar hsbSauce;
        private Label lblSauce;
        private Label lblCheese;
        private Label label4;
        private Label label3;
        private Label label5;
        private DateTimePicker dtpDeliverey;
        private Label label6;
        private PictureBox picPizzaBox;
        private Label label7;
        private Label lblPizzaPrice;
        private Button btnFormReset;
        private Button btnFinishOrder;
        private Button btnOrderList;
    }
}
