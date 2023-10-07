using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using KevinMaduProject1.Model;

namespace KevinMaduProject1.View
{
    public partial class CreateShopperForm : Form
    {
        public Shopper shopper;

        public CreateShopperForm()
        {
            InitializeComponent();
        }

        private void createShopperBtn_Click(object sender, EventArgs e)
        {
            ValidateShopperForm();

            if (!createShopperNameErrorLbl.Visible && !createShopperMoneyErrorLbl.Visible)
            {
                shopper = new Shopper(createShopperNameTxtbox.Text, Decimal.Parse(createShopperMoneyTxtbox.Text));
                Close();
            }
        }

        private void ValidateShopperForm()
        {
            string alphaPattern = "^[a-zA-Z]{2,}$";
            string numericPattern = "^\\-?[0-9]+(?:\\.[0-9]{1,2})?$";

            Regex rg = new Regex(numericPattern);
            Regex rg2 = new Regex(alphaPattern);

            ValidateFieldValue(alphaPattern, createShopperNameTxtbox, createShopperNameErrorLbl);
            ValidateFieldValue(numericPattern, createShopperMoneyTxtbox, createShopperMoneyErrorLbl);
        }

        private void ValidateFieldValue(string pattern, TextBox box, Label errLabel)
        {
            Match m = Regex.Match(box.Text, pattern);

            if (!m.Success)
            {
                errLabel.Visible = true;
                return;
            }

            errLabel.Visible = false;
        }
    }
}
