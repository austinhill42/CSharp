using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Assignment_2
{
    public class Car
    {
        private double cityMileage;
        private double hwyMileage;
        private double price;
        public string Make { get; set; }   // combobox doesn't allow for user input, default get/set 
        public string Model { get; set; }  // combobox doesn't allow for user input, default get/set 
        private static int numCars;
        private static double cityMilesDriven;
        private static double hwyMilesDriven;
        private static List<Car> cars = new List<Car>();
        private static List<double> pricePerGal = new List<double>();

        public double CityMileage
        {
            get
            {
                return cityMileage;
            }
            set
            {
                if (value < 0)
                    show_error("Invalid input: city mileage must be greater then 0");
                else
                    cityMileage = value;
            }
        }

        public double HwyMileage
        {
            get
            {
                return hwyMileage;
            }
            set
            {
                if (value < 0)
                    show_error("Invalid input: highway mileage must be greater then 0");
                else
                    hwyMileage = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0)
                    show_error("Invalid input: initial price must be greater then 0");
                else
                    price = value;
            }
        }

        public int NumCars
        {
            get
            {
                return numCars;
            }
            set
            {
                if (value < 0)
                    show_error("Invalid input: number of cars must be greater then 0");
                else
                    numCars = value;
            }
        }

        public static double CityMilesDriven
        {
            get
            {
                return cityMilesDriven;
            }
            set
            {
                if (value < 0)
                    show_error("Invalid input: city miles driven price must be greater then 0");
                else
                    cityMilesDriven = value;
            }
        }

        public static double HwyMilesDriven
        {
            get
            {
                return hwyMilesDriven;
            }
            set
            {
                if (value < 0)
                    show_error("Invalid input: highway miles driven price must be greater then 0");
                else
                    hwyMilesDriven = value;
            }
        }

        public static List<Car> Cars
        {
            get
            {
                return cars;
            }
            set
            {
                cars = value;
            }
        }

        public static List<double> PricePerGal
        {
            get
            {
                return pricePerGal;
            }
            set
            {
                pricePerGal = value;
            }
        }

        public static void show_error(string message)
        {
            MessageBox.Show(message, "Input Error", MessageBoxButtons.OK);
        }

        // fully parameterized constructor
        public Car(double cityMileage = 0, double hwyMileage = 0, double price = 0, string make = "", string model = "")
        {
            CityMileage = cityMileage;
            HwyMileage = hwyMileage;
            Price = price;
            Make = make;
            Model = model;
        }

        public override string ToString()
        {
            return string.Format("{0,-15} {1,-20} MPG rating: city: {2,-4} highway: {3, -4}" +
                                 "\r\n{4,-37}Initial cost: {5, -8:C2} \r\n{6,-37}Ten year cost of gas: {7,-5:C2}" +
                                 "\r\n{8,-37}Ten year cost of ownership: {9,-6:C2}\r\n",
                                 this.Make, this.Model, this.CityMileage, this.HwyMileage, " ",
                                 this.Price, " ", this.costOfGas(), " ", this.costOfOwnership());
        }

        public double costOfGas()
        {
            double sum = 0;

            // calculate cost of gas
            foreach (double ppg in Car.PricePerGal)
                sum += ((CityMilesDriven / this.CityMileage) + (HwyMilesDriven / this.HwyMileage)) * ppg;

            return sum;
        }

        public double costOfOwnership()
        {
            return this.Price + this.costOfGas();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Main_Form mainform;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(mainform = new Main_Form());
        }
    }
}
