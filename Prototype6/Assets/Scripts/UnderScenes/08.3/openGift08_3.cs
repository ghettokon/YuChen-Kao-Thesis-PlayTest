using UnityEngine;
using System.Collections;

public class openGift08_3 : MonoBehaviour {

	public GameObject gift1;
	public GameObject gift2;
	public GameObject openSound;

	// Use this for initialization
	void Start () {
	
	}
	
	void OnMouseUpAsButton(){
		openSound.audio.Play ();
		gift1.GetComponent<SpriteRenderer>().enabled = false;
		gift1.GetComponent<BoxCollider2D>().enabled = false;
		gift2.GetComponent<SpriteRenderer>().enabled = true;
		gift2.GetComponent<BoxCollider2D>().enabled = true;
	}
}
