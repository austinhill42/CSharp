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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            int year = DateTime.Today.Year;

            // assign the next ten years to the labels for price/Gal
            foreach (Label l in ((Main_Form)sender).Controls.OfType<Label>())
                if (l.Name.Contains("year") && !l.Name.Equals("l_year"))
                    l.Text = (year++).ToString();

            // add event handlers to check if textboxes have received input
            foreach (TextBox tb in ((Main_Form)sender).Controls.OfType<TextBox>())
                tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.input_check);

            foreach (TextBox tb in ((Main_Form)sender).pnl_ppg.Controls.OfType<TextBox>())
                tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.input_check);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            // exit the program when done
            if (btn_next.Text.Equals("Done"))
            {
                this.Close();
                return;
            }

            Main_Form mainform = (Main_Form)(((Button)sender).Parent);

            // create the list of objects and populate static variables
            try
            {
                // create the list of objects
                for (int i = 0; i < Convert.ToInt32(tb_numcars.Text); i++)
                    Car.Cars.Add(new Car());

                // populate static variables
                Car.CityMilesDriven = Convert.ToInt32(tb_citymiles.Text);
                Car.HwyMilesDriven = Convert.ToInt32(tb_hwymiles.Text);

                // use linq to get all fields for price per gal at once, and in order
                Car.PricePerGal = (from tb in mainform.pnl_ppg.Controls.Cast<TextBox>()
                                   orderby tb.TabIndex
                                   select Convert.ToDouble(tb.Text)).ToList<double>();
                
                // show the next form to get data for each car
                Car_Details form = new Car_Details();
                form.ShowDialog();

                // done with the program
                btn_next.Text = "Done";

                string output = "";
                string spacer = " ";

                // Formatting the header
                output += string.Format("{0,-15}", "Year:");

                foreach (Label l in mainform.Controls.OfType<Label>())
                    if (l.Name.Contains("year") && !l.Name.Equals("l_year"))
                        output += string.Format("{0,-8}", l.Text);

                output += string.Format("\r\n{0,-15}", "Price per Gal:");
                //output += string.Format("{0,-30}", spacer);

                foreach (double i in Car.PricePerGal)
                    output += string.Format("{0, -8}", i);

                output += string.Format("\r\n\r\nMiles driven: {0,-8} {1,-9}", "city:", "highway:");
                output += string.Format("\r\n{0,-13} {1,-8:##,###} {2,-9:##,###}", spacer, 
                    Car.CityMilesDriven, Car.HwyMilesDriven);
                output += string.Format("\r\n\r\n");

                foreach (Car car in Car.Cars)
                    output += car.ToString();


                tb_output.Text = output;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Only numbers are allowed, please check your data", "Error", MessageBoxButtons.OK);
                Console.WriteLine(ex.Message);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void input_check(object sender, EventArgs e)
        {
            Main_Form mainform;
            bool complete = true;

            // determine if parent is the form or the panel
            if (((TextBox)sender).Parent is Panel)
                mainform = (Main_Form)(((TextBox)sender).Parent).Parent;
            else
                mainform = (Main_Form)(((TextBox)sender).Parent);

            // check to make sure the user has filled out all fields
            foreach (TextBox tb in mainform.Controls.OfType<TextBox>())
            {
                if (tb.Text.Equals(string.Empty))
                {
                    complete = false;
                    break;
                }
            }
            foreach (TextBox tb in mainform.pnl_ppg.Controls)
            {
                if (tb.Text.Equals(string.Empty))
                {
                    complete = false;
                    break;
                }
            }

            // show or hide the error label and next button
            if (complete)
            {
                l_error.Visible = false;
                btn_next.Enabled = true;
            }
            else
            {
                l_error.Visible = true;
                btn_next.Enabled = false;
            }
        }
    }
}
