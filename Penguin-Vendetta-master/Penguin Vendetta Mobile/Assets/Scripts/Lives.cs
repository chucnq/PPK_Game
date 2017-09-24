using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Lives : MonoBehaviour {

	
	private Text myText;	
	
	
	// Use this for initialization
	void Start () {
		myText = GetComponent<Text>();
		UpdateLives();
		
		if(LoseCollider.lives == -1){
			myText.text = "Dead";
		}
		else{
			UpdateLives();
		}
		
	}
	
	void Update(){
		UpdateLives();
	}
	
	public void LoseLives(int lifeLeft){
		if(lifeLeft == -1){
			Destroy(gameObject);
		}else{
			myText.text = lifeLeft.ToString();
		}
	}
	
	public void UpdateLives(){
		myText.text = LoseCollider.lives.ToString();
	}
	
}
