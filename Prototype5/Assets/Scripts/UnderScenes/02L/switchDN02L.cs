using UnityEngine;
using System.Collections;

public class switchDN02L : MonoBehaviour {

	public GameObject outspace;
	public Sprite day;
	public Sprite night;
	public GameObject pianoSound;
	public GameObject filterNight;

	public GameObject mirror;
	public Sprite mirror1;
	public Sprite mirror2;
	public GameObject Gtext;
	
	//contorl right side
	public GameObject outspaceR;
	public Sprite dayR;
	public Sprite nightR;
	public GameObject ZoeR;
	public GameObject piano2R;
	public GameObject pianoSoundR;
	public GameObject nightSoundR;
	public GameObject filterNightR;

	
	
	public bool IsDay = true;
	
	
	void OnMouseUpAsButton(){
		IsDay = !IsDay;
		
		if (IsDay) {
			//Left
			outspace.GetComponent<SpriteRenderer>().sprite = day;
			pianoSound.audio.Play();

			filterNight.GetComponent<SpriteRenderer>().enabled = false;

			mirror.GetComponent<SpriteRenderer> ().sprite = mirror1;
			mirror.GetComponent<BoxCollider2D>().enabled = false;
			Gtext.GetComponent<MeshRenderer>().enabled = false;
			GameObject.Find ("02L-mirror").GetComponent<MouseClickText> ().turnOff = true;

			//Right
			piano2R.GetComponent<SpriteRenderer>().enabled = false;
			ZoeR.GetComponent<SpriteRenderer>().enabled = true;
			filterNightR.GetComponent<SpriteRenderer>().enabled = false;
			nightSoundR.audio.Stop();
			outspaceR.GetComponent<SpriteRenderer>().sprite = dayR;
			pianoSoundR.audio.Play();
			GameObject.Find ("02R-DN-collider").GetComponent<switchDN02R> ().IsDay = true;
			

			
		} else {
			//Left
			outspace.GetComponent<SpriteRenderer>().sprite = night;
			pianoSound.audio.Stop();
			
			//Right
			piano2R.GetComponent<SpriteRenderer>().enabled = true;
			ZoeR.GetComponent<SpriteRenderer>().enabled = false;
			filterNightR.GetComponent<SpriteRenderer>().enabled = true;
			nightSoundR.audio.Play();
			outspaceR.GetComponent<SpriteRenderer>().sprite = nightR;
			pianoSoundR.audio.Stop();
			GameObject.Find ("02R-DN-collider").GetComponent<switchDN02R> ().IsDay = false;
		}
	}
}
