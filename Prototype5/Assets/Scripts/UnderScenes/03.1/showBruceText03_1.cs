using UnityEngine;
using System.Collections;

public class showBruceText03_1 : MonoBehaviour {

	public GameObject text1;
	public GameObject textBg;
	
	public bool turnOff = true;
	
	private float alpha = 0;
	
	private void Start(){
		
	}
	
	
	void OnMouseUpAsButton(){
		turnOff = false;
		
		alpha = 0;
		text1.GetComponent<MeshRenderer>().enabled = true;
		text1.GetComponent<BoxCollider2D>().enabled = true;
		textBg.GetComponent<SpriteRenderer>().enabled = true;
	}
	
	
	void Update(){
		//Debug.Log (text.GetComponent<TextMesh>().color.a);
		text1.GetComponent<TextMesh>().color = new Color (1,1,1,alpha);
		textBg.GetComponent<SpriteRenderer>().color = new Color (1,1,1,alpha);
		
		if (turnOff == false) {
			if(alpha<1){
				alpha += 0.03f;
			}
		} 
	}

}
