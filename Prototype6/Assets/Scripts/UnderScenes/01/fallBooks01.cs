using UnityEngine;
using System.Collections;

public class fallBooks01 : MonoBehaviour {

	public GameObject Book1;
	public GameObject Book2;
	public GameObject noteCollider;
	public GameObject fallSound;
	
	void OnMouseUpAsButton(){
		fallSound.audio.Play();
		Book1.GetComponent<SpriteRenderer>().enabled = false;
		Book1.GetComponent<BoxCollider2D> ().enabled = false;
		Book2.GetComponent<SpriteRenderer>().enabled = true;
		noteCollider.GetComponent<BoxCollider2D> ().enabled = true;
	}
}
