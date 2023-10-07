namespace KevinMaduProject1
{
    partial class CarLotForm
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
            mainMenuStrip = new MenuStrip();
            addCarMenuItem = new ToolStripMenuItem();
            shopperBtn = new Button();
            shopperNameInfoLbl = new Label();
            shopperMoneyInfoLbl = new Label();
            shopperNameLbl = new Label();
            shopperMoneyLbl = new Label();
            mainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { addCarMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(800, 24);
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // addCarMenuItem
            // 
            addCarMenuItem.Name = "addCarMenuItem";
            addCarMenuItem.Size = new Size(62, 20);
            addCarMenuItem.Text = "Add Car";
            addCarMenuItem.Click += addCarMenuItem_Click;
            // 
            // shopperBtn
            // 
            shopperBtn.Location = new Point(347, 198);
            shopperBtn.Name = "shopperBtn";
            shopperBtn.Size = new Size(98, 23);
            shopperBtn.TabIndex = 1;
            shopperBtn.Text = "Enter Shopper";
            shopperBtn.UseVisualStyleBackColor = true;
            shopperBtn.Click += shopperBtn_Click;
            // 
            // shopperNameInfoLbl
            // 
            shopperNameInfoLbl.AutoSize = true;
            shopperNameInfoLbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            shopperNameInfoLbl.Location = new Point(79, 37);
            shopperNameInfoLbl.Name = "shopperNameInfoLbl";
            shopperNameInfoLbl.Size = new Size(157, 28);
            shopperNameInfoLbl.TabIndex = 2;
            shopperNameInfoLbl.Text = "Shopper Name:";
            // 
            // shopperMoneyInfoLbl
            // 
            shopperMoneyInfoLbl.AutoSize = true;
            shopperMoneyInfoLbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            shopperMoneyInfoLbl.Location = new Point(446, 37);
            shopperMoneyInfoLbl.Name = "shopperMoneyInfoLbl";
            shopperMoneyInfoLbl.Size = new Size(176, 28);
            shopperMoneyInfoLbl.TabIndex = 3;
            shopperMoneyInfoLbl.Text = "Money Available:";
            // 
            // shopperNameLbl
            // 
            shopperNameLbl.AutoSize = true;
            shopperNameLbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            shopperNameLbl.Location = new Point(242, 37);
            shopperNameLbl.Name = "shopperNameLbl";
            shopperNameLbl.Size = new Size(0, 28);
            shopperNameLbl.TabIndex = 4;
            // 
            // shopperMoneyLbl
            // 
            shopperMoneyLbl.AutoSize = true;
            shopperMoneyLbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            shopperMoneyLbl.Location = new Point(624, 37);
            shopperMoneyLbl.Name = "shopperMoneyLbl";
            shopperMoneyLbl.Size = new Size(0, 28);
            shopperMoneyLbl.TabIndex = 5;
            // 
            // CarLotForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(shopperMoneyLbl);
            Controls.Add(shopperNameLbl);
            Controls.Add(shopperMoneyInfoLbl);
            Controls.Add(shopperNameInfoLbl);
            Controls.Add(shopperBtn);
            Controls.Add(mainMenuStrip);
            MainMenuStrip = mainMenuStrip;
            Name = "CarLotForm";
            Text = "CarLot Form";
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem addCarMenuItem;
        private Button shopperBtn;
        private Label shopperNameInfoLbl;
        private Label shopperMoneyInfoLbl;
        private Label shopperNameLbl;
        private Label shopperMoneyLbl;
    }
}