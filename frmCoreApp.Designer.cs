namespace Course_14___C__lvl_1_Win_Forms
{
    partial class frmCoreApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoreApp));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_CopyOnClick = new System.Windows.Forms.Button();
            this.btn_CopyOnEnter = new System.Windows.Forms.Button();
            this.btn_CopyOnHover = new System.Windows.Forms.Button();
            this.btn_CopyOnLeave = new System.Windows.Forms.Button();
            this.btn_CopyOnMove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_DisableTB1 = new System.Windows.Forms.Button();
            this.btn_DisableTB2 = new System.Windows.Forms.Button();
            this.btn_ResetTB1 = new System.Windows.Forms.Button();
            this.btn_ChngTB2Clr = new System.Windows.Forms.Button();
            this.btn_ResetTB2 = new System.Windows.Forms.Button();
            this.btn_ChngTB1Clr = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Link = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_VerticalSeperator = new System.Windows.Forms.Label();
            this.lbl_HorizontalSeperator = new System.Windows.Forms.Label();
            this.btn_OpenStartWindow = new System.Windows.Forms.Button();
            this.btn_OpenCalcForm = new System.Windows.Forms.Button();
            this.btn_showMsgBoxForm = new System.Windows.Forms.Button();
            this.btn_OpenOtherControlsFom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox1.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(41, 95);
            this.textBox1.MaxLength = 20;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox2.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(359, 95);
            this.textBox2.MaxLength = 20;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(170, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_CopyOnClick
            // 
            this.btn_CopyOnClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CopyOnClick.Font = new System.Drawing.Font("Unispace", 6.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CopyOnClick.Location = new System.Drawing.Point(41, 144);
            this.btn_CopyOnClick.Name = "btn_CopyOnClick";
            this.btn_CopyOnClick.Size = new System.Drawing.Size(93, 28);
            this.btn_CopyOnClick.TabIndex = 5;
            this.btn_CopyOnClick.Text = "Copy On Click";
            this.btn_CopyOnClick.UseVisualStyleBackColor = true;
            this.btn_CopyOnClick.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_CopyOnEnter
            // 
            this.btn_CopyOnEnter.Font = new System.Drawing.Font("Unispace", 6.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CopyOnEnter.Location = new System.Drawing.Point(140, 144);
            this.btn_CopyOnEnter.Name = "btn_CopyOnEnter";
            this.btn_CopyOnEnter.Size = new System.Drawing.Size(93, 28);
            this.btn_CopyOnEnter.TabIndex = 6;
            this.btn_CopyOnEnter.Text = "Copy On Enter";
            this.btn_CopyOnEnter.UseVisualStyleBackColor = true;
            this.btn_CopyOnEnter.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            // 
            // btn_CopyOnHover
            // 
            this.btn_CopyOnHover.Font = new System.Drawing.Font("Unispace", 6.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CopyOnHover.Location = new System.Drawing.Point(238, 144);
            this.btn_CopyOnHover.Name = "btn_CopyOnHover";
            this.btn_CopyOnHover.Size = new System.Drawing.Size(93, 28);
            this.btn_CopyOnHover.TabIndex = 7;
            this.btn_CopyOnHover.Text = "Copy On Hover";
            this.btn_CopyOnHover.UseVisualStyleBackColor = true;
            this.btn_CopyOnHover.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // btn_CopyOnLeave
            // 
            this.btn_CopyOnLeave.Font = new System.Drawing.Font("Unispace", 6.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CopyOnLeave.Location = new System.Drawing.Point(337, 144);
            this.btn_CopyOnLeave.Name = "btn_CopyOnLeave";
            this.btn_CopyOnLeave.Size = new System.Drawing.Size(93, 28);
            this.btn_CopyOnLeave.TabIndex = 8;
            this.btn_CopyOnLeave.Text = "Copy On Leave";
            this.btn_CopyOnLeave.UseVisualStyleBackColor = true;
            this.btn_CopyOnLeave.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            // 
            // btn_CopyOnMove
            // 
            this.btn_CopyOnMove.Font = new System.Drawing.Font("Unispace", 6.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CopyOnMove.Location = new System.Drawing.Point(436, 144);
            this.btn_CopyOnMove.Name = "btn_CopyOnMove";
            this.btn_CopyOnMove.Size = new System.Drawing.Size(93, 28);
            this.btn_CopyOnMove.TabIndex = 9;
            this.btn_CopyOnMove.Text = "Copy On Move";
            this.btn_CopyOnMove.UseVisualStyleBackColor = true;
            this.btn_CopyOnMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button5_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original Text";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Copied Text";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_DisableTB1
            // 
            this.btn_DisableTB1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DisableTB1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_DisableTB1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_DisableTB1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_DisableTB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DisableTB1.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DisableTB1.Location = new System.Drawing.Point(41, 234);
            this.btn_DisableTB1.Name = "btn_DisableTB1";
            this.btn_DisableTB1.Size = new System.Drawing.Size(110, 28);
            this.btn_DisableTB1.TabIndex = 11;
            this.btn_DisableTB1.Text = "Disable TB1";
            this.btn_DisableTB1.UseVisualStyleBackColor = true;
            this.btn_DisableTB1.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_DisableTB2
            // 
            this.btn_DisableTB2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DisableTB2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_DisableTB2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_DisableTB2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_DisableTB2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DisableTB2.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DisableTB2.Location = new System.Drawing.Point(419, 234);
            this.btn_DisableTB2.Name = "btn_DisableTB2";
            this.btn_DisableTB2.Size = new System.Drawing.Size(110, 28);
            this.btn_DisableTB2.TabIndex = 14;
            this.btn_DisableTB2.Text = "Disable TB2";
            this.btn_DisableTB2.UseVisualStyleBackColor = true;
            this.btn_DisableTB2.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_ResetTB1
            // 
            this.btn_ResetTB1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ResetTB1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_ResetTB1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_ResetTB1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_ResetTB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResetTB1.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetTB1.Location = new System.Drawing.Point(41, 200);
            this.btn_ResetTB1.Name = "btn_ResetTB1";
            this.btn_ResetTB1.Size = new System.Drawing.Size(110, 28);
            this.btn_ResetTB1.TabIndex = 10;
            this.btn_ResetTB1.Text = "Reset TB1";
            this.btn_ResetTB1.UseVisualStyleBackColor = true;
            this.btn_ResetTB1.Click += new System.EventHandler(this.btn_ResetTB1_Click);
            // 
            // btn_ChngTB2Clr
            // 
            this.btn_ChngTB2Clr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChngTB2Clr.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_ChngTB2Clr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_ChngTB2Clr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_ChngTB2Clr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChngTB2Clr.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChngTB2Clr.Location = new System.Drawing.Point(419, 268);
            this.btn_ChngTB2Clr.Name = "btn_ChngTB2Clr";
            this.btn_ChngTB2Clr.Size = new System.Drawing.Size(110, 28);
            this.btn_ChngTB2Clr.TabIndex = 15;
            this.btn_ChngTB2Clr.Text = "Change TB2 Color";
            this.btn_ChngTB2Clr.UseVisualStyleBackColor = true;
            this.btn_ChngTB2Clr.Click += new System.EventHandler(this.btn_ChngTB2Clr_Click);
            // 
            // btn_ResetTB2
            // 
            this.btn_ResetTB2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ResetTB2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_ResetTB2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_ResetTB2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_ResetTB2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResetTB2.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetTB2.Location = new System.Drawing.Point(419, 200);
            this.btn_ResetTB2.Name = "btn_ResetTB2";
            this.btn_ResetTB2.Size = new System.Drawing.Size(110, 28);
            this.btn_ResetTB2.TabIndex = 13;
            this.btn_ResetTB2.Text = "Reset TB2";
            this.btn_ResetTB2.UseVisualStyleBackColor = true;
            this.btn_ResetTB2.Click += new System.EventHandler(this.btn_ResetTB2_Click);
            // 
            // btn_ChngTB1Clr
            // 
            this.btn_ChngTB1Clr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChngTB1Clr.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_ChngTB1Clr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_ChngTB1Clr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_ChngTB1Clr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChngTB1Clr.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChngTB1Clr.Location = new System.Drawing.Point(41, 268);
            this.btn_ChngTB1Clr.Name = "btn_ChngTB1Clr";
            this.btn_ChngTB1Clr.Size = new System.Drawing.Size(110, 28);
            this.btn_ChngTB1Clr.TabIndex = 12;
            this.btn_ChngTB1Clr.Text = "Change TB1 Color";
            this.btn_ChngTB1Clr.UseVisualStyleBackColor = true;
            this.btn_ChngTB1Clr.Click += new System.EventHandler(this.btn_ChngTB1Clr_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(159, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "This is a Practice Project";
            // 
            // btn_Link
            // 
            this.btn_Link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Link.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Link.FlatAppearance.BorderSize = 5;
            this.btn_Link.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Link.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Link.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Link.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Link.Location = new System.Drawing.Point(255, 95);
            this.btn_Link.Name = "btn_Link";
            this.btn_Link.Size = new System.Drawing.Size(61, 23);
            this.btn_Link.TabIndex = 2;
            this.btn_Link.Text = "Link";
            this.btn_Link.UseVisualStyleBackColor = true;
            this.btn_Link.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(620, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(359, 124);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(170, 8);
            this.progressBar1.TabIndex = 22;
            // 
            // lbl_VerticalSeperator
            // 
            this.lbl_VerticalSeperator.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_VerticalSeperator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_VerticalSeperator.Location = new System.Drawing.Point(572, 19);
            this.lbl_VerticalSeperator.Name = "lbl_VerticalSeperator";
            this.lbl_VerticalSeperator.Size = new System.Drawing.Size(3, 300);
            this.lbl_VerticalSeperator.TabIndex = 23;
            // 
            // lbl_HorizontalSeperator
            // 
            this.lbl_HorizontalSeperator.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_HorizontalSeperator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_HorizontalSeperator.Location = new System.Drawing.Point(16, 184);
            this.lbl_HorizontalSeperator.Name = "lbl_HorizontalSeperator";
            this.lbl_HorizontalSeperator.Size = new System.Drawing.Size(550, 3);
            this.lbl_HorizontalSeperator.TabIndex = 24;
            // 
            // btn_OpenStartWindow
            // 
            this.btn_OpenStartWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OpenStartWindow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_OpenStartWindow.FlatAppearance.BorderSize = 5;
            this.btn_OpenStartWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_OpenStartWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_OpenStartWindow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OpenStartWindow.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenStartWindow.Location = new System.Drawing.Point(255, 289);
            this.btn_OpenStartWindow.Name = "btn_OpenStartWindow";
            this.btn_OpenStartWindow.Size = new System.Drawing.Size(61, 23);
            this.btn_OpenStartWindow.TabIndex = 18;
            this.btn_OpenStartWindow.Text = "Back";
            this.btn_OpenStartWindow.UseVisualStyleBackColor = false;
            this.btn_OpenStartWindow.Click += new System.EventHandler(this.btn_OpenStartWindow_Click);
            // 
            // btn_OpenCalcForm
            // 
            this.btn_OpenCalcForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OpenCalcForm.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_OpenCalcForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_OpenCalcForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_OpenCalcForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OpenCalcForm.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenCalcForm.Location = new System.Drawing.Point(592, 92);
            this.btn_OpenCalcForm.Name = "btn_OpenCalcForm";
            this.btn_OpenCalcForm.Size = new System.Drawing.Size(122, 28);
            this.btn_OpenCalcForm.TabIndex = 16;
            this.btn_OpenCalcForm.Text = "Calculator";
            this.btn_OpenCalcForm.UseVisualStyleBackColor = true;
            this.btn_OpenCalcForm.Click += new System.EventHandler(this.btn_OpenTempForm_Click);
            // 
            // btn_showMsgBoxForm
            // 
            this.btn_showMsgBoxForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_showMsgBoxForm.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_showMsgBoxForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_showMsgBoxForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_showMsgBoxForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showMsgBoxForm.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showMsgBoxForm.Location = new System.Drawing.Point(592, 146);
            this.btn_showMsgBoxForm.Name = "btn_showMsgBoxForm";
            this.btn_showMsgBoxForm.Size = new System.Drawing.Size(122, 28);
            this.btn_showMsgBoxForm.TabIndex = 17;
            this.btn_showMsgBoxForm.Text = "MessageBox";
            this.btn_showMsgBoxForm.UseVisualStyleBackColor = true;
            this.btn_showMsgBoxForm.Click += new System.EventHandler(this.btn_messageBox1_Click);
            // 
            // btn_OpenOtherControlsFom
            // 
            this.btn_OpenOtherControlsFom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OpenOtherControlsFom.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_OpenOtherControlsFom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_OpenOtherControlsFom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_OpenOtherControlsFom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OpenOtherControlsFom.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenOtherControlsFom.Location = new System.Drawing.Point(592, 200);
            this.btn_OpenOtherControlsFom.Name = "btn_OpenOtherControlsFom";
            this.btn_OpenOtherControlsFom.Size = new System.Drawing.Size(122, 28);
            this.btn_OpenOtherControlsFom.TabIndex = 18;
            this.btn_OpenOtherControlsFom.Text = "Other Controls";
            this.btn_OpenOtherControlsFom.UseVisualStyleBackColor = true;
            this.btn_OpenOtherControlsFom.Click += new System.EventHandler(this.btn_OpenOtherControlsFom_Click);
            // 
            // frmCoreApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 328);
            this.Controls.Add(this.btn_OpenOtherControlsFom);
            this.Controls.Add(this.btn_showMsgBoxForm);
            this.Controls.Add(this.btn_OpenCalcForm);
            this.Controls.Add(this.btn_OpenStartWindow);
            this.Controls.Add(this.lbl_HorizontalSeperator);
            this.Controls.Add(this.lbl_VerticalSeperator);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Link);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_ChngTB1Clr);
            this.Controls.Add(this.btn_ResetTB2);
            this.Controls.Add(this.btn_ChngTB2Clr);
            this.Controls.Add(this.btn_ResetTB1);
            this.Controls.Add(this.btn_DisableTB2);
            this.Controls.Add(this.btn_DisableTB1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CopyOnMove);
            this.Controls.Add(this.btn_CopyOnLeave);
            this.Controls.Add(this.btn_CopyOnHover);
            this.Controls.Add(this.btn_CopyOnEnter);
            this.Controls.Add(this.btn_CopyOnClick);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "frmCoreApp";
            this.Text = " Core App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_CopyOnClick;
        private System.Windows.Forms.Button btn_CopyOnEnter;
        private System.Windows.Forms.Button btn_CopyOnHover;
        private System.Windows.Forms.Button btn_CopyOnLeave;
        private System.Windows.Forms.Button btn_CopyOnMove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_DisableTB1;
        private System.Windows.Forms.Button btn_DisableTB2;
        private System.Windows.Forms.Button btn_ResetTB1;
        private System.Windows.Forms.Button btn_ChngTB2Clr;
        private System.Windows.Forms.Button btn_ResetTB2;
        private System.Windows.Forms.Button btn_ChngTB1Clr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Link;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_VerticalSeperator;
        private System.Windows.Forms.Label lbl_HorizontalSeperator;
        private System.Windows.Forms.Button btn_OpenStartWindow;
        private System.Windows.Forms.Button btn_OpenCalcForm;
        private System.Windows.Forms.Button btn_showMsgBoxForm;
        private System.Windows.Forms.Button btn_OpenOtherControlsFom;
    }
}

