using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniformScaling3D : MonoBehaviour
{
    private Material _material;
    public float[] A = new float[4];
    public float[] B = new float[4];
    public float[] C = new float[4];
    public float[] D = new float[4];
    public bool isMove;
    public float sx;
    public float sy;
    public float sz;

    private Mesh _mesh;

    // (1) 頂点座標（この配列のインデックスが頂点インデックス）
    public Vector3[] _positions = new Vector3[]{
        new Vector3(0, 0, -1),
        new Vector3(0, 0, -1),
        new Vector3(0, 0, -1),
    };

    // (2) ポリゴンを形成する頂点インデックスを順番に指定する
    private int[] _triangles = new int[] { 0, 1, 2 };
       // 0, 2, 3 };

    // (3) 法線
    private Vector3[] _normals = new Vector3[]{
        new Vector3(0, 0, -1),
        new Vector3(0, 0, -1),
        new Vector3(0, 0, -1),
    };

    private void Awake()
    {
        _mesh = new Mesh();
    }

    private void Update()
    {

        if (isMove)
        {
            Matrix4X4 matrixA = new Matrix4X4();
            A = MatrixMultiplication(matrixA, A);
            Matrix4X4 matrixB = new Matrix4X4();
            B = MatrixMultiplication(matrixB, B);
            Matrix4X4 matrixC = new Matrix4X4();
            C = MatrixMultiplication(matrixC, C);
            isMove = false;
        }

        _positions[0] = new Vector3(A[0], A[1], A[2]);
        _positions[1] = new Vector3(B[0], B[1], B[2]);
        _positions[2] = new Vector3(C[0], C[1], C[2]);

        // (4) Meshに頂点情報を代入
        _mesh.vertices = _positions;
        _mesh.triangles = _triangles;
        _mesh.normals = _normals;

        _mesh.RecalculateBounds();

        // (5) 描画
        Graphics.DrawMesh(_mesh, Vector3.zero, Quaternion.identity, _material, 0);

    }

    public float[] MatrixMultiplication(Matrix4X4 X, float[] vertex)
    {
        // sx  0   0  0
        // 0  sy   0  0 
        // 0   0  sz  0
        // 0   0   0  1
        X.matrix[3, 3] = 1;

        X.matrix[0, 0] = sx;
        X.matrix[1, 1] = sy;
        X.matrix[2, 2] = sz;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                X.matrix[i, j] *= vertex[j];
            }
        }

        float[] x = new float[4];

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                x[i] += X.matrix[i, j];
            }
        }
        return x;
    }

}
