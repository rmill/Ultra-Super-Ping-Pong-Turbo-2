using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	private int score;
	public Racket racket;
	public Text scoreText;

	// Use this for initialization
	void Start () {
		renderScore();
	}

	void renderScore () {
		scoreText.text = score.ToString();
	}

	public void scored () {
		score++;
		renderScore();
	}
}
