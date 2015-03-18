using UnityEngine;
using System.Collections;

public class showJoelText206 : MonoBehaviour {
	
	public GameObject MaryText1;
	public GameObject MaryText2;
	public GameObject JoelText2;
	
	void OnMouseUpAsButton(){
		MaryText1.GetComponent<MeshRenderer>().enabled = false;
		MaryText1.GetComponent<BoxCollider2D>().enabled = false;
		MaryText2.GetComponent<MeshRenderer>().enabled = false;
		MaryText2.GetComponent<BoxCollider2D>().enabled = false;
		JoelText2.GetComponent<MeshRenderer>().enabled = true;
		JoelText2.GetComponent<BoxCollider2D>().enabled = true;
	}
}
