 using UnityEngine;
using System.Collections;

public class Balloon : MonoBehaviour {

	public GameObject smoke;
	
	private LevelManager levelManager;
	public AudioClip pop;
	
	private int timesHit;
	public Sprite[] hitSprites;

	public int scoreValue;
	private Score score;
	
	
	// Use this for initialization
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		score = GameObject.FindObjectOfType<Score>();
		timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionExit2D(Collision2D col){
		bool isBreakable = (this.tag == "Breakable");
		if(isBreakable){
			if(col.gameObject.name == "ballfish" ){
				timesHit++;
				int maxHits = hitSprites.Length + 1;
				
				if(timesHit >= maxHits){
					AudioSource.PlayClipAtPoint(pop, transform.position, 0.85f);
					PuffSmoke();
					
					score.ScorePoints(scoreValue);
					
					Destroy (gameObject);
				}else{
					LoadSprites();
				}
			}
		}
	}
	
	void PuffSmoke(){
		GameObject smokePuff = Instantiate(smoke,transform.position, Quaternion.identity) as GameObject;
		smokePuff.GetComponent<ParticleSystem>().startColor = gameObject.GetComponent<SpriteRenderer>().color;
	}
	
	
	void LoadSprites(){
		int spriteIndex = timesHit - 1;
		
		if(hitSprites[spriteIndex]){
			this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		}
	}
	
	//TODO remove this method once we can actually win
	
	void SimulateWin(){
		levelManager.LoadNextLevel();
	}
}
