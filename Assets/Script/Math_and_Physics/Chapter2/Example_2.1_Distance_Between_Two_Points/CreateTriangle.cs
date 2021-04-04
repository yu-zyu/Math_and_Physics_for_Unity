using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTriangle : MonoBehaviour
{

    [SerializeField]
    private Material _material;

    private Mesh _mesh;

    // (1) 頂点座標（この配列のインデックスが頂点インデックス）
    private Vector3[] _positions = new Vector3[]{
        new Vector3(0, 1, 0),
        new Vector3(1, -1, 0),
        new Vector3(-1, -1, 0)
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

        // (4) Meshに頂点情報を代入
        _mesh.vertices = _positions;
        _mesh.triangles = _triangles;
        _mesh.normals = _normals;

        _mesh.RecalculateBounds();
    }

    private void Update()
    {
        // (5) 描画
        Graphics.DrawMesh(_mesh, Vector3.zero, Quaternion.identity, _material, 0);
    }
}
