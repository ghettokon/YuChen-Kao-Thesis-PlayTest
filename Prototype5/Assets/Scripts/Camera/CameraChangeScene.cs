using UnityEngine;
using System.Collections;

//link to CameraChangeScene

public class CameraChangeScene : MonoBehaviour {

	//private Vector3 currentLoc;

	public GameObject currentScene;

	//link to SceneControl
	private sceneControl sceneScript;

	//Camera z position
	public float zPos = 16f;


	void Start(){
		sceneScript = currentScene.GetComponent<sceneControl>();
		//currentLoc = new Vector3(sceneScript.center.position.x, sceneScript.center.position.y, zPos);
	}

	//no black transition between scenes--------------------------------------------------------------
	void Update(){
		//Reload
		if(Input.GetKey (KeyCode.R)){
			Application.LoadLevel(0);
		}

		//CLICKED AND CHANGE TO THE OTHER SCENE
		if(Input.GetMouseButtonDown (0)){
			if(sceneScript.accessableObjects.Length>0 ){
				for(int i=0; i<sceneScript.accessableObjects.Length; i++){
					CheckCloseUp localScript = sceneScript.accessableObjects[i].GetComponent<CheckCloseUp>();
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
		}
	}
	
	//with black transition between scenes------------------------------------------------------------
//	void Update(){
//		//CLICKED AND CHANGE TO THE OTHER SCENE
//		if(Input.GetMouseButtonDown (0)){
//			if(sceneScript.accessableObjects.Length>0 ){
//				for(int i=0; i<sceneScript.accessableObjects.Length; i++){
//					CheckCloseUp localScript = sceneScript.accessableObjects[i].GetComponent<CheckCloseUp>();
//					if(localScript.closeup && !localScript.oldcloseup){
//						localScript.oldcloseup = true;
//						StartCoroutine (ChangeScene ());
//						//sceneControl sceneInfo = sceneScript.accessableScenes[i].GetComponent<sceneControl>();
//						//transform.position = new Vector3(sceneInfo.center.position.x, sceneInfo.center.position.y, zPos);
//						
//						//update target
//						currentScene = sceneScript.accessableScenes[i];
//						sceneScript = currentScene.GetComponent<sceneControl>();
//						//break;
//					}
//				}
//			}
//		}
//	}
//	
//	IEnumerator ChangeScene(){
//		while (true) { 
//			if(sceneScript.accessableObjects.Length>0 ){
//				for(int i=0; i<sceneScript.accessableObjects.Length; i++){
//					sceneControl sceneInfo = sceneScript.accessableScenes[i].GetComponent<sceneControl>();
//					transform.position = new Vector3(-730f, -45f, zPos);
//					yield return new WaitForSeconds(0.5f);
//					transform.position = new Vector3(sceneInfo.center.position.x, sceneInfo.center.position.y, zPos);
//					yield break;
//				}
//			}
//		}
//	}






}
