using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Programming_Assignment_2
{
    public partial class Car_Details : Form
    {
        public Car_Details()
        {
            InitializeComponent();
        } // Car_Details

        // on form load, populate the makes combobox from the list of makes, alphabetically
        private void Car_Details_Load(object sender, EventArgs e)
        {
            if (Car.Cars.Count == 1)
            {
                ((Car_Details)sender).btn_next.Text = "Done";
            }

            List<string> makes = new List<string>();

            // gets the list of makes from the xml file
            foreach (XElement make in XElement.Load(@"..\..\Hybrid Cars.xml").Elements("make"))
                makes.Add(make.Attribute("name").Value);

            // order the items alphabetically and populate the combobox
            cb_makes.Items.AddRange((from make in makes
                                     orderby make ascending
                                     select make).ToArray<object>());
        } // Car_Details_Load

        // Updates the form and retrieves data from controls, 
        // exits when last of the data has been entered
        private void btn_next_Click(object sender, EventArgs e)
        {
            Car_Details form = (Car_Details)((Button)sender).Parent;
            int counter = Convert.ToInt32(form.l_counter.Text);
            int count = counter - 1;

            try
            {
                // store the entered values
                Car.Cars[count].Make = cb_makes.SelectedItem.ToString();
                Car.Cars[count].Model = cb_models.SelectedItem.ToString();
                Car.Cars[count].CityMileage = Convert.ToInt32(tb_city.Text);
                Car.Cars[count].HwyMileage = Convert.ToInt32(tb_hwy.Text);
                Car.Cars[count].Price = Convert.ToInt32(tb_price.Text);
                Car.Cars[count].CalculateCostOfGas();
                Car.Cars[count].CalculateCostOfOwnership();

                // update the counter for selected car
                form.l_counter.Text = (++counter).ToString();
                ++count;

                // make previous button clickable
                if (!form.btn_prev.Enabled)
                    form.btn_prev.Enabled = true;

                // exit the program when done
                if (btn_next.Text.Equals("Done"))
                {
                    this.Close();
                    return;
                }

                // don't allow the user to enter more cars than given
                if (form.l_counter.Text.Equals(Car.Cars.Count.ToString()))
                    form.btn_next.Text = "Done";

                if (Car.Cars[count].Make.Equals(""))
                {
                    // clear errant data
                    form.cb_makes.SelectedIndex = -1;
                    form.tb_city.Text = string.Empty;
                    form.tb_hwy.Text = string.Empty;
                    form.tb_price.Text = string.Empty;

                    // reset the models combobox
                    form.cb_models.Text = string.Empty;
                    form.cb_models.Items.Clear();
                }
                else
                {
                    // show previously entered data
                    form.cb_makes.SelectedIndex = form.cb_makes.FindString(Car.Cars[count].Make);
                    form.cb_models.SelectedIndex = form.cb_models.FindString(Car.Cars[count].Model);
                    form.tb_city.Text = Car.Cars[count].CityMileage.ToString();
                    form.tb_hwy.Text = Car.Cars[count].HwyMileage.ToString();
                    form.tb_price.Text = Car.Cars[count].Price.ToString();
                }

                // reset focus to first control
                form.cb_makes.Focus();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Only numbers are allowed to be entered for price and mileage",
                    "Error", MessageBoxButtons.OK);
            }
        } // btn_next_click

        // shows previously entered data
        private void b_prev_Click(object sender, EventArgs e)
        {
            Car_Details form = (Car_Details)((Button)sender).Parent;
            int counter = Convert.ToInt32(form.l_counter.Text);
            int count = counter - 1;

            // update the counter for selected car
            form.l_counter.Text = (--counter).ToString();
            --count;

            // don't allow negative counter
            if (form.l_counter.Text.Equals("1"))
                ((Button)sender).Enabled = false;

            // show previous selections
            form.cb_makes.SelectedIndex = form.cb_makes.FindString(Car.Cars[count].Make);
            form.cb_models.SelectedIndex = form.cb_models.FindString(Car.Cars[count].Model);
            form.tb_city.Text = Car.Cars[count].CityMileage.ToString();
            form.tb_hwy.Text = Car.Cars[count].HwyMileage.ToString();
            form.tb_price.Text = Car.Cars[count].Price.ToString();

            btn_next.Text = "Next Car";
        } // btn_prev_Click

        // populate the comboboxes with correct make/models
        private void cb_makes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car_Details form = (Car_Details)((ComboBox)sender).Parent;

            // make the models combobox selectable
            form.cb_models.Enabled = true;
            form.l_model.Enabled = true;

            // reset the models combobox
            form.cb_models.Items.Clear();
            form.cb_models.Text = string.Empty;

            try
            {
                string selected = ((ComboBox)sender).SelectedItem.ToString();
                List<string> models = new List<string>();

                // gets the list of models for the selected make from the xml file
                foreach (XElement make in XElement.Load(@"..\..\Hybrid Cars.xml").Elements("make"))
                    if (make.Attribute("name").Value.Equals(selected))
                        foreach (XElement model in make.Elements("model"))
                            models.Add(model.Attribute("name").Value);

                // populate the combobox with the list of models ordered alphabetically
                form.cb_models.Items.AddRange((from model in models
                                               orderby model ascending
                                               select model).ToArray<object>());
            }
            catch (NullReferenceException ex)
            {
                /* nothing needs to be done here: placeholder because NullReferenceException is thrown 
                 * when selectedItem is -1, selectedItem becomes -1 while resetting the values when the 
                 * next button is clicked
                 * it's not a bug...it's a feature...
                 */
            }
        } // cb_makes_SelectedIndexChanged

        // check if all fields have recieved input
        private void Input_Check(object sender, EventArgs e)
        {
            Car_Details form = (Car_Details)((Control)sender).Parent;
            bool complete = true;

            // check to make sure the user has filled out all fields
            foreach (TextBox tb in form.Controls.OfType<TextBox>())
            {
                if (tb.Text.Equals(string.Empty))
                {
                    complete = false;
                    break;
                }
            }

            if (cb_makes.SelectedIndex == -1 || cb_models.SelectedIndex == -1)
                complete = false;

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
        } // Input_Check

        // close the dialog window
        private void btn_cancel_Click(object sender, EventArgs e) { this.Close(); }

    } // class Car_Details
} // namespace Programming_Assignment_2
