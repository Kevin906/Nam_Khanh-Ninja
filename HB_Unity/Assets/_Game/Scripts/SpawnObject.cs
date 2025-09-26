using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
	[SerializeField] private SpawnObject SpawnObjectPretab;
	// Update is called once per frame
	void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CreateTriangle();
        }
    }

	void CreateTriangle()
	{
		GameObject triangleObject = new GameObject("ProceduralTriangle");
		triangleObject.transform.position = Vector3.zero;

		MeshFilter meshFilter = triangleObject.AddComponent<MeshFilter>();
		MeshRenderer meshRenderer = triangleObject.AddComponent<MeshRenderer>();

		meshRenderer.material = new Material(Shader.Find("Standard"));

		Mesh mesh = new Mesh();
		meshFilter.mesh = mesh;

		Vector3[] vertices = new Vector3[]
		{
				new Vector3(0, 0, 0),
                new Vector3(0, 1, 0),
                new Vector3(1, 0, 0)
		};

		int[] triangles = new int[]
		{
				0, 1, 2
		};

		mesh.vertices = vertices;
		mesh.triangles = triangles;

		mesh.RecalculateNormals();
	}
}
