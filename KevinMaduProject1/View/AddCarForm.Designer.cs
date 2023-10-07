namespace KevinMaduProject1.View
{
    partial class AddCarForm
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
            carMakeLbl = new Label();
            carModelLbl = new Label();
            carMpgLbl = new Label();
            carPriceLbl = new Label();
            carMakeTxtbox = new TextBox();
            carModelTxtbox = new TextBox();
            carMpgTxtbox = new TextBox();
            carPriceTxtbox = new TextBox();
            addCarBtn = new Button();
            carMakeErrorLbl = new Label();
            carModelErrorLbl = new Label();
            carMpgErrorLbl = new Label();
            carPriceErrorLbl = new Label();
            SuspendLayout();
            // 
            // carMakeLbl
            // 
            carMakeLbl.AutoSize = true;
            carMakeLbl.Location = new Point(135, 69);
            carMakeLbl.Name = "carMakeLbl";
            carMakeLbl.Size = new Size(60, 15);
            carMakeLbl.TabIndex = 0;
            carMakeLbl.Text = "Car Make:";
            // 
            // carModelLbl
            // 
            carModelLbl.AutoSize = true;
            carModelLbl.Location = new Point(135, 118);
            carModelLbl.Name = "carModelLbl";
            carModelLbl.Size = new Size(65, 15);
            carModelLbl.TabIndex = 1;
            carModelLbl.Text = "Car Model:";
            // 
            // carMpgLbl
            // 
            carMpgLbl.AutoSize = true;
            carMpgLbl.Location = new Point(135, 170);
            carMpgLbl.Name = "carMpgLbl";
            carMpgLbl.Size = new Size(56, 15);
            carMpgLbl.TabIndex = 2;
            carMpgLbl.Text = "Car Mpg:";
            // 
            // carPriceLbl
            // 
            carPriceLbl.AutoSize = true;
            carPriceLbl.Location = new Point(135, 219);
            carPriceLbl.Name = "carPriceLbl";
            carPriceLbl.Size = new Size(57, 15);
            carPriceLbl.TabIndex = 3;
            carPriceLbl.Text = "Car Price:";
            // 
            // carMakeTxtbox
            // 
            carMakeTxtbox.Location = new Point(201, 66);
            carMakeTxtbox.Name = "carMakeTxtbox";
            carMakeTxtbox.Size = new Size(100, 23);
            carMakeTxtbox.TabIndex = 4;
            // 
            // carModelTxtbox
            // 
            carModelTxtbox.Location = new Point(201, 115);
            carModelTxtbox.Name = "carModelTxtbox";
            carModelTxtbox.Size = new Size(100, 23);
            carModelTxtbox.TabIndex = 5;
            // 
            // carMpgTxtbox
            // 
            carMpgTxtbox.Location = new Point(201, 167);
            carMpgTxtbox.Name = "carMpgTxtbox";
            carMpgTxtbox.Size = new Size(100, 23);
            carMpgTxtbox.TabIndex = 6;
            // 
            // carPriceTxtbox
            // 
            carPriceTxtbox.Location = new Point(201, 216);
            carPriceTxtbox.Name = "carPriceTxtbox";
            carPriceTxtbox.Size = new Size(100, 23);
            carPriceTxtbox.TabIndex = 7;
            // 
            // addCarBtn
            // 
            addCarBtn.Location = new Point(201, 265);
            addCarBtn.Name = "addCarBtn";
            addCarBtn.Size = new Size(100, 23);
            addCarBtn.TabIndex = 8;
            addCarBtn.Text = "Add Car";
            addCarBtn.UseVisualStyleBackColor = true;
            // 
            // carMakeErrorLbl
            // 
            carMakeErrorLbl.AutoSize = true;
            carMakeErrorLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            carMakeErrorLbl.ForeColor = Color.Red;
            carMakeErrorLbl.Location = new Point(307, 69);
            carMakeErrorLbl.Name = "carMakeErrorLbl";
            carMakeErrorLbl.Size = new Size(82, 15);
            carMakeErrorLbl.TabIndex = 9;
            carMakeErrorLbl.Text = "Invalid Make!";
            carMakeErrorLbl.Visible = false;
            // 
            // carModelErrorLbl
            // 
            carModelErrorLbl.AutoSize = true;
            carModelErrorLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            carModelErrorLbl.ForeColor = Color.Red;
            carModelErrorLbl.Location = new Point(307, 118);
            carModelErrorLbl.Name = "carModelErrorLbl";
            carModelErrorLbl.Size = new Size(86, 15);
            carModelErrorLbl.TabIndex = 10;
            carModelErrorLbl.Text = "Invalid Model!";
            carModelErrorLbl.Visible = false;
            // 
            // carMpgErrorLbl
            // 
            carMpgErrorLbl.AutoSize = true;
            carMpgErrorLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            carMpgErrorLbl.ForeColor = Color.Red;
            carMpgErrorLbl.Location = new Point(307, 170);
            carMpgErrorLbl.Name = "carMpgErrorLbl";
            carMpgErrorLbl.Size = new Size(78, 15);
            carMpgErrorLbl.TabIndex = 11;
            carMpgErrorLbl.Text = "Invalid MPG!";
            carMpgErrorLbl.Visible = false;
            // 
            // carPriceErrorLbl
            // 
            carPriceErrorLbl.AutoSize = true;
            carPriceErrorLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            carPriceErrorLbl.ForeColor = Color.Red;
            carPriceErrorLbl.Location = new Point(307, 219);
            carPriceErrorLbl.Name = "carPriceErrorLbl";
            carPriceErrorLbl.Size = new Size(79, 15);
            carPriceErrorLbl.TabIndex = 12;
            carPriceErrorLbl.Text = "Invalid Price!";
            carPriceErrorLbl.Visible = false;
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 450);
            Controls.Add(carPriceErrorLbl);
            Controls.Add(carMpgErrorLbl);
            Controls.Add(carModelErrorLbl);
            Controls.Add(carMakeErrorLbl);
            Controls.Add(addCarBtn);
            Controls.Add(carPriceTxtbox);
            Controls.Add(carMpgTxtbox);
            Controls.Add(carModelTxtbox);
            Controls.Add(carMakeTxtbox);
            Controls.Add(carPriceLbl);
            Controls.Add(carMpgLbl);
            Controls.Add(carModelLbl);
            Controls.Add(carMakeLbl);
            Name = "AddCarForm";
            Text = "AddCarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label carMakeLbl;
        private Label carModelLbl;
        private Label carMpgLbl;
        private Label carPriceLbl;
        private TextBox carMakeTxtbox;
        private TextBox carModelTxtbox;
        private TextBox carMpgTxtbox;
        private TextBox carPriceTxtbox;
        private Button addCarBtn;
        private Label carMakeErrorLbl;
        private Label carModelErrorLbl;
        private Label carMpgErrorLbl;
        private Label carPriceErrorLbl;
    }
}