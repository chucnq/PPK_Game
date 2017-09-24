using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	
	private Paddle paddle;
	public bool hasStarted = false;
	private Vector3 paddleToBallVector;
	// Use this for initialization
	void Start () {
	
		paddle = GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		BallStart();
	}
	
	
	
	public void BallStart(){
		if(!hasStarted){
			//lock the ball to the paddle
			this.transform.position = paddle.transform.position + paddleToBallVector;
			
			//wait for a mouse press to launch
			if(Input.GetMouseButtonDown(0)){
				hasStarted = true;
				this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
			}
		}
		this.GetComponent<Rigidbody2D>().velocity = this.GetComponent<Rigidbody2D>().velocity.normalized * 9f;
	}
	
	public IEnumerator BallReturn(){
		yield return new WaitForSeconds(5f);
		BallStart();
	}
	
	
	void OnCollisionEnter2D(Collision2D col){
		if(hasStarted){
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
		}
	}
}
