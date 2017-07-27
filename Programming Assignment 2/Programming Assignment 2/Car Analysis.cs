using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Assignment_2
{
    public static class Car_Analysis
    {
        private static List<double> pricePerGal = new List<double>();
        private static List<string> makes = new List<string>();
        private static List<string> models = new List<string>();
        public static int NumCars { get; set; }
        public static double CityMiles { get; set; }
        public static double HwyMiles { get; set; }

        public static List<string> Makes
        {
            get
            {
                return makes;
            }
            set
            {
                makes = new List<string>();
                makes.AddRange(value);
            }
        }

        public static List<string> Models
        {
            get
            {
                return models;
            }
            set
            {
                models = new List<string>();
                models.AddRange(value);
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
                pricePerGal = new List<double>();
                pricePerGal.AddRange(value);
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Main_Form form;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(form = new Main_Form());

            foreach (double d in PricePerGal)
                Console.WriteLine(d);
        }
    }
}
