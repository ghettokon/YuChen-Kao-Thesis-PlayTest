using UnityEngine;
using System.Collections;

public class MouseHoverSprite : MonoBehaviour {

	//what to showup when hover
	public GameObject show;

	void OnMouseEnter(){
		show.GetComponent<SpriteRenderer>().enabled = true;
	}
		
	void OnMouseExit(){
		show.GetComponent<SpriteRenderer> ().enabled = false;
	}

}
