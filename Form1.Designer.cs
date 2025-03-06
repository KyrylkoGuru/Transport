namespace Transport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBrand = new System.Windows.Forms.TextBox();
            this.textSpeed = new System.Windows.Forms.TextBox();
            this.textCapacity = new System.Windows.Forms.TextBox();
            this.labelFuelType = new System.Windows.Forms.Label();
            this.labelRoute = new System.Windows.Forms.Label();
            this.textRoute = new System.Windows.Forms.TextBox();
            this.textFuel = new System.Windows.Forms.TextBox();
            this.labelGears = new System.Windows.Forms.Label();
            this.checkBoxGears = new System.Windows.Forms.CheckBox();
            this.listBoxTransport = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAdd.Location = new System.Drawing.Point(653, 35);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(137, 39);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Додати транспорт";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonClear.Location = new System.Drawing.Point(653, 96);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(137, 39);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Очистити список";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Тип транспорту";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.BackColor = System.Drawing.Color.Black;
            this.labelBrand.ForeColor = System.Drawing.Color.White;
            this.labelBrand.Location = new System.Drawing.Point(189, 58);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(49, 16);
            this.labelBrand.TabIndex = 3;
            this.labelBrand.Text = "Марка";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.BackColor = System.Drawing.Color.Black;
            this.labelSpeed.ForeColor = System.Drawing.Color.White;
            this.labelSpeed.Location = new System.Drawing.Point(300, 58);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(73, 16);
            this.labelSpeed.TabIndex = 4;
            this.labelSpeed.Text = "Швидкість";
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.BackColor = System.Drawing.Color.Black;
            this.labelCapacity.ForeColor = System.Drawing.Color.White;
            this.labelCapacity.Location = new System.Drawing.Point(379, 58);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(144, 16);
            this.labelCapacity.TabIndex = 5;
            this.labelCapacity.Text = "Місткість (пасажирів)";
            // 
            // comboBoxType
            // 
            this.comboBoxType.BackColor = System.Drawing.Color.Silver;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(12, 77);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxType.TabIndex = 6;
            // 
            // textBrand
            // 
            this.textBrand.BackColor = System.Drawing.Color.Silver;
            this.textBrand.Location = new System.Drawing.Point(159, 77);
            this.textBrand.Name = "textBrand";
            this.textBrand.Size = new System.Drawing.Size(100, 22);
            this.textBrand.TabIndex = 7;
            // 
            // textSpeed
            // 
            this.textSpeed.BackColor = System.Drawing.Color.Silver;
            this.textSpeed.Location = new System.Drawing.Point(285, 77);
            this.textSpeed.Name = "textSpeed";
            this.textSpeed.Size = new System.Drawing.Size(100, 22);
            this.textSpeed.TabIndex = 8;
            // 
            // textCapacity
            // 
            this.textCapacity.BackColor = System.Drawing.Color.Silver;
            this.textCapacity.Location = new System.Drawing.Point(404, 77);
            this.textCapacity.Name = "textCapacity";
            this.textCapacity.Size = new System.Drawing.Size(100, 22);
            this.textCapacity.TabIndex = 9;
            // 
            // labelFuelType
            // 
            this.labelFuelType.AutoSize = true;
            this.labelFuelType.BackColor = System.Drawing.Color.Black;
            this.labelFuelType.ForeColor = System.Drawing.Color.White;
            this.labelFuelType.Location = new System.Drawing.Point(545, 58);
            this.labelFuelType.Name = "labelFuelType";
            this.labelFuelType.Size = new System.Drawing.Size(96, 16);
            this.labelFuelType.TabIndex = 12;
            this.labelFuelType.Text = "Тип пального";
            // 
            // labelRoute
            // 
            this.labelRoute.AutoSize = true;
            this.labelRoute.BackColor = System.Drawing.Color.Black;
            this.labelRoute.ForeColor = System.Drawing.Color.White;
            this.labelRoute.Location = new System.Drawing.Point(529, 58);
            this.labelRoute.Name = "labelRoute";
            this.labelRoute.Size = new System.Drawing.Size(118, 16);
            this.labelRoute.TabIndex = 13;
            this.labelRoute.Text = "Номер маршруту";
            // 
            // textRoute
            // 
            this.textRoute.BackColor = System.Drawing.Color.Silver;
            this.textRoute.Location = new System.Drawing.Point(541, 77);
            this.textRoute.Name = "textRoute";
            this.textRoute.Size = new System.Drawing.Size(100, 22);
            this.textRoute.TabIndex = 14;
            // 
            // textFuel
            // 
            this.textFuel.BackColor = System.Drawing.Color.Silver;
            this.textFuel.Location = new System.Drawing.Point(541, 77);
            this.textFuel.Name = "textFuel";
            this.textFuel.Size = new System.Drawing.Size(100, 22);
            this.textFuel.TabIndex = 15;
            // 
            // labelGears
            // 
            this.labelGears.AutoSize = true;
            this.labelGears.BackColor = System.Drawing.Color.Black;
            this.labelGears.ForeColor = System.Drawing.Color.White;
            this.labelGears.Location = new System.Drawing.Point(556, 58);
            this.labelGears.Name = "labelGears";
            this.labelGears.Size = new System.Drawing.Size(68, 16);
            this.labelGears.TabIndex = 16;
            this.labelGears.Text = "Передачі";
            // 
            // checkBoxGears
            // 
            this.checkBoxGears.AutoSize = true;
            this.checkBoxGears.BackColor = System.Drawing.Color.Silver;
            this.checkBoxGears.Location = new System.Drawing.Point(570, 77);
            this.checkBoxGears.Name = "checkBoxGears";
            this.checkBoxGears.Size = new System.Drawing.Size(39, 20);
            this.checkBoxGears.TabIndex = 17;
            this.checkBoxGears.Text = "Є";
            this.checkBoxGears.UseVisualStyleBackColor = false;
            // 
            // listBoxTransport
            // 
            this.listBoxTransport.BackColor = System.Drawing.Color.Black;
            this.listBoxTransport.ForeColor = System.Drawing.Color.White;
            this.listBoxTransport.FormattingEnabled = true;
            this.listBoxTransport.ItemHeight = 16;
            this.listBoxTransport.Location = new System.Drawing.Point(12, 150);
            this.listBoxTransport.Name = "listBoxTransport";
            this.listBoxTransport.Size = new System.Drawing.Size(776, 260);
            this.listBoxTransport.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxTransport);
            this.Controls.Add(this.checkBoxGears);
            this.Controls.Add(this.labelGears);
            this.Controls.Add(this.textFuel);
            this.Controls.Add(this.textRoute);
            this.Controls.Add(this.labelRoute);
            this.Controls.Add(this.labelFuelType);
            this.Controls.Add(this.textCapacity);
            this.Controls.Add(this.textSpeed);
            this.Controls.Add(this.textBrand);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBrand;
        private System.Windows.Forms.TextBox textSpeed;
        private System.Windows.Forms.TextBox textCapacity;
        private System.Windows.Forms.Label labelFuelType;
        private System.Windows.Forms.Label labelRoute;
        private System.Windows.Forms.TextBox textRoute;
        private System.Windows.Forms.TextBox textFuel;
        private System.Windows.Forms.Label labelGears;
        private System.Windows.Forms.CheckBox checkBoxGears;
        private System.Windows.Forms.ListBox listBoxTransport;
    }
}

