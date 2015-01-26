using UnityEngine;
using System.Collections;

//link to CameraChangeScene

public class CameraGoToMouse : MonoBehaviour {


	private Vector3 currentLoc;

	public GameObject currentScene;

	//link to SceneControl
	private sceneControl sceneScript;

	//Camera moving speed
	public float speed = 20f;

	//Camera z position
	public float zPos = 6f;




	void Start(){
		sceneScript = currentScene.GetComponent<sceneControl>();
		currentLoc = new Vector3(sceneScript.center.position.x, sceneScript.center.position.y, zPos);
	}

	void Update(){
		//MOVE TO THE CLICKED POINT
		if(Input.GetMouseButtonDown (0)){

			if(sceneScript.accessableObjects.Length>0 ){
				for(int i=0; i<sceneScript.accessableObjects.Length; i++){
					CameraChangeScene localScript = sceneScript.accessableObjects[i].GetComponent<CameraChangeScene>();
					if(localScript.closeup && !localScript.oldcloseup){
						localScript.oldcloseup = true;
						sceneControl sceneInfo = sceneScript.accessableScenes[i].GetComponent<sceneControl>();
						transform.position = new Vector3(sceneInfo.center.position.x, sceneInfo.center.position.y, zPos);

						//update target
						currentScene = sceneScript.accessableScenes[i];
						sceneScript = currentScene.GetComponent<sceneControl>();
						break;
					}
				}
			}
			//Debug.Log ("PRESSED");
			currentLoc = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, zPos));
			currentLoc.z = transform.position.z;
		}
		transform.position = Vector3.MoveTowards(transform.position, currentLoc, speed * Time.deltaTime);

		//DEFINE THE RANGE OF EACH SCENE
		//Start Scene
		if(transform.position.x>-30.0f && transform.position.x<65.0f && transform.position.y>-11.0f && transform.position.y<19.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, -19.5f, 40.0f);
			pos.y = Mathf.Clamp (pos.y, -6.0f, 6.0f);
			transform.position = pos;

		}

		//Scene2
		if(transform.position.x>94.0f && transform.position.x<183.0f && transform.position.y>-11.0f && transform.position.y<19.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, 120.0f, 170.0f);
			pos.y = Mathf.Clamp (pos.y, -6.0f, 6.0f);
			transform.position = pos;
		}

		//Scene3
		if(transform.position.x>-160.0f && transform.position.x<-80.0f && transform.position.y>-11.0f && transform.position.y<19.0f){
			Vector3 pos = transform.position;
			pos.x = Mathf.Clamp (pos.x, -145.0f, -95.0f);
			pos.y = Mathf.Clamp (pos.y, -6.0f, 6.0f);
			transform.position = pos;
		}





	}
}
