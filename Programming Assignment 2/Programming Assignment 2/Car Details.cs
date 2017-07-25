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

                // don't allow negative counter
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
                Error_Form error = new Error_Form();
                error.Show();
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
        }

        private void cb_makes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car_Details form = (Car_Details)((ComboBox)sender).Parent;

            // make the models combobox selectable
            form.cb_models.Enabled = true;
            form.l_model.Enabled = true;

            // reset the models combobox
            form.cb_models.Items.Clear();

            // populate the models combobox with the hybrid cars of the selected make
            populateModels(((ComboBox)sender).SelectedItem.ToString(), form);
        }

        private void Car_Details_Load(object sender, EventArgs e)
        {
            // populates the makes combobox with a list of current hybrid car manufacturers 
            foreach (XElement make in XElement.Load(@"..\..\Hybrid Cars.xml").Elements("make"))
                cb_makes.Items.Add(make.Attribute("name").Value);
        }

        private void populateModels(string name, Car_Details form)
        {
            // populates the models combobox with current (model year 2000 or newer) hybrid models
            // from the selected make
            foreach (XElement make in XElement.Load(@"..\..\Hybrid Cars.xml").Elements("make"))
                if (make.Attribute("name").Value.Equals(name))
                    foreach (XElement model in make.Elements("model"))
                        form.cb_models.Items.Add(model.Attribute("name").Value);
        }
    }
}
