﻿using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public bool autoPlay = false;
	private Ball ball;
	
	void Start(){
		ball = GameObject.FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	//void Update () {
	//	if(!autoPlay){
	//		MoveWithMouse();
	//	}else{
	//		AutoPlay();
	//	}
	//}
	
	void AutoPlay(){
		Vector3 paddlePos = new Vector3(8f, this.transform.position.y, 0f);	
		Vector3 ballPos = ball.transform.position;
		paddlePos.x = Mathf.Clamp(ballPos.x, 0.75f, 15.3f);
		this.transform.position = paddlePos;
	}
	
	void OnMouseDrag(){
		Vector3 paddlePos = new Vector3(8f, this.transform.position.y, 0f);	
		float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
		paddlePos.x = Mathf.Clamp(mousePosInBlocks, 1.2f, 14.95f);
		this.transform.position = paddlePos;
	}
		
}
