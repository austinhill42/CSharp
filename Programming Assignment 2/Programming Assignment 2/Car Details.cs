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
            int count = Convert.ToInt32(form.l_counter.Text);
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
            foreach (ComboBox cb in form.Controls.OfType<ComboBox>())
            {
                if (cb.Text.Equals(string.Empty))
                {
                    complete = false;
                    break;
                }
            }

            // show error window if any fields are missing, otherwise continue
            if (complete)
            {
                // update the counter for selected car
                form.l_counter.Text = (++count).ToString();

                // don't allow the user to enter more cars than given
                if (form.l_counter.Text.Equals(Car_Analysis.NumCars.ToString()))
                {
                    form.btn_next.Enabled = false;
                    form.btn_done.Enabled = true;
                }
                
                // make previous button clickable
                if (!form.btn_prev.Enabled)
                    form.btn_prev.Enabled = true;

                // clear previous selections
                form.cb_makes.Text = string.Empty;
                form.tb_city.Text = string.Empty;
                form.tb_highway.Text = string.Empty;
                form.tb_price.Text = string.Empty;

                // reset the models combobox
                form.cb_models.Text = string.Empty;
                form.cb_models.Items.Clear();
            }
            else
            {
                Error_Form error = new Error_Form("You must complete all fields to continue!");
                error.ShowDialog();
            }
        }

        private void b_prev_Click(object sender, EventArgs e)
        {
            Car_Details form = (Car_Details)((Button)sender).Parent;
            int count = Convert.ToInt32(form.l_counter.Text);

            // update the counter for selected car
            form.l_counter.Text = (--count).ToString();

            // don't allow negative counter
            if (form.l_counter.Text.Equals("1"))
                ((Button)sender).Enabled = false;

            /*
             * TODO add done and next functionality
             */ 
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

        private void Car_Details_Load(object sender, EventArgs e)
        {
            if (Car_Analysis.NumCars == 1)
            {
                ((Car_Details)sender).btn_next.Enabled = false;
                ((Car_Details)sender).btn_done.Enabled = true;
            }

            List <string> temp = new List<string>();

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

        private void populateModels(string name, Car_Details form)
        {
            // populates the models combobox with current (model year 2000 or newer) hybrid models
            // from the selected make
            
        }
    }
}
