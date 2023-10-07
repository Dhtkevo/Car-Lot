using System.Text.RegularExpressions;
using KevinMaduProject1.Model;

namespace KevinMaduProject1.View
{
    /// <summary>
    /// Class for shopper form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class CreateShopperForm : Form
    {
        /// <summary>
        /// The shopper
        /// </summary>
        public Shopper shopper;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShopperForm"/> class.
        /// </summary>
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
