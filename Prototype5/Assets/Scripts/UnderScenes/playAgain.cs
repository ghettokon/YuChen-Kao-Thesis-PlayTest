using UnityEngine;
using System.Collections;

public class playAgain : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnMouseUpAsButton(){
		Application.LoadLevel(0);
	}
}
