using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KevinMaduProject1.Model;

namespace KevinMaduProject1.View
{
    /// <summary>
    /// Class representing detailed summary form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class DetailedInventoryForm : Form
    {
        public CarLot summaryCars;
        public DetailedInventoryForm(CarLot cars)
        {
            InitializeComponent();
            summaryCars = cars;

            PopulateCarSummary();
        }

        private void PopulateCarSummary()
        {
            summaryTextbox.Text = $"Inventory of {summaryCars.Count} cars. {Environment.NewLine}";
            foreach (Car car in summaryCars.Inventory)
            {
                summaryTextbox.Text += $"{car.ToString()} {Environment.NewLine}";
            }

            summaryTextbox.Text += $"{Environment.NewLine} Most Expensive: {Environment.NewLine} " +
                                   $"{summaryCars.FindMostExpensiveCar().ToString()} {Environment.NewLine}";

            summaryTextbox.Text += $"{Environment.NewLine} Least Expensive: {Environment.NewLine} " +
                                   $"{summaryCars.FindLeastExpensiveCar().ToString()} {Environment.NewLine}";

            summaryTextbox.Text += $"{Environment.NewLine} Best MPG: {Environment.NewLine} " +
                                   $"{summaryCars.FindBestMPGCar().ToString()} {Environment.NewLine}";

            summaryTextbox.Text += $"{Environment.NewLine} Worst MPG: {Environment.NewLine} " +
                                   $"{summaryCars.FindWorstMPG().ToString()} {Environment.NewLine}";
        }
    }
}
