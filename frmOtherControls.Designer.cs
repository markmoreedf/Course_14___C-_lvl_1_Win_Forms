namespace Course_14___C__lvl_1_Win_Forms
{
    partial class frmPizzaShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPizzaShop));
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.gbxSize = new System.Windows.Forms.GroupBox();
            this.gbxCrust = new System.Windows.Forms.GroupBox();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPriceNumber = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxToppings = new System.Windows.Forms.GroupBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkPeppers = new System.Windows.Forms.CheckBox();
            this.chkMushroom = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.btnResetOrder = new System.Windows.Forms.Button();
            this.lblSummaryCrust = new System.Windows.Forms.Label();
            this.lblSummarySize = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.gbxOderSummary = new System.Windows.Forms.GroupBox();
            this.lblSummaryToppings = new System.Windows.Forms.Label();
            this.gbxWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.gbxSize.SuspendLayout();
            this.gbxCrust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxToppings.SuspendLayout();
            this.gbxOderSummary.SuspendLayout();
            this.gbxWhereToEat.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbSmall
            // 
            this.rbSmall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbSmall.AutoSize = true;
            this.rbSmall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSmall.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmall.Location = new System.Drawing.Point(25, 32);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(57, 21);
            this.rbSmall.TabIndex = 3;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "1";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbMedium.AutoSize = true;
            this.rbMedium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMedium.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedium.Location = new System.Drawing.Point(25, 60);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(72, 21);
            this.rbMedium.TabIndex = 6;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "1.2";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rdMedium_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbLarge.AutoSize = true;
            this.rbLarge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbLarge.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLarge.Location = new System.Drawing.Point(25, 88);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(58, 21);
            this.rbLarge.TabIndex = 7;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "1.5";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // gbxSize
            // 
            this.gbxSize.Controls.Add(this.rbMedium);
            this.gbxSize.Controls.Add(this.rbLarge);
            this.gbxSize.Controls.Add(this.rbSmall);
            this.gbxSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxSize.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSize.Location = new System.Drawing.Point(32, 201);
            this.gbxSize.Margin = new System.Windows.Forms.Padding(0);
            this.gbxSize.Name = "gbxSize";
            this.gbxSize.Size = new System.Drawing.Size(118, 129);
            this.gbxSize.TabIndex = 8;
            this.gbxSize.TabStop = false;
            this.gbxSize.Text = "Size";
            // 
            // gbxCrust
            // 
            this.gbxCrust.Controls.Add(this.rbThick);
            this.gbxCrust.Controls.Add(this.rbThin);
            this.gbxCrust.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCrust.Location = new System.Drawing.Point(32, 75);
            this.gbxCrust.Margin = new System.Windows.Forms.Padding(0);
            this.gbxCrust.Name = "gbxCrust";
            this.gbxCrust.Size = new System.Drawing.Size(118, 108);
            this.gbxCrust.TabIndex = 10;
            this.gbxCrust.TabStop = false;
            this.gbxCrust.Text = "Crust";
            // 
            // rbThick
            // 
            this.rbThick.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbThick.AutoSize = true;
            this.rbThick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbThick.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThick.Location = new System.Drawing.Point(28, 61);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(56, 21);
            this.rbThick.TabIndex = 6;
            this.rbThick.TabStop = true;
            this.rbThick.Tag = "5";
            this.rbThick.Text = "Thick";
            this.rbThick.UseVisualStyleBackColor = true;
            this.rbThick.CheckedChanged += new System.EventHandler(this.rbThick_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbThin.AutoSize = true;
            this.rbThin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbThin.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThin.Location = new System.Drawing.Point(28, 32);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(51, 21);
            this.rbThin.TabIndex = 3;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "0";
            this.rbThin.Text = "Thin";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTitle.Location = new System.Drawing.Point(319, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(255, 41);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "PizzaZoo (.,.)";
            // 
            // lblPriceNumber
            // 
            this.lblPriceNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPriceNumber.AutoSize = true;
            this.lblPriceNumber.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceNumber.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblPriceNumber.Location = new System.Drawing.Point(760, 283);
            this.lblPriceNumber.Name = "lblPriceNumber";
            this.lblPriceNumber.Size = new System.Drawing.Size(77, 41);
            this.lblPriceNumber.TabIndex = 12;
            this.lblPriceNumber.Text = "0 $";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlaceOrder.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(341, 289);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(111, 41);
            this.btnPlaceOrder.TabIndex = 14;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(743, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // gbxToppings
            // 
            this.gbxToppings.Controls.Add(this.chkOlives);
            this.gbxToppings.Controls.Add(this.chkPeppers);
            this.gbxToppings.Controls.Add(this.chkMushroom);
            this.gbxToppings.Controls.Add(this.chkTomatoes);
            this.gbxToppings.Controls.Add(this.chkExtraCheese);
            this.gbxToppings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxToppings.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxToppings.Location = new System.Drawing.Point(173, 75);
            this.gbxToppings.Margin = new System.Windows.Forms.Padding(0);
            this.gbxToppings.Name = "gbxToppings";
            this.gbxToppings.Size = new System.Drawing.Size(145, 255);
            this.gbxToppings.TabIndex = 17;
            this.gbxToppings.TabStop = false;
            this.gbxToppings.Text = "Toppings";
            // 
            // chkOlives
            // 
            this.chkOlives.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkOlives.AutoSize = true;
            this.chkOlives.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlives.Location = new System.Drawing.Point(15, 160);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(67, 24);
            this.chkOlives.TabIndex = 22;
            this.chkOlives.Tag = "3";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkPeppers
            // 
            this.chkPeppers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPeppers.AutoSize = true;
            this.chkPeppers.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPeppers.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.chkPeppers.Location = new System.Drawing.Point(15, 201);
            this.chkPeppers.Name = "chkPeppers";
            this.chkPeppers.Size = new System.Drawing.Size(80, 24);
            this.chkPeppers.TabIndex = 21;
            this.chkPeppers.Tag = "2";
            this.chkPeppers.Text = "Peppers";
            this.chkPeppers.UseVisualStyleBackColor = true;
            this.chkPeppers.CheckedChanged += new System.EventHandler(this.chkPeppers_CheckedChanged);
            // 
            // chkMushroom
            // 
            this.chkMushroom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkMushroom.AutoSize = true;
            this.chkMushroom.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushroom.Location = new System.Drawing.Point(15, 119);
            this.chkMushroom.Name = "chkMushroom";
            this.chkMushroom.Size = new System.Drawing.Size(99, 24);
            this.chkMushroom.TabIndex = 20;
            this.chkMushroom.Tag = "10";
            this.chkMushroom.Text = "Mushroom";
            this.chkMushroom.UseVisualStyleBackColor = true;
            this.chkMushroom.CheckedChanged += new System.EventHandler(this.chkMushroom_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomatoes.Location = new System.Drawing.Point(15, 78);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(95, 24);
            this.chkTomatoes.TabIndex = 19;
            this.chkTomatoes.Tag = "1";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtraCheese.Location = new System.Drawing.Point(15, 37);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(116, 24);
            this.chkExtraCheese.TabIndex = 18;
            this.chkExtraCheese.Tag = "5";
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // btnResetOrder
            // 
            this.btnResetOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetOrder.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetOrder.Location = new System.Drawing.Point(613, 234);
            this.btnResetOrder.Name = "btnResetOrder";
            this.btnResetOrder.Size = new System.Drawing.Size(111, 41);
            this.btnResetOrder.TabIndex = 18;
            this.btnResetOrder.Text = "Reset Order";
            this.btnResetOrder.UseVisualStyleBackColor = true;
            this.btnResetOrder.Click += new System.EventHandler(this.btnResetOrder_Click);
            // 
            // lblSummaryCrust
            // 
            this.lblSummaryCrust.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSummaryCrust.AutoSize = true;
            this.lblSummaryCrust.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryCrust.Location = new System.Drawing.Point(14, 31);
            this.lblSummaryCrust.Name = "lblSummaryCrust";
            this.lblSummaryCrust.Size = new System.Drawing.Size(52, 17);
            this.lblSummaryCrust.TabIndex = 20;
            this.lblSummaryCrust.Text = "Crust: ";
            // 
            // lblSummarySize
            // 
            this.lblSummarySize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSummarySize.AutoSize = true;
            this.lblSummarySize.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummarySize.Location = new System.Drawing.Point(14, 59);
            this.lblSummarySize.Name = "lblSummarySize";
            this.lblSummarySize.Size = new System.Drawing.Size(43, 17);
            this.lblSummarySize.TabIndex = 21;
            this.lblSummarySize.Text = "Size: ";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(739, 260);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(61, 21);
            this.lblPrice.TabIndex = 22;
            this.lblPrice.Text = "Price: ";
            // 
            // gbxOderSummary
            // 
            this.gbxOderSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxOderSummary.Controls.Add(this.lblSummaryToppings);
            this.gbxOderSummary.Controls.Add(this.lblSummaryCrust);
            this.gbxOderSummary.Controls.Add(this.lblSummarySize);
            this.gbxOderSummary.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOderSummary.Location = new System.Drawing.Point(341, 75);
            this.gbxOderSummary.Name = "gbxOderSummary";
            this.gbxOderSummary.Size = new System.Drawing.Size(383, 131);
            this.gbxOderSummary.TabIndex = 23;
            this.gbxOderSummary.TabStop = false;
            this.gbxOderSummary.Text = "Order Summary";
            // 
            // lblSummaryToppings
            // 
            this.lblSummaryToppings.AllowDrop = true;
            this.lblSummaryToppings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSummaryToppings.AutoSize = true;
            this.lblSummaryToppings.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryToppings.Location = new System.Drawing.Point(14, 87);
            this.lblSummaryToppings.Name = "lblSummaryToppings";
            this.lblSummaryToppings.Size = new System.Drawing.Size(69, 17);
            this.lblSummaryToppings.TabIndex = 22;
            this.lblSummaryToppings.Text = "Toppings: ";
            // 
            // gbxWhereToEat
            // 
            this.gbxWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbxWhereToEat.Controls.Add(this.rbEatIn);
            this.gbxWhereToEat.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxWhereToEat.Location = new System.Drawing.Point(341, 215);
            this.gbxWhereToEat.Margin = new System.Windows.Forms.Padding(0);
            this.gbxWhereToEat.Name = "gbxWhereToEat";
            this.gbxWhereToEat.Size = new System.Drawing.Size(244, 60);
            this.gbxWhereToEat.TabIndex = 24;
            this.gbxWhereToEat.TabStop = false;
            this.gbxWhereToEat.Text = "Where to eat?";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTakeOut.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTakeOut.Location = new System.Drawing.Point(133, 26);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(81, 21);
            this.rbTakeOut.TabIndex = 6;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Tag = "2";
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEatIn.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatIn.Location = new System.Drawing.Point(28, 27);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(63, 21);
            this.rbEatIn.TabIndex = 3;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat in";
            this.rbEatIn.UseVisualStyleBackColor = true;
            // 
            // frmPizzaShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 349);
            this.Controls.Add(this.gbxWhereToEat);
            this.Controls.Add(this.gbxOderSummary);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnResetOrder);
            this.Controls.Add(this.gbxToppings);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.lblPriceNumber);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbxCrust);
            this.Controls.Add(this.gbxSize);
            this.Name = "frmPizzaShop";
            this.Text = "PizzaZoo ";
            this.gbxSize.ResumeLayout(false);
            this.gbxSize.PerformLayout();
            this.gbxCrust.ResumeLayout(false);
            this.gbxCrust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxToppings.ResumeLayout(false);
            this.gbxToppings.PerformLayout();
            this.gbxOderSummary.ResumeLayout(false);
            this.gbxOderSummary.PerformLayout();
            this.gbxWhereToEat.ResumeLayout(false);
            this.gbxWhereToEat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.GroupBox gbxSize;
        private System.Windows.Forms.GroupBox gbxCrust;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPriceNumber;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbxToppings;
        private System.Windows.Forms.CheckBox chkPeppers;
        private System.Windows.Forms.CheckBox chkMushroom;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.Button btnResetOrder;
        private System.Windows.Forms.Label lblSummaryCrust;
        private System.Windows.Forms.Label lblSummarySize;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox gbxOderSummary;
        private System.Windows.Forms.Label lblSummaryToppings;
        private System.Windows.Forms.GroupBox gbxWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
    }
}