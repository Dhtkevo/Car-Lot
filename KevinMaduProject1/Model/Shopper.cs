namespace KevinMaduProject1.Model
{
    /// <summary>
    /// Class to represent shopper
    /// </summary>
    public class Shopper
    {
        private readonly List<Car> Cars;

        /// <summary>
        /// Gets or sets the name of the shopper.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string? Name { get; set; }

        private string _money;

        /// <summary>
        /// Gets or sets the money available.
        /// </summary>
        /// <value>
        /// The money available.
        /// </value>
        public decimal? MoneyAvailable
        {
            get
            {
                return decimal.Parse(_money);
            }
            set
            {
                _money = string.Format("{0:00.00}", value);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Shopper"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="money">The money.</param>
        /// <exception cref="System.ArgumentException">
        /// Invalid Name
        /// or
        /// Invalid money available
        /// </exception>
        public Shopper(string name, decimal money)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Invalid Name");
            }

            if (money < 0)
            {
                throw new ArgumentException("Invalid money available");
            }

            Name = name;
            MoneyAvailable = money;
            Cars = new List<Car>();
        }

        /// <summary>
        /// Determines whether this shopper can purchase the specified car.
        /// </summary>
        /// <param name="car">The car.</param>
        /// <returns>
        ///   <c>true</c> if this instance can purchase the specified car; otherwise, <c>false</c>.
        /// </returns>
        public bool CanPurchase(Car car)
        {
            if (car == null)
            {
                throw new ArgumentException("Invalid car");
            }

            var totalCost = new CarLot().GetTotalCostOfPurchase(car);

            if (MoneyAvailable >= totalCost)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Purchases the car and adds to shopper's collection.
        /// </summary>
        /// <param name="car">The car.</param>
        public void PurchaseCar(Car car)
        {
            if (car == null)
            {
                throw new ArgumentException("Invalid car");
            }

            Cars.Add(car);
            MoneyAvailable -= new CarLot().GetTotalCostOfPurchase(car);
        }
    }
}
