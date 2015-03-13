using UnityEngine;
using System.Collections;

public class CheckSceneRange : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//DEFINE THE RANGE OF EACH SCENE

		//Scene00
		if(transform.position.x>-770.0f && transform.position.x<-730.0f && transform.position.y>-4.0f && transform.position.y<9.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, -744f, -743.5f);
			pos.y = Mathf.Clamp (pos.y, 2f, 3f);
			transform.position = pos;;
		}

		//Scene05
//		if(transform.position.x>-30.0f && transform.position.x<65.0f && transform.position.y>-11.0f && transform.position.y<19.0f){
//			Vector3 pos = transform.position;
//			pos.x = Mathf.Clamp (pos.x, -19.5f, 30.0f);
//			pos.y = Mathf.Clamp (pos.y, -3.0f, 3.8f);
//			transform.position = pos;
//		}
		
		//Scene12.2
//		if(transform.position.x>230.0f && transform.position.x<300.0f && transform.position.y>-11.0f && transform.position.y<19.0f){
//			Vector3 pos = transform.position;
//			pos.x = Mathf.Clamp (pos.x, 237.0f, 291.0f);
//			pos.y = Mathf.Clamp (pos.y, -3.0f, 3.8f);
//			transform.position = pos;
//		}
		
		//Scene01
//		if(transform.position.x>-340.0f && transform.position.x<-230.0f && transform.position.y>-11.0f && transform.position.y<19.0f){
//			Vector3 pos = transform.position;
//			pos.x = Mathf.Clamp (pos.x, -290.0f, -250.0f);
//			pos.y = Mathf.Clamp (pos.y, -3.0f, 3.8f);
//			transform.position = pos;;
//		}

		//Scene02R
//		if(transform.position.x>775.0f && transform.position.x<900.0f && transform.position.y>-11.0f && transform.position.y<19.0f){
//			Vector3 pos = transform.position;
//			pos.x = Mathf.Clamp (pos.x, 810.0f, 850.0f);
//			pos.y = Mathf.Clamp (pos.y, -3.0f, 3.8f);
//			transform.position = pos;;
//		}

		//Scene02L
//		if(transform.position.x>570.0f && transform.position.x<720.0f && transform.position.y>-11.0f && transform.position.y<19.0f){
//			Vector3 pos = transform.position;
//			pos.x = Mathf.Clamp (pos.x, 610.0f, 668.0f);
//			pos.y = Mathf.Clamp (pos.y, -3.0f, 3.8f);
//			transform.position = pos;;
//		}

		//Scene09
//		if(transform.position.x>390.0f && transform.position.x<510.0f && transform.position.y>-11.0f && transform.position.y<19.0f){
//			Vector3 pos = transform.position;
//			pos.x = Mathf.Clamp (pos.x, 445.0f, 455.0f);
//			pos.y = Mathf.Clamp (pos.y, -2.0f, 1.5f);
//			transform.position = pos;;
//		}

		//Scene04
//		if(transform.position.x>800.0f && transform.position.x<900.0f && transform.position.y>-192.0f && transform.position.y<-160.0f){
//			Vector3 pos = transform.position;
//			pos.x = Mathf.Clamp (pos.x, 810.0f, 865.0f);
//			pos.y = Mathf.Clamp (pos.y, -180f, -170f);
//			transform.position = pos;;
//		}

		//Scene11
//		if(transform.position.x>610.0f && transform.position.x<670.0f && transform.position.y>-192.0f && transform.position.y<-160.0f){
//			Vector3 pos = transform.position;
//			pos.x = Mathf.Clamp (pos.x, 634.0f, 660.0f);
//			pos.y = Mathf.Clamp (pos.y, -180f, -170f);
//			transform.position = pos;;
//		}

		//Scene07.1
//		if(transform.position.x>-30.0f && transform.position.x<65.0f && transform.position.y>-192.0f && transform.position.y<-160.0f){
//			Vector3 pos = transform.position;
//			pos.x = Mathf.Clamp (pos.x, -19.0f, 30.0f);
//			pos.y = Mathf.Clamp (pos.y, -180f, -170f);
//			transform.position = pos;;
//		}

	
	}
}
