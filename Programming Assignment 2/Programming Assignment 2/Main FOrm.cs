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
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Main_Form mainform = (Main_Form)(((Button)sender).Parent);
            bool complete = true;

            // check to make sure the user has filled out all fields
            foreach (TextBox tb in mainform.Controls.OfType<TextBox>())
                if (tb.Text.Equals(string.Empty))
                    complete = false;
            foreach (TextBox tb in mainform.pnl_ppg.Controls)
                if (tb.Text.Equals(string.Empty))
                    complete = false;

            // show error window if any fields are missing, otherwise continue
            if (complete)
            {
                // store the values entered
                Car_Analysis.NumCars = Convert.ToInt32(tb_numcars.Text);
                Car_Analysis.CityMiles = Convert.ToInt32(tb_citymiles.Text);
                Car_Analysis.HwyMiles = Convert.ToInt32(tb_hwymiles.Text);
                Car_Analysis.PricePerGal = ((from control in mainform.pnl_ppg.Controls.Cast<TextBox>()
                                             select Convert.ToDouble(control.Text)).Reverse().ToList<double>());


                Car_Details form = new Car_Details();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must complete all fields to continue!", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
