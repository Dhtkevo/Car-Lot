using KevinMaduProject1.Model;
using KevinMaduProject1.View;

namespace KevinMaduProject1
{
    public partial class CarLotForm : Form
    {
        private AddCarForm addCarForm;

        public CarLot Lot;
        public CarLotForm()
        {
            InitializeComponent();
            Lot = new CarLot();
        }

        // Add menu item to form that has functionality to open a dialog box that asks for details about
        // a car and adds it to current inventory of cars. 
        // The dialog box should make sure the car details are valid
        // before submitting entered car info

        private void addCarMenuItem_Click(object sender, EventArgs e)
        {
            addCarForm = new AddCarForm();
            addCarForm.ShowDialog();
        }

        



    }
}