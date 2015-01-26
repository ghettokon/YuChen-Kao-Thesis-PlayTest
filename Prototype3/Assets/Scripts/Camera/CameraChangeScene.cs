using UnityEngine;
using System.Collections;

//link to CameraChangeScene

public class CameraChangeScene : MonoBehaviour {

	//private Vector3 currentLoc;

	public GameObject currentScene;

	//link to SceneControl
	private sceneControl sceneScript;

	//Camera z position
	public float zPos = 6f;


	void Start(){
		sceneScript = currentScene.GetComponent<sceneControl>();
		//currentLoc = new Vector3(sceneScript.center.position.x, sceneScript.center.position.y, zPos);
	}

	void Update(){
		//CLICKED AND CHANGE TO THE OTHER SCENE
		//TODO:Might need to add the fade-in fade-out between each scene. HOW TO DO IT!!!OH NO!!!
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




}
