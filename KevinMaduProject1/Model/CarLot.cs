namespace KevinMaduProject1.Model
{
    /// <summary>
    /// Class representing a Car lot
    /// </summary>
    public class CarLot
    {
        private readonly List<Car> _inventory;

        /// <summary>
        /// The tax rate for cars
        /// </summary>
        public const decimal TaxRate = 7.8m;

        /// <summary>
        /// Gets the count of cars in inventory.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        public int Count => _inventory.Count;

        /// <summary>
        /// Gets the inventory of cars.
        /// </summary>
        /// <value>
        /// The inventory.
        /// </value>
        public List<Car> Inventory => _inventory;

        /// <summary>
        /// Initializes a new instance of the <see cref="CarLot"/> class.
        /// </summary>
        public CarLot()
        {
            _inventory = new List<Car>();
            StockLotWithDefaultInventory();
        }

        private void StockLotWithDefaultInventory()
        {
            var ford = new Car("Ford", "Focus ST", 28.3m, 26298.98m);
            var chevy = new Car("Chevrolet", "Camaro ZL1", 19m,65401.23m);
            var honda = new Car("Honda", "Accord Sedan EX", 30.2m, 26780m);
            var lexus = new Car("Lexus", "ES 350", 24.1m, 42101.10m);

            _inventory.Add(ford);
            _inventory.Add(chevy);
            _inventory.Add(honda);
            _inventory.Add(lexus);
        }

        /// <summary>
        /// Finds the cars by make.
        /// </summary>
        /// <param name="make">The make.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">Invalid Make</exception>
        public List<Car>? FindCarsByMake(string make)
        {
            if (string.IsNullOrWhiteSpace(make))
            {
                throw new ArgumentException("Invalid Make");
            }

            var matchedCars = new List<Car>();
       
            foreach (Car car in _inventory)
            {
                if (car.Make.ToLower() == make.ToLower())
                {
                    matchedCars.Add(car);
                }
            }
            return matchedCars.Count > 0 ? matchedCars : null;
        }

        /// <summary>
        /// Finds the car by make and model.
        /// </summary>
        /// <param name="make">The make.</param>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">
        /// Invalid Make
        /// or
        /// Invalid Model
        /// </exception>
        public Car FindCarByMakeModel(string make, string model)
        {
            if (string.IsNullOrWhiteSpace(make))
            {
                throw new ArgumentException("Invalid Make");
            }

            if (string.IsNullOrWhiteSpace(model))
            {
                throw new ArgumentException("Invalid Model");
            }

            var match = _inventory.Find(car =>
                car.Make.ToLower() == make.ToLower() && car.Model.ToLower() == model.ToLower());

            return match != null? match: null;
        }

        /// <summary>
        /// Purchases the car that matches make and model.
        /// </summary>
        /// <param name="make">The make.</param>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">
        /// Invalid Make
        /// or
        /// Invalid Model
        /// </exception>
        public Car? PurchaseCar(string make, string model)
        {
            if (string.IsNullOrWhiteSpace(make))
            {
                throw new ArgumentException("Invalid Make");
            }

            if (string.IsNullOrWhiteSpace(model))
            {
                throw new ArgumentException("Invalid Model");
            }

            var match = _inventory.Exists(car =>
                car.Make.ToLower() == make.ToLower() && car.Model.ToLower() == model.ToLower());

            if (match)
            {
                var matchToRemove = FindCarByMakeModel(make, model);

                _inventory.Remove(matchToRemove);

                return matchToRemove;
            }

            return null;
        }

        /// <summary>
        /// Creates and adds car to inventory.
        /// </summary>
        /// <param name="make">The make.</param>
        /// <param name="model">The model.</param>
        /// <param name="mpg">The MPG.</param>
        /// <param name="price">The price.</param>
        /// <exception cref="System.ArgumentException">
        /// Invalid Make
        /// or
        /// Invalid Model
        /// or
        /// Invalid MPG
        /// </exception>
        public void AddCar(string make, string model, decimal mpg, decimal price)
        {
            if (string.IsNullOrWhiteSpace(make))
            {
                throw new ArgumentException("Invalid Make");
            }

            if (string.IsNullOrWhiteSpace(model))
            {
                throw new ArgumentException("Invalid Model");
            }

            if (mpg < 0)
            {
                throw new ArgumentException("Invalid MPG");
            }

            if (price < 0)
            {
                throw new ArgumentException("Invalid MPG");
            }

            var newCar = new Car(make, model, mpg, price);
            _inventory.Add(newCar);
        }

        /// <summary>
        /// Gets the total cost of purchase for specified car.
        /// </summary>
        /// <param name="car">The car.</param>
        /// <returns></returns>
        public decimal? GetTotalCostOfPurchase(Car car)
        {
            return car.Price * TaxRate;
        }

        /// <summary>
        /// Finds the least expensive car in the inventory.
        /// </summary>
        /// <returns></returns>
        public Car? FindLeastExpensiveCar()
        {
            if (_inventory.Count == 0)
            {
                return null;
            }

            var cheapestCar = _inventory[0];

            foreach (var car in _inventory)
            {
                if (car.Price < cheapestCar.Price)
                {
                    cheapestCar = car;
                }
            }

            return cheapestCar;
        }

        /// <summary>
        /// Finds the most expensive car in the inventory.
        /// </summary>
        /// <returns></returns>
        public Car? FindMostExpensiveCar()
        {
            if (_inventory.Count == 0)
            {
                return null;
            }

            var expensiveCar = _inventory[0];

            foreach (var car in _inventory)
            {
                if (car.Price > expensiveCar.Price)
                {
                    expensiveCar = car;
                }
            }

            return expensiveCar;
        }

        /// <summary>
        /// Finds the best MPG car.
        /// </summary>
        /// <returns></returns>
        public Car? FindBestMPGCar()
        {
            if (_inventory.Count == 0)
            {
                return null;
            }

            var bestMpgCar = _inventory[0];

            foreach (var car in _inventory)
            {
                if (car.Mpg > bestMpgCar.Mpg)
                {
                    bestMpgCar = car;
                }
            }

            return bestMpgCar;
        }

        /// <summary>
        /// Finds the worst MPG.
        /// </summary>
        /// <returns></returns>
        public Car? FindWorstMPG()
        {
            if (_inventory.Count == 0)
            {
                return null;
            }

            var worstMpgCar = _inventory[0];

            foreach (var car in _inventory)
            {
                if (car.Mpg < worstMpgCar.Mpg)
                {
                    worstMpgCar = car;
                }
            }

            return worstMpgCar;
        }
    }
}
