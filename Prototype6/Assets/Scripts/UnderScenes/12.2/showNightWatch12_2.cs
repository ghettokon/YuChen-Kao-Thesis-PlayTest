using UnityEngine;
using System.Collections;

public class showNightWatch12_2 : MonoBehaviour {

	public GameObject nightWatch;
	
	public bool turnOff = true;
	
	private float alpha = 0;
	
	private void Start(){
		//nightWatch.GetComponent<SpriteRenderer>().enabled = true;
	}
	
	void OnMouseUpAsButton(){
		turnOff = !turnOff;
		
		if (!turnOff) {
			alpha = 0;
			nightWatch.GetComponent<SpriteRenderer>().enabled = true;
			nightWatch.GetComponent<BoxCollider2D> ().enabled = true;
		}
		
		if (turnOff) {
			nightWatch.GetComponent<BoxCollider2D> ().enabled = false;
		}
		
	}
	
	void Update(){
		//Debug.Log (text.GetComponent<TextMesh>().color.a);
		nightWatch.GetComponent<SpriteRenderer>().color = new Color (1,1,1,alpha);
		
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
