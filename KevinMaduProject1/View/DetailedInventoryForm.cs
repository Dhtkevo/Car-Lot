using KevinMaduProject1.Model;

namespace KevinMaduProject1.View
{
    /// <summary>
    /// Class representing detailed summary form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class DetailedInventoryForm : Form
    {
        /// <summary>
        /// The inventory of cars to be summarized
        /// </summary>
        public CarLot SummaryCars;

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedInventoryForm"/> class.
        /// </summary>
        /// <param name="cars">The cars.</param>
        public DetailedInventoryForm(CarLot cars)
        {
            InitializeComponent();
            SummaryCars = cars;

            PopulateCarSummary();
        }

        private void PopulateCarSummary()
        {
            summaryTextbox.Text = $"Inventory of {SummaryCars.Count} cars. {Environment.NewLine}";
            foreach (Car car in SummaryCars.Inventory)
            {
                summaryTextbox.Text += $"{car.ToString()} {Environment.NewLine}";
            }

            summaryTextbox.Text += $"{Environment.NewLine} Most Expensive: {Environment.NewLine} " +
                                   $"{SummaryCars.FindMostExpensiveCar().ToString()} {Environment.NewLine}";

            summaryTextbox.Text += $"{Environment.NewLine} Least Expensive: {Environment.NewLine} " +
                                   $"{SummaryCars.FindLeastExpensiveCar().ToString()} {Environment.NewLine}";

            summaryTextbox.Text += $"{Environment.NewLine} Best MPG: {Environment.NewLine} " +
                                   $"{SummaryCars.FindBestMPGCar().ToString()} {Environment.NewLine}";

            summaryTextbox.Text += $"{Environment.NewLine} Worst MPG: {Environment.NewLine} " +
                                   $"{SummaryCars.FindWorstMPG().ToString()} {Environment.NewLine}";
        }
    }
}
