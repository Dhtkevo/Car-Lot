using KevinMaduProject1.Model;
using KevinMaduProject1.View;

namespace KevinMaduProject1
{
    /// <summary>
    /// Car Lot Form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class CarLotForm : Form
    {
        private AddCarForm _addCarForm;
        private CreateShopperForm _shopperForm;
        private DetailedInventoryForm _summaryForm;

        /// <summary>
        /// The car lot
        /// </summary>
        public CarLot Lot;

        /// <summary>
        /// Initializes a new instance of the <see cref="CarLotForm"/> class.
        /// </summary>
        public CarLotForm()
        {
            InitializeComponent();
            Lot = new CarLot();
            carsListbox.DataSource = Lot.Inventory;
        }

        private void addCarMenuItem_Click(object sender, EventArgs e)
        {
            _addCarForm = new AddCarForm();
            _addCarForm.ShowDialog();

            Lot.Inventory.Add(_addCarForm.CreatedCar);
        }

        private void shopperBtn_Click(object sender, EventArgs e)
        {
            _shopperForm = new CreateShopperForm();
            _shopperForm.ShowDialog();

            shopperNameLbl.Text = _shopperForm.CurrentShopper.Name;
            nullShopperLbl.Visible = false;

            UpdateMoneyAvailable();
        }

        private void UpdateMoneyAvailable()
        {
            var money = _shopperForm.CurrentShopper.MoneyAvailable;
            string mstring = String.Format("{0:C}", money);

            shopperMoneyLbl.Text = mstring;
        }

        private void purchaseCarBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(shopperNameLbl.Text))
            {
                nullShopperLbl.Visible = true;
                return;
            }

            var selectedCar = (Car)carsListbox.SelectedItem;


            if (!_shopperForm.CurrentShopper.CanPurchase(selectedCar))
            {
                successfulCarPurchaseLbl.Visible = false;
                notEnoughFundsLbl.Visible = true;
                return;
            }
            else
            {
                notEnoughFundsLbl.Visible = false;
                successfulCarPurchaseLbl.Text = $"Successful Purchase! Product Details: {selectedCar.ToString()} |" +
                                                $" Total After Tax: {String.Format("{0:C}", Lot.GetTotalCostOfPurchase(selectedCar))}";
                successfulCarPurchaseLbl.Visible = true;
                _shopperForm.CurrentShopper.PurchaseCar(selectedCar);

                UpdateMoneyAvailable();
            }
        }

        private void detailedInventoryBtn_Click(object sender, EventArgs e)
        {
            _summaryForm = new DetailedInventoryForm(Lot);
            _summaryForm.ShowDialog();
            
            
        }
    }
}