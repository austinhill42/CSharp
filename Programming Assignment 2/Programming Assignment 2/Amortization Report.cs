using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Assignment_2
{
    public partial class Amortization_Report : Form
    {
        public Amortization_Report()
        {
            InitializeComponent();
        }

        private void Amortization_Report_Load(object sender, EventArgs e)
        {
            cb_cars.Items.AddRange((from Car car in Car.Cars
                                    orderby car.Make, car.Model
                                    from str in new string[] { car.Make + " " + car.Model }
                                    select str).ToArray<object>());
        }
    }
}
