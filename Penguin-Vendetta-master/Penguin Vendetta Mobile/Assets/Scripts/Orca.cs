using UnityEngine;
using System.Collections;

public class Orca : MonoBehaviour {


	public static int orcaCount = 0;
	private LevelManager levelManager;
	private bool isOrca;
	
	public GameObject explosion;

	public int scoreValue;
	private Score score;

	// Use this for initialization
	void Start () {
		
		score = GameObject.FindObjectOfType<Score>();
		
		isOrca = (this.tag == "Orca");
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		
		if(isOrca){
			orcaCount++;	
		}
	}
	
	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.name == "LoseCollider"){

			
			orcaCount--;
			levelManager.OrcaDestroyed();
			
			score.ScorePoints(scoreValue);
			
			Instantiate(explosion, transform.position, Quaternion.identity);
			Destroy(gameObject);
			
			
			
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
