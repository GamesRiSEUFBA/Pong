using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBackgroundColor : MonoBehaviour {

	private Material backMat;

	private Camera cam;

	void Start () {
		backMat = Resources.Load ("Materials/MatBack") as Material;
		backMat.color = Variables.backMat;
		cam = GetComponent<Camera> ();
		cam.backgroundColor = backMat.color;
	}
	
	// Update is called once per frame
	void Update () {
		cam.backgroundColor = backMat.color;
	}
}
