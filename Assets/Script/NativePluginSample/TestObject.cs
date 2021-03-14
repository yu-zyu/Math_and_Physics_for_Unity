using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Debug.Log("int:    " + Lib.SampleAPIInt(111));
        Debug.Log("float:  " + Lib.SampleAPIFloat(111.111f));
        Debug.Log("double: " + Lib.SampleAPIDouble(111.111));

        int i = 222;
        float f = 222.0f;
        double d = 222.0;
        Lib.SampleAPIInt2(ref i);
        Lib.SampleAPIFloat2(ref f);
        Lib.SampleAPIDouble2(ref d);
        Debug.Log("int:    " + i);
        Debug.Log("float:  " + f);
        Debug.Log("double: " + d);

        int[] i_s = new int[] { 111, 222, 333 };
        int[] l_s = new int[] { 111, 222, 333 };
        float[] f_s = new float[] { 111.0f, 222.0f, 333.0f };
        float[] f_s2 = new float[] { 1.0f, 5.0f};
        float[] f_s3 = new float[] { -2.0f, 0.0f};
        double[] d_s = new double[] { 111.0, 222.0, 333.0 };
        Lib.SampleAPIIntArray(i_s, i_s.Length);
        Lib.SampleAPILongArray(l_s, l_s.Length);
        Lib.SampleAPIFloatArray(f_s, f_s.Length);
        Lib.SampleAPIDoubleArray(d_s, d_s.Length);
        Debug.LogFormat("int:    {0},{1},{2}", i_s[0], i_s[1], i_s[2]);
        Debug.LogFormat("long:   {0},{1},{2}", l_s[0], l_s[1], l_s[2]);
        Debug.LogFormat("float:  {0},{1},{2}", f_s[0], f_s[1], f_s[2]);
        Debug.LogFormat("double: {0},{1},{2}", d_s[0], d_s[1], d_s[2]);

        string st = "MyTest ";
        string s1 = Lib.SampleAPIString1();
        string s2 = Lib.SampleAPIString2(st);
        Debug.Log("string1: " + s1);
        Debug.Log("string2: " + s2);
    }
}
