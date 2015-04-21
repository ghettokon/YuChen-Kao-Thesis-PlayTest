using UnityEngine;
using System.Collections;

public class showBruceText01 : MonoBehaviour {

	public GameObject BruceText1;
	public GameObject MaryText1;
	public GameObject MaryCollider;
	public GameObject textBgMary1;
	public GameObject textBG;

	public bool turnOff = true;

	private float alpha = 0;

	private void Start(){
		BruceText1.GetComponent<MeshRenderer>().enabled = true;
		textBG.GetComponent<SpriteRenderer>().enabled = true;
	}

	
	void OnMouseUpAsButton(){
		if(turnOff==true){
			turnOff=false;
		}

		alpha = 0;
		BruceText1.GetComponent<MeshRenderer>().enabled = true;
		BruceText1.GetComponent<BoxCollider2D> ().enabled = true;
		textBG.GetComponent<SpriteRenderer>().enabled = true;

		MaryText1.GetComponent<MeshRenderer>().enabled = false;
		MaryText1.GetComponent<BoxCollider2D> ().enabled = false;
		MaryCollider.GetComponent<BoxCollider2D> ().enabled = false;
		textBgMary1.GetComponent<SpriteRenderer>().enabled = false;
	}

	void Update(){
		BruceText1.GetComponent<TextMesh>().color = new Color (1,1,1,alpha);
		textBG.GetComponent<SpriteRenderer>().color = new Color (1,1,1,alpha);

		if (turnOff == false) {
			if(alpha<1){
				alpha += 0.03f;
			}
		} 
	}
}
