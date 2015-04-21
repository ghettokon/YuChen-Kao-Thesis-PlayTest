using UnityEngine;
using System.Collections;

public class showBruceText07_1 : MonoBehaviour {

	public GameObject text1;
	public GameObject text2;
	public GameObject textBg;

	public bool turnOff = true;
	
	private float alpha = 0;

	private void Start(){

	}

	
	void OnMouseUpAsButton(){
		turnOff = false;

		alpha = 0;
		text2.GetComponent<MeshRenderer>().enabled = true;
		GameObject.Find ("07.1-Zoe").GetComponent<showZoeText07_1> ().turnOff = true;
		GameObject.Find ("07.3-Zoe").GetComponent<showZoeText07_3> ().turnOff = true;

		text1.GetComponent<MeshRenderer>().enabled = false;
		text1.GetComponent<BoxCollider2D>().enabled = false;
		textBg.GetComponent<SpriteRenderer>().enabled = false;
	}

	
	void Update(){
		//Debug.Log (text.GetComponent<TextMesh>().color.a);
		text2.GetComponent<TextMesh>().color = new Color (1,1,1,alpha);
		
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
		yield return new WaitForSeconds(3);
		turnOff = true;
	}
}
