using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	private AdsManager adsManager;
	
	void Start(){
		adsManager = GameObject.FindObjectOfType<AdsManager>();
	}
	
	
	public void AdsLoadLevel(string name){
		adsManager.ShowAd();
		SceneManager.LoadScene(name);
	}
	
	public void LoadLevel(string name){
		
		Orca.orcaCount = 0;
		SceneManager.LoadScene(name);
	}
	
	
	public void AdsLoadNextLevel(){
		adsManager.ShowRewardedAd();
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	
	
	
	
	public void LoadNextLevel(){
		
		Orca.orcaCount = 0;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	
	public void OrcaDestroyed(){
		if(Orca.orcaCount <= 0){
			
			Invoke ("LoadNextLevel", 2.2f);
			
		}
	}
	
	
}
