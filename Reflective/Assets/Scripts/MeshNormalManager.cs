using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MeshNormalManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.triangles = mesh.triangles.Reverse().ToArray();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
