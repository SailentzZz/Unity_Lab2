using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDisable : MonoBehaviour
{

	private Light MyLight;
	
	// Use this for initialization
	void Start ()
	{
		MyLight = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.T))
		{
			MyLight.enabled = !MyLight.enabled;
		}
	}
}
