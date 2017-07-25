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

            form.l_counter.Text = (++count).ToString();

            if (!form.btn_prev.Enabled)
                form.btn_prev.Enabled = true;
        }

        private void b_prev_Click(object sender, EventArgs e)
        {
            Car_Details form = (Car_Details)((Button)sender).Parent;
            int count = Convert.ToInt32(form.l_counter.Text);

            form.l_counter.Text = (--count).ToString();

            if (form.l_counter.Text.Equals("1"))
                ((Button)sender).Enabled = false;
        }

        private void cb_makes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car_Details form = (Car_Details)((ComboBox)sender).Parent;

            form.cb_models.Enabled = true;
            form.l_model.Enabled = true;
        }

        private void Car_Details_Load(object sender, EventArgs e)
        {

        }
    }
}
