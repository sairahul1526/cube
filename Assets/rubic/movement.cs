﻿using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}



	// Update is called once per frame
	void Update () {

	
	if (Input.GetKey (KeyCode.LeftArrow))
		transform.Translate ((Vector3.forward ) * Time.deltaTime * 3);
	else if (Input.GetKey (KeyCode.RightArrow))
		transform.Translate (Vector3.back * Time.deltaTime * 3);
	if (Input.GetKey (KeyCode.DownArrow))
			transform.Translate (Vector3.left * Time.deltaTime * 3);
	else if (Input.GetKey (KeyCode.UpArrow))
			transform.Translate (Vector3.right * Time.deltaTime * 3);
	}
}
