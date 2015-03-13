using UnityEngine;
using System.Collections;

public class showText00 : MonoBehaviour {

	public GameObject text;
	public GameObject closeText;
	public GameObject showSound;
	public GameObject particle;
	
	
	void OnMouseUpAsButton(){
		showSound.audio.Play();
		particle.renderer.sortingLayerName = "hint";
		text.GetComponent<MeshRenderer>().enabled = true;
		text.GetComponent<BoxCollider2D> ().enabled = true;
		closeText.GetComponent<MeshRenderer>().enabled = false;
		closeText.GetComponent<BoxCollider2D> ().enabled = false;
	}
}
