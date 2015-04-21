using UnityEngine;
using System.Collections;

public class showDayWatch12_2 : MonoBehaviour {

	public GameObject dayWatch;

	public bool turnOff = true;

	private float alpha = 0;

	private void Start(){
		//dayWatch.GetComponent<SpriteRenderer>().enabled = true;
	}

	void OnMouseUpAsButton(){
		turnOff = !turnOff;

		if (!turnOff) {
			alpha = 0;
			dayWatch.GetComponent<SpriteRenderer>().enabled = true;
			dayWatch.GetComponent<BoxCollider2D> ().enabled = true;
		}
		
		if (turnOff) {
			dayWatch.GetComponent<BoxCollider2D> ().enabled = false;
		}

	}

	void Update(){
		//Debug.Log (text.GetComponent<TextMesh>().color.a);
		dayWatch.GetComponent<SpriteRenderer>().color = new Color (1,1,1,alpha);
		
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
