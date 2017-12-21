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

	public int cover = 2;
	private float enBarVelocity;
	private Rigidbody2D smallPosXBall;

	void Start () {
		enBarRb = GetComponent<Rigidbody2D> ();
		enBarBc = GetComponent<BoxCollider2D> ();
		enBarVelocity = Variables.barSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		if (Variables.vsCPU == 1) {
			List<Rigidbody2D> _ballsRb = new List<Rigidbody2D>();

			GameObject[] _balls = GameObject.FindGameObjectsWithTag ("ball");
			foreach (GameObject obj in _balls)
				_ballsRb.Add (obj.GetComponent<Rigidbody2D>());

			smallPosXBall = _ballsRb.ToArray () [0];
			foreach (Rigidbody2D rb in _ballsRb) {
				if (smallPosXBall.position.x < rb.position.x)
					smallPosXBall = rb;
			}

			_ballRb = smallPosXBall;

			enBarDirection = (_ballRb.position.y < enBarRb.position.y) ? -1 : 1;

			if (_ballRb.position.y > enBarRb.position.y + enBarBc.size.y / cover 
			    || _ballRb.position.y < enBarRb.position.y - enBarBc.size.y / cover)
				enBarRb.velocity = new Vector2 (enBarRb.velocity.x, enBarDirection * enBarVelocity);
			else
				enBarRb.velocity = new Vector2 (enBarRb.velocity.x, 0);

			enBarBc = GetComponent<BoxCollider2D> ();
		} else {

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
				enBarDirection = 1;
			else if (downKeyPressed)
				enBarDirection = -1;
			else
				enBarDirection = 0;

			enBarVelocity = Variables.barSpeed;

			enBarRb.velocity = new Vector2(enBarRb.velocity.x, enBarDirection * enBarVelocity);
		}
	}
}
