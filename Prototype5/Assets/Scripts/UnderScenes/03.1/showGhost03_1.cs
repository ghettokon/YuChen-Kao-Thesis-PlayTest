using UnityEngine;
using System.Collections;

public class showGhost03_1 : MonoBehaviour {

	public GameObject bruce;
	public GameObject bruceText;
	public GameObject Ghost;
	public GameObject filterDark;
	public GameObject textBgBruce;

	void OnMouseUpAsButton(){
		bruce.GetComponent<BoxCollider2D>().enabled = false;
		bruceText.GetComponent<MeshRenderer>().enabled = false;
		bruceText.GetComponent<BoxCollider2D>().enabled = false;
		Ghost.GetComponent<SpriteRenderer>().enabled = true;
		Ghost.GetComponent<BoxCollider2D>().enabled = true;
		filterDark.GetComponent<SpriteRenderer>().enabled = true;
		textBgBruce.GetComponent<SpriteRenderer>().enabled = false;
	}
}
