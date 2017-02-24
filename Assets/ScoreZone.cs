using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreZone : MonoBehaviour {
	public Player player;
	
	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.name == "Ball") {
			player.scored();
			col.gameObject.GetComponent<Ball>().reset();
		}
	}
}
