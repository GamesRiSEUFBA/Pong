using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameOver : MonoBehaviour {

	private Material backMat;

	void Start () {
		GameObject.Find("Winner").GetComponent<Text> ().text = Variables.winner;

		backMat = Resources.Load ("Materials/MatBack") as Material;	
		backMat.color = Variables.backMat;
	}
}
