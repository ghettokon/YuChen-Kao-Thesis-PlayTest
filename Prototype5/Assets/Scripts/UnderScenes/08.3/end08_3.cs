using UnityEngine;
using System.Collections;

public class end08_3 : MonoBehaviour {

	public GameObject text;
	public GameObject EndText;
	
	public bool turnOff = true;
	
	void OnMouseUpAsButton(){
		turnOff = !turnOff;
		if (turnOff) {
			text.GetComponent<MeshRenderer>().enabled = false;
			text.GetComponent<BoxCollider2D>().enabled = false;
			EndText.GetComponent<MeshRenderer>().enabled = false;
			EndText.GetComponent<BoxCollider2D>().enabled = false;
			
		} else {
			text.GetComponent<MeshRenderer>().enabled = true;
			text.GetComponent<BoxCollider2D>().enabled = true;
			EndText.GetComponent<MeshRenderer>().enabled = true;
			EndText.GetComponent<BoxCollider2D>().enabled = true;
		}
	}
}
