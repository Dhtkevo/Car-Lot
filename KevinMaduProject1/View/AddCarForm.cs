using System.Text.RegularExpressions;
using KevinMaduProject1.Model;

namespace KevinMaduProject1.View
{
    /// <summary>
    /// Class representing the form that adds car to inventory
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class AddCarForm : Form
    {

        /// <summary>
        /// The created car
        /// </summary>
        public Car CreatedCar;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddCarForm"/> class.
        /// </summary>
        public AddCarForm()
        {
            InitializeComponent();
        }

        private void addCarBtn_Click(object sender, EventArgs e)
        {
            if (ValidateAddCarForm())
            {
                Close();
            }

        }

        private bool ValidateAddCarForm()
        {
            ValidateTextFieldNotEmpty(carMakeTxtbox, carMakeErrorLbl);
            ValidateTextFieldNotEmpty(carModelTxtbox, carModelErrorLbl);
            ValidateTextFieldNotEmpty(carMpgTxtbox, carMpgErrorLbl);
            ValidateTextFieldNotEmpty(carPriceTxtbox, carPriceErrorLbl);

            string numericPattern = "^\\-?[0-9]+(?:\\.[0-9]{1,2})?$";
            string alphaPattern = "^[a-zA-Z]{2,}$";

            Regex rg = new Regex(numericPattern);
            Regex rg2 = new Regex(alphaPattern);

            ValidateFieldValue(alphaPattern, carMakeTxtbox, carMakeErrorLbl);
            ValidateFieldValue(alphaPattern, carModelTxtbox, carModelErrorLbl);
            ValidateFieldValue(numericPattern, carMpgTxtbox, carMpgErrorLbl);
            ValidateFieldValue(numericPattern, carPriceTxtbox, carPriceErrorLbl);

            if (!carMakeErrorLbl.Visible && !carModelErrorLbl.Visible && !carMpgErrorLbl.Visible &&
                !carPriceErrorLbl.Visible)
            {
                CreatedCar = new Car(carMakeTxtbox.Text, carModelTxtbox.Text,
                    Decimal.Parse(carMpgTxtbox.Text), Decimal.Parse(carPriceTxtbox.Text));
                return true;
            }

            return false;
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

        private void ValidateTextFieldNotEmpty(TextBox box, Label label)
        {
            if (string.IsNullOrWhiteSpace(box.Text))
            {
                label.Visible = true;
                return;
            }

            label.Visible = false;
        }
    }
}
