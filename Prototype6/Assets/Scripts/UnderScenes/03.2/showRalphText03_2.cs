using UnityEngine;
using System.Collections;

public class showRalphText03_2 : MonoBehaviour {

	public GameObject text1;
	public GameObject text2;
	public GameObject textBG1;
	public GameObject textBG2;

	public bool turnOff = true;
	
	private float alpha = 0;
	
	
	private void Start(){

	}
	
	void OnMouseUpAsButton(){
		
		turnOff = false;

		alpha = 0;
		text2.GetComponent<MeshRenderer>().enabled = true;
		text2.GetComponent<BoxCollider2D>().enabled = true;
		textBG2.GetComponent<SpriteRenderer>().enabled = true;

		text1.GetComponent<MeshRenderer>().enabled = false;
		text1.GetComponent<BoxCollider2D>().enabled = false;
		textBG1.GetComponent<SpriteRenderer>().enabled = false;
	}
	
	void Update(){
		//Debug.Log (text.GetComponent<TextMesh>().color.a);
		text2.GetComponent<TextMesh>().color = new Color (1,1,1,alpha);
		textBG2.GetComponent<SpriteRenderer>().color = new Color (1,1,1,alpha);
		
		if (turnOff == false) {
			if(alpha<1){
				alpha += 0.03f;
			}
		}
	}
}
