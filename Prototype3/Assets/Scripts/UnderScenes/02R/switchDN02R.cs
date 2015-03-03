using UnityEngine;
using System.Collections;

public class switchDN02R : MonoBehaviour {

	public GameObject outspace;
	public Sprite day;
	public Sprite night;
	public GameObject Zoe;
	public GameObject piano2;
	public GameObject pianoSound;
	public GameObject nightSound;
	public GameObject filterNight;

	//control left side
	public GameObject outspaceL;
	public Sprite dayL;
	public Sprite nightL;
	public GameObject pianoSoundL;
	public GameObject filterNightL;
	public GameObject mirrorL;
	public Sprite mirror1L;
	public GameObject GtextL;

	//control showup
	public GameObject message;


	public bool IsDay = true;


	void OnMouseUpAsButton(){
		IsDay = !IsDay;
		
		if (IsDay) {
			outspace.GetComponent<SpriteRenderer>().sprite = day;
			piano2.GetComponent<SpriteRenderer>().enabled = false;
			Zoe.GetComponent<SpriteRenderer>().enabled = true;
			filterNight.GetComponent<SpriteRenderer>().enabled = false;
			pianoSound.audio.Play();
			nightSound.audio.Stop();

			//Left
			outspaceL.GetComponent<SpriteRenderer>().sprite = dayL;
			pianoSoundL.audio.Play();
			GameObject.Find ("02L-DN-collider").GetComponent<switchDN02L> ().IsDay = true;
			filterNightL.GetComponent<SpriteRenderer>().enabled = false;
			mirrorL.GetComponent<SpriteRenderer> ().sprite = mirror1L;
			mirrorL.GetComponent<BoxCollider2D>().enabled = false;
			GtextL.GetComponent<MeshRenderer>().enabled = false;
			GameObject.Find ("02L-mirror").GetComponent<MouseClickText> ().turnOff = true;

			//
			message.GetComponent<SpriteRenderer>().enabled = false;

		} else {
			outspace.GetComponent<SpriteRenderer>().sprite = night;
			piano2.GetComponent<SpriteRenderer>().enabled = true;
			Zoe.GetComponent<SpriteRenderer>().enabled = false;
			filterNight.GetComponent<SpriteRenderer>().enabled = true;
			pianoSound.audio.Stop();
			nightSound.audio.Play();

			//Left
			outspaceL.GetComponent<SpriteRenderer>().sprite = nightL;
			pianoSoundL.audio.Stop();
			GameObject.Find ("02L-DN-collider").GetComponent<switchDN02L> ().IsDay = false;
		}
	}
}
