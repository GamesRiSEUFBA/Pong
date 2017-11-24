using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BallScript : MonoBehaviour {

	[SerializeField]
	float forceValue = 4.5f;

	public GameObject ballPrefab;

	private Rigidbody2D myBody;
	private Transform ballTr;
	private Vector3 pos;

	private Text score1;
	private Text score2;

	private PlayerBar playerSc;
	private EnemyBar enemySc;

	// Adiciona uma força inicial
	void Start () {
		ballTr = GetComponent<Transform> ();
		myBody = GetComponent<Rigidbody2D>();

		score1 = GameObject.Find ("Score1").GetComponent<Text> ();
		score2 = GameObject.Find ("Score2").GetComponent<Text> ();

		playerSc = GameObject.Find ("player_01").GetComponent<PlayerBar> ();
		enemySc = GameObject.Find ("player_02").GetComponent<EnemyBar> ();

		myBody.AddForce (new Vector2 (forceValue * 50, 50));

		pos = ballTr.position;
	}

	// Nada no update
	void Update () {

	}

	void OnCollisionEnter2D (Collision2D colisao) {
		if (colisao.gameObject.tag == "right" || colisao.gameObject.tag == "left") {
			restartOver ();
		}
	}

	void restartOver() {
		if (myBody.position.x > 0) {
			playerSc.scr1++;
			score1.text = "" + playerSc.scr1;
		} else {
			enemySc.scr2++;
			score2.text = "" + enemySc.scr2;
		}

		Instantiate (ballPrefab, pos, transform.localRotation);
		Destroy (this.gameObject);
	}
}