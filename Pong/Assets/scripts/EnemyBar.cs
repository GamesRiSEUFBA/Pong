using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBar : MonoBehaviour {

	private BoxCollider2D enBarBc;
	private Rigidbody2D enBarRb;
	private Rigidbody2D _ballRb;
	private int enBarDirection = 0;

	public int scr2;

	public uint enBarVelocity;

	void Start () {
		enBarRb = GetComponent<Rigidbody2D> ();
		enBarBc = GetComponent<BoxCollider2D> ();

		_ballRb = GameObject.FindGameObjectWithTag("ball").GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		_ballRb = GameObject.FindGameObjectWithTag("ball").GetComponent<Rigidbody2D> ();

		enBarDirection = (_ballRb.position.y < enBarRb.position.y) ? -1 : 1;

		if (_ballRb.position.y > enBarRb.position.y + enBarBc.size.y/2 
			|| _ballRb.position.y < enBarRb.position.y - enBarBc.size.y/2)
			enBarRb.velocity = new Vector2(enBarRb.velocity.x, enBarDirection * ((int) enBarVelocity));
		else
			enBarRb.velocity = new Vector2(enBarRb.velocity.x, 0);
	}
}
