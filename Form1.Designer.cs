namespace projactPazzi
{
    partial class Form1
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
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.rbThank = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkMeushrooms = new System.Windows.Forms.CheckBox();
            this.chkTometos = new System.Windows.Forms.CheckBox();
            this.chkOnon = new System.Windows.Forms.CheckBox();
            this.chkOiwus = new System.Windows.Forms.CheckBox();
            this.chkPeppers = new System.Windows.Forms.CheckBox();
            this.chkChees = new System.Windows.Forms.CheckBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbEatin = new System.Windows.Forms.RadioButton();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.TextSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbToppangs = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btrCrust = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbEat = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Location = new System.Drawing.Point(26, 31);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(154, 157);
            this.gbSize.TabIndex = 3;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(40, 68);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(74, 21);
            this.rbMedium.TabIndex = 5;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "7";
            this.rbMedium.Text = "Medum";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(40, 123);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(63, 21);
            this.rbLarge.TabIndex = 4;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "10";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(40, 13);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(60, 21);
            this.rbSmall.TabIndex = 3;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "5";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbCrust
            // 
            this.gbCrust.Controls.Add(this.rbThank);
            this.gbCrust.Controls.Add(this.rbThin);
            this.gbCrust.Location = new System.Drawing.Point(37, 230);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(143, 108);
            this.gbCrust.TabIndex = 8;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust Type";
            // 
            // rbThank
            // 
            this.rbThank.AutoSize = true;
            this.rbThank.Location = new System.Drawing.Point(17, 65);
            this.rbThank.Name = "rbThank";
            this.rbThank.Size = new System.Drawing.Size(104, 21);
            this.rbThank.TabIndex = 9;
            this.rbThank.TabStop = true;
            this.rbThank.Tag = "30";
            this.rbThank.Text = "Thank Crust";
            this.rbThank.UseVisualStyleBackColor = true;
            this.rbThank.CheckedChanged += new System.EventHandler(this.rbThank_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Location = new System.Drawing.Point(17, 22);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(92, 21);
            this.rbThin.TabIndex = 8;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "20";
            this.rbThin.Text = "Thin Crust";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkMeushrooms);
            this.groupBox1.Controls.Add(this.chkTometos);
            this.groupBox1.Controls.Add(this.chkOnon);
            this.groupBox1.Controls.Add(this.chkOiwus);
            this.groupBox1.Controls.Add(this.chkPeppers);
            this.groupBox1.Controls.Add(this.chkChees);
            this.groupBox1.Location = new System.Drawing.Point(262, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 131);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // chkMeushrooms
            // 
            this.chkMeushrooms.AutoSize = true;
            this.chkMeushrooms.Location = new System.Drawing.Point(7, 57);
            this.chkMeushrooms.Name = "chkMeushrooms";
            this.chkMeushrooms.Size = new System.Drawing.Size(108, 21);
            this.chkMeushrooms.TabIndex = 23;
            this.chkMeushrooms.Tag = "10";
            this.chkMeushrooms.Text = "Meushrooms";
            this.chkMeushrooms.UseVisualStyleBackColor = true;
            this.chkMeushrooms.CheckedChanged += new System.EventHandler(this.chkMeushrooms_CheckedChanged);
            // 
            // chkTometos
            // 
            this.chkTometos.AutoSize = true;
            this.chkTometos.Location = new System.Drawing.Point(7, 104);
            this.chkTometos.Name = "chkTometos";
            this.chkTometos.Size = new System.Drawing.Size(84, 21);
            this.chkTometos.TabIndex = 22;
            this.chkTometos.Tag = "10";
            this.chkTometos.Text = "Tometos";
            this.chkTometos.UseVisualStyleBackColor = true;
            this.chkTometos.CheckedChanged += new System.EventHandler(this.chkTometos_CheckedChanged);
            // 
            // chkOnon
            // 
            this.chkOnon.AutoSize = true;
            this.chkOnon.Location = new System.Drawing.Point(132, 5);
            this.chkOnon.Name = "chkOnon";
            this.chkOnon.Size = new System.Drawing.Size(64, 21);
            this.chkOnon.TabIndex = 21;
            this.chkOnon.Tag = "20";
            this.chkOnon.Text = "Onon";
            this.chkOnon.UseVisualStyleBackColor = true;
            this.chkOnon.CheckedChanged += new System.EventHandler(this.chkOnon_CheckedChanged);
            // 
            // chkOiwus
            // 
            this.chkOiwus.AutoSize = true;
            this.chkOiwus.Location = new System.Drawing.Point(132, 57);
            this.chkOiwus.Name = "chkOiwus";
            this.chkOiwus.Size = new System.Drawing.Size(66, 21);
            this.chkOiwus.TabIndex = 20;
            this.chkOiwus.Tag = "10";
            this.chkOiwus.Text = "Oiwus";
            this.chkOiwus.UseVisualStyleBackColor = true;
            this.chkOiwus.CheckedChanged += new System.EventHandler(this.chkOiwus_CheckedChanged);
            // 
            // chkPeppers
            // 
            this.chkPeppers.AutoSize = true;
            this.chkPeppers.Location = new System.Drawing.Point(132, 104);
            this.chkPeppers.Name = "chkPeppers";
            this.chkPeppers.Size = new System.Drawing.Size(119, 21);
            this.chkPeppers.TabIndex = 19;
            this.chkPeppers.Tag = "10";
            this.chkPeppers.Text = "Green Peppers";
            this.chkPeppers.UseVisualStyleBackColor = true;
            this.chkPeppers.CheckedChanged += new System.EventHandler(this.chkPeppers_CheckedChanged);
            // 
            // chkChees
            // 
            this.chkChees.AutoSize = true;
            this.chkChees.Location = new System.Drawing.Point(7, 5);
            this.chkChees.Name = "chkChees";
            this.chkChees.Size = new System.Drawing.Size(104, 21);
            this.chkChees.TabIndex = 18;
            this.chkChees.Tag = "5";
            this.chkChees.Text = "Extra Chees";
            this.chkChees.UseVisualStyleBackColor = true;
            this.chkChees.CheckedChanged += new System.EventHandler(this.chkChees_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbEatin);
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Location = new System.Drawing.Point(249, 219);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(254, 68);
            this.gbWhereToEat.TabIndex = 19;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            this.gbWhereToEat.Enter += new System.EventHandler(this.gbWhereToEat_Enter);
            // 
            // rbEatin
            // 
            this.rbEatin.AutoSize = true;
            this.rbEatin.Location = new System.Drawing.Point(10, 24);
            this.rbEatin.Name = "rbEatin";
            this.rbEatin.Size = new System.Drawing.Size(63, 21);
            this.rbEatin.TabIndex = 8;
            this.rbEatin.TabStop = true;
            this.rbEatin.Text = "Eat in";
            this.rbEatin.UseVisualStyleBackColor = true;
            this.rbEatin.CheckedChanged += new System.EventHandler(this.rbEatin_CheckedChanged);
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(160, 24);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(85, 21);
            this.rbTakeOut.TabIndex = 9;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // TextSize
            // 
            this.TextSize.AutoSize = true;
            this.TextSize.Location = new System.Drawing.Point(636, 70);
            this.TextSize.Name = "TextSize";
            this.TextSize.Size = new System.Drawing.Size(40, 17);
            this.TextSize.TabIndex = 21;
            this.TextSize.Text = "Size :";
            this.TextSize.Click += new System.EventHandler(this.TextSize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(607, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Toppangs :";
            // 
            // tbToppangs
            // 
            this.tbToppangs.Location = new System.Drawing.Point(621, 151);
            this.tbToppangs.Multiline = true;
            this.tbToppangs.Name = "tbToppangs";
            this.tbToppangs.Size = new System.Drawing.Size(167, 71);
            this.tbToppangs.TabIndex = 24;
            this.tbToppangs.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox2.Location = new System.Drawing.Point(639, 384);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 48);
            this.textBox2.TabIndex = 26;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(593, 230);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 24);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "Crust Type :";
            // 
            // btrCrust
            // 
            this.btrCrust.Location = new System.Drawing.Point(675, 230);
            this.btrCrust.Name = "btrCrust";
            this.btrCrust.Size = new System.Drawing.Size(100, 24);
            this.btrCrust.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 40);
            this.button1.TabIndex = 29;
            this.button1.Text = "Whoro to Eat :";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rbEat
            // 
            this.rbEat.Location = new System.Drawing.Point(636, 309);
            this.rbEat.Name = "rbEat";
            this.rbEat.Size = new System.Drawing.Size(139, 36);
            this.rbEat.TabIndex = 30;
            this.rbEat.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox3.Location = new System.Drawing.Point(215, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(406, 50);
            this.textBox3.TabIndex = 31;
            this.textBox3.Text = "MAKE YOUR PIZZA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(599, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Size :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.rbEat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btrCrust);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbToppangs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextSize);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.gbSize);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.RadioButton rbThank;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkMeushrooms;
        private System.Windows.Forms.CheckBox chkTometos;
        private System.Windows.Forms.CheckBox chkOnon;
        private System.Windows.Forms.CheckBox chkOiwus;
        private System.Windows.Forms.CheckBox chkPeppers;
        private System.Windows.Forms.CheckBox chkChees;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbEatin;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.Label TextSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbToppangs;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox btrCrust;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button rbEat;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
    }
}

