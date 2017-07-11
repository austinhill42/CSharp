using System;

public class Time2tz : Time2
{
    private string timezone;

    // constructor that takes 0 - 4 arguments
    public Time2tz(int h = 0, int m = 0, int s = 0, string tz = "EST")
        : base(h, m, s)
    {
        Timezone = tz;
    } // end four-argument constructor

    // contructor to add a timezone to existing time object
    public Time2tz(Time2 atime, string tz)
        : this(atime.hour(), atime.minute(), atime.second(), tz) { }

    // constructor to create Time2tz object from existing Time2tz object
    public Time2tz(Time2tz atime)
        : this(atime.hour(), atime.minute(), atime.second(), atime.Timezone) { }

    // property that gets and sets the timezone
    public string Timezone
    {
        get
        {
            return timezone;
        } // end get
        set
        {
            switch (value.ToUpper())
            {
                case "EST":
                case "CST":
                case "MST":
                case "PST":
                    timezone = value.ToUpper();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Timezone", value.ToUpper(), "Timezone must be EST, CST, MST, or PST");
            } // end switch
        } // end set
    } // end property Timezone

    // convert to string in universal-time format (HH:MM:SS TimeZone)
    public override string ToUniversalString()
    {
        return string.Format(base.ToUniversalString() + " " + Timezone);

    } // end method ToUniversalString

    // convert to string in standard-time format (H:MM:SS AM or PM TimeZone)
    public override string ToString()
    {
        return string.Format(base.ToString() + " " + Timezone);
    } // end method ToString

} // end class Time2tz

