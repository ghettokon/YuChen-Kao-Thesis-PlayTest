using UnityEngine;
using System.Collections;

public class musicPlayerClick : MonoBehaviour {

	public GameObject musicplayer;
	public GameObject music;

	public bool turnOn = false;

	void OnMouseUpAsButton(){
		turnOn = !turnOn;
		if (turnOn) {
			musicplayer.GetComponent<Animator>().enabled = true;
			music.audio.Play();
		} else {
			musicplayer.GetComponent<Animator>().enabled = false;
			music.audio.Stop();
		}
	}
}
