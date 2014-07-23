using UnityEngine;
using System.Collections;

public class ripple : MonoBehaviour {

	public int rows;
	public int cols;

	Mesh mesh;
	float[][] heights;

	// Use this for initialization
	void Start () {
		var meshFilter = GetComponent<MeshFilter>();
		mesh = meshFilter.mesh;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
