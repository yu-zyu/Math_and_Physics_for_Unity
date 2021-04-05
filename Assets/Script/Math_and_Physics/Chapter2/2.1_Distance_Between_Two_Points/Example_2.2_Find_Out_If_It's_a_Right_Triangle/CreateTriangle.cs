using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTriangle : MonoBehaviour
{

    [SerializeField]
    private Material _material;
    public float distanceAB;
    public float distanceBC;
    public float distanceCA;
    public float A2B2;
    public float C2;

    public float[] A = new float[2];
    public float[] B = new float[2];
    public float[] C = new float[2];

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
        distanceAB = Math_and_PhysicsLib.distance2D(A, B);
        distanceBC = Math_and_PhysicsLib.distance2D(B, C);
        distanceCA = Math_and_PhysicsLib.distance2D(C, A);

        A2B2 = distanceAB * distanceAB + distanceBC * distanceBC;
        C2 = distanceCA * distanceCA;

        if (A2B2 == C2)
        {
            Debug.Log("直角三角形です");
        }

    }
}
