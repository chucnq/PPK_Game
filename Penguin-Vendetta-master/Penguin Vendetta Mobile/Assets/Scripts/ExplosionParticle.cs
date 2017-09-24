using UnityEngine;
using System.Collections;

public class ExplosionParticle : MonoBehaviour {


	// Use this for initialization
	void Start () {
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
		//destroy the explosion after 3 seconds
		Destroy(gameObject, 1.7f);
	}
	
}
