using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

	public GameObject door;
	public float movmentSpeed;
	private Vector3 pos;
	private bool doorIsOpening;
	
	// Use this for initialization
	void Start () {
		pos = door.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (doorIsOpening && door.transform.position.x > -2)
		{
			door.transform.Translate(Vector3.left * Time.deltaTime * 5);
		}
		if (!doorIsOpening && door.transform.position.x < pos.x)
		{
			door.transform.Translate(Vector3.right * Time.deltaTime * 5);
		}
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if (Input.GetKey(KeyCode.E))
		{
			doorIsOpening = true;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		doorIsOpening = false;
	}
}
