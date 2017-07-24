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
            Form1 form;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(form = new Form1());
            List<TextBox> ppg = new List<TextBox>();
            List<Label> years = new List<Label>();

            foreach (TextBox tb in form.Controls.OfType<TextBox>())
                if (tb.Name.Contains("ppg"))
                    ppg.Add(tb);

        }

    }
}
