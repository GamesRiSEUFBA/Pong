﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerBar : MonoBehaviour {

	private Rigidbody2D barRb;
	private bool upKeyPressed = false, downKeyPressed = false;
	private int barDirection = 0;

	public int scr1;

	int direction = 0; // 0 = parado, 1= cima, -1 = baixo

	public uint barVelocity;

	void Start () {
		barRb = GetComponent<Rigidbody2D> ();	
		barRb.velocity = new Vector2(barRb.velocity.x, barDirection * ((int) barVelocity));
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
			SceneManager.LoadScene (0, LoadSceneMode.Single);

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			upKeyPressed = true;
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			downKeyPressed = true;
		}

		if (Input.GetKeyUp (KeyCode.UpArrow)) {
			upKeyPressed = false;
		} else if (Input.GetKeyUp (KeyCode.DownArrow)) {
			downKeyPressed = false;
		}

		if (upKeyPressed)
			barDirection = 1;
		else if (downKeyPressed)
			barDirection = -1;
		else
			barDirection = 0;

		barRb.velocity = new Vector2(barRb.velocity.x, barDirection * ((int) barVelocity));
	}
}
