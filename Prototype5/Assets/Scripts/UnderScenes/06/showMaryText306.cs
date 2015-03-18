using UnityEngine;
using System.Collections;

public class showMaryText306 : MonoBehaviour {

	public GameObject MaryText3;
	public GameObject MaryText4;
	public GameObject JoelText2;
	
	void OnMouseUpAsButton(){
		MaryText3.GetComponent<MeshRenderer>().enabled = true;
		MaryText3.GetComponent<BoxCollider2D>().enabled = true;
		MaryText4.GetComponent<MeshRenderer>().enabled = true;
		MaryText4.GetComponent<BoxCollider2D>().enabled = true;
		JoelText2.GetComponent<MeshRenderer>().enabled = false;
		JoelText2.GetComponent<BoxCollider2D>().enabled = false;
	}
}
