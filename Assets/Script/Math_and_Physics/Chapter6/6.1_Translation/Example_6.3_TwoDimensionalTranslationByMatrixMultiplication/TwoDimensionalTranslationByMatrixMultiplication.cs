using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoDimensionalTranslationByMatrixMultiplication : MonoBehaviour
{
    private Material _material;
    public float[] A = new float[3];
    public float[] B = new float[3];
    public float[] C = new float[3];
    public bool isMove;
    public float dx;
    public float dy;

    private Mesh _mesh;

    // (1) 頂点座標（この配列のインデックスが頂点インデックス）
    public Vector3[] _positions = new Vector3[]{
        new Vector3(0, 0, -1),
        new Vector3(0, 0, -1),
        new Vector3(0, 0, -1)
    };


    // (2) ポリゴンを形成する頂点インデックスを順番に指定する
    private int[] _triangles = new int[] { 0, 1, 2 };

    // (3) 法線
    private Vector3[] _normals = new Vector3[]{
        new Vector3(0, 0, -1),
        new Vector3(0, 0, -1),
        new Vector3(0, 0, -1)
    };

    private void Awake()
    {
        _mesh = new Mesh();
    }

    private void Update()
    {

        if (isMove)
        {
            Matrix3X3 matrixA = new Matrix3X3();
            A = MatrixMultiplication(matrixA, A);
            Matrix3X3 matrixB = new Matrix3X3();
            B = MatrixMultiplication(matrixB, B);
            Matrix3X3 matrixC = new Matrix3X3();
            C = MatrixMultiplication(matrixC, C);
            isMove = false;
        }

        _positions[0] = new Vector3(A[0], A[1], 0);
        _positions[1] = new Vector3(B[0], B[1], 0);
        _positions[2] = new Vector3(C[0], C[1], 0);

        // (4) Meshに頂点情報を代入
        _mesh.vertices = _positions;
        _mesh.triangles = _triangles;
        _mesh.normals = _normals;

        _mesh.RecalculateBounds();

        // (5) 描画
        Graphics.DrawMesh(_mesh, Vector3.zero, Quaternion.identity, _material, 0);

    }

    public float[] MatrixMultiplication(Matrix3X3 X, float[] vertex)
    {
        // 1 0 dx
        // 0 1 dy
        // 0 0 1
        X.matrix[0, 0] = 1;
        X.matrix[1, 1] = 1;
        X.matrix[2, 2] = 1;

        X.matrix[0, 2] = dx;
        X.matrix[1, 2] = dy;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                X.matrix[i, j] *= vertex[j];
            }
        }

        float[] x = new float[3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                x[i] += X.matrix[i, j];
            }
        }
        return x;
    }

}


