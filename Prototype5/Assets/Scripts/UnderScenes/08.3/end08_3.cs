using UnityEngine;
using System.Collections;

public class end08_3 : MonoBehaviour {

	public GameObject text;
	public GameObject EndText;
	
	public bool turnOff = true;

	private float alpha = 0;

	private void Start(){
		
	}
	
	void OnMouseUpAsButton(){
		turnOff = !turnOff;

		if (!turnOff) {
			alpha = 0;
			text.GetComponent<MeshRenderer>().enabled = true;
			text.GetComponent<BoxCollider2D>().enabled = true;
			EndText.GetComponent<MeshRenderer>().enabled = true;
			EndText.GetComponent<BoxCollider2D>().enabled = true;
		}

		if (turnOff) {
			//text.GetComponent<MeshRenderer>().enabled = false;
			text.GetComponent<BoxCollider2D>().enabled = false;
			//EndText.GetComponent<MeshRenderer>().enabled = false;
			EndText.GetComponent<BoxCollider2D>().enabled = false;
			
		}
	}

	void Update(){
		//Debug.Log (text.GetComponent<TextMesh>().color.a);
		text.GetComponent<TextMesh>().color = new Color (1,1,1,alpha);
		EndText.GetComponent<TextMesh>().color = new Color (1,1,1,alpha);
		
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
