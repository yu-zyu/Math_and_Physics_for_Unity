using System.Runtime.InteropServices;

public class Math_and_PhysicsLib
{

    //物理・数学ライブラリ
    [DllImport("NativePluginSample")]
    public static extern float slopeBetweenPoints(float[] P1, float[] P2);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
