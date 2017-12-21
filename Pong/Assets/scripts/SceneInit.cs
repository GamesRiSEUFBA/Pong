using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneInit : MonoBehaviour {

	private Material barMat;
	private Material ballMat;
	private Material lineMat;
	private Material backMat;

	void Start () {
		barMat = GameObject.Find ("player_01").GetComponent<Renderer> ().sharedMaterial;
		ballMat = GameObject.Find ("ball").GetComponent<Renderer> ().sharedMaterial;
		lineMat = GameObject.Find ("linhaPNGBranca").GetComponent<Renderer> ().sharedMaterial;
		backMat = Resources.Load ("Materials/MatBack") as Material;	

		barMat.color = Variables.barMat;
		ballMat.color = Variables.ballMat;
		lineMat.color = Variables.lineMat;
		backMat.color = Variables.backMat;
	}

	void Update () {
	}
}
