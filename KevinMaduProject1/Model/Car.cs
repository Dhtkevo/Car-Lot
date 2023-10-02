namespace KevinMaduProject1.Model
{
    /// <summary>
    /// Class representing Car model
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Gets or sets the make of car.
        /// </summary>
        /// <value>
        /// The make.
        /// </value>
        /// 
        public string? Make { get; set; }
        /// <summary>
        /// Gets or sets the model of car.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        public string? Model { get; set; }


        private string? _mpg;

        /// <summary>
        /// Gets or sets the MPG of car.
        /// </summary>
        /// <value>
        /// The MPG.
        /// </value>
        public decimal? Mpg
        {
            get
            {
                return decimal.Parse(_mpg);
            }
            set
            {
                _mpg = string.Format("{0:00.00}", value);
            }
        }

        private string? _price;

        /// <summary>
        /// Gets or sets the price of car.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public decimal? Price
        {
            get
            {
                return decimal.Parse(_price);
            }
            set
            {
                _price = string.Format("{0:00.00}", value);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class based on parameters.
        /// </summary>
        /// <param name="make">The make.</param>
        /// <param name="model">The model.</param>
        /// <param name="mpg">The MPG.</param>
        /// <param name="price">The price.</param>
        /// <exception cref="System.ArgumentException">
        /// Make can't be null!
        /// or
        /// Model can't be null!
        /// or
        /// Invalid MPG
        /// or
        /// Invalid Price
        /// </exception>
        public Car(string? make, string? model, decimal? mpg, decimal? price)
        {
            if (string.IsNullOrEmpty(make))
            {
                throw new ArgumentException("Make can't be null!");
            }
            if (string.IsNullOrEmpty(model))
            {
                throw new ArgumentException("Model can't be null!");
            }
            if (mpg < 0 || mpg == null)
            {
                throw new ArgumentException("Invalid MPG");
            }
            if (price < 0 || price == null)
            {
                throw new ArgumentException("Invalid Price");
            }

            Make = make;
            Model = model;
            Mpg = mpg;
            Price = price;
        }
    }
}
