// Modified Time2 class declaration with overloaded constructors
using System;   // for class ArgumentOutOfRangeException

public class Time2
{
    private int seconds;   // representing time in seconds since midnight

    // constructor can be called with  zero, one, two, or three arguments
    public Time2(int h = 0, int m = 0, int s = 0)
    {
        Seconds = (h * 3600) + (m * 60) + s;    // validate time
    } // end Time2 three-argument constructor

    // Time2 constructor: another Time2 object supplied as an argument
    public Time2(Time2 time) 
        : this(time.hour(), time.minute(), time.second()) { }

    // property that gets and sets the second
    public int Seconds
    {
        get
        {
            return seconds;
        } // end get
        set
        {
            if (value >= 0 && value < 86400)
                seconds = value;
            else
                throw new ArgumentOutOfRangeException(
                    "Second", value, "Second must be 0 - 60");
        } // end set
    } // end property Second
    
    // get hours since midnight
    public int hour()
    {
        return Seconds / 3600;
    }

    // get minutes since last hour
    public int minute()
    {
        return (Seconds % 3600) / 60;
    }

    // get seconds since last minute
    public int second()
    {
        return (Seconds % 3600) % 60;
    }

    // convert to string in universal-time format (HH:MM:SS)
    public string ToUniversalString()
    {
        return string.Format("Using modified Time2 {0:D2}:{1:D2}:{2:D2}", hour(), minute(), second());

    } // end method ToUniversalString

    // convert to string in standard-time format (H:MM:SS AM or PM)
    public override string ToString()
    {
        return string.Format("Using modified Time2{0}:{1:D2}:{2:D2} {3}",
            ((hour() == 0 || hour() == 12) ? 12 : hour() % 12),
            minute(), second(), hour() < 12 ? "AM" : "PM");
    } // end method ToString
} // end class Time2

