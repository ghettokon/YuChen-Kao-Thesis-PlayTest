using UnityEngine;
using System.Collections;

public class CheckSceneRange : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//DEFINE THE RANGE OF EACH SCENE
		//Scene05.1
		if(transform.position.x>-30.0f && transform.position.x<65.0f && transform.position.y>-11.0f && transform.position.y<19.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, -19.5f, 30.0f);
			pos.y = Mathf.Clamp (pos.y, -3.0f, 3.8f);
			transform.position = pos;
			
		}
		
		//Scene12.3
		if(transform.position.x>94.0f && transform.position.x<183.0f && transform.position.y>-11.0f && transform.position.y<19.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, 120.0f, 170.0f);
			pos.y = Mathf.Clamp (pos.y, -6.0f, 6.0f);
			transform.position = pos;
		}
		
		//Scene01
		if(transform.position.x>-160.0f && transform.position.x<-80.0f && transform.position.y>-11.0f && transform.position.y<19.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, -145.0f, -95.0f);
			pos.y = Mathf.Clamp (pos.y, -6.0f, 6.0f);
			transform.position = pos;
		}
	
	}
}
