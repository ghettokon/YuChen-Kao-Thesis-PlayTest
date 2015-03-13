using UnityEngine;
using System.Collections;

public class doorOpen07_1 : MonoBehaviour {

	public GameObject door;
	public GameObject doorOpen;
	public GameObject outsideCol;
	
	void OnMouseUpAsButton(){
		door.GetComponent<SpriteRenderer>().enabled = false;
		door.GetComponent<BoxCollider2D>().enabled = false;

		doorOpen.GetComponent<SpriteRenderer>().enabled = true;
		doorOpen.GetComponent<BoxCollider2D>().enabled = true;
		outsideCol.GetComponent<BoxCollider2D>().enabled = true;
	}
}
