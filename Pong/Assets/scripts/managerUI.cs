using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerUI : MonoBehaviour {

	public GameObject ranking;
	public GameObject score;


	// Use this for initialization
	void Start () {
		disableRanking ();
		activeScore ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void gameOver(){
		activeRanking ();
		desableScore ();
	}

	public void activeRanking(){
		ranking.SetActive (true);
	}

	public void disableRanking(){
		ranking.SetActive (false);
	}


	public void activeScore(){
		score.SetActive (true);
	}

	public void desableScore(){
		score.SetActive (false);
	}




}
