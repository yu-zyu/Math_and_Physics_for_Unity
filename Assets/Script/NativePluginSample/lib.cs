using System.Runtime.InteropServices;

public class Lib
{

    // 値渡し
    [DllImport("NativePluginSample")]
    public static extern int SampleAPIInt(int i);
    [DllImport("NativePluginSample")]
    public static extern float SampleAPIFloat(float f);
    [DllImport("NativePluginSample")]
    public static extern double SampleAPIDouble(double d);

    // 参照渡し
    [DllImport("NativePluginSample")]
    public static extern void SampleAPIInt2(ref int i);
    [DllImport("NativePluginSample")]
    public static extern void SampleAPIFloat2(ref float f);
    [DllImport("NativePluginSample")]
    public static extern void SampleAPIDouble2(ref double d);

    // 配列の参照渡し
    [DllImport("NativePluginSample")]
    public static extern void SampleAPIIntArray(int[] intArray, int intArraySize);
    [DllImport("NativePluginSample")]
    public static extern void SampleAPILongArray(int[] longArray, int longArraySize);
    [DllImport("NativePluginSample")]
    public static extern void SampleAPIFloatArray(float[] floatArray, int floatArraySize);
    [DllImport("NativePluginSample")]
    public static extern float slopeBetweenPoints(float[] P1, float[] P2, int P1Size, int P2Size);
    [DllImport("NativePluginSample")]
    public static extern void SampleAPIDoubleArray(double[] doubleArray, int doubleArraySize);

    // 文字列
    [DllImport("NativePluginSample")]
    public static extern string SampleAPIString1();
    [DllImport("NativePluginSample")]
    public static extern string SampleAPIString2(string str);
}
