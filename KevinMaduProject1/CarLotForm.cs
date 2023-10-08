using KevinMaduProject1.Model;
using KevinMaduProject1.View;
using System.Security.Policy;

namespace KevinMaduProject1
{
    /// <summary>
    /// Car Lot Form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class CarLotForm : Form
    {
        private AddCarForm addCarForm;
        private CreateShopperForm shopperForm;
        private DetailedInventoryForm summaryForm;

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
            addCarForm = new AddCarForm();
            addCarForm.ShowDialog();

            Lot.Inventory.Add(addCarForm.CreatedCar);
        }

        private void shopperBtn_Click(object sender, EventArgs e)
        {
            shopperForm = new CreateShopperForm();
            shopperForm.ShowDialog();

            shopperNameLbl.Text = shopperForm.shopper.Name;
            nullShopperLbl.Visible = false;

            UpdateMoneyAvailable();
        }

        private void UpdateMoneyAvailable()
        {
            var money = shopperForm.shopper.MoneyAvailable;
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


            if (!shopperForm.shopper.CanPurchase(selectedCar))
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
                shopperForm.shopper.PurchaseCar(selectedCar);

                UpdateMoneyAvailable();
            }
        }

        private void detailedInventoryBtn_Click(object sender, EventArgs e)
        {
            summaryForm = new DetailedInventoryForm(Lot);
            summaryForm.ShowDialog();
            
            
        }
    }
}