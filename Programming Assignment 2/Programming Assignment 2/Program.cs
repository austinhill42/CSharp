using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Assignment_2
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form1 form = new Form1();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(form);
            List<TextBox> ppg = new List<TextBox>();

            foreach (TextBox tb in form.Controls.OfType<TextBox>())
                if (tb.Name.Contains("ppg"))
                    ppg.Add(tb);
        }

    }
}
