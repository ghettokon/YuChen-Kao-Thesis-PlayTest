using UnityEngine;
using System.Collections;

public class switchDN01 : MonoBehaviour {

	public GameObject outspace;
	public Sprite day;
	public Sprite night;
	public GameObject filterN;
	public GameObject Bruce;
	public GameObject Mary;
	public GameObject Ralph;
	public GameObject piano1;
	public GameObject piano2;
	public GameObject Zoe;
	public GameObject ZoeText;
	public GameObject ghost;
	public GameObject pianoSound;
	public GameObject ghostSound;
	public GameObject ghostText1;
	public GameObject ghostText2;
	public GameObject ghostTextBg;
	public GameObject MaryText1;
	public GameObject MaryText1Bg;
	public GameObject MaryText2;
	public GameObject MaryText2Bg;
	public GameObject BruceText1;
	public GameObject BruceText1Bg;

	public GameObject MaryCollider1;

	
	public bool IsDay = true;

	
	
	void OnMouseUpAsButton(){
		IsDay = !IsDay;

		if (IsDay) {
			outspace.GetComponent<SpriteRenderer>().sprite = day;
			filterN.GetComponent<SpriteRenderer>().enabled = false;
			Bruce.GetComponent<SpriteRenderer>().enabled = true;
			Mary.GetComponent<SpriteRenderer>().enabled = true;
			Ralph.GetComponent<SpriteRenderer>().enabled = true;
			piano1.GetComponent<SpriteRenderer>().enabled = true;
			piano2.GetComponent<SpriteRenderer>().enabled = false;
			Zoe.GetComponent<SpriteRenderer>().enabled = true;
			Zoe.GetComponent<BoxCollider2D> ().enabled = true;
			ghost.GetComponent<SpriteRenderer>().enabled = false;
			ghost.GetComponent<BoxCollider2D> ().enabled = false;
			ghostText1.GetComponent<MeshRenderer>().enabled = false;
			ghostText2.GetComponent<MeshRenderer>().enabled = false;
			ghostTextBg.GetComponent<SpriteRenderer> ().enabled = false;
			pianoSound.audio.Play();
			ghostSound.audio.Stop();

			MaryCollider1.GetComponent<BoxCollider2D> ().enabled = true;
			GameObject.Find ("01-Mary-collider1").GetComponent<showMaryText101> ().turnOff = true;
		} else {
			outspace.GetComponent<SpriteRenderer>().sprite = night;
			filterN.GetComponent<SpriteRenderer>().enabled = true;
			Bruce.GetComponent<SpriteRenderer>().enabled = false;
			Mary.GetComponent<SpriteRenderer>().enabled = false;
			Ralph.GetComponent<SpriteRenderer>().enabled = false;
			piano1.GetComponent<SpriteRenderer>().enabled = false;
			piano2.GetComponent<SpriteRenderer>().enabled = true;
			Zoe.GetComponent<SpriteRenderer>().enabled = false;
			Zoe.GetComponent<BoxCollider2D> ().enabled = false;
			ZoeText.GetComponent<MeshRenderer>().enabled = false;
			pianoSound.audio.Stop();
			if (!GameObject.Find ("01-switchOn").GetComponent<switcher01> ().turnOn) {
				ghostSound.audio.Play();
			}
			MaryText1.GetComponent<MeshRenderer>().enabled = false;
			MaryText1Bg.GetComponent<SpriteRenderer>().enabled = false;
			MaryText2.GetComponent<MeshRenderer>().enabled = false;
			MaryText2Bg.GetComponent<SpriteRenderer>().enabled = false;
			BruceText1.GetComponent<MeshRenderer>().enabled = false;
			BruceText1Bg.GetComponent<SpriteRenderer>().enabled = false;
		}
	}
}
