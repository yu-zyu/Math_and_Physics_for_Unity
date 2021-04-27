using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoDimensionalTranslationMatrixAddition : MonoBehaviour
{
    private Material _material;
    public float[] A = new float[2];
    public float[] B = new float[2];
    public float[] C = new float[2];
    public bool isMove;
    public float[] addMatrix = new float[2];

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
            for(int i =0; i<2; i++)
            {
                A[i] += addMatrix[i];
                B[i] += addMatrix[i];
                C[i] += addMatrix[i];
            }
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
}

