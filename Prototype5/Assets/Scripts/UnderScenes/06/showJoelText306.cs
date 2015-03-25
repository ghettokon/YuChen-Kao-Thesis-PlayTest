using UnityEngine;
using System.Collections;

public class showJoelText306 : MonoBehaviour {

	public GameObject MaryText3;
	public GameObject MaryText4;
	public GameObject JoelText3;
	public GameObject textBg1;
	public GameObject textBg2;
	
	void OnMouseUpAsButton(){
		MaryText3.GetComponent<MeshRenderer>().enabled = false;
		MaryText3.GetComponent<BoxCollider2D>().enabled = false;
		MaryText4.GetComponent<MeshRenderer>().enabled = false;
		MaryText4.GetComponent<BoxCollider2D>().enabled = false;
		JoelText3.GetComponent<MeshRenderer>().enabled = true;
		JoelText3.GetComponent<BoxCollider2D>().enabled = true;
		textBg1.GetComponent<SpriteRenderer>().enabled = false;
		textBg2.GetComponent<SpriteRenderer>().enabled = true;
	}
}
