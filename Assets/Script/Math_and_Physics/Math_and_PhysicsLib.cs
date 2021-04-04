﻿using System.Runtime.InteropServices;
using System;

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
    public static extern IntPtr lineIntersect(float[] L1Point, float L1Slope, float[] L2Point, float L2Slope);

    [DllImport("NativePluginSample")]
    public static extern float distance2D(float[] P1, float[] P2);

    [DllImport("NativePluginSample")]
    public static extern float distance3D(float[] P1, float[] P2);

    [DllImport("NativePluginSample")]
    public static extern float find2DMidPoint(float[] P1, float[] P2);

    [DllImport("NativePluginSample")]
    public static extern float find3DMidPoint(float[] P1, float[] P2);

    public struct sphere { };

    [DllImport("NativePluginSample")]
    public static extern bool ColBetweenSpheres(ref sphere S1, ref sphere S2);
}
