using UnityEngine;
using System.Collections;

public class showRalph08_3 : MonoBehaviour {

	public GameObject ghostRalph;
	public GameObject RDark;
	public GameObject RText;
	public GameObject EndText;
	
	public bool turnOff = true;
	
	private float alpha = 0;
	
	private void Start(){
		
	}
	
	void OnMouseUpAsButton(){
		turnOff = !turnOff;

		if (!turnOff) {
			ghostRalph.GetComponent<SpriteRenderer>().enabled = true;
			ghostRalph.GetComponent<BoxCollider2D>().enabled = true;
			RDark.GetComponent<SpriteRenderer>().enabled = true;
		} else {
			//ghostRalph.GetComponent<SpriteRenderer>().enabled = false;
			ghostRalph.GetComponent<BoxCollider2D>().enabled = false;
			//RDark.GetComponent<SpriteRenderer>().enabled = false;
			RText.GetComponent<MeshRenderer>().enabled = false;
			RText.GetComponent<BoxCollider2D>().enabled = false;
			EndText.GetComponent<MeshRenderer>().enabled = false;
			EndText.GetComponent<BoxCollider2D>().enabled = false;
		}
	}

	void Update(){
		//Debug.Log (text.GetComponent<TextMesh>().color.a);
		ghostRalph.GetComponent<SpriteRenderer> ().color = new Color (1,1,1,alpha);
		RDark.GetComponent<SpriteRenderer> ().color = new Color (1,1,1,alpha);
		
		if (turnOff == false) {
			if(alpha<1){
				alpha += 0.03f;
			}
		} 
		else if (turnOff == true) {
			if (alpha >= 0){
				alpha -= 0.03f;
			}
		}
	}
}
