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
}