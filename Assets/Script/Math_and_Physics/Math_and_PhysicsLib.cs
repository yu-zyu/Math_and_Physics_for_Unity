﻿using System.Runtime.InteropServices;

public class Math_and_PhysicsLib
{

    //物理・数学ライブラリ
    [DllImport("NativePluginSample")]
    public static extern float slopeBetweenPoints(float[] P1, float[] P2);
    [DllImport("NativePluginSample")]
    public static extern float perpSlope(float slope);
    [DllImport("NativePluginSample")]
    public static extern bool arePerp(float slope1, float slope2);
    [DllImport("NativePluginSample")]
    public static extern float lineIntersect(float[] L1Point, float L1Slope, float[] L2Point, float L2Slope);
}