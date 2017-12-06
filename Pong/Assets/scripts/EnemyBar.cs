using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBar : MonoBehaviour {

	private BoxCollider2D enBarBc;
	private Rigidbody2D enBarRb;
	private Rigidbody2D _ballRb;
	private int enBarDirection = 0;
	private bool upKeyPressed = false, downKeyPressed = false;
	public int scr2;

	public uint enBarVelocity;

	void Start () {
		enBarRb = GetComponent<Rigidbody2D> ();
		enBarBc = GetComponent<BoxCollider2D> ();

		_ballRb = GameObject.FindGameObjectWithTag("ball").GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (GameInit.vsCPU == 1) {
			_ballRb = GameObject.FindGameObjectWithTag ("ball").GetComponent<Rigidbody2D> ();

			enBarDirection = (_ballRb.position.y < enBarRb.position.y) ? -1 : 1;

			if (_ballRb.position.y > enBarRb.position.y + enBarBc.size.y / 2
			    || _ballRb.position.y < enBarRb.position.y - enBarBc.size.y / 2)
				enBarRb.velocity = new Vector2 (enBarRb.velocity.x, enBarDirection * ((int)enBarVelocity));
			else
				enBarRb.velocity = new Vector2 (enBarRb.velocity.x, 0);
		} else {

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
				enBarDirection = 1;
			else if (downKeyPressed)
				enBarDirection = -1;
			else
				enBarDirection = 0;

			enBarRb.velocity = new Vector2(enBarRb.velocity.x, enBarDirection * ((int) enBarVelocity));

		}
	}
}
