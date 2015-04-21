using UnityEngine;
using System.Collections;

public class showGhost11 : MonoBehaviour {

	public GameObject Mary;
	public GameObject dark;
	public GameObject text1;
	public GameObject text2;
	public GameObject textbg;
	
	public bool turnOff = true;
	
	private float alpha = 0;
	
	private void Start(){
		
	}
	
	void OnMouseUpAsButton(){
		turnOff = !turnOff;
		
		if (!turnOff) {
			alpha = 0;
			Mary.GetComponent<SpriteRenderer>().enabled = true;
			Mary.GetComponent<BoxCollider2D>().enabled = true;
			dark.GetComponent<SpriteRenderer>().enabled = true;
			GameObject.Find ("11-MaryG").GetComponent<showPortal11> ().turnOff = true;
		} else {
			//Mary.GetComponent<SpriteRenderer>().enabled = false;
			Mary.GetComponent<BoxCollider2D>().enabled = false;
			//dark.GetComponent<SpriteRenderer>().enabled = false;
			text1.GetComponent<MeshRenderer>().enabled = false;
			text2.GetComponent<MeshRenderer>().enabled = false;
			text1.GetComponent<BoxCollider2D>().enabled = false;
			text2.GetComponent<BoxCollider2D>().enabled = false;
			textbg.GetComponent<SpriteRenderer>().enabled = false;
		}
	}

	void Update(){
		//Debug.Log (text.GetComponent<TextMesh>().color.a);
		Mary.GetComponent<SpriteRenderer> ().color = new Color (1,1,1,alpha);
		dark.GetComponent<SpriteRenderer> ().color = new Color (1,1,1,alpha);
		
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
