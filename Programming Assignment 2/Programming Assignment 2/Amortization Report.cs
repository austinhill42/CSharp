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
            // populate the combobox with list of selected cars
            cb_cars.Items.AddRange((from Car car in Car.Cars
                                    orderby car.Make, car.Model
                                    from str in new string[] { car.Make + " " + car.Model }
                                    select str).ToArray<object>());
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            Car car = (Car)(from Car cars in Car.Cars
                            where (cars.Make + " " + cars.Model).ToString() == cb_cars.SelectedItem.ToString()
                            select cars).FirstOrDefault();

            Amortization_Report form = (Amortization_Report)((Button)sender).Parent;
            double down = Convert.ToDouble(form.tb_downpmt.Text);
            double rate = Convert.ToDouble(form.tb_rate.Text);
            double period = Convert.ToDouble(form.tb_period.Text);
            double principle = car.Price - down;
            double interest = rate / 12;
            double payment = (principle * interest) / (1 - Math.Pow((1 + interest), -(period * 12)));

            while (principle > 0)
            {
                double currentInterest = principle * interest;
                double currentPrinciple = payment - currentInterest;
                double newPrinciple = principle - currentPrinciple;

                Console.WriteLine("current interest: {0:C}\ncurrent principle: {1:C}\nnew balance: {2:C}\n", 
                    currentInterest, currentPrinciple, newPrinciple);

                principle = newPrinciple;
            }

            //Console.WriteLine("Price: {0:C}\nPrinciple: {1:C}\n");
            //Console.WriteLine("Monthly Payments: {0:C}", payment);

        }
    }
}
