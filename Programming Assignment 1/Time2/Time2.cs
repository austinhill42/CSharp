// Time2 class declaration with overloaded constructors
using System;   // for class ArgumentOutOfRangeException

public class Time2
{
    private int hour;       // 0 - 23
    private int minute;     // 0 - 59
    private int second;     // 0 - 59

    // constructor can be called with  zero, one, two, or three arguments
    public Time2(int h = 0, int m = 0, int s = 0)
    {
        SetTime(h, m, s);   // invoke SetTime to validate time
    } // end Time2 three-argument constructor

    // Time2 constructor: another Time2 object supplied as an argument
    public Time2(Time2 time)
        : this(time.Hour, time.Minute, time.Second) { }

    // set a new time value using universasl time; ensure that the data
    // remains consistent by setting invalid values to zero
    public void SetTime(int h, int m, int s)
    {
        Hour = h;     // set the Hour property
        Minute = m;     // set the Minute property
        Second = s;     // set the Second property
    } // end method SetTime

    // property that gets and sets the hour
    public int Hour
    {
        get
        {
            return hour;
        } // end get
        set
        {
            if (value >= 0 && value < 24)
                hour = value;
            else
                throw new ArgumentOutOfRangeException(
                    "Hour", value, "Hour must be 0 - 23");
        } // end set
    } // end property Hour

    // property that gets and sets the minute
    public int Minute
    {
        get
        {
            return minute;
        } // end get
        set
        {
            if (value >= 0 && value < 60)
                minute = value;
            else
                throw new ArgumentOutOfRangeException(
                    "Minute", value, "Minute must be 0 - 60");
        } // end set
    } // end property Minute

    // property that gets and sets the second
    public int Second
    {
        get
        {
            return second;
        } // end get
        set
        {
            if (value >= 0 && value < 60)
                second = value;
            else
                throw new ArgumentOutOfRangeException(
                    "Second", value, "Second must be 0 - 60");
        } // end set
    } // end property Second

    // method to add time 
    public void addtime(int h, int m, int s)
    {
        // initialize temporary variables for time
        int hour = 0,
            minute = 0,
            second = 0;

        // check for seconds overflow
        if (s > 59)
            second = s % 60;
        else
            second = s;

        // add any seconds overflow to minutes and check for overflow
        if (m + (s / 60) > 59)
            minute = (m + (s / 60)) % 60;
        else
            minute = m;

        // add minutes and seconds overflow to hours and check for overflow
        if (h + ((m + (s / 60)) / 60) > 23)
            throw new ArgumentOutOfRangeException(
                "Total time will exceed 23:59:59");
        else
            hour = h + ((m + (s / 60)) / 60);

        // add time
        Hour += hour;
        Minute += minute;
        Second += second;

    } // end method addtime

    // method to add time using Time2 object
    public void addtime(Time2 atime)
    {
        addtime(atime.Hour, atime.Minute, atime.Second);
    } // end overloaded method addtime

    // convert to string in universal-time format (HH:MM:SS)
    public virtual string ToUniversalString()
    {
        return string.Format("Using Time2: {0:D2}:{1:D2}:{2:D2}", Hour, Minute, Second);

    } // end method ToUniversalString

    // convert to string in standard-time format (H:MM:SS AM or PM)
    public override string ToString()
    {
        return string.Format("Using Time2: {0}:{1:D2}:{2:D2} {3}",
            ((Hour == 0 || Hour == 12) ? 12 : Hour % 12),
            Minute, Second, (Hour < 12 ? "AM" : "PM"));
    } // end method ToString
} // end class Time2

