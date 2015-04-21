using UnityEngine;
using System.Collections;

public class showghost01 : MonoBehaviour {

	public GameObject ghostB;
	public GameObject text1;
	public GameObject text2;
	public GameObject textBg;
	//public GameObject ghostSound;
		
		
	void Update () {
		if (!GameObject.Find ("01-switchOn").GetComponent<switcher01> ().turnOn) {
			if (!GameObject.Find ("01-DN-collider").GetComponent<switchDN01> ().IsDay) {
				//ghostSound.audio.Play();
				ghostB.GetComponent<SpriteRenderer> ().enabled = true;
				ghostB.GetComponent<BoxCollider2D> ().enabled = true;
			}
		} 
		else {
			//ghostSound.audio.Stop();
			ghostB.GetComponent<SpriteRenderer> ().enabled = false;
			ghostB.GetComponent<BoxCollider2D> ().enabled = false;
			text1.GetComponent<MeshRenderer>().enabled = false;
			text2.GetComponent<MeshRenderer>().enabled = false;
			text2.GetComponent<BoxCollider2D> ().enabled = false;
			textBg.GetComponent<SpriteRenderer> ().enabled = false;
		}
	}
}
