using UnityEngine;
using System.Collections;

public class showJoelText206 : MonoBehaviour {
	
	public GameObject MaryText1;
	public GameObject MaryText2;
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
		JoelText2.GetComponent<MeshRenderer>().enabled = true;
		JoelText2.GetComponent<BoxCollider2D>().enabled = true;
		textBg2.GetComponent<SpriteRenderer>().enabled = true;

		MaryText1.GetComponent<MeshRenderer>().enabled = false;
		MaryText1.GetComponent<BoxCollider2D>().enabled = false;
		MaryText2.GetComponent<MeshRenderer>().enabled = false;
		MaryText2.GetComponent<BoxCollider2D>().enabled = false;
		textBg1.GetComponent<SpriteRenderer>().enabled = false;
	}

	void Update(){
		//Debug.Log (text.GetComponent<TextMesh>().color.a);
		JoelText2.GetComponent<TextMesh>().color = new Color (1,1,1,alpha);
		textBg2.GetComponent<SpriteRenderer>().color = new Color (1,1,1,alpha);
		
		if (turnOff == false) {
			if(alpha<1){
				alpha += 0.03f;
			}
		} 
	}
}
