using UnityEngine;
using System.Collections;

public class MouseClickedSound : MonoBehaviour {

	public GameObject sound;

	void OnMouseUpAsButton(){
		sound.audio.Play();
	}

}
