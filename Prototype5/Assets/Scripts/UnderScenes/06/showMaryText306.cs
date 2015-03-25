using UnityEngine;
using System.Collections;

public class showMaryText306 : MonoBehaviour {

	public GameObject MaryText3;
	public GameObject MaryText4;
	public GameObject JoelText2;
	public GameObject textBg1;
	public GameObject textBg2;
	
	void OnMouseUpAsButton(){
		MaryText3.GetComponent<MeshRenderer>().enabled = true;
		MaryText3.GetComponent<BoxCollider2D>().enabled = true;
		MaryText4.GetComponent<MeshRenderer>().enabled = true;
		MaryText4.GetComponent<BoxCollider2D>().enabled = true;
		JoelText2.GetComponent<MeshRenderer>().enabled = false;
		JoelText2.GetComponent<BoxCollider2D>().enabled = false;
		textBg1.GetComponent<SpriteRenderer>().enabled = false;
		textBg2.GetComponent<SpriteRenderer>().enabled = true;
	}
}
