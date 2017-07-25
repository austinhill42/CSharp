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
        public List<string> Makes { get; set; }
        public List<string> Models { get; set; }

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

            // show error window if any fields are missing, otherwise continue
            if (complete)
            {
                Car_Details form = new Car_Details();
                form.Show();              
            }
            else
            {
                Error_Form form = new Error_Form();
                form.Show();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
