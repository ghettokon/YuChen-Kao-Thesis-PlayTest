using UnityEngine;
using System.Collections;

public class cdplayer09 : MonoBehaviour {

	public GameObject cdPlayer;
	public GameObject cdSound;
	public Sprite on;
	public Sprite off;

	
	public bool turnOn;
	
	void OnMouseUpAsButton(){
		turnOn = !turnOn;
		
		if (turnOn) {
			cdSound.audio.Play ();
			cdPlayer.GetComponent<SpriteRenderer>().sprite = on;
		} else {
			cdSound.audio.Stop ();
			cdPlayer.GetComponent<SpriteRenderer>().sprite = off;
		}
	}
}
