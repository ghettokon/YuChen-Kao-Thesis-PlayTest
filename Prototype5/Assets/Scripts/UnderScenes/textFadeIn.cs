using UnityEngine;
using System.Collections;

public class textFadeIn : MonoBehaviour {

	void Start () {
		iTween.FadeFrom (gameObject, iTween.Hash ("alpha", 255, "time", 1f));
	}

	void Update () {

	}

}
