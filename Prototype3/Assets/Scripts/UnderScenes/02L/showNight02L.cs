using UnityEngine;
using System.Collections;

public class showNight02L : MonoBehaviour {

	public GameObject night;
	
	void Update () {
		if (!GameObject.Find ("02L-switchOnL").GetComponent<switcherL02L> ().turnOn) {
			if (!GameObject.Find ("02L-DN-collider").GetComponent<switchDN02L> ().IsDay) {
				night.GetComponent<SpriteRenderer> ().enabled = true;
			}
		}
		else {
			night.GetComponent<SpriteRenderer> ().enabled = false;
		}
	}
}
