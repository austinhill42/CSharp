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

        private void Form1_Load(object sender, EventArgs e)
        {
            int year = DateTime.Today.Year;

            foreach (Label l in ((Main_Form)sender).Controls.OfType<Label>())
                if (l.Name.Contains("year") && !l.Name.Equals("l_year"))
                    l.Text = (year++).ToString();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Car_Details form = new Car_Details();
            form.Show();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
