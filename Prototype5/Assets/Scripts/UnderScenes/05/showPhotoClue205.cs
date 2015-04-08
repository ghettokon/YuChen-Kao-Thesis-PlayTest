using UnityEngine;
using System.Collections;

public class showPhotoClue205 : MonoBehaviour {

	public GameObject spriteObject;
	
	public bool turnOff = true;
	
	private float alpha = 0;
	
	private void Start(){
		spriteObject.GetComponent<SpriteRenderer>().enabled = true;
		
	}
	
	void OnMouseUpAsButton(){
		if(turnOff==true){
			turnOff=false;
		}
		
		if (!turnOff) {
			alpha = 0;
			spriteObject.GetComponent<SpriteRenderer>().enabled = true;
			spriteObject.GetComponent<BoxCollider2D> ().enabled = true;
		}
	}
	
	void Update(){
		//Debug.Log (text.GetComponent<TextMesh>().color.a);
		spriteObject.GetComponent<SpriteRenderer>().color = new Color (1,1,1,alpha);
		
		
		if (turnOff == false) {
			if(alpha<1){
				alpha += 0.03f;
			}
		} 
		
	}


}
