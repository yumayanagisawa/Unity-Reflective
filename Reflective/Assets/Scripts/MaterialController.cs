using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialController : MonoBehaviour {
    private Material mat;

	// Use this for initialization
	void Start () {
        mat = GetComponent<Renderer>().material;//.SetFloat("_BumpScale", -0.5f);
		
	}
	
	// Update is called once per frame
	void Update () {

        mat.SetFloat("_BumpScale", Mathf.Sin(Time.time)*1.5f);
    }
}
