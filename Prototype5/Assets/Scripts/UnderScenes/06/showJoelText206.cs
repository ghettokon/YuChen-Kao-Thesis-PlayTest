using UnityEngine;
using System.Collections;

public class showJoelText206 : MonoBehaviour {
	
	public GameObject MaryText1;
	public GameObject MaryText2;
	public GameObject JoelText2;
	public GameObject textBg1;
	public GameObject textBg2;
	
	void OnMouseUpAsButton(){
		MaryText1.GetComponent<MeshRenderer>().enabled = false;
		MaryText1.GetComponent<BoxCollider2D>().enabled = false;
		MaryText2.GetComponent<MeshRenderer>().enabled = false;
		MaryText2.GetComponent<BoxCollider2D>().enabled = false;
		JoelText2.GetComponent<MeshRenderer>().enabled = true;
		JoelText2.GetComponent<BoxCollider2D>().enabled = true;
		textBg1.GetComponent<SpriteRenderer>().enabled = false;
		textBg2.GetComponent<SpriteRenderer>().enabled = true;
	}
}
