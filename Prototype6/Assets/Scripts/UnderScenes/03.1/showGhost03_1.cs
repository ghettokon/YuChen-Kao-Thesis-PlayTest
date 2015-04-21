using UnityEngine;
using System.Collections;

public class showGhost03_1 : MonoBehaviour {

	public GameObject bruce;
	public GameObject bruceText;
	public GameObject Ghost;
	public GameObject filterDark;
	public GameObject textBgBruce;

	public bool turnOff = true;
	
	private float alpha = 0;
	
	private void Start(){
		
	}

	void OnMouseUpAsButton(){
		turnOff = false;

		alpha = 0;
		Ghost.GetComponent<SpriteRenderer>().enabled = true;
		Ghost.GetComponent<BoxCollider2D>().enabled = true;
		filterDark.GetComponent<SpriteRenderer>().enabled = true;

		bruce.GetComponent<BoxCollider2D>().enabled = false;
		bruceText.GetComponent<MeshRenderer>().enabled = false;
		bruceText.GetComponent<BoxCollider2D>().enabled = false;
		textBgBruce.GetComponent<SpriteRenderer>().enabled = false;
	}

	void Update(){
		//Debug.Log (text.GetComponent<TextMesh>().color.a);
		Ghost.GetComponent<SpriteRenderer>().color = new Color (1,1,1,alpha);
		filterDark.GetComponent<SpriteRenderer>().color = new Color (1,1,1,alpha);
		
		if (turnOff == false) {
			if(alpha<1){
				alpha += 0.03f;
			}
		}
	}
}
