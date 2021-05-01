using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UnitConversion 
{
    public const float MILE_TO_KM = 1.609f;
    public const float KN_TO_METER = 1000;
    public const int WEEK_TO_DAY = 7;
    public const int DAY_TO_HOUR = 24;
    public const int HOUR_TO_MIN = 60;
    public const int MIN_TO_SEC = 60;

    public static float ConvertDaysToSeconds(float days)
    {
        float seconds;
        seconds = days * DAY_TO_HOUR * HOUR_TO_MIN * MIN_TO_SEC;
        return seconds;
    }
    public static float ConvertMilesToMeters(float miles)
    {
        float meters;
        meters = miles * MILE_TO_KM * KN_TO_METER;
        return meters;
    }
    public static float ConvertSpeed(float miles)
    {
        float meters;
        meters = (miles * MILE_TO_KM * KN_TO_METER) / (HOUR_TO_MIN * MIN_TO_SEC);
        return meters;
    }
    public static float ConvertAcelMilesToMeters(float miles)
    {
        float accelMeters;
        accelMeters = (miles * MILE_TO_KM * KN_TO_METER) /
            (HOUR_TO_MIN * MIN_TO_SEC * HOUR_TO_MIN * MIN_TO_SEC);
        return accelMeters;
    }
}
