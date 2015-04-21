using UnityEngine;
using System.Collections;

//switch livingroomlight(filterDark)

public class SwitchL05 : MonoBehaviour {

	public GameObject filterDark;
	public GameObject lamplight;
	public GameObject switcher;
	public Sprite switcherOn;
	public Sprite switcherOff;
	public GameObject clickSound;
	public GameObject BGhost;
	public GameObject BGhostText;
	public GameObject MGhost;
	public GameObject MGhostText;
	public GameObject MGhostTextBg;

	public bool turnOff = true;

	private float alpha = 0;

	void OnMouseUpAsButton(){
		turnOff = !turnOff;
		clickSound.audio.Play();
		if (turnOff) {
			//filterDark.GetComponent<SpriteRenderer>().enabled = false;
			switcher.GetComponent<SpriteRenderer>().sprite = switcherOn;
			lamplight.GetComponent<SpriteRenderer>().enabled = true;
			//BGhost.GetComponent<SpriteRenderer>().enabled = false;
			BGhost.GetComponent<BoxCollider2D> ().enabled = false;
			BGhostText.GetComponent<MeshRenderer>().enabled = false;
			MGhost.GetComponent<SpriteRenderer>().enabled = false;
			MGhost.GetComponent<BoxCollider2D> ().enabled = false;
			MGhostText.GetComponent<MeshRenderer>().enabled = false;
			MGhostText.GetComponent<BoxCollider2D> ().enabled = false;
			MGhostTextBg.GetComponent<SpriteRenderer>().enabled = false;
		} else {
			alpha = 0;
			filterDark.GetComponent<SpriteRenderer>().enabled = true;
			switcher.GetComponent<SpriteRenderer>().sprite = switcherOff;
			lamplight.GetComponent<SpriteRenderer>().enabled = false;
			BGhost.GetComponent<SpriteRenderer>().enabled = true;
			BGhost.GetComponent<BoxCollider2D> ().enabled = true;
		}
	}

	void Update(){
		//Debug.Log (text.GetComponent<TextMesh>().color.a);
		filterDark.GetComponent<SpriteRenderer> ().color = new Color (1,1,1,alpha);
		BGhost.GetComponent<SpriteRenderer> ().color = new Color (1,1,1,alpha);
		
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
