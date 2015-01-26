using UnityEngine;
using System.Collections;

public class showghostB05_1 : MonoBehaviour {


	public GameObject ghost;
	public bool NotShowing = true;

	void Update () {
		NotShowing = !NotShowing;
		if(!NotShowing){
			if (!GameObject.Find ("05.1-switchL").GetComponent<SwitchL05_1> ().turnOff) {
				ghost.GetComponent<SpriteRenderer> ().enabled = true;
				ghost.GetComponent<BoxCollider2D> ().enabled = true;
				//Debug.Log ("showingGhost");
			}
		}
		else {
			ghost.GetComponent<SpriteRenderer> ().enabled = false;
			ghost.GetComponent<BoxCollider2D> ().enabled = false;
			//Debug.Log("notShowingGhost");
		}
	}



}
