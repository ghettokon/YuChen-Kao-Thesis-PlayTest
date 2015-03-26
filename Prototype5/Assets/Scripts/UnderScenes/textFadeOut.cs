using UnityEngine;
using System.Collections;

public class textFadeOut : MonoBehaviour {

	void Start () {
		iTween.FadeTo (gameObject, iTween.Hash ("alpha", 0, "delay", 6f, "time", 1f)); 
	}

	void Update () {

	}

}
