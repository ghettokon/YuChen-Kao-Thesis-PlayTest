using UnityEngine;
using System.Collections;

public class showGhost02L : MonoBehaviour {

	public GameObject mirror;
	public Sprite mirror1;
	public Sprite mirror2;
	public GameObject ghostCollider;

	void Update () {
		if (!GameObject.Find ("02L-switchOnL").GetComponent<switcherL02L> ().turnOn) {
			if (!GameObject.Find ("02L-DN-collider").GetComponent<switchDN02L> ().IsDay) {
				if(!GameObject.Find ("02L-switchOnR").GetComponent<switcherR02L> ().turnOn){
					mirror.GetComponent<SpriteRenderer> ().sprite = mirror2;
					mirror.GetComponent<BoxCollider2D>().enabled = true;
				}
			}
		}
		else {
			mirror.GetComponent<SpriteRenderer> ().sprite = mirror1;
			mirror.GetComponent<BoxCollider2D>().enabled = false;
		}
	}
}
