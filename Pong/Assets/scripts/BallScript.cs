using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {
	[SerializeField]
	float forceValue = 4.5f;

	Rigidbody2D myBody;
	// Adiciona uma força inicial
	void Start () {
		myBody = GetComponent<Rigidbody2D>();
		myBody.AddForce (new Vector2 (forceValue * 50, 50));
	}

	// Nada no update
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D c2d){
		if (c2d.gameObject.tag == "right") {
			myBody.velocity = Vector2.zero;
			transform.position = new Vector3 (0, 0, 0);
		}
		if (c2d.gameObject.tag == "left") {
			myBody.velocity = Vector2.zero;
			transform.position = new Vector3 (0, 0, 0);
		}
	}
}