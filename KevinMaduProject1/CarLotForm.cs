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
        private AddCarForm addCarForm;

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
        }

        private void addCarMenuItem_Click(object sender, EventArgs e)
        {
            addCarForm = new AddCarForm();
            addCarForm.ShowDialog();

            Lot.Inventory.Add(addCarForm.CreatedCar);
        }

        



    }
}