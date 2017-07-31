using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Programming_Assignment_2
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        } // Main_Form

        private void Main_Form_Load(object sender, EventArgs e)
        {
            int year = DateTime.Today.Year;

            // assign the next ten years to the labels for price/Gal
            foreach (Label l in ((Main_Form)sender).Controls.OfType<Label>())
                if (l.Name.Contains("year") && !l.Name.Equals("l_year"))
                    l.Text = (year++).ToString();

            // add event handlers to check if textboxes have received input
            foreach (TextBox tb in ((Main_Form)sender).Controls.OfType<TextBox>())
                tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Input_Check);

            foreach (TextBox tb in ((Main_Form)sender).pnl_ppg.Controls.OfType<TextBox>())
                tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Input_Check);
        } // Main_Form_Load

        private void btn_next_Click(object sender, EventArgs e)
        {
            Main_Form mainform = (Main_Form)(((Button)sender).Parent);

            // create the list of objects and populate static variables
            try
            {
                // remove old entries
                Car.Cars = new List<Car>();

                // populate static variables
                Car.NumCars = Convert.ToInt32(tb_numcars.Text);
                Car.CityMilesDriven = Convert.ToInt32(tb_citymiles.Text);
                Car.HwyMilesDriven = Convert.ToInt32(tb_hwymiles.Text);

                // use linq to get all fields for price per gal at once, and in order
                Car.PricePerGal = (from tb in mainform.pnl_ppg.Controls.Cast<TextBox>()
                                   orderby tb.TabIndex
                                   select Convert.ToDouble(tb.Text)).ToList<double>();

                // show the next form to get data for each car
                Car_Details form = new Car_Details();
                form.ShowDialog();

                tb_output.Text = Car.FormattedOutput();
            }
            catch (FormatException ex)
            {
                // show error message if Convert.ToInt32 throws an exception
                MessageBox.Show("Only numbers are allowed, please check your data", "Error", MessageBoxButtons.OK);
            }
        } // btn_next_click

        // check if all fields have recieved input
        private void Input_Check(object sender, EventArgs e)
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
        } // input_check 

        // close the dialog window
        private void btn_done_Click(object sender, EventArgs e) { this.Close(); }

    } // class Main_Form
} // namespace Programming_Assignment_2
