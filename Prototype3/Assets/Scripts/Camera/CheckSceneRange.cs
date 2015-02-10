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
		
		//Scene12.2
		if(transform.position.x>230.0f && transform.position.x<300.0f && transform.position.y>-11.0f && transform.position.y<19.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, 237.0f, 291.0f);
			pos.y = Mathf.Clamp (pos.y, -3.0f, 3.8f);
			transform.position = pos;
		}
		
		//Scene01
		if(transform.position.x>-340.0f && transform.position.x<-230.0f && transform.position.y>-11.0f && transform.position.y<19.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, -290.0f, -240.0f);
			pos.y = Mathf.Clamp (pos.y, -3.0f, 3.8f);
			transform.position = pos;;
		}
	
	}
}
