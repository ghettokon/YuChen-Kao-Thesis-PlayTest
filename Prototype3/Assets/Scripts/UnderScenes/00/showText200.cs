using UnityEngine;
using System.Collections;

public class showText200 : MonoBehaviour {

	public GameObject text;
	public GameObject showSound;
	public GameObject particle;
	public GameObject ghost;
	
	
	void OnMouseUpAsButton(){
		showSound.audio.Play();
		particle.renderer.sortingLayerName = "hint";
		text.GetComponent<MeshRenderer>().enabled = true;
		text.GetComponent<BoxCollider2D> ().enabled = true;
		ghost.GetComponent<BoxCollider2D> ().enabled = false;
	}
}
