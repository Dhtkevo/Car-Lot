namespace KevinMaduProject1.View
{
    partial class CreateShopperForm
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
            createShopperNameLbl = new Label();
            createShopperMoneyLbl = new Label();
            createShopperNameTxtbox = new TextBox();
            createShopperMoneyTxtbox = new TextBox();
            createShopperBtn = new Button();
            createShopperNameErrorLbl = new Label();
            createShopperMoneyErrorLbl = new Label();
            SuspendLayout();
            // 
            // createShopperNameLbl
            // 
            createShopperNameLbl.AutoSize = true;
            createShopperNameLbl.Location = new Point(133, 117);
            createShopperNameLbl.Name = "createShopperNameLbl";
            createShopperNameLbl.Size = new Size(114, 15);
            createShopperNameLbl.TabIndex = 0;
            createShopperNameLbl.Text = "Shopper First Name:";
            // 
            // createShopperMoneyLbl
            // 
            createShopperMoneyLbl.AutoSize = true;
            createShopperMoneyLbl.Location = new Point(146, 162);
            createShopperMoneyLbl.Name = "createShopperMoneyLbl";
            createShopperMoneyLbl.Size = new Size(98, 15);
            createShopperMoneyLbl.TabIndex = 1;
            createShopperMoneyLbl.Text = "Money Available:";
            // 
            // createShopperNameTxtbox
            // 
            createShopperNameTxtbox.Location = new Point(253, 114);
            createShopperNameTxtbox.Name = "createShopperNameTxtbox";
            createShopperNameTxtbox.Size = new Size(100, 23);
            createShopperNameTxtbox.TabIndex = 2;
            // 
            // createShopperMoneyTxtbox
            // 
            createShopperMoneyTxtbox.Location = new Point(253, 159);
            createShopperMoneyTxtbox.Name = "createShopperMoneyTxtbox";
            createShopperMoneyTxtbox.Size = new Size(100, 23);
            createShopperMoneyTxtbox.TabIndex = 3;
            // 
            // createShopperBtn
            // 
            createShopperBtn.Location = new Point(253, 209);
            createShopperBtn.Name = "createShopperBtn";
            createShopperBtn.Size = new Size(100, 23);
            createShopperBtn.TabIndex = 4;
            createShopperBtn.Text = "Submit";
            createShopperBtn.UseVisualStyleBackColor = true;
            createShopperBtn.Click += createShopperBtn_Click;
            // 
            // createShopperNameErrorLbl
            // 
            createShopperNameErrorLbl.AutoSize = true;
            createShopperNameErrorLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            createShopperNameErrorLbl.ForeColor = Color.Red;
            createShopperNameErrorLbl.Location = new Point(359, 117);
            createShopperNameErrorLbl.Name = "createShopperNameErrorLbl";
            createShopperNameErrorLbl.Size = new Size(113, 15);
            createShopperNameErrorLbl.TabIndex = 5;
            createShopperNameErrorLbl.Text = "Enter a valid name!";
            createShopperNameErrorLbl.Visible = false;
            // 
            // createShopperMoneyErrorLbl
            // 
            createShopperMoneyErrorLbl.AutoSize = true;
            createShopperMoneyErrorLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            createShopperMoneyErrorLbl.ForeColor = Color.Red;
            createShopperMoneyErrorLbl.Location = new Point(359, 167);
            createShopperMoneyErrorLbl.Name = "createShopperMoneyErrorLbl";
            createShopperMoneyErrorLbl.Size = new Size(129, 15);
            createShopperMoneyErrorLbl.TabIndex = 6;
            createShopperMoneyErrorLbl.Text = "Valid Format: \"XX.XX\"";
            createShopperMoneyErrorLbl.Visible = false;
            // 
            // CreateShopperForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 450);
            Controls.Add(createShopperMoneyErrorLbl);
            Controls.Add(createShopperNameErrorLbl);
            Controls.Add(createShopperBtn);
            Controls.Add(createShopperMoneyTxtbox);
            Controls.Add(createShopperNameTxtbox);
            Controls.Add(createShopperMoneyLbl);
            Controls.Add(createShopperNameLbl);
            Name = "CreateShopperForm";
            Text = "CreateShopperForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createShopperNameLbl;
        private Label createShopperMoneyLbl;
        private TextBox createShopperNameTxtbox;
        private TextBox createShopperMoneyTxtbox;
        private Button createShopperBtn;
        private Label createShopperNameErrorLbl;
        private Label createShopperMoneyErrorLbl;
    }
}