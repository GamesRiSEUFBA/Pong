using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BallScript : MonoBehaviour {

	public GameObject ballPrefab;

	private Rigidbody2D barRb;
	private Rigidbody2D enBarRb;

	private Rigidbody2D ballRb;
	private Transform ballTr;
	private Vector3 pos;

	private Text score1;
	private Text score2;

	private PlayerBar playerSc;
	private EnemyBar enemySc;

	private LoadOnClick loadOnClick;

	private float velBX, velBY;
	public float speed;
	private float randomAngle;

	// Adiciona uma força inicial
	void Start () {
		ballTr = GetComponent<Transform> ();
		ballRb = GetComponent<Rigidbody2D>();

		score1 = GameObject.Find ("Score1").GetComponent<Text> ();
		score2 = GameObject.Find ("Score2").GetComponent<Text> ();

		playerSc = GameObject.Find ("player_01").GetComponent<PlayerBar> ();
		enemySc = GameObject.Find ("player_02").GetComponent<EnemyBar> ();

		barRb = GameObject.Find ("player_01").GetComponent<Rigidbody2D> ();
		enBarRb = GameObject.Find ("player_02").GetComponent<Rigidbody2D> ();

		//ballRb.AddForce (new Vector2 (forceValue * 50, 50));

		pos = ballTr.position;

		speed = 8f;

		randomAngle = getRandonAngle (true);
		velBX = Mathf.Cos (randomAngle) * speed;
		velBY = Mathf.Sin (randomAngle) * speed;
	}

	// Nada no update
	void Update () {
		ballRb.velocity = new Vector2 (velBX, velBY);

		if (ballRb.position.x > enBarRb.position.x || ballRb.position.x < barRb.position.x)
			restartOver();
	}

	void OnCollisionEnter2D (Collision2D colisao) {
		if (colisao.gameObject.tag == "parede") {
			velBY *= -1;
		}
		if (colisao.gameObject.tag == "bar") {
			bounceBall ();
		}

	}

	void restartOver() {
		if (ballRb.position.x > 0) {
			playerSc.scr1++;
			score1.text = "" + playerSc.scr1;
		} else {
			enemySc.scr2++;
			score2.text = "" + enemySc.scr2;
		}

		Instantiate (ballPrefab, pos, transform.localRotation);
		//changeLevel (playerSc.scr1, enemySc.scr2);
		Destroy (this.gameObject);
		//changeLevel (playerSc.scr1, enemySc.scr2); 

	}

	void changeLevel(int scr1, int scr2){
		print ("changeLevel");
		if (scr1 + scr2 == 15) {
			loadOnClick.loadScene (4);
		}
		

	}

	void bounceBall() {
		int direct = (ballRb.position.x > 0)?( -1):(1);

		randomAngle = getRandonAngle (false);

		float dir = Random.value;
		if (dir > 0.5)
			dir = 1;
		else
			dir = -1;

		velBX = direct * Mathf.Cos(randomAngle) * speed * 1.3f;
		velBY = dir * Mathf.Sin (randomAngle) * speed * 1.3f;
	}

	float getRandonAngle(bool init) {
		float angle;
		if (init) {
			angle = Random.value * 2 * Mathf.PI;
			while ((angle > Mathf.PI / 3 && angle < 2 * Mathf.PI / 3) || (angle > 4 * Mathf.PI / 3 && angle < 5 * Mathf.PI / 3))
				angle = Random.value * 2 * Mathf.PI;
		} else {
			angle = (Random.value * Mathf.PI / 3);
		}

		return angle;
	}
}