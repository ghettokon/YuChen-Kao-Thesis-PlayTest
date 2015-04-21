using UnityEngine;
using System.Collections;

public class showMaryText201 : MonoBehaviour {

	public GameObject BruceText1;
	public GameObject MaryText2;
	public GameObject textBgBruce;
	public GameObject textBG;

	public bool turnOff = true;
	
	private float alpha = 0;

	private void Start(){
		MaryText2.GetComponent<MeshRenderer>().enabled = true;
		textBG.GetComponent<SpriteRenderer>().enabled = true;
	}
	
	
	void OnMouseUpAsButton(){
		if(turnOff==true){
			turnOff=false;
		}


		alpha = 0;
		
		MaryText2.GetComponent<MeshRenderer>().enabled = true;
		MaryText2.GetComponent<BoxCollider2D> ().enabled = true;
		textBG.GetComponent<SpriteRenderer>().enabled = true;

		BruceText1.GetComponent<MeshRenderer>().enabled = false;
		BruceText1.GetComponent<BoxCollider2D> ().enabled = false;
		textBgBruce.GetComponent<SpriteRenderer>().enabled = false;
	}

	void Update(){
		MaryText2.GetComponent<TextMesh>().color = new Color (1,1,1,alpha);
		textBG.GetComponent<SpriteRenderer>().color = new Color (1,1,1,alpha);
		
		if (turnOff == false) {
			if(alpha<1){
				alpha += 0.03f;
			}
		} 
	}
}
