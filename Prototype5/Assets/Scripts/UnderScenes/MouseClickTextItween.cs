using UnityEngine;
using System.Collections;

public class MouseClickTextItween : MonoBehaviour {

	public GameObject text;
	
	public bool turnOff = true;

	private float alpha=0;


//	void OnMouseUpAsButton(){
//		turnOff = !turnOff;
//		if (turnOff) {
//			text.GetComponent<MeshRenderer>().enabled = false;
//		} else {
//			//iTween.FadeFrom (gameObject, iTween.Hash ("alpha", 255, "time", 1f)); 
//
//			text.GetComponent<MeshRenderer>().enabled = true;
//		}
//	}

	private void Start(){
		text.GetComponent<MeshRenderer>().enabled = true;

	}


	void OnMouseUpAsButton(){
		if(turnOff==true){
			turnOff=false;
		}
	}

	void Update(){
		//Debug.Log (text.GetComponent<TextMesh>().color.a);
		text.GetComponent<TextMesh>().color = new Color (1,1,1,alpha);


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
		yield return new WaitForSeconds(2);
		turnOff = true;
	}
}
