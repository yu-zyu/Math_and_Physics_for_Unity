using System.Runtime.InteropServices;
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
    public static extern IntPtr find2DMidPoint(float[] P1, float[] P2);

    [DllImport("NativePluginSample")]
    public static extern IntPtr find3DMidPoint(float[] P1, float[] P2);

    public struct sphere {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] center;
        public float radius;
    };


    [DllImport("NativePluginSample")]
    public static extern bool ColBetweenSpheres(ref sphere S1, ref sphere S2);


    [DllImport("NativePluginSample")]
    public static extern float calcAngle2D(float[] p1, float[] p2);

    public struct Vector2D_comp {
        public float x,y;
    };

    public struct Vector2D_polar {
        public float mag, dir;
    };

    [DllImport("NativePluginSample")]
    public static extern void PolarToCompConversion(Vector2D_polar vec, ref Vector2D_comp temp);

    [DllImport("NativePluginSample")]
    public static extern void CompToPolarConversion(Vector2D_comp vec, ref Vector2D_polar temp);


    //  [DllImport("NativePluginSample")]
    //  public static extern class Vector3D;

    public struct Matrix3X3
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
        public float[][] index;
    };

    [DllImport("NativePluginSample")]
    public static extern bool areMatricesEqual(ref Matrix3X3 a, ref Matrix3X3 b);
}
