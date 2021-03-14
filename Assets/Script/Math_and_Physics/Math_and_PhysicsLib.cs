using System.Runtime.InteropServices;

public class Math_and_PhysicsLib
{

    //物理・数学ライブラリ
    [DllImport("NativePluginSample")]
    public static extern float slopeBetweenPoints(float[] P1, float[] P2);
}
