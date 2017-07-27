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
    public partial class Error_Form : Form
    {
        public Error_Form()
        {
            InitializeComponent();
        }

        public Error_Form(string message) : this()
        {
            l_error.Text = message;
        }
    }
}
