using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameOver : MonoBehaviour {

	void Start () {
		GameObject.Find("Winner").GetComponent<Text> ().text = GameInit.winner;
	}
}
