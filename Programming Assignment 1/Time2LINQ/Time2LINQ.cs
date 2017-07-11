using System;
using System.Linq;
using System.Collections.Generic;


public static class Time2Test
{
    static void Main(string[] args)
    {
        List<Time2> times = new List<Time2>();
        bool quit = false;
        int hour = 0,
            minute = 0,
            second = 0,
            temp = 0;
        string tz = "";

        // display main menu
        while (!quit)
        {
            "\n1: Time2\n2: Time2tz\n3: Quit\n".print();
            "Make a selection: ".print();

            // get user input for time objects
            switch (read(out temp))
            {
                case 1:
                    "Enter hours: ".print();
                    read(out hour);
                    "Enter minutes: ".print();
                    read(out minute);
                    "Enter seconds: ".print();
                    read(out second);
                    times.Add(new Time2(hour, minute, second));
                    break;
                case 2:
                    "Enter hours: ".print();
                    read(out hour);
                    "Enter minutes: ".print();
                    read(out minute);
                    "Enter seconds: ".print();
                    read(out second);
                    "Enter timezone: ".print();
                    tz = Console.ReadLine();
                    times.Add(new Time2tz(hour, minute, second, tz));
                    break;
                case 3:
                    quit = true;
                    break;
                default:
                    continue;
            } // end switch
        } // end while

        quit = false;

        // display reports menu
        while (!quit)
        {
            "\n1: All objects\n2: All objects with AM times".print();
            "3: All objects with PM times\n4: Quit".print();
            "Select report type: ".print();

            // get user input for report type
            switch (read(out temp))
            {
                case 1:
                    "\nAll times: ".print();
                    foreach (var time in LINQquery(times))
                        time.ToString().print();
                    break;
                case 2:
                    "\nOnly AM times: ".print();
                    foreach (var time in LINQquery(times, "AM"))
                        time.ToString().print();
                    break;
                case 3:
                    "\nOnly PM times: ".print();
                    foreach (var time in LINQquery(times, "PM"))
                        time.ToString().print();
                    break;
                case 4:
                    quit = true;
                    break;
                default:
                    continue;
            } // end switch
        } // end while
    } // end main method

    // function to return the LINQ query as a list 
    public static List<Time2> LINQquery(List<Time2> times, String select = "")
    {
        if (select.ToUpper() == "AM")
        {
            return
                (from time in times
                 where time.Hour < 12
                 orderby time.Hour, time.Minute, time.Second ascending
                 select time).ToList();
        }

        if (select.ToUpper() == "PM")
        {
            return
                (from time in times
                 where time.Hour >= 12
                 orderby time.Hour, time.Minute, time.Second ascending
                 select time).ToList();
        }

        return
            (from time in times
             orderby time.Hour, time.Minute, time.Second ascending
             select time).ToList();
    }
    // print extension method so I don't have to keep typing Console.WriteLine
    public static void print(this string str, params object[] args)
    {
        Console.WriteLine(str, args);
    } // end print method

    // method to read int from console so I don't have to keep typing Convert.ToInt32(Console.ReadLine())
    public static int read(out int x)
    {
        return x = Convert.ToInt32(Console.ReadLine());
    } // end read method
}
