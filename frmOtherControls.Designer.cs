namespace Course_14___C__lvl_1_Win_Forms
{
    partial class frmOtherControls
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
            this.chk_checkBox1 = new System.Windows.Forms.CheckBox();
            this.rdbtn_choice1 = new System.Windows.Forms.RadioButton();
            this.lbl_checkbox1Status = new System.Windows.Forms.Label();
            this.lbl_rdbtn1Status = new System.Windows.Forms.Label();
            this.rdbtn_choice2 = new System.Windows.Forms.RadioButton();
            this.rdbtn_choice3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_checkBox1
            // 
            this.chk_checkBox1.AutoSize = true;
            this.chk_checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_checkBox1.Location = new System.Drawing.Point(57, 26);
            this.chk_checkBox1.Name = "chk_checkBox1";
            this.chk_checkBox1.Size = new System.Drawing.Size(92, 20);
            this.chk_checkBox1.TabIndex = 0;
            this.chk_checkBox1.Text = "checkBox1";
            this.chk_checkBox1.UseVisualStyleBackColor = true;
            this.chk_checkBox1.CheckedChanged += new System.EventHandler(this.chk_checkBox1_CheckedChanged);
            // 
            // rdbtn_choice1
            // 
            this.rdbtn_choice1.AutoSize = true;
            this.rdbtn_choice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_choice1.Location = new System.Drawing.Point(6, 15);
            this.rdbtn_choice1.Name = "rdbtn_choice1";
            this.rdbtn_choice1.Size = new System.Drawing.Size(77, 20);
            this.rdbtn_choice1.TabIndex = 3;
            this.rdbtn_choice1.TabStop = true;
            this.rdbtn_choice1.Text = "Choice 1";
            this.rdbtn_choice1.UseVisualStyleBackColor = true;
            this.rdbtn_choice1.CheckedChanged += new System.EventHandler(this.rdbtn_choice1_CheckedChanged);
            // 
            // lbl_checkbox1Status
            // 
            this.lbl_checkbox1Status.AutoSize = true;
            this.lbl_checkbox1Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_checkbox1Status.Location = new System.Drawing.Point(54, 122);
            this.lbl_checkbox1Status.Name = "lbl_checkbox1Status";
            this.lbl_checkbox1Status.Size = new System.Drawing.Size(78, 16);
            this.lbl_checkbox1Status.TabIndex = 4;
            this.lbl_checkbox1Status.Text = "UnChecked";
            // 
            // lbl_rdbtn1Status
            // 
            this.lbl_rdbtn1Status.AutoSize = true;
            this.lbl_rdbtn1Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rdbtn1Status.Location = new System.Drawing.Point(206, 122);
            this.lbl_rdbtn1Status.Name = "lbl_rdbtn1Status";
            this.lbl_rdbtn1Status.Size = new System.Drawing.Size(73, 16);
            this.lbl_rdbtn1Status.TabIndex = 5;
            this.lbl_rdbtn1Status.Text = " No Choice";
            // 
            // rdbtn_choice2
            // 
            this.rdbtn_choice2.AutoSize = true;
            this.rdbtn_choice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_choice2.Location = new System.Drawing.Point(6, 38);
            this.rdbtn_choice2.Name = "rdbtn_choice2";
            this.rdbtn_choice2.Size = new System.Drawing.Size(77, 20);
            this.rdbtn_choice2.TabIndex = 6;
            this.rdbtn_choice2.TabStop = true;
            this.rdbtn_choice2.Text = "Choice 2";
            this.rdbtn_choice2.UseVisualStyleBackColor = true;
            this.rdbtn_choice2.CheckedChanged += new System.EventHandler(this.rdbtn_choice2_CheckedChanged);
            // 
            // rdbtn_choice3
            // 
            this.rdbtn_choice3.AutoSize = true;
            this.rdbtn_choice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_choice3.Location = new System.Drawing.Point(6, 61);
            this.rdbtn_choice3.Name = "rdbtn_choice3";
            this.rdbtn_choice3.Size = new System.Drawing.Size(77, 20);
            this.rdbtn_choice3.TabIndex = 7;
            this.rdbtn_choice3.TabStop = true;
            this.rdbtn_choice3.Text = "Chocie 3";
            this.rdbtn_choice3.UseVisualStyleBackColor = true;
            this.rdbtn_choice3.CheckedChanged += new System.EventHandler(this.rdbtn_choice3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtn_choice2);
            this.groupBox1.Controls.Add(this.rdbtn_choice3);
            this.groupBox1.Controls.Add(this.rdbtn_choice1);
            this.groupBox1.Location = new System.Drawing.Point(209, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 84);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Location = new System.Drawing.Point(346, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(92, 84);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(6, 38);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 20);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Choice 2";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(6, 61);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 20);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Chocie 3";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(6, 15);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(77, 20);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Choice 1";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "No Choice";
            // 
            // frmOtherControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 156);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_rdbtn1Status);
            this.Controls.Add(this.lbl_checkbox1Status);
            this.Controls.Add(this.chk_checkBox1);
            this.Name = "frmOtherControls";
            this.Text = "Other Controls";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_checkBox1;
        private System.Windows.Forms.RadioButton rdbtn_choice1;
        private System.Windows.Forms.Label lbl_checkbox1Status;
        private System.Windows.Forms.Label lbl_rdbtn1Status;
        private System.Windows.Forms.RadioButton rdbtn_choice2;
        private System.Windows.Forms.RadioButton rdbtn_choice3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label1;
    }
}