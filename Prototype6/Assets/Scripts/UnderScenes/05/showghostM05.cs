using UnityEngine;
using System.Collections;

public class showghostM05 : MonoBehaviour {

	public GameObject ghostM;
	public GameObject ghostMtext;

//	public bool turnOff = true;
//	
//	private float alpha = 0;
//	
//	private void Start(){
//		
//	}

	void Update () {

		if (!GameObject.Find ("05-switchR").GetComponent<SwitchR05> ().turnOn) {
			if (!GameObject.Find ("05-switchL").GetComponent<SwitchL05> ().turnOff) {
//				turnOff = false;
//				alpha = 0;
				ghostM.GetComponent<SpriteRenderer> ().enabled = true;
				ghostM.GetComponent<BoxCollider2D> ().enabled = true;

			}
		} 
		else {
			//turnOff = true;
			ghostM.GetComponent<SpriteRenderer> ().enabled = false;
			ghostM.GetComponent<BoxCollider2D> ().enabled = false;
			ghostMtext.GetComponent<MeshRenderer>().enabled = false;
			ghostMtext.GetComponent<BoxCollider2D> ().enabled = false;
		}

//		ghostM.GetComponent<SpriteRenderer>().color = new Color (1,1,1,alpha);
//		
//		if (turnOff == false) {
//			if(alpha<1){
//				alpha += 0.03f;
//			}
//		}
//		else if (turnOff == true) {
//			if (alpha >= 0){
//				alpha -= 0.03f;
//			}
//		}
	}

}
