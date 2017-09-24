using UnityEngine;
using System.Collections;

public class StartLives : MonoBehaviour {

	public LoseCollider loseCollider;
	// Use this for initialization
	void Start () {
		loseCollider = GameObject.FindObjectOfType<LoseCollider>();
		loseCollider.Reset();
	}
	
	
}
