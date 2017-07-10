// Fig. 10.6: Time2Test.cs
// Overloaded constructors used to initialize Time2 objects.

using System;

public class Time2Test
{
    public static void Main(string[] args)
    {
        Time2 t1 = new Time2();             // 00:00:00
        Time2 t2 = new Time2(2);            // 02:00:00
        Time2 t3 = new Time2(21, 34);       // 21:34:00
        Time2 t4 = new Time2(12, 25, 42);   // 12:25:42
        Time2 t5 = new Time2(t4);           // 12:25:42
        Time2 t6;                           // initialized later in the program
        Time2 t7 = new Time2(3);           // time object for part b

        Console.WriteLine("Constructed with:\n");
        Console.WriteLine("t1: all arguments defaulted");
        Console.WriteLine(" {0}", t1.ToUniversalString());  // 00:00:00
        Console.WriteLine(" {0}\n", t1.ToString());         // 12:00:00 AM

        Console.WriteLine(
            "t2: hour specified; minute and second defaulted");
        Console.WriteLine(" {0}", t2.ToUniversalString());  // 02:00:00
        Console.WriteLine(" {0}\n", t2.ToString());         // 2:00:00 AM

        Console.WriteLine(
            "t3: hour and minute specified; second defaulted");
        Console.WriteLine(" {0}", t3.ToUniversalString());  // 21:34:00
        Console.WriteLine(" {0}\n", t3.ToString());         // 9:34:00 PM

        Console.WriteLine(
            "t4: hour, minute and second specified");
        Console.WriteLine(" {0}", t4.ToUniversalString());  // 12:25:42
        Console.WriteLine(" {0}\n", t4.ToString());         // 12:25:42 PM

        Console.WriteLine("t5: Time2 object t4 specified");
        Console.WriteLine(" {0}", t5.ToUniversalString());  // 12:25:42
        Console.WriteLine(" {0}\n", t5.ToString());         // 12:25:42 PM

        // attempt to initialize t6 with invalid values
        try
        {
            t6 = new Time2(27, 74, 99); // invalid values
        } // end try
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("\nException while initializing t6:");
            Console.WriteLine(ex.Message);
        } // end catch

        t7.addtime(12, 12, 12);
        Console.WriteLine("\nt7: addtime 12:12:12");
        Console.WriteLine(" {0}", t7.ToUniversalString());      // 15:12:12
        Console.WriteLine(" {0}\n", t7.ToString());             // 3:12:12 PM

        t7.addtime(3, 58, 180);
        Console.WriteLine("\nt7: addtime 3:58:180");
        Console.WriteLine(" {0}", t7.ToUniversalString());      // 19:13:12
        Console.WriteLine(" {0}\n", t7.ToString());             // 7:13:12 PM

        t7.addtime(t2);
        Console.WriteLine("\nt7: addtime t2");
        Console.WriteLine(" {0}", t7.ToUniversalString());      // 21:13:12
        Console.WriteLine(" {0}\n", t7.ToString());             // 9:13:12 PM

        // attempt to add time to t2 beyond 23:59:59
        try
        {
            t7.addtime(t4);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("\nException while adding time to t7: ");
            Console.WriteLine(e.Message);
        }

        Console.Read();

    } // end Main
} // end class Time2Test