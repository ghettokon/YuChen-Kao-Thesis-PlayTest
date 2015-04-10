using UnityEngine;
using System.Collections;

public class showMaryText306 : MonoBehaviour {

	public GameObject MaryText3;
	public GameObject MaryText4;
	public GameObject JoelText2;
	public GameObject textBg1;
	public GameObject textBg2;

	public bool turnOff = true;
	
	private float alpha = 0;
	
	private void Start(){
		
	}
	
	void OnMouseUpAsButton(){
		turnOff = false;
		
		alpha = 0;
		MaryText3.GetComponent<MeshRenderer>().enabled = true;
		MaryText3.GetComponent<BoxCollider2D>().enabled = true;
		MaryText4.GetComponent<MeshRenderer>().enabled = true;
		MaryText4.GetComponent<BoxCollider2D>().enabled = true;
		textBg2.GetComponent<SpriteRenderer>().enabled = true;

		JoelText2.GetComponent<MeshRenderer>().enabled = false;
		JoelText2.GetComponent<BoxCollider2D>().enabled = false;
		textBg1.GetComponent<SpriteRenderer>().enabled = false;
	}

	void Update(){
		//Debug.Log (text.GetComponent<TextMesh>().color.a);
		MaryText3.GetComponent<TextMesh>().color = new Color (1,1,1,alpha);
		MaryText4.GetComponent<TextMesh>().color = new Color (1,1,1,alpha);
		textBg2.GetComponent<SpriteRenderer>().color = new Color (1,1,1,alpha);
		
		if (turnOff == false) {
			if(alpha<1){
				alpha += 0.03f;
			}
		} 
	}
}
