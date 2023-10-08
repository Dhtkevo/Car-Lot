namespace KevinMaduProject1.View
{
    partial class DetailedInventoryForm
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
            summaryTextbox = new TextBox();
            SuspendLayout();
            // 
            // summaryTextbox
            // 
            summaryTextbox.Location = new Point(125, 60);
            summaryTextbox.Multiline = true;
            summaryTextbox.Name = "summaryTextbox";
            summaryTextbox.ReadOnly = true;
            summaryTextbox.Size = new Size(547, 338);
            summaryTextbox.TabIndex = 0;
            // 
            // DetailedInventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(summaryTextbox);
            Name = "DetailedInventoryForm";
            Text = "DetailedInventoryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox summaryTextbox;
    }
}