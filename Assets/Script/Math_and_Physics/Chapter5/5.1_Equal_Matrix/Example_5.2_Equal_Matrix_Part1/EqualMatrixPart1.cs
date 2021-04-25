using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EqualMatrixPart1 : MonoBehaviour
{
    Math_and_PhysicsLib.Matrix3X3 matrixC;
    Math_and_PhysicsLib.Matrix3X3 matrixD;
    Math_and_PhysicsLib.Matrix3X3 matrixF;
    Math_and_PhysicsLib.Matrix3X3 matrixG;
    Math_and_PhysicsLib.Matrix3X3 matrixA = new Math_and_PhysicsLib.Matrix3X3();
    Math_and_PhysicsLib.Matrix3X3 matrixB= new Math_and_PhysicsLib.Matrix3X3();

    // Start is called before the first frame update
    void Start()
    {

        //        matrixC.index = new float[,] {
        //        { 1, 2, 3 },
        //        { 4, 5, 6 }
        //        };
        //
        //        matrixD.index = new float[,] {
        //        { 1, 2, 3 },
        //        { 4, 5, 6 },
        //        { 7, 8, 9 }
        //        };
        //
        //        matrixF.index = new float[,] {
        //        { 1, 2, 3 },
        //        { 4, 5, 6 },
        //        { 0, 8, 9 }
        //        };
        //
        //        matrixG.index = new float[,] {
        //        { 1, 2, 3 },
        //        { 4, 5, 6 },
        //        { 7, 8, 9 }
        //        };
        //

        //        matrixA.index = new float[3][3];
        //        matrixA.index[0,0] = 1;

        matrixA.index = new float[9][];
        matrixA.index[0] = new float[9];
        matrixA.index[1] = new float[9];
        matrixA.index[2] = new float[9];
        matrixB.index = new float[9][];
        matrixB.index[0] = new float[9];
        matrixB.index[1] = new float[9];
        matrixB.index[2] = new float[9];

       matrixA.index[0][0] = 1;
       matrixA.index[0][1] = 2;
       matrixA.index[0][2] = 3;
       matrixA.index[1][0] = 4;
       matrixA.index[1][1] = 5;
       matrixA.index[1][2] = 6;
       matrixA.index[2][0] = 7;
       matrixA.index[2][1] = 8;
       matrixA.index[2][2] = 9;

        
////        matrixA.index[0,1] = 1;
////        matrixA.index[0,2] = 1;
////        matrixA.index[1,0] = 1;
////        matrixA.index[1,1] = 1;
////        matrixA.index[1,2] = 1;
////        matrixA.index[2,0] = 1;
////        matrixA.index[2,1] = 1;
////        matrixA.index[2,2] = 1;

////        matrixB.index = new float[3,3];
////        matrixB.index[0, 0] = 1;
       matrixB.index[0][0] = 1;
       matrixB.index[0][1] = 2;
       matrixB.index[0][2] = 3;
       matrixB.index[1][0] = 4;
       matrixB.index[1][1] = 5;
       matrixB.index[1][2] = 6;
       matrixB.index[2][0] = 7;
       matrixB.index[2][1] = 8;
       matrixB.index[2][2] = 9;

for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                Debug.Log(matrixB.index[i][j]);

            }

        }

//        matrixB.index[0, 1] = 1;
//        matrixB.index[0,2] = 1;
//        matrixB.index[1,0] = 1;
//        matrixB.index[1,1] = 1;
//        matrixB.index[1,2] = 1;
//        matrixB.index[2,0] = 1;
//        matrixB.index[2,1] = 1;
//        matrixB.index[2,2] = 1;


        bool resultCD = Math_and_PhysicsLib.areMatricesEqual(ref matrixA, ref matrixB);
        if (resultCD)
        {
            Debug.Log("CDは等しい");
        }
        else
        {
            Debug.Log("CDは等しくない");
        }

//        bool resultFG = Math_and_PhysicsLib.areMatricesEqual(ref matrixF, ref matrixG);
//        if (resultFG)
//        {
//            Debug.Log("FGは等しい");
//        }
//        else
//        {
//            Debug.Log("FGは等しくない");
//        }
//
    }
}
