using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	private LevelManager levelManager;
	public static int lives = 2;
	public GameObject explosion;
	private Ball ball;
	private Lives life;
	

	void Start(){
		life = GameObject.FindObjectOfType<Lives>();
		ball = GameObject.FindObjectOfType<Ball>();
	}

	
	public void Reset(){
		lives = 2;
	}
	
	void OnCollisionEnter2D(Collision2D col){
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		
		
		if(col.gameObject.name == "ballfish"){	
			ball.hasStarted = false;
			lives--;
			life.LoseLives(lives);

			Instantiate(Resources.Load("explosion"), ball.transform.position, Quaternion.identity);
			

			if(lives <=-1){		
				Invoke("Loser", 2f);
				Destroy(ball.gameObject);
			}
		}
	}
	
	void Loser(){
		levelManager.LoadLevel("LoseScreen");
	}
	
	public void AddLives(){
		lives += 1;
	}
	
	
}
