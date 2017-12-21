using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerBar : MonoBehaviour {

	private Rigidbody2D barRb;
	private bool upKeyPressed = false, downKeyPressed = false;
	private int barDirection = 0; // 0 = parado, 1= cima, -1 = baixo

	public int scr1;

	private float barVelocity;

	void Start () {
		barRb = GetComponent<Rigidbody2D> ();
		barVelocity = Variables.barSpeed;
		barRb.velocity = new Vector2(barRb.velocity.x, barDirection * barVelocity);
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
			SceneManager.LoadScene (0, LoadSceneMode.Single);

		if (Input.GetKeyDown (KeyCode.Q)) {
			upKeyPressed = true;
		} else if (Input.GetKeyDown (KeyCode.A)) {
			downKeyPressed = true;
		}

		if (Input.GetKeyUp (KeyCode.Q)) {
			upKeyPressed = false;
		} else if (Input.GetKeyUp (KeyCode.A)) {
			downKeyPressed = false;
		}

		if (upKeyPressed)
			barDirection = 1;
		else if (downKeyPressed)
			barDirection = -1;
		else
			barDirection = 0;

		barVelocity = Variables.barSpeed;

		barRb.velocity = new Vector2(barRb.velocity.x, barDirection * barVelocity);
	}
}
