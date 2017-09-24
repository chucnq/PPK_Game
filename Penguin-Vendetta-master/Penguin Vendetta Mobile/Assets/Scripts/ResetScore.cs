using UnityEngine;
using System.Collections;

public class ResetScore : MonoBehaviour {

	private Score score;

	// Use this for initialization
	void Start () {
		score = GameObject.FindObjectOfType<Score>();
		
	}
	
	void Update(){
		score.ResetScore();
	}
	
}
