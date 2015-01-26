using UnityEngine;
using System.Collections;

public class showghostM05_1 : MonoBehaviour {

	public GameObject ghostM;
	public bool NotShowing = true;

	void Update () {
		NotShowing = !NotShowing;
		if(!NotShowing){
			if (!GameObject.Find ("05.1-switchR").GetComponent<SwitchR05_1> ().turnOn) {
				if (!GameObject.Find ("05.1-switchL").GetComponent<SwitchL05_1> ().turnOff) {
					ghostM.GetComponent<SpriteRenderer> ().enabled = true;
					ghostM.GetComponent<BoxCollider2D> ().enabled = true;
					//Debug.Log ("showingGhost");
				}
			} 
		}
		else {
			ghostM.GetComponent<SpriteRenderer> ().enabled = false;
			ghostM.GetComponent<BoxCollider2D> ().enabled = false;
			//Debug.Log("notShowingGhost");
		}
	}
}
