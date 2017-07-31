using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Programming_Assignment_2
{
    public class Car
    {
        // Using default get/set since data is validated by the form before continuing
        public double CostOfOwnership { get; set; }
        public double CostOfGas { get; set; }
        public double CityMileage { get; set; }
        public double HwyMileage { get; set; }
        public double Price { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public static int NumCars { get; set; }
        public static double CityMilesDriven { get; set; }
        public static double HwyMilesDriven { get; set; }
        public static List<Car> Cars { get; set; }
        public static List<double> PricePerGal { get; set; }

        // fully parameterized constructor, all parameters optional
        public Car(string make = "", string model = "", double price = 0, double cityMileage = 0,
            double hwyMileage = 0, double costOfGas = 0, double costOfOwnership = 0)
        {
            Make = make;
            Model = model;
            Price = price;
            CityMileage = cityMileage;
            HwyMileage = hwyMileage;
            CostOfGas = (from ppg in PricePerGal
                         select ((CityMilesDriven / CityMileage) + (HwyMilesDriven / HwyMileage)) * ppg).Sum();
            CostOfOwnership = this.Price + this.CostOfGas;
        } // Car

        // calculate cost of gas
        public void CalculateCostOfGas()
        {
            // override previous data, if any
            CostOfGas = 0;



        } // CalculateCostOfGas

        // calculate cost of ownership
        public void CalculateCostOfOwnership()
        {

        } // CalculateCostOfOwnership

        // overrided ToString
        public override string ToString()
        {
            return string.Format("{0,-15} {1,-20} MPG rating: city: {2,-4} highway: {3, -4}" +
                "\r\n{4,-37}Initial cost: {5, -8:C2} \r\n{6,-37}Ten year cost of gas: {7,-5:C2}" +
                "\r\n{8,-37}Ten year cost of ownership: {9,-6:C2}\r\n", this.Make, this.Model,
                this.CityMileage, this.HwyMileage, " ", this.Price, " ", this.CostOfGas, " ",
                this.CostOfOwnership);
        } // ToString

        // format output into neat rows/comlums
        public static string FormattedOutput()
        {
            string output = "";
            int year = DateTime.Today.Year;

            // order cars by cost of ownership
            List<Car> orderedCars = (from Car cars in Car.Cars
                                     orderby cars.CostOfOwnership ascending
                                     select cars).ToList();

            /** print the header **/
            output += string.Format("{0,-15}", "Year:");

            // getting the next 10 consecutive years
            for (int i = 0; i < 10; i++)
                output += string.Format("{0,-8}", year++.ToString());

            output += string.Format("\r\n{0,-15}", "Price per Gal:");

            foreach (double i in Car.PricePerGal)
                output += string.Format("{0, -8}", i);

            output += string.Format("\r\n\r\nMiles driven: {0,-8} {1,-9}", "city:", "highway:");
            output += string.Format("\r\n{0,-13} {1,-8:##,###} {2,-9:##,###}", " ",
                Car.CityMilesDriven, Car.HwyMilesDriven);
            output += string.Format("\r\n\r\n");

            /** print each cars data **/
            foreach (Car car in orderedCars)
                output += car.ToString() + "\r\n";

            return output;
        } // FormattedOutput

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Form());
        } // Main
    } // class Car
} // namespace Programming_Assignment_2
