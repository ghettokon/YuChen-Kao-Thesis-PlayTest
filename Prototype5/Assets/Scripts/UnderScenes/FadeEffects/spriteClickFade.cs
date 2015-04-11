using UnityEngine;
using System.Collections;

public class spriteClickFade : MonoBehaviour {

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
	}
	
	void Update(){
		//Debug.Log (text.GetComponent<TextMesh>().color.a);
		spriteObject.GetComponent<SpriteRenderer>().color = new Color (1,1,1,alpha);
		
		
		if (turnOff == false) {
			if(alpha<1){
				alpha += 0.03f;
			}
		} else {
			if (alpha >= 0){
				alpha -= 0.01f;
			}
		}
		
		if (alpha >= 1) {
			StartCoroutine("wait");
		}
	}
	
	private IEnumerator wait(){
		yield return new WaitForSeconds(1);
		turnOff = true;
	}

}
