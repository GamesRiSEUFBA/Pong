using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InstructionMenu : MonoBehaviour {

	private RectTransform instructions;
	private RectTransform pong;

	private int dir = -1;
	private float scale = 1;

	// Use this for initialization
	void Start () {
		instructions = GameObject.Find ("Instructions").GetComponent<RectTransform> ();
		pong = GameObject.Find ("Pong").GetComponent<RectTransform> ();
	}

	public void loadInstructions(){
		pong.localPosition = new Vector3 (pong.localPosition.x + 168F * dir, pong.localPosition.y, pong.localPosition.z);
		instructions.localScale = new Vector3 (scale, instructions.localScale.y, instructions.localScale.z);

		if (scale == 1)
			scale = 0;
		else
			scale = 1;

		if (dir == 1)
			dir = -1;
		else
			dir = 1;
	}
}
