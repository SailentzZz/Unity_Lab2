using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenLight : MonoBehaviour {

	public Material[] materials;
	private Renderer rend;
	
	// Use this for initialization
	void Start ()
	{
		rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Q))
		{
			rend.sharedMaterial = rend.sharedMaterial == materials[1] ? materials[0] : materials[1];
		}
	}
}
