﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ChangerLevel : MonoBehaviour {

	private BallScript ballSc;

	private Transform enemyTr;
	private Transform playerTr;

	//private RectTransform panel;
	//private Text warning;

	// Use this for initialization
	void Start () {
		playerTr = GameObject.Find ("player_01").GetComponent<Transform> ();
		enemyTr = GameObject.Find ("player_02").GetComponent<Transform> ();
		ballSc = GameObject.Find ("ball").GetComponent<BallScript> ();

		//warning = GameObject.Find ("Warning").GetComponent<Text> ();
		//panel = GameObject.Find ("Panel").GetComponent<RectTransform> ();
	}
	
	// Update is called once per frame
	void Update () {}
		
	public void changeLevel(int scr1, int scr2, Vector3 initScaleBar, Vector3 initScaleBall){
		if (scr1 + scr2 == 0)
			return;
		
		print ("changeLevel");

		if ((scr1 + scr2)%5 == 0) {
			// Change bar size
			if (scr1 < scr2)
				if ((playerTr.localScale.y - 0.2)/initScaleBar.y > 0.3) 
					playerTr.localScale -= new Vector3 (0, 0.2F, 0);
			if (scr1 > scr2)
				if ((enemyTr.localScale.y - 0.2)/initScaleBar.y > 0.3) 
					enemyTr.localScale -= new Vector3 (0, 0.2F, 0);
			if (scr1 == scr2) {
				if (playerTr.localScale.y > enemyTr.localScale.y) {
					enemyTr.localScale = playerTr.localScale;
				} else {
					playerTr.localScale = enemyTr.localScale;
				}
			}
		} 

		if ((scr1 + scr2)%10 == 0) {
			// Decrease ball size
			if ((ballSc.transform.localScale.y - 0.2)/initScaleBall.y > 0.4) 
				ballSc.transform.localScale -= new Vector3 (0.2F, 0.2F, 0);
		} 

		if (scr1 <= 15 && scr2 <= 15 && (scr1 == 15 || scr2 == 15)) {
			// Add a ball
			Instantiate (ballSc.ballPrefab, ballSc.pos, transform.localRotation);
			playerTr.localScale = initScaleBar;
			enemyTr.localScale = initScaleBar;
			GameInit.barSpeed += 1.5F;
		}
	}
}
