using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour {

	public float delayTime = 2.2f;
	
	IEnumerator Start(){
		yield return new WaitForSeconds(delayTime);
		SceneManager.LoadScene("StartScreen");
	}
}
