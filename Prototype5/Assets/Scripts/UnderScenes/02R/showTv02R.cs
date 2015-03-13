using UnityEngine;
using System.Collections;

public class showTv02R : MonoBehaviour {

	public GameObject message;

	void Update () {
		if (!GameObject.Find ("02R-switchOn").GetComponent<switchLight02R> ().turnOn) {
			if (!GameObject.Find ("02R-DN-collider").GetComponent<switchDN02R> ().IsDay) {
				if(GameObject.Find ("02R-tvSwitchL").GetComponent<switchTV02R> ().open){
					message.GetComponent<SpriteRenderer> ().enabled = true;
				}
			}
		}
		else {
			message.GetComponent<SpriteRenderer> ().enabled = false;
		}
	}

}
