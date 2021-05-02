using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionFromBinaryValueToDecimalValue : MonoBehaviour
{
    public char[] tobeconverted = new char[9];
    public float finalvalue = 0;
    public float powerval = 0;

    public int[] binaryplaceholder = new int[32];
    public int tobeconverted2;

    // Start is called before the first frame update
    void Start()
    {
        binarytoDecimal();
        decimaltoBinary();
    }

    //0から初めて7まで実行。トータルで8ビット
    void binarytoDecimal()
    {
        //MSBが先頭になるように指数で逆にする
        for(int j = 0; j <=7; j++)
        {
            powerval = Mathf.Pow(2, (7 - j));
            //1かどうかチェック。異なる場合は0になるはず
            if(tobeconverted[j] == '1')
            {
                finalvalue = finalvalue + powerval;
            }
        }
        tobeconverted2 = (int)finalvalue;
    }

    void decimaltoBinary()
    {
        for(int i = 0; i < 32; i++)
        {
            //入力された数を取り込み、それに余剰演算を施して、1か0を返す
            binaryplaceholder[i] = tobeconverted2 % 2;
            //余った数を2で割る操作を繰り返す
            tobeconverted2 = tobeconverted2 / 2;
        }
    }
}
