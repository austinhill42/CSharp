using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Programming_Assignment_2
{
    public partial class Car_Details : Form
    {
        public Car_Details()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Car_Details form = (Car_Details)((Button)sender).Parent;
            int counter = Convert.ToInt32(form.l_counter.Text);
            int count = counter - 1;

            // store the entered values
            Car.Cars[count].Make = cb_makes.SelectedItem.ToString();
            Car.Cars[count].Model = cb_models.SelectedItem.ToString();
            Car.Cars[count].CityMileage = Convert.ToInt32(tb_city.Text);
            Car.Cars[count].HwyMileage = Convert.ToInt32(tb_hwy.Text);
            Car.Cars[count].Price = Convert.ToInt32(tb_price.Text);

            // show error window if any fields are missing, otherwise continue
            // update the counter for selected car
            form.l_counter.Text = (++counter).ToString();
            ++count;

            // exit the program when done
            if (btn_next.Text.Equals("Done"))
            {
                this.Close();
                return;
            }

            // don't allow the user to enter more cars than given
            if (form.l_counter.Text.Equals(Car.Cars.Count.ToString()))
                form.btn_next.Text = "Done";

            // make previous button clickable
            if (!form.btn_prev.Enabled)
                form.btn_prev.Enabled = true;


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
                // show previouslyentered data
                form.cb_makes.SelectedIndex = form.cb_makes.FindString(Car.Cars[count].Make);
                form.cb_models.SelectedIndex = form.cb_models.FindString(Car.Cars[count].Model);
                form.tb_city.Text = Car.Cars[count].CityMileage.ToString();
                form.tb_hwy.Text = Car.Cars[count].HwyMileage.ToString();
                form.tb_price.Text = Car.Cars[count].Price.ToString();
            } 

        }

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
        }

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
                List<string> temp = new List<string>();

                // gets the list of models for the selected make from the xml file
                foreach (XElement make in XElement.Load(@"..\..\Hybrid Cars.xml").Elements("make"))
                    if (make.Attribute("name").Value.Equals(selected))
                        foreach (XElement model in make.Elements("model"))
                            temp.Add(model.Attribute("name").Value);

                // order the items alphabetically
                object[] models = (from model in temp
                                   orderby model ascending
                                   select model).ToArray<object>();

                // populate the combobox with the list of models
                form.cb_models.Items.AddRange(models);
            }
            catch (NullReferenceException ex)
            {
               /* nothing needs to be done here: placeholder because NullReferenceException is thrown 
                * when selectedItem is -1, selectedItem becomes -1 when resetting the values when the 
                * next button is clicked
                * it's not a bug...it's a feature...
                */
            }

        }

        private void Car_Details_Load(object sender, EventArgs e)
        {
            if (Car.Cars.Count == 1)
            {
                ((Car_Details)sender).btn_next.Text = "Done";
            }

            List<string> temp = new List<string>();

            // gets the list of makes from the xml file
            foreach (XElement make in XElement.Load(@"..\..\Hybrid Cars.xml").Elements("make"))
                temp.Add(make.Attribute("name").Value);

            // order the items alphabetically
            object[] makes = (from make in temp
                              orderby make ascending
                              select make).ToArray<object>();

            // populate the combobox with the list of makes
            cb_makes.Items.AddRange(makes);

        }

        private void input_check(object sender, EventArgs e)
        {
            Car_Details form;

            if (sender is ComboBox)
                form = (Car_Details)((ComboBox)sender).Parent;
            else if (sender is TextBox)
                form = (Car_Details)((TextBox)sender).Parent;
            else// if (sender is Button)
                form = (Car_Details)((Button)sender).Parent;

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
        }
    }
}
